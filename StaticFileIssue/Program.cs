using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace StaticFileIssue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebHost.CreateDefaultBuilder(args)
                //.UseWebRoot("/Users/wis3guy/Projects/StaticFileIssue/StaticFileIssue/wwwroot") // This hardcodes the location of the wwwroot to the folde rin the codebase
                //.UseWebRoot(Path.Join(Directory.GetCurrentDirectory(), "wwwroot")) // This emulates the default behavior and uses tha path of the wwwroot folder in the executing directory
                .UseStartup<Startup>();
            
            var host = builder.Build();

            // Put a breakpoint on host.Run() and watch the host.Options.WebRoot (sadly not public) property
            // - Empty by default
            // - Value set in the .UseWebRoot() call

            host.Run();
        }
    }
}