﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewCaasNetworkPublicIpBlockCmdlet.cs" company="">
//   
// </copyright>
// <summary>
//   The new caas network public ip block cmdlet.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Management.Automation;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Network;
using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Powershell.Mcp20
{
	/// <summary>
	///     The new caas network public ip block cmdlet.
	/// </summary>
	[Cmdlet(VerbsCommon.New, "CaasNetworkPublicIpBlock")]


    [OutputType(typeof(ResponseType), ParameterSetName = new[] { "MCP2" })]
    [OutputType(typeof(IpBlockType[]), ParameterSetName = new[] { "MCP1" })]
    public class NewCaasNetworkPublicIpBlockCmdlet : PSCmdletCaasWithConnectionBase
	{
		/// <summary>
		///     The network to add the public ip addresses
		/// </summary>
		[Parameter(Mandatory = true,ParameterSetName = "MCP1", HelpMessage = "The network to add the public ip addresses", ValueFromPipeline = true)]
		public NetworkWithLocationsNetwork Network { get; set; }
        /// <summary>
        ///     Gets or sets the network domain.
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "MCP2", ValueFromPipeline = true, HelpMessage = "The network domain")]
        public NetworkDomainType NetworkDomain { get; set; }

        /// <summary>
        ///     The network to add the public ip addresses
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Return the IpBlockType object")]
		public SwitchParameter PassThru { get; set; }

		/// <summary>
		///     The process record.
		/// </summary>
		protected override void ProcessRecord()
		{
			base.ProcessRecord();
			try
			{
			    if (ParameterSetName == "MCP2")
			    {
			        var netdomainid = Guid.Parse(NetworkDomain.id);
			        var status =
			            Connection.ApiClient.Networking.IpAddress.AddPublicIpBlock(netdomainid).Result;
			        WriteObject(status);
			    }
			    else
			    {
			        var status =
			            Connection.ApiClient.NetworkingLegacy.Network.ReserveNetworkPublicIpAddressBlock(Network.id).Result;
			        if (status == null) return;
			        if (status.additionalInformation != null && PassThru.IsPresent)
			        {
			            var ipblock = new IpBlockType();


			            AdditionalInformation ipblockid =
			                status.additionalInformation.Single(info => info.name == "ipBlock.id");
			            if (ipblockid != null)
			                ipblock.id = ipblockid.value;

			            AdditionalInformation baseip =
			                status.additionalInformation.Single(info => info.name == "ipBlock.baseIp");
			            if (baseip != null)
			                ipblock.baseIp = baseip.value;

			            AdditionalInformation blocksize =
			                status.additionalInformation.Single(info => info.name == "ipBlock.size");
			            if (blocksize != null)
			                ipblock.subnetSize = int.Parse(blocksize.value);

			            ipblock.serverToVipConnectivity = false;
			            WriteObject(ipblock);
			        }

			        WriteDebug(
			            string.Format(
			                "{0} resulted in {1} ({2}): {3}",
			                status.operation,
			                status.result,
			                status.resultCode,
			                status.resultDetail));
			    }
			}
			catch (AggregateException ae)
			{
				ae.Handle(
					e =>
					{
						if (e is ComputeApiException)
						{
							WriteError(new ErrorRecord(e, "-2", ErrorCategory.InvalidOperation, Connection));
						}
						else
						{
// if (e is HttpRequestException)
							ThrowTerminatingError(new ErrorRecord(e, "-1", ErrorCategory.ConnectionError, Connection));
						}

						return true;
					});
			}
		}
	}
}