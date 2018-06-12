using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsole.Services;
using HelloWorldInfrastructure.Services;

namespace HelloWorldConsole.Application
{
    public class HelloWorldConsoleApp : IHelloWorldConsoleApp
    {
      
        private readonly IHelloWorldWebService helloWorldWebService;

       
        private readonly ILogger logger;

        public HelloWorldConsoleApp(IHelloWorldWebService helloWorldWebService, ILogger logger)
        {
            this.helloWorldWebService = helloWorldWebService;
            this.logger = logger;
        }
        
        public void Run(string[] arguments)
        {
            // Get Today's data
            var todaysData = this.helloWorldWebService.GetTodaysData();

            // Write Today's data to the screen
            this.logger.Info(todaysData != null ? todaysData.Data : "No data was found!", null);
        }
    }
}
