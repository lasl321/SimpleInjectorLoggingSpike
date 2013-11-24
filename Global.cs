using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorLoggingSpike
{
    static class Global
    {
        public static Container Container { get; private set; }

        static Global()
        {
            Container = new Container();

            Container.Register<IMyInterface, MyConcreteClass>();
        }
    }
}
