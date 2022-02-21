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
    public partial class GetVmList
    {

        private QueryResultRecordsLink[] linkField;

        private QueryResultRecordsVMRecord[] vMRecordField;

        private string nameField;

        private byte pageField;

        private byte pageSizeField;

        private byte totalField;

        private string hrefField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Link")]
        public QueryResultRecordsLink[] Link
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
        [System.Xml.Serialization.XmlElementAttribute("VMRecord")]
        public QueryResultRecordsVMRecord[] VMRecord
        {
            get
            {
                return this.vMRecordField;
            }
            set
            {
                this.vMRecordField = value;
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
        public byte page
        {
            get
            {
                return this.pageField;
            }
            set
            {
                this.pageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
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
    public partial class QueryResultRecordsLink
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
    public partial class QueryResultRecordsVMRecord
    {

        private QueryResultRecordsVMRecordLink[] linkField;

        private string nameField;

        private string containerNameField;

        private string containerField;

        private string ownerNameField;

        private string ownerField;

        private string vdcField;

        private string descriptionField;

        private string vappScopedLocalIdField;

        private bool isVAppTemplateField;

        private bool isDeletedField;

        private string guestOsField;

        private byte numberOfCpusField;

        private ushort memoryMBField;

        private string statusField;

        private string networkNameField;

        private string networkField;

        private string ipAddressField;

        private bool isBusyField;

        private bool isDeployedField;

        private bool isPublishedField;

        private byte hardwareVersionField;

        private string vmToolsStatusField;

        private bool isInMaintenanceModeField;

        private bool isAutoNatureField;

        private string storageProfileNameField;

        private bool snapshotField;

        private string gcStatusField;

        private bool isAutoUndeployNotifiedField;

        private bool isAutoDeleteNotifiedField;

        private bool isComputePolicyCompliantField;

        private string vmSizingPolicyIdField;

        private System.DateTime dateCreatedField;

        private ushort totalStorageAllocatedMbField;

        private bool isExpiredField;

        private string hrefField;

        private ushort vmToolsVersionField;

        private string taskStatusNameField;

        private string taskField;

        private bool isVdcEnabledField;

        private byte pvdcHighestSupportedHardwareVersionField;

        private string taskStatusField;

        private string taskDetailsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Link")]
        public QueryResultRecordsVMRecordLink[] Link
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
        public string containerName
        {
            get
            {
                return this.containerNameField;
            }
            set
            {
                this.containerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string container
        {
            get
            {
                return this.containerField;
            }
            set
            {
                this.containerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ownerName
        {
            get
            {
                return this.ownerNameField;
            }
            set
            {
                this.ownerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vdc
        {
            get
            {
                return this.vdcField;
            }
            set
            {
                this.vdcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vappScopedLocalId
        {
            get
            {
                return this.vappScopedLocalIdField;
            }
            set
            {
                this.vappScopedLocalIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isVAppTemplate
        {
            get
            {
                return this.isVAppTemplateField;
            }
            set
            {
                this.isVAppTemplateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isDeleted
        {
            get
            {
                return this.isDeletedField;
            }
            set
            {
                this.isDeletedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guestOs
        {
            get
            {
                return this.guestOsField;
            }
            set
            {
                this.guestOsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte numberOfCpus
        {
            get
            {
                return this.numberOfCpusField;
            }
            set
            {
                this.numberOfCpusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort memoryMB
        {
            get
            {
                return this.memoryMBField;
            }
            set
            {
                this.memoryMBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ipAddress
        {
            get
            {
                return this.ipAddressField;
            }
            set
            {
                this.ipAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isBusy
        {
            get
            {
                return this.isBusyField;
            }
            set
            {
                this.isBusyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isDeployed
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
        public bool isPublished
        {
            get
            {
                return this.isPublishedField;
            }
            set
            {
                this.isPublishedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hardwareVersion
        {
            get
            {
                return this.hardwareVersionField;
            }
            set
            {
                this.hardwareVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vmToolsStatus
        {
            get
            {
                return this.vmToolsStatusField;
            }
            set
            {
                this.vmToolsStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isInMaintenanceMode
        {
            get
            {
                return this.isInMaintenanceModeField;
            }
            set
            {
                this.isInMaintenanceModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAutoNature
        {
            get
            {
                return this.isAutoNatureField;
            }
            set
            {
                this.isAutoNatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storageProfileName
        {
            get
            {
                return this.storageProfileNameField;
            }
            set
            {
                this.storageProfileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool snapshot
        {
            get
            {
                return this.snapshotField;
            }
            set
            {
                this.snapshotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string gcStatus
        {
            get
            {
                return this.gcStatusField;
            }
            set
            {
                this.gcStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAutoUndeployNotified
        {
            get
            {
                return this.isAutoUndeployNotifiedField;
            }
            set
            {
                this.isAutoUndeployNotifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAutoDeleteNotified
        {
            get
            {
                return this.isAutoDeleteNotifiedField;
            }
            set
            {
                this.isAutoDeleteNotifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isComputePolicyCompliant
        {
            get
            {
                return this.isComputePolicyCompliantField;
            }
            set
            {
                this.isComputePolicyCompliantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vmSizingPolicyId
        {
            get
            {
                return this.vmSizingPolicyIdField;
            }
            set
            {
                this.vmSizingPolicyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dateCreated
        {
            get
            {
                return this.dateCreatedField;
            }
            set
            {
                this.dateCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort totalStorageAllocatedMb
        {
            get
            {
                return this.totalStorageAllocatedMbField;
            }
            set
            {
                this.totalStorageAllocatedMbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isExpired
        {
            get
            {
                return this.isExpiredField;
            }
            set
            {
                this.isExpiredField = value;
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
        public ushort vmToolsVersion
        {
            get
            {
                return this.vmToolsVersionField;
            }
            set
            {
                this.vmToolsVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string taskStatusName
        {
            get
            {
                return this.taskStatusNameField;
            }
            set
            {
                this.taskStatusNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isVdcEnabled
        {
            get
            {
                return this.isVdcEnabledField;
            }
            set
            {
                this.isVdcEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pvdcHighestSupportedHardwareVersion
        {
            get
            {
                return this.pvdcHighestSupportedHardwareVersionField;
            }
            set
            {
                this.pvdcHighestSupportedHardwareVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string taskStatus
        {
            get
            {
                return this.taskStatusField;
            }
            set
            {
                this.taskStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string taskDetails
        {
            get
            {
                return this.taskDetailsField;
            }
            set
            {
                this.taskDetailsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class QueryResultRecordsVMRecordLink
    {

        private string relField;

        private string hrefField;

        private string typeField;

        private string nameField;

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
