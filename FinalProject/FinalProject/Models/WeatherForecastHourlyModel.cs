/***********************************************************************
Title:        C# 494 - Final Project
Author:		  Erick Tenorio
Course:		  COMP 494
Due Date:	  May 3, 2021
Environment:  Visual C#

Objective:  This model is the HourlyForecast part of the live API.
            This will include all the available endpoints found in
            the Swagger documentation.
***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastWeb.Models
{
    // This class inherits the variables in the WeatherForecast class.
    // This class includes includes variables related to the hourly
    // details reported in a weather forecast
    public class WeatherForecastHourlyModel : WeatherForecastModel
    {
        public Int32 precipitationPercent { get; set; }
        public double precipitationAmount { get; set; }
        public Int32 cloudCover { get; set; }
        public Int32 dewPoint { get; set; }
        public Int32 humidity { get; set; } // Also present in WeatherForecastDetails, change it?
    }
}
