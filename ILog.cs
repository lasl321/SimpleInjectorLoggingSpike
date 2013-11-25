using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorLoggingSpike
{
    interface ILog
    {
        void Debug(string format, params object[] args);
    }

    class Log<T> : ILog
    {
        public void Debug(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}
