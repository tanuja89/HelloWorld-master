using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsole.Application;
using HelloWorldConsole.Services;
using HelloWorldInfrastructure.FrameworkWrappers;
using HelloWorldInfrastructure.Services;
using LightInject;
using RestSharp;

namespace HelloWorldConsole
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}


    public class MainDriver
    {
        public static void Main(string[] args)
        {
            // Setup dependency injection and run the application
            using (var container = new ServiceContainer())
            {
                // Configure depenency injection
                container.Register<IHelloWorldConsoleApp, HelloWorldConsoleApp>();
                container.Register<IAppSettings, ConfigAppSettings>();
                container.Register<IConsole, SystemConsole>();
                container.Register<ILogger, ConsoleLogger>();
                container.Register<IUri, SystemUri>();
                container.Register<IHelloWorldWebService, HelloWorldWebService>();
                container.RegisterInstance(typeof(IRestClient), new RestClient());
                container.RegisterInstance(typeof(IRestRequest), new RestRequest());

                // Run the main program
                container.GetInstance<IHelloWorldConsoleApp>().Run(args);
            }
        }
    }

}
