using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInjectorLoggingSpike
{
    class MyConcreteClass : IMyInterface
    {
        private ILog<MyConcreteClass> _log;

        public MyConcreteClass(ILog<MyConcreteClass> log)
        {
            _log = log;

            _log.Debug("This is a message from MyConcreteClass");
        }
    }
}
