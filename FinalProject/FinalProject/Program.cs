/***********************************************************************
Title:        C# 494 - Final Project
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  May 3, 2021
Environment:  Visual C#

Objective:  Build a Web MVC Project and use a Web API provided. Consume
            all API endpoints available according to the Swagger
            documentation and have each page use Razor. Each page
            must use unique layouts to stand out. Integrate all
            content provided by the endpoint into the application for
            display.

            For Program.cs, set up a localhost page to display the data
            from the API endpoints available.
***********************************************************************/

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WeatherForecastWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // Build a hosting website page to display models through
        // a browser. Without out, we cannot display anything.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls(
                        "https://localhost:5001", // for MVC client, https
                        "http://localhost:5003" // for mobile client, http
                    );
                });
    }
}
    