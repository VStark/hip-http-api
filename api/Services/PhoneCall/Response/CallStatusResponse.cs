using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIPHttpApi
{
    public class CallStatusResponse : IResponse
    {
        public CallStatusResponse(IEnumerable<SessionEntity> sessions)
        {
            _sessions = sessions;
        }

        IEnumerable<SessionEntity> _sessions;
        public IEnumerable<SessionEntity> Sessinos { get { return _sessions; } }

        public bool Success
        {
            get { return true; }
        }
    }
}
