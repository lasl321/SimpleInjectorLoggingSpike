using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorLoggingSpike
{
    interface ILog<T>
    {
        void Debug(string format, params object[] args);
    }

    class Log<T> : ILog<T>
    {
        public void Debug(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
