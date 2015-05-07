﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace DD.CBU.Compute.Api.Contracts.Network20
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class RulePlacementType
	{

		private RulePositionType positionField;

		private string relativeToRuleField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public RulePositionType position
		{
			get { return this.positionField; }
			set { this.positionField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string relativeToRule
		{
			get { return this.relativeToRuleField; }
			set { this.relativeToRuleField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public enum RulePositionType
	{

		/// <remarks/>
		BEFORE,

		/// <remarks/>
		AFTER,

		/// <remarks/>
		FIRST,

		/// <remarks/>
		LAST,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class IpAndPortFilterType
	{

		private IpAndPortFilterTypeIP ipField;

		private IpAndPortFilterTypePort portField;

		/// <remarks/>
		public IpAndPortFilterTypeIP ip
		{
			get { return this.ipField; }
			set { this.ipField = value; }
		}

		/// <remarks/>
		public IpAndPortFilterTypePort port
		{
			get { return this.portField; }
			set { this.portField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class IpAndPortFilterTypeIP
	{

		private string addressField;

		private int prefixSizeField;

		private bool prefixSizeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int prefixSize
		{
			get { return this.prefixSizeField; }
			set { this.prefixSizeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool prefixSizeSpecified
		{
			get { return this.prefixSizeFieldSpecified; }
			set { this.prefixSizeFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class IpAndPortFilterTypePort
	{

		private int beginField;

		private int endField;

		private bool endFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int begin
		{
			get { return this.beginField; }
			set { this.beginField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int end
		{
			get { return this.endField; }
			set { this.endField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool endSpecified
		{
			get { return this.endFieldSpecified; }
			set { this.endFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	public partial class IcmpPropertiesType
	{

		private int typeField;

		private int codeField;

		private bool codeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int code
		{
			get { return this.codeField; }
			set { this.codeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool codeSpecified
		{
			get { return this.codeFieldSpecified; }
			set { this.codeFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("firewallRule", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class FirewallRuleType
	{

		private string networkDomainIdField;

		private string nameField;

		private string actionField;

		private string ipVersionField;

		private string protocolField;

		private IcmpPropertiesType icmpPropertiesField;

		private IpAndPortFilterType sourceField;

		private IpAndPortFilterType destinationField;

		private bool enabledField;

		private string stateField;

		private string idField;

		private string datacenterIdField;

		private string ruleTypeField;

		/// <remarks/>
		public string networkDomainId
		{
			get { return this.networkDomainIdField; }
			set { this.networkDomainIdField = value; }
		}

		/// <remarks/>
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}

		/// <remarks/>
		public string action
		{
			get { return this.actionField; }
			set { this.actionField = value; }
		}

		/// <remarks/>
		public string ipVersion
		{
			get { return this.ipVersionField; }
			set { this.ipVersionField = value; }
		}

		/// <remarks/>
		public string protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}

		/// <remarks/>
		public IcmpPropertiesType icmpProperties
		{
			get { return this.icmpPropertiesField; }
			set { this.icmpPropertiesField = value; }
		}

		/// <remarks/>
		public IpAndPortFilterType source
		{
			get { return this.sourceField; }
			set { this.sourceField = value; }
		}

		/// <remarks/>
		public IpAndPortFilterType destination
		{
			get { return this.destinationField; }
			set { this.destinationField = value; }
		}

		/// <remarks/>
		public bool enabled
		{
			get { return this.enabledField; }
			set { this.enabledField = value; }
		}

		/// <remarks/>
		public string state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string datacenterId
		{
			get { return this.datacenterIdField; }
			set { this.datacenterIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ruleType
		{
			get { return this.ruleTypeField; }
			set { this.ruleTypeField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class firewallRules
	{

		private FirewallRuleType[] firewallRuleField;

		private int pageNumberField;

		private bool pageNumberFieldSpecified;

		private int pageCountField;

		private bool pageCountFieldSpecified;

		private int totalCountField;

		private bool totalCountFieldSpecified;

		private int pageSizeField;

		private bool pageSizeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("firewallRule")]
		public FirewallRuleType[] firewallRule
		{
			get { return this.firewallRuleField; }
			set { this.firewallRuleField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageNumber
		{
			get { return this.pageNumberField; }
			set { this.pageNumberField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageNumberSpecified
		{
			get { return this.pageNumberFieldSpecified; }
			set { this.pageNumberFieldSpecified = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageCount
		{
			get { return this.pageCountField; }
			set { this.pageCountField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageCountSpecified
		{
			get { return this.pageCountFieldSpecified; }
			set { this.pageCountFieldSpecified = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int totalCount
		{
			get { return this.totalCountField; }
			set { this.totalCountField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool totalCountSpecified
		{
			get { return this.totalCountFieldSpecified; }
			set { this.totalCountFieldSpecified = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int pageSize
		{
			get { return this.pageSizeField; }
			set { this.pageSizeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pageSizeSpecified
		{
			get { return this.pageSizeFieldSpecified; }
			set { this.pageSizeFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("createFirewallRule", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class CreateFirewallRuleType
	{

		private string networkDomainIdField;

		private string nameField;

		private string actionField;

		private string ipVersionField;

		private string protocolField;

		private IpAndPortFilterType sourceField;

		private IpAndPortFilterType destinationField;

		private bool enabledField;

		private RulePlacementType placementField;

		/// <remarks/>
		public string networkDomainId
		{
			get { return this.networkDomainIdField; }
			set { this.networkDomainIdField = value; }
		}

		/// <remarks/>
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}

		/// <remarks/>
		public string action
		{
			get { return this.actionField; }
			set { this.actionField = value; }
		}

		/// <remarks/>
		public string ipVersion
		{
			get { return this.ipVersionField; }
			set { this.ipVersionField = value; }
		}

		/// <remarks/>
		public string protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}

		/// <remarks/>
		public IpAndPortFilterType source
		{
			get { return this.sourceField; }
			set { this.sourceField = value; }
		}

		/// <remarks/>
		public IpAndPortFilterType destination
		{
			get { return this.destinationField; }
			set { this.destinationField = value; }
		}

		/// <remarks/>
		public bool enabled
		{
			get { return this.enabledField; }
			set { this.enabledField = value; }
		}

		/// <remarks/>
		public RulePlacementType placement
		{
			get { return this.placementField; }
			set { this.placementField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("deleteFirewallRule", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class IdType
	{

		private string idField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("editFirewallRule", Namespace = "urn:didata.com:api:cloud:types",
		IsNullable = false)]
	public partial class EditFirewallRuleType
	{

		private string actionField;

		private string ipVersionField;

		private string protocolField;

		private IpAndPortFilterType sourceField;

		private IpAndPortFilterType destinationField;

		private bool enabledField;

		private bool enabledFieldSpecified;

		private RulePlacementType placementField;

		private string idField;

		/// <remarks/>
		public string action
		{
			get { return this.actionField; }
			set { this.actionField = value; }
		}

		/// <remarks/>
		public string ipVersion
		{
			get { return this.ipVersionField; }
			set { this.ipVersionField = value; }
		}

		/// <remarks/>
		public string protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}

		/// <remarks/>
		public IpAndPortFilterType source
		{
			get { return this.sourceField; }
			set { this.sourceField = value; }
		}

		/// <remarks/>
		public IpAndPortFilterType destination
		{
			get { return this.destinationField; }
			set { this.destinationField = value; }
		}

		/// <remarks/>
		public bool enabled
		{
			get { return this.enabledField; }
			set { this.enabledField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool enabledSpecified
		{
			get { return this.enabledFieldSpecified; }
			set { this.enabledFieldSpecified = value; }
		}

		/// <remarks/>
		public RulePlacementType placement
		{
			get { return this.placementField; }
			set { this.placementField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
	}
}