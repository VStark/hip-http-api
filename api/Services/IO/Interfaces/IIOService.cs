using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HIPHttpApi
{
    public interface IIOService : IService
    {
        IResponse Caps(string port);
        IResponse Status(string port);
        IResponse Ctrl(string port, IOPortAction action, string response);
    }
}
