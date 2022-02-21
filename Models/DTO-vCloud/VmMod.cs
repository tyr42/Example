using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WOPS_API.Models.DTO_vCloud.VmMod
{

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = false, Namespace = "http://www.vmware.com/schema/ovf")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.vmware.com/vcloud/v1.5", IsNullable = false)]

    public partial class VmMod
    {
        [XmlNamespaceDeclarationsAttribute]
        public XmlSerializerNamespaces myNamespaces;
        ///###trying to change namespaces


        private string descriptionField;

        private VmVmSpecSection vmSpecSectionField;

        private VmVmCapabilities vmCapabilitiesField;

        private string idField;

        private string nameField;
        // ( new VmVmSpec() , new VmCap()

        //this is the used Constructor
        public VmMod(string name, string description, int cores, int ram, int hdd, string hwVersion_href, string hwVersion_value)
        {
            this.name = name;
            Description = description;
            VmSpecSection = new VmVmSpecSection(cores, ram, hdd, hwVersion_href, hwVersion_value);
            VmCapabilities = new VmVmCapabilities();
        }
        public VmMod()
        {

            Description = "new Description";
            name = "Browser Test 01";

            VmSpecSection = new VmVmSpecSection();
            VmCapabilities = new VmVmCapabilities();
        }

        public VmMod(string description, VmVmSpecSection vmSpecSection, VmVmCapabilities vmCapabilities, string id, string name)
        {
            Description = description;
            VmSpecSection = vmSpecSection;
            VmCapabilities = vmCapabilities;
            this.id = id;
            this.name = name;
        }

        public VmMod(string description, VmVmSpecSection vmSpecSection)
        {
            Description = description;
            VmSpecSection = vmSpecSection;
            VmCapabilities = new VmVmCapabilities();
        }

        public VmMod(VmVmSpecSection vmSpecSection)
        {
            VmSpecSection = vmSpecSection;
            VmCapabilities = new VmVmCapabilities();
        }

        public VmMod(string desc, string name)
        {
            this.name = name;
            Description = desc;
            VmSpecSection = new VmVmSpecSection();
            VmCapabilities = new VmVmCapabilities();
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

        /// <remarks/>
        public VmVmSpecSection VmSpecSection
        {
            get
            {
                return this.vmSpecSectionField;
            }
            set
            {
                this.vmSpecSectionField = value;
            }
        }

        /// <remarks/>
        public VmVmCapabilities VmCapabilities
        {
            get
            {
                return this.vmCapabilitiesField;
            }
            set
            {
                this.vmCapabilitiesField = value;
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class VmVmSpecSection
    {

        private string infoField;

        private byte numCpusField;

        private byte numCoresPerSocketField;

        private VmVmSpecSectionCpuResourceMhz cpuResourceMhzField;

        private VmVmSpecSectionMemoryResourceMb memoryResourceMbField;

        private VmVmSpecSectionDiskSection diskSectionField;

        private VmVmSpecSectionHardwareVersion hardwareVersionField;

        private string virtualCpuTypeField;

        private bool modifiedField;

        public VmVmSpecSection(byte numCpus, byte numCoresPerSocket, VmVmSpecSectionCpuResourceMhz cpuResourceMhz, VmVmSpecSectionMemoryResourceMb memoryResourceMb, VmVmSpecSectionDiskSection diskSection, VmVmSpecSectionHardwareVersion hardwareVersion, string virtualCpuType)
        {
            NumCpus = numCpus;
            NumCoresPerSocket = numCoresPerSocket;
            CpuResourceMhz = cpuResourceMhz;
            MemoryResourceMb = memoryResourceMb;
            DiskSection = diskSection;
            HardwareVersion = hardwareVersion;
            VirtualCpuType = virtualCpuType;
            Modified = true;
        }

        public VmVmSpecSection(int cores, int ram, int hdd, string hwVersion_href, string hwVersion_value)
        {
            infoField = "Virtual hardware requirements (simplified)";
            NumCpus = (byte)cores;
            NumCoresPerSocket = (byte)1;
            CpuResourceMhz = new VmVmSpecSectionCpuResourceMhz();
            MemoryResourceMb = new VmVmSpecSectionMemoryResourceMb(ram);
            DiskSection = new VmVmSpecSectionDiskSection(hdd);
            HardwareVersion = new VmVmSpecSectionHardwareVersion(hwVersion_href, hwVersion_value);
            VirtualCpuType = "VM64";
            Modified = true;
        }

        //for first Test all hard coded to see if api call works
        public VmVmSpecSection()
        {
            infoField = "Virtual hardware requirements (simplified)";
            NumCpus = (byte)3;
            NumCoresPerSocket = (byte)1;
            CpuResourceMhz = new VmVmSpecSectionCpuResourceMhz();
            MemoryResourceMb = new VmVmSpecSectionMemoryResourceMb();
            DiskSection = new VmVmSpecSectionDiskSection();
            HardwareVersion = new VmVmSpecSectionHardwareVersion();
            VirtualCpuType = "VM64";
            Modified = true;
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
        public byte NumCpus
        {
            get
            {
                return this.numCpusField;
            }
            set
            {
                this.numCpusField = value;
            }
        }

        /// <remarks/>
        public byte NumCoresPerSocket
        {
            get
            {
                return this.numCoresPerSocketField;
            }
            set
            {
                this.numCoresPerSocketField = value;
            }
        }

        /// <remarks/>
        public VmVmSpecSectionCpuResourceMhz CpuResourceMhz
        {
            get
            {
                return this.cpuResourceMhzField;
            }
            set
            {
                this.cpuResourceMhzField = value;
            }
        }

        /// <remarks/>
        public VmVmSpecSectionMemoryResourceMb MemoryResourceMb
        {
            get
            {
                return this.memoryResourceMbField;
            }
            set
            {
                this.memoryResourceMbField = value;
            }
        }

        /// <remarks/>
        public VmVmSpecSectionDiskSection DiskSection
        {
            get
            {
                return this.diskSectionField;
            }
            set
            {
                this.diskSectionField = value;
            }
        }

        /// <remarks/>
        public VmVmSpecSectionHardwareVersion HardwareVersion
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
        public string VirtualCpuType
        {
            get
            {
                return this.virtualCpuTypeField;
            }
            set
            {
                this.virtualCpuTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class VmVmSpecSectionCpuResourceMhz
    {

        private byte configuredField;

        public VmVmSpecSectionCpuResourceMhz(byte configured)
        {
            Configured = configured;
        }
        public VmVmSpecSectionCpuResourceMhz()
        {
            Configured = 1;
        }

        /// <remarks/>
        public byte Configured
        {
            get
            {
                return this.configuredField;
            }
            set
            {
                this.configuredField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class VmVmSpecSectionMemoryResourceMb
    {

        private ushort configuredField;

        public VmVmSpecSectionMemoryResourceMb(ushort configured)
        {
            Configured = configured;
        }

        public VmVmSpecSectionMemoryResourceMb()
        {
            Configured = 2048;
        }
        public VmVmSpecSectionMemoryResourceMb(int ram)
        {
            Configured = (ushort)ram;
        }

        /// <remarks/>
        public ushort Configured
        {
            get
            {
                return this.configuredField;
            }
            set
            {
                this.configuredField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class VmVmSpecSectionDiskSection
    {

        private VmVmSpecSectionDiskSectionDiskSettings diskSettingsField;

        public VmVmSpecSectionDiskSection(int hdd)
        {
            DiskSettings = new VmVmSpecSectionDiskSectionDiskSettings(hdd);
        }
        public VmVmSpecSectionDiskSection(VmVmSpecSectionDiskSectionDiskSettings diskSettings)
        {
            DiskSettings = diskSettings;
        }

        public VmVmSpecSectionDiskSection()
        {
            DiskSettings = new VmVmSpecSectionDiskSectionDiskSettings();
        }
        /// <remarks/>
        public VmVmSpecSectionDiskSectionDiskSettings DiskSettings
        {
            get
            {
                return this.diskSettingsField;
            }
            set
            {
                this.diskSettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class VmVmSpecSectionDiskSectionDiskSettings
    {

        private ushort diskIdField;

        private ushort sizeMbField;

        private byte unitNumberField;

        private byte busNumberField;

        private byte adapterTypeField;

        private bool thinProvisionedField;

        private bool overrideVmDefaultField;

        private byte iopsField;

        private string virtualQuantityUnitField;

        public VmVmSpecSectionDiskSectionDiskSettings(ushort diskId, ushort sizeMb, byte unitNumber, byte busNumber, byte adapterType, bool thinProvisioned, bool overrideVmDefault, byte iops, string virtualQuantityUnit)
        {
            DiskId = diskId;
            SizeMb = sizeMb;
            UnitNumber = unitNumber;
            BusNumber = busNumber;
            AdapterType = adapterType;
            ThinProvisioned = thinProvisioned;
            this.overrideVmDefault = overrideVmDefault;
            this.iops = iops;
            VirtualQuantityUnit = virtualQuantityUnit;
        }

        public VmVmSpecSectionDiskSectionDiskSettings(int sizeMB)
        {
            DiskId = 2000;
            SizeMb = (ushort)sizeMB;
            UnitNumber = 0;
            BusNumber = 0;
            AdapterType = 3;
            ThinProvisioned = false;
            this.overrideVmDefault = false;
            this.iops = 0;
            VirtualQuantityUnit = "byte";
        }

        public VmVmSpecSectionDiskSectionDiskSettings(ushort sizeMB)
        {
            DiskId = 2000;
            SizeMb = sizeMB;
            UnitNumber = 0;
            BusNumber = 0;
            AdapterType = 3;
            ThinProvisioned = false;
            this.overrideVmDefault = false;
            this.iops = 0;
            VirtualQuantityUnit = "byte";
        }
        public VmVmSpecSectionDiskSectionDiskSettings()
        {
            DiskId = 2000;
            SizeMb = 22528;
            UnitNumber = 0;
            BusNumber = 0;
            AdapterType = 3;
            ThinProvisioned = false;
            this.overrideVmDefault = false;
            this.iops = 0;
            VirtualQuantityUnit = "byte";
        }
        /// <remarks/>
        public ushort DiskId
        {
            get
            {
                return this.diskIdField;
            }
            set
            {
                this.diskIdField = value;
            }
        }

        /// <remarks/>
        public ushort SizeMb
        {
            get
            {
                return this.sizeMbField;
            }
            set
            {
                this.sizeMbField = value;
            }
        }

        /// <remarks/>
        public byte UnitNumber
        {
            get
            {
                return this.unitNumberField;
            }
            set
            {
                this.unitNumberField = value;
            }
        }

        /// <remarks/>
        public byte BusNumber
        {
            get
            {
                return this.busNumberField;
            }
            set
            {
                this.busNumberField = value;
            }
        }

        /// <remarks/>
        public byte AdapterType
        {
            get
            {
                return this.adapterTypeField;
            }
            set
            {
                this.adapterTypeField = value;
            }
        }

        /// <remarks/>
        public bool ThinProvisioned
        {
            get
            {
                return this.thinProvisionedField;
            }
            set
            {
                this.thinProvisionedField = value;
            }
        }

        /// <remarks/>
        public bool overrideVmDefault
        {
            get
            {
                return this.overrideVmDefaultField;
            }
            set
            {
                this.overrideVmDefaultField = value;
            }
        }

        /// <remarks/>
        public byte iops
        {
            get
            {
                return this.iopsField;
            }
            set
            {
                this.iopsField = value;
            }
        }

        /// <remarks/>
        public string VirtualQuantityUnit
        {
            get
            {
                return this.virtualQuantityUnitField;
            }
            set
            {
                this.virtualQuantityUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class VmVmSpecSectionHardwareVersion
    {

        private string hrefField;

        private string valueField;

        public VmVmSpecSectionHardwareVersion(string hrefhw, string value)
        {
            href = hrefhw;
            Value = value;
        }

        public VmVmSpecSectionHardwareVersion()
        {
            this.href = "https://vcloud.claranet.de/api/vdc/2dade109-3233-4f7e-b746-e3825f044796/hwv/vmx-11";
            Value = "vmx-11";
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.vmware.com/vcloud/v1.5")]
    public partial class VmVmCapabilities
    {

        private bool memoryHotAddEnabledField;

        private bool cpuHotAddEnabledField;

        public VmVmCapabilities()
        {
            MemoryHotAddEnabled = true;
            CpuHotAddEnabled = true;
        }
        public VmVmCapabilities(bool memoryHotAddEnabled, bool cpuHotAddEnabled)
        {
            MemoryHotAddEnabled = memoryHotAddEnabled;
            CpuHotAddEnabled = cpuHotAddEnabled;
        }

        /// <remarks/>
        public bool MemoryHotAddEnabled
        {
            get
            {
                return this.memoryHotAddEnabledField;
            }
            set
            {
                this.memoryHotAddEnabledField = value;
            }
        }

        /// <remarks/>
        public bool CpuHotAddEnabled
        {
            get
            {
                return this.cpuHotAddEnabledField;
            }
            set
            {
                this.cpuHotAddEnabledField = value;
            }
        }
    }

}
