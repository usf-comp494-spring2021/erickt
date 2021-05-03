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

            The HomeController will control how the web MVC's will
            interact with the live API available.
***********************************************************************/

using WeatherForecastWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WeatherForecastWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory clientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            clientFactory = httpClientFactory;
        }

        // This controller handles the WeatherForecast
        // model endpoints in the API.
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(WeatherForecastModel))]
        public async Task<IActionResult> WeatherForecastView()
        {
            string uri = "WeatherForecast";
            ViewData["Title"] = "WeatherForecast";

            var client = clientFactory.CreateClient(
                name: "WeatherForecastWeb");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);
            var model = await response.Content.ReadFromJsonAsync<WeatherForecastModel>();

            return View(model);
        }

        // This controller handles the DetailedForecast
        // model endpoints in the API.
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(WeatherForecastDetailsModel))]
        public async Task<IActionResult> WeatherForecastDetailsView()
        {
            string uri = "WeatherForecast/details";

            var client = clientFactory.CreateClient(
                name: "WeatherForecastWeb");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);
            var model = await response.Content.ReadFromJsonAsync<WeatherForecastDetailsModel>();

            return View(model);
        }

        // This controller handles the HourlyForecast
        // model endpoints in the API.
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<WeatherForecastHourlyModel>))]
        public async Task<IActionResult> WeatherForecastHourlyView()
        {
            string uri = "WeatherForecast/hourly";

            var client = clientFactory.CreateClient(
                name: "WeatherForecastWeb");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);
            var model = await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecastHourlyModel>>();

            return View(model);
        }

        // This controller handles the Privacy view
        public IActionResult Sponsor()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
