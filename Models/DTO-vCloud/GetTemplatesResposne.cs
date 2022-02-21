using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOPS_API.Models.DTO_vCloud.GetTemplateResponse
{
    public class GetTemplatesResposne
    {
    }

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.vmware.com/vcloud/v1.5", IsNullable = false)]
    public partial class QueryResultRecords
    {

        private QueryResultRecordsLink[] linkField;

        private QueryResultRecordsVAppTemplateRecord[] vAppTemplateRecordField;

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
        [System.Xml.Serialization.XmlElementAttribute("VAppTemplateRecord")]
        public QueryResultRecordsVAppTemplateRecord[] VAppTemplateRecord
        {
            get
            {
                return this.vAppTemplateRecordField;
            }
            set
            {
                this.vAppTemplateRecordField = value;
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
    public partial class QueryResultRecordsVAppTemplateRecord
    {

        private string ownerNameField;

        private string catalogNameField;

        private bool isPublishedField;

        private string nameField;

        private string descriptionField;

        private string vdcField;

        private string vdcNameField;

        private string orgField;

        private System.DateTime creationDateField;

        private bool isBusyField;

        private bool isGoldMasterField;

        private bool isEnabledField;

        private string statusField;

        private bool isDeployedField;

        private bool isExpiredField;

        private string storageProfileNameField;

        private byte versionField;

        private string hrefField;

        private byte numberOfCpusField;

        private byte cpuAllocationMhzField;

        private byte numberOfShadowVMsField;

        private bool isInCatalogField;

        private bool isAutoDeleteNotifiedField;

        private ushort memoryAllocationMBField;

        private bool isVdcEnabledField;

        private bool honorBootOrderField;

        private uint storageKBField;

        private bool isAutoUndeployNotifiedField;

        private byte numberOfVMsField;

        private ushort cpuAllocationInMhzField;

        private System.DateTime autoDeleteDateField;

        private bool autoDeleteDateFieldSpecified;

        private bool mustBeFencedField;

        private bool mustBeFencedFieldSpecified;

        private string taskStatusNameField;

        private string taskField;

        private string taskStatusField;

        private string taskDetailsField;

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
        public string catalogName
        {
            get
            {
                return this.catalogNameField;
            }
            set
            {
                this.catalogNameField = value;
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
        public string org
        {
            get
            {
                return this.orgField;
            }
            set
            {
                this.orgField = value;
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
        public bool isGoldMaster
        {
            get
            {
                return this.isGoldMasterField;
            }
            set
            {
                this.isGoldMasterField = value;
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
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte numberOfShadowVMs
        {
            get
            {
                return this.numberOfShadowVMsField;
            }
            set
            {
                this.numberOfShadowVMsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isInCatalog
        {
            get
            {
                return this.isInCatalogField;
            }
            set
            {
                this.isInCatalogField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime autoDeleteDate
        {
            get
            {
                return this.autoDeleteDateField;
            }
            set
            {
                this.autoDeleteDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool autoDeleteDateSpecified
        {
            get
            {
                return this.autoDeleteDateFieldSpecified;
            }
            set
            {
                this.autoDeleteDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool mustBeFenced
        {
            get
            {
                return this.mustBeFencedField;
            }
            set
            {
                this.mustBeFencedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool mustBeFencedSpecified
        {
            get
            {
                return this.mustBeFencedFieldSpecified;
            }
            set
            {
                this.mustBeFencedFieldSpecified = value;
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
