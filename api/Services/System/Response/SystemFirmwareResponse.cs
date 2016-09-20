using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIPHttpApi
{
    public class SystemFirmwareResponse : IResponse
    {
        public SystemFirmwareResponse(string version, bool downgrade)
        {
            _version = version;
            _downgrade = downgrade;
        }

        private bool _downgrade;
        public bool Downgrade { get { return _downgrade; } }

        private string _version;
        public string Version { get { return _version; } }

        public bool Success
        {
            get { return true; }
        }
    }
}
