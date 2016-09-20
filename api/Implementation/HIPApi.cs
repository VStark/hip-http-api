using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIPHttpApi
{
    public class HIPApi : IApi
    {
        public HIPApi(ILoggingService logging = null, ISystemService system = null)
        {
            _logging = logging;
            _system = system;
        }

        private ISystemService _system;
        public ISystemService System
        {
            get { return _system; }
        }

        private ILoggingService _logging;
        public ILoggingService Logging
        {
            get { return _logging; }
        }
    }
}
