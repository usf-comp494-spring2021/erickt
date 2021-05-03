/***********************************************************************
Title:        C# 494 - Final Project
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  May 3, 2021
Environment:  Visual C#

Objective:  This model is the WeatherForecast part of the live API.
            This will include all the available endpoints found in
            the Swagger documentation.
***********************************************************************/

using System;

namespace WeatherForecastWeb.Models
{
    // This class includes all the endpoints from the API and the data
    // types are set to what is shown in the documentation.
    // This will be used by the HomeController and shown for display
    public class WeatherForecastModel
    {
        public DateTime forecastDate { get; set; }
        public string location { get; set; }
        public double temperature { get; set; }
        public double feelsLike { get; set; }
        public string descriptor { get; set; }
        public string imagePath { get; set; }
        public double windSpeed { get; set; }
        public string windDirection { get; set; }
        public double pressure { get; set; }
    }
}
