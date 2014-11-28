﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Client.VIP;
using DD.CBU.Compute.Api.Contracts.Network;
using DD.CBU.Compute.Api.Contracts.Vip;

namespace DD.CBU.Compute.Powershell
{
    /// <summary>
    /// The new CaaS VIP Real cmdlet.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "CaasProbe")]
    [OutputType(typeof (PersistenceProfile))]
    public class NewCaasPersistenceProfileCmdlet : PsCmdletCaasBase
    {
        /// <summary>
        /// The network to manage the VIP settings
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The network to manage the VIP settings",
            ValueFromPipelineByPropertyName = true)]
        public NetworkWithLocationsNetwork Network { get; set; }

        /// <summary>
        /// The name for the real server
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The name for the persistence profile")]
        public string Name { get; set; }


        /// <summary>
        /// The name for the real server
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The server farm for the persistence profile",
            ValueFromPipeline = true)]
        public ServerFarm ServerFarm { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "The timeout in munites to the profile.")]
        public int TimeoutMinutes { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "IpNetMask",
            HelpMessage = "For IP_NETMASK only.The direction for the persistence profile")]
        public PersistenceProfileDirection Direction { get; set; }


        [Parameter(Mandatory = true, ParameterSetName = "IpNetMask",
            HelpMessage = "For IP_NETMASK only.The netmask for the persistence profile")]
        public string Netmask { get; set; }


        [Parameter(Mandatory = true, ParameterSetName = "HttpCookie",
            HelpMessage = "For HTTP_COOKIE only.The name of the cookie for the persistence profile")]
        public string CookieName { get; set; }


        [Parameter(Mandatory = true, ParameterSetName = "HttpCookie",
            HelpMessage = "For HTTP_COOKIE only.The HTTP cookie type for the persistence profile")]
        public PersistenceProfileCookieType CookieType { get; set; }

        /// <summary>
        /// The network to add the public ip addresses
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Return the Probe object")]
        public SwitchParameter PassThru { get; set; }





        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                Status status = null;
                if (ParameterSetName.Equals("HttpCookie"))
                    status =
                        CaaS.ApiClient.CreatePersistenceProfileHttpCookie(Network.id, Name, ServerFarm.id,
                            TimeoutMinutes, CookieName, CookieType).Result;
                else
                    status =
                        CaaS.ApiClient.CreatePersistenceProfileIpNetmask(Network.id, Name, ServerFarm.id, TimeoutMinutes,
                            Direction, Netmask).Result;
                if (status != null && PassThru.IsPresent)
                {

                    //Regex to extract the Id from the status result detail: Real-Server (id:b1a3aea6-37) created
                    var regexObj = new Regex(@"\x28id\x3A([-\w]*)\x29");
                    var match = regexObj.Match(status.resultDetail);
                    if (match.Success && match.Groups.Count > 1)
                    {
                        var persprofile = new PersistenceProfile()
                        {
                            id = match.Groups[1].Value,
                            name = Name,
                            serverFarmId = ServerFarm.id,
                            timeout = TimeoutMinutes.ToString(CultureInfo.InvariantCulture),

                        };
                        if (ParameterSetName.Equals("HttpCookie"))
                        {
                            persprofile.type = PersistenceProfileType.HTTP_COOKIE;
                            persprofile.cookieName = CookieName;
                            persprofile.cookieType = CookieType.ToString();

                        }
                        else
                        {
                            persprofile.type = PersistenceProfileType.IP_NETMASK;
                            persprofile.netmask = Netmask;
                            persprofile.direction = Direction.ToString();

                        }
                        WriteObject(persprofile);
                    }
                    else
                    {
                        WriteError(new ErrorRecord(new Exception("{Probe Id not returned from API"), "-1",
                            ErrorCategory.InvalidData, status));
                    }

                }
                WriteDebug(
                    string.Format(
                        "{0} resulted in {1} ({2}): {3}",
                        status.operation,
                        status.result,
                        status.resultCode,
                        status.resultDetail));



            }
            catch (AggregateException ae)
            {
                ae.Handle(
                    e =>
                    {
                        if (e is ComputeApiException)
                        {
                            WriteError(new ErrorRecord(e, "-2", ErrorCategory.InvalidOperation, CaaS));
                        }
                        else //if (e is HttpRequestException)
                        {
                            ThrowTerminatingError(new ErrorRecord(e, "-1", ErrorCategory.ConnectionError, CaaS));
                        }
                        return true;
                    });
            }


        }
    }
}

