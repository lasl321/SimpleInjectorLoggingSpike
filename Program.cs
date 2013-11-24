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
            var instance = Global.Container.GetInstance<IMyInterface>();

            Console.WriteLine("Got instance");
        }
    }
}
