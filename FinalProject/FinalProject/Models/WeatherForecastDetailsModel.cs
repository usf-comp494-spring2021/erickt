/***********************************************************************
Title:        C# 494 - Final Project
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  May 3, 2021
Environment:  Visual C#

Objective:  This model is the DetailedForecast part of the live API.
            This will include all the available endpoints found in
            the Swagger documentation.
***********************************************************************/

using System;

namespace WeatherForecastWeb.Models
{
    // This class inherits the variables in the WeatherForecast class.
    // This class includes the details that would be found in a
    // weather forecast.
    public class WeatherForecastDetailsModel : WeatherForecastModel
    {
        public Int32 visibility { get; set; }
        public string clouds { get; set; }
        public Int32 humidity { get; set; } // Also present in WeatherForecastHourly, change it?
        public double rainfall { get; set; }
        public double snowfall { get; set; }
    }
}
