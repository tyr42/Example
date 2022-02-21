using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models.DTO_vCloud
{

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.vmware.com/vcloud/v1.5", IsNullable = false)]
    public partial class NetworkConfiguration
    {

        private string infoField;

        private NetworkConfigSectionLink[] linkField;

        private NetworkConfigSectionNetworkConfig networkConfigField;

        private string hrefField;

        private string typeField;

        private bool requiredField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.dmtf.org/ovf/envelope/1")]
        public string Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Link")]
        public NetworkConfigSectionLink[] Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        public NetworkConfigSectionNetworkConfig NetworkConfig
        {
            get
            {
                return this.networkConfigField;
            }
            set
            {
                this.networkConfigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.dmtf.org/ovf/envelope/1")]
        public bool required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionLink
    {

        private string relField;

        private string hrefField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfig
    {

        private NetworkConfigSectionNetworkConfigLink linkField;

        private object descriptionField;

        private NetworkConfigSectionNetworkConfigConfiguration configurationField;

        private bool isDeployedField;

        private string networkNameField;

        /// <remarks/>
        public NetworkConfigSectionNetworkConfigLink Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        public object Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public NetworkConfigSectionNetworkConfigConfiguration Configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        /// <remarks/>
        public bool IsDeployed
        {
            get
            {
                return this.isDeployedField;
            }
            set
            {
                this.isDeployedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string networkName
        {
            get
            {
                return this.networkNameField;
            }
            set
            {
                this.networkNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfigLink
    {

        private string relField;

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rel
        {
            get
            {
                return this.relField;
            }
            set
            {
                this.relField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfigConfiguration
    {

        private NetworkConfigSectionNetworkConfigConfigurationIpScopes ipScopesField;

        private NetworkConfigSectionNetworkConfigConfigurationParentNetwork parentNetworkField;

        private string fenceModeField;

        private bool retainNetInfoAcrossDeploymentsField;

        private bool guestVlanAllowedField;

        private bool dualStackNetworkField;

        /// <remarks/>
        public NetworkConfigSectionNetworkConfigConfigurationIpScopes IpScopes
        {
            get
            {
                return this.ipScopesField;
            }
            set
            {
                this.ipScopesField = value;
            }
        }

        /// <remarks/>
        public NetworkConfigSectionNetworkConfigConfigurationParentNetwork ParentNetwork
        {
            get
            {
                return this.parentNetworkField;
            }
            set
            {
                this.parentNetworkField = value;
            }
        }

        /// <remarks/>
        public string FenceMode
        {
            get
            {
                return this.fenceModeField;
            }
            set
            {
                this.fenceModeField = value;
            }
        }

        /// <remarks/>
        public bool RetainNetInfoAcrossDeployments
        {
            get
            {
                return this.retainNetInfoAcrossDeploymentsField;
            }
            set
            {
                this.retainNetInfoAcrossDeploymentsField = value;
            }
        }

        /// <remarks/>
        public bool GuestVlanAllowed
        {
            get
            {
                return this.guestVlanAllowedField;
            }
            set
            {
                this.guestVlanAllowedField = value;
            }
        }

        /// <remarks/>
        public bool DualStackNetwork
        {
            get
            {
                return this.dualStackNetworkField;
            }
            set
            {
                this.dualStackNetworkField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfigConfigurationIpScopes
    {

        private NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScope ipScopeField;

        /// <remarks/>
        public NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScope IpScope
        {
            get
            {
                return this.ipScopeField;
            }
            set
            {
                this.ipScopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScope
    {

        private bool isInheritedField;

        private string gatewayField;

        private string netmaskField;

        private byte subnetPrefixLengthField;

        private bool isEnabledField;

        private NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScopeIpRanges ipRangesField;

        /// <remarks/>
        public bool IsInherited
        {
            get
            {
                return this.isInheritedField;
            }
            set
            {
                this.isInheritedField = value;
            }
        }

        /// <remarks/>
        public string Gateway
        {
            get
            {
                return this.gatewayField;
            }
            set
            {
                this.gatewayField = value;
            }
        }

        /// <remarks/>
        public string Netmask
        {
            get
            {
                return this.netmaskField;
            }
            set
            {
                this.netmaskField = value;
            }
        }

        /// <remarks/>
        public byte SubnetPrefixLength
        {
            get
            {
                return this.subnetPrefixLengthField;
            }
            set
            {
                this.subnetPrefixLengthField = value;
            }
        }

        /// <remarks/>
        public bool IsEnabled
        {
            get
            {
                return this.isEnabledField;
            }
            set
            {
                this.isEnabledField = value;
            }
        }

        /// <remarks/>
        public NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScopeIpRanges IpRanges
        {
            get
            {
                return this.ipRangesField;
            }
            set
            {
                this.ipRangesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScopeIpRanges
    {

        private NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScopeIpRangesIpRange ipRangeField;

        /// <remarks/>
        public NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScopeIpRangesIpRange IpRange
        {
            get
            {
                return this.ipRangeField;
            }
            set
            {
                this.ipRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfigConfigurationIpScopesIpScopeIpRangesIpRange
    {

        private string startAddressField;

        private string endAddressField;

        /// <remarks/>
        public string StartAddress
        {
            get
            {
                return this.startAddressField;
            }
            set
            {
                this.startAddressField = value;
            }
        }

        /// <remarks/>
        public string EndAddress
        {
            get
            {
                return this.endAddressField;
            }
            set
            {
                this.endAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class NetworkConfigSectionNetworkConfigConfigurationParentNetwork
    {

        private string hrefField;

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

}
