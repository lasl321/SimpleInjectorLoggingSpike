using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace SimpleInjectorLoggingSpike
{
    class MyConcreteClass : IMyInterface
    {
        private log4net.ILog _log;

        public MyConcreteClass(log4net.ILog log)
        {
            _log = log;

            _log.Debug("This is a message from MyConcreteClass" + " xyz123" + " " + _log.GetHashCode());
        }
    }
}
