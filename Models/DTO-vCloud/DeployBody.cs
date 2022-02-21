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
    public partial class DeployBody
    {

        private RecomposeVAppParamsSourcedItem sourcedItemField;

        private bool allEULAsAcceptedField;

        private bool powerOnField;

        public DeployBody()
        {
        }

        public DeployBody(string href, string id, string name, string network, string description, string nameTemplate, bool allEULAsAccepted, bool powerOn)
        {
            SourcedItem = new RecomposeVAppParamsSourcedItem(href, id, name, network, description, nameTemplate);
            AllEULAsAccepted = allEULAsAccepted;
            this.powerOn = powerOn;
        }

        /// <remarks/>
        public RecomposeVAppParamsSourcedItem SourcedItem
        {
            get
            {
                return this.sourcedItemField;
            }
            set
            {
                this.sourcedItemField = value;
            }
        }

        /// <remarks/>
        public bool AllEULAsAccepted
        {
            get
            {
                return this.allEULAsAcceptedField;
            }
            set
            {
                this.allEULAsAcceptedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool powerOn
        {
            get
            {
                return this.powerOnField;
            }
            set
            {
                this.powerOnField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class RecomposeVAppParamsSourcedItem
    {

        private RecomposeVAppParamsSourcedItemSource sourceField;

        private RecomposeVAppParamsSourcedItemVmGeneralParamsType vmGeneralParamsTypeField;

        private RecomposeVAppParamsSourcedItemInstantiationParams instantiationParamsField;

        public RecomposeVAppParamsSourcedItem()
        {
        }

        public RecomposeVAppParamsSourcedItem(string href, string id, string name, string network, string description, string nameTemplate)
        {
            Source = new RecomposeVAppParamsSourcedItemSource(href, id, nameTemplate);
            VmGeneralParamsType = new RecomposeVAppParamsSourcedItemVmGeneralParamsType(name, description);
            InstantiationParams = new RecomposeVAppParamsSourcedItemInstantiationParams(network);
        }

        /// <remarks/>
        public RecomposeVAppParamsSourcedItemSource Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public RecomposeVAppParamsSourcedItemVmGeneralParamsType VmGeneralParamsType
        {
            get
            {
                return this.vmGeneralParamsTypeField;
            }
            set
            {
                this.vmGeneralParamsTypeField = value;
            }
        }

        /// <remarks/>
        public RecomposeVAppParamsSourcedItemInstantiationParams InstantiationParams
        {
            get
            {
                return this.instantiationParamsField;
            }
            set
            {
                this.instantiationParamsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class RecomposeVAppParamsSourcedItemSource
    {

        private string hrefField;

        private string idField;

        private string nameField;

        private string typeField;

        public RecomposeVAppParamsSourcedItemSource()
        {
        }

        public RecomposeVAppParamsSourcedItemSource(string href, string id, string templateName)
        {
            this.href = href;
            this.id = id;
            this.name = templateName;
            this.type = "application/vnd.vmware.vcloud.vappTemplate+xml";
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
    public partial class RecomposeVAppParamsSourcedItemVmGeneralParamsType
    {

        private string nameField;

        private string descriptionField;

        public RecomposeVAppParamsSourcedItemVmGeneralParamsType()
        {
        }

        public RecomposeVAppParamsSourcedItemVmGeneralParamsType(string name, string description)
        {
            Name = name;
            Description = description;
        }

        /// <remarks/>
        public string Name
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

        /// <remarks/>
        public string Description
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class RecomposeVAppParamsSourcedItemInstantiationParams
    {

        private RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSection networkConnectionSectionField;

        public RecomposeVAppParamsSourcedItemInstantiationParams()
        {

        }

        public RecomposeVAppParamsSourcedItemInstantiationParams(string network)
        {
            NetworkConnectionSection = new RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSection(network);
        }

        /// <remarks/>
        public RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSection NetworkConnectionSection
        {
            get
            {
                return this.networkConnectionSectionField;
            }
            set
            {
                this.networkConnectionSectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSection
    {

        private string infoField;

        private byte primaryNetworkConnectionIndexField;

        private RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSectionNetworkConnection networkConnectionField;

        public RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSection()
        {
        }

        public RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSection(string network)
        {
            PrimaryNetworkConnectionIndex = 0;
            NetworkConnection = new RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSectionNetworkConnection(network);
        }

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
        public byte PrimaryNetworkConnectionIndex
        {
            get
            {
                return this.primaryNetworkConnectionIndexField;
            }
            set
            {
                this.primaryNetworkConnectionIndexField = value;
            }
        }

        /// <remarks/>
        public RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSectionNetworkConnection NetworkConnection
        {
            get
            {
                return this.networkConnectionField;
            }
            set
            {
                this.networkConnectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSectionNetworkConnection
    {

        private byte networkConnectionIndexField;

        private bool isConnectedField;

        private string ipAddressAllocationModeField;

        private string networkAdapterTypeField;

        private string networkField;

        public RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSectionNetworkConnection()
        {
        }

        public RecomposeVAppParamsSourcedItemInstantiationParamsNetworkConnectionSectionNetworkConnection(string network)
        {
            NetworkConnectionIndex = 0;
            IsConnected = true;
            IpAddressAllocationMode = "POOL";
            NetworkAdapterType = "VMXNET3";
            this.network = network;
        }

        /// <remarks/>
        public byte NetworkConnectionIndex
        {
            get
            {
                return this.networkConnectionIndexField;
            }
            set
            {
                this.networkConnectionIndexField = value;
            }
        }

        /// <remarks/>
        public bool IsConnected
        {
            get
            {
                return this.isConnectedField;
            }
            set
            {
                this.isConnectedField = value;
            }
        }

        /// <remarks/>
        public string IpAddressAllocationMode
        {
            get
            {
                return this.ipAddressAllocationModeField;
            }
            set
            {
                this.ipAddressAllocationModeField = value;
            }
        }

        /// <remarks/>
        public string NetworkAdapterType
        {
            get
            {
                return this.networkAdapterTypeField;
            }
            set
            {
                this.networkAdapterTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string network
        {
            get
            {
                return this.networkField;
            }
            set
            {
                this.networkField = value;
            }
        }

    }
}
