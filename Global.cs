using System;
using System.Collections.Generic;
using log4net;
using SimpleInjector;
using SimpleInjector.Advanced;

namespace SimpleInjectorLoggingSpike
{
    internal static class Global
    {
        public static List<log4net.ILog> Loggers = new List<log4net.ILog>();

        static Global()
        {
            Container = new Container();

            Container.RegisterWithContext(dependencyContext =>
            {
                if (dependencyContext.ServiceType == null && !Container.IsVerifying())
                {
                    throw new InvalidOperationException(
                        "Can't request ILog directly from container, it must be injected as a dependency.");
                }

                var logger = LogManager.GetLogger(dependencyContext.ImplementationType ?? typeof (object));

                foreach (var log in Loggers)
                {
                    if (ReferenceEquals(log, logger))
                    {
                        Console.WriteLine("Found duplicate");
                    }
                }

                Loggers.Add(logger);

                return logger;
            });

            Console.WriteLine("About to call register");
            Container.Register<IMyInterface, MyConcreteClass>();

            Console.WriteLine("About to call verify");
            Container.Verify();
        }

        public static Container Container { get; private set; }
    }
}