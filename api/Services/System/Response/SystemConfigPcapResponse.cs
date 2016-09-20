using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIPHttpApi
{
    public class SystemConfigPcapResponse : IResponse
    {
        public SystemConfigPcapResponse(byte[] data)
        {
            _data = data;
        }

        byte[] _data = null;
        public byte[] Data { get { return _data; } }

        public bool Success
        {
            get { return true; }
        }
    }
}
