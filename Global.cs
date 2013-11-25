using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace SimpleInjectorLoggingSpike
{
    static class Global
    {
        public static Container Container { get; private set; }

        static Global()
        {
            Container = new Container();

            Container.RegisterWithContext<log4net.ILog>(dependencyContext =>
            {
                Console.WriteLine("Getting another log");
                return LogManager.GetLogger(dependencyContext.ImplementationType);
            });

            Container.Register<IMyInterface, MyConcreteClass>();
        }
    }
}
