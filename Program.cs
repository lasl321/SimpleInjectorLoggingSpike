using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorLoggingSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            var instance = Global.Container.GetInstance<IMyInterface>();
          
            Console.WriteLine("Got instance");

            var instance2 = Global.Container.GetInstance<IMyInterface>();

            Console.WriteLine("Got another instance");
        }
    }
}
