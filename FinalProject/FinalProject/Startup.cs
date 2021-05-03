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

            Before starting the project, get necessary NuGet packages.
            Swashbuckle and EntityFrameworkCore NuGet packages are
            necessary. Afterwards, set up the startup of of the
            web MVC site. Make sure to refer to the given API.
***********************************************************************/

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using System;
using System.Net.Http.Headers;

namespace WeatherForecastWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddControllers();

            // Create SwaggerDoc and set up the base address to the
            // live API and accept JSON values
            services.AddSwaggerGen(doc =>
                doc.SwaggerDoc("v1", new OpenApiInfo { Title = "COMP494_FINAL", Version = "v1" }));

            services.AddHttpClient(name: "WeatherForecastWeb",
                configureClient: options =>
                {
                    options.BaseAddress = new Uri("http://csc494a-sp21-final.azurewebsites.net/");
                    options.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(
                        "application/json", 1.0));
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(doc => doc.SwaggerEndpoint(
                    "http://csc494a-sp21-final.azurewebsites.net/swagger/v1/swagger.json", "COMP494_FINAL"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=WeatherForecastView}/{id?}");

                // Use Razor for endpoints on MVC web pages
                endpoints.MapRazorPages();
            });
        }
    }
}
