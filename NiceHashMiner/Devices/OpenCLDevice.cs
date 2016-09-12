﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashMiner.Devices {
    [Serializable]
    public class OpenCLDevice {
        public uint DeviceID;
        public string _CL_DEVICE_NAME;
        public string _CL_DEVICE_TYPE;
        public ulong _CL_DEVICE_GLOBAL_MEM_SIZE;
        public string _CL_DEVICE_VENDOR;
        public string _CL_DEVICE_VERSION;
        public string _CL_DRIVER_VERSION;
        public int AMD_BUS_ID = -1; // -1 indicates that it is not set
    }
}
