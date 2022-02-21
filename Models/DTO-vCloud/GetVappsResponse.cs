using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models.DTO_vCloud.GetVappsResponse
{

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.vmware.com/vcloud/v1.5", IsNullable = false)]
    public partial class QueryResultRecords
    {

        private QueryResultRecordsLink[] linkField;

        private QueryResultRecordsVAppRecord[] vAppRecordField;

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
        [System.Xml.Serialization.XmlElementAttribute("VAppRecord")]
        public QueryResultRecordsVAppRecord[] VAppRecord
        {
            get
            {
                return this.vAppRecordField;
            }
            set
            {
                this.vAppRecordField = value;
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
    public partial class QueryResultRecordsVAppRecord
    {

        private string nameField;

        private string vdcField;

        private string vdcNameField;

        private string descriptionField;

        private bool isPublicField;

        private bool isEnabledField;

        private bool isBusyField;

        private System.DateTime creationDateField;

        private string statusField;

        private string ownerNameField;

        private ushort memoryAllocationMBField;

        private bool memoryAllocationMBFieldSpecified;

        private bool isDeployedField;

        private bool isInMaintenanceModeField;

        private bool isAutoNatureField;

        private bool isExpiredField;

        private byte numberOfCpusField;

        private bool numberOfCpusFieldSpecified;

        private bool snapshotField;

        private ushort totalStorageAllocatedMbField;

        private string hrefField;

        private string taskStatusNameField;

        private bool isAutoDeleteNotifiedField;

        private bool isVdcEnabledField;

        private bool honorBootOrderField;

        private byte numberOfVMsField;

        private ushort cpuAllocationInMhzField;

        private bool cpuAllocationInMhzFieldSpecified;

        private byte cpuAllocationMhzField;

        private bool cpuAllocationMhzFieldSpecified;

        private string taskField;

        private byte lowestHardwareVersionInVAppField;

        private bool lowestHardwareVersionInVAppFieldSpecified;

        private uint storageKBField;

        private byte pvdcHighestSupportedHardwareVersionField;

        private bool isAutoUndeployNotifiedField;

        private string taskStatusField;

        private string taskDetailsField;

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
        public string vdcName
        {
            get
            {
                return this.vdcNameField;
            }
            set
            {
                this.vdcNameField = value;
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
        public bool isPublic
        {
            get
            {
                return this.isPublicField;
            }
            set
            {
                this.isPublicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isEnabled
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
        public System.DateTime creationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
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
        public ushort memoryAllocationMB
        {
            get
            {
                return this.memoryAllocationMBField;
            }
            set
            {
                this.memoryAllocationMBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool memoryAllocationMBSpecified
        {
            get
            {
                return this.memoryAllocationMBFieldSpecified;
            }
            set
            {
                this.memoryAllocationMBFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfCpusSpecified
        {
            get
            {
                return this.numberOfCpusFieldSpecified;
            }
            set
            {
                this.numberOfCpusFieldSpecified = value;
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
        public bool honorBootOrder
        {
            get
            {
                return this.honorBootOrderField;
            }
            set
            {
                this.honorBootOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte numberOfVMs
        {
            get
            {
                return this.numberOfVMsField;
            }
            set
            {
                this.numberOfVMsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort cpuAllocationInMhz
        {
            get
            {
                return this.cpuAllocationInMhzField;
            }
            set
            {
                this.cpuAllocationInMhzField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpuAllocationInMhzSpecified
        {
            get
            {
                return this.cpuAllocationInMhzFieldSpecified;
            }
            set
            {
                this.cpuAllocationInMhzFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cpuAllocationMhz
        {
            get
            {
                return this.cpuAllocationMhzField;
            }
            set
            {
                this.cpuAllocationMhzField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cpuAllocationMhzSpecified
        {
            get
            {
                return this.cpuAllocationMhzFieldSpecified;
            }
            set
            {
                this.cpuAllocationMhzFieldSpecified = value;
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
        public byte lowestHardwareVersionInVApp
        {
            get
            {
                return this.lowestHardwareVersionInVAppField;
            }
            set
            {
                this.lowestHardwareVersionInVAppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lowestHardwareVersionInVAppSpecified
        {
            get
            {
                return this.lowestHardwareVersionInVAppFieldSpecified;
            }
            set
            {
                this.lowestHardwareVersionInVAppFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint storageKB
        {
            get
            {
                return this.storageKBField;
            }
            set
            {
                this.storageKBField = value;
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


}
