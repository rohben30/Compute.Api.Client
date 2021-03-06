﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace DD.CBU.Compute.Api.Contracts.Network20
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("publicIpBlock", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class PublicIpBlockType
    {

        private object[] itemsField;

        private NetworkDomainIdOrNetworkIdIpBlockChoiceType[] itemsElementNameField;

        private string baseIpField;

        private int sizeField;

        private System.DateTime createTimeField;

        private string stateField;

        private string idField;

        private string datacenterIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("networkDefault", typeof (bool))]
        [System.Xml.Serialization.XmlElementAttribute("networkDomainId", typeof (string))]
        [System.Xml.Serialization.XmlElementAttribute("networkId", typeof (string))]
        [System.Xml.Serialization.XmlElementAttribute("serverToVipConnectivity", typeof (bool))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public NetworkDomainIdOrNetworkIdIpBlockChoiceType[] ItemsElementName
        {
            get { return this.itemsElementNameField; }
            set { this.itemsElementNameField = value; }
        }

        /// <remarks/>
        public string baseIp
        {
            get { return this.baseIpField; }
            set { this.baseIpField = value; }
        }

        /// <remarks/>
        public int size
        {
            get { return this.sizeField; }
            set { this.sizeField = value; }
        }

        /// <remarks/>
        public System.DateTime createTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
    public enum NetworkDomainIdOrNetworkIdIpBlockChoiceType
    {

        /// <remarks/>
        networkDefault,

        /// <remarks/>
        networkDomainId,

        /// <remarks/>
        networkId,

        /// <remarks/>
        serverToVipConnectivity,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class publicIpBlocks
    {

        private PublicIpBlockType[] publicIpBlockField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("publicIpBlock")]
        public PublicIpBlockType[] publicIpBlock
        {
            get { return this.publicIpBlockField; }
            set { this.publicIpBlockField = value; }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("addPublicIpBlock", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class AddPublicIpBlockType
    {

        private string itemField;

        private NetworkDomainIdOrNetworkIdChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("networkDomainId", typeof (string))]
        [System.Xml.Serialization.XmlElementAttribute("networkId", typeof (string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public NetworkDomainIdOrNetworkIdChoiceType ItemElementName
        {
            get { return this.itemElementNameField; }
            set { this.itemElementNameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("removePublicIpBlock", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class RemovePublicIpBlockType
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
}
