#pragma checksum "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f1372e3e89bf4aebdd37ae94e021dc75af5939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeatherForecastDetailsView), @"mvc.1.0.view", @"/Views/Home/WeatherForecastDetailsView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\C-Sharp 494\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using WeatherForecastWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C-Sharp 494\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using WeatherForecastWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f1372e3e89bf4aebdd37ae94e021dc75af5939", @"/Views/Home/WeatherForecastDetailsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8aa9ad3ace87690d7907be3a50d97f9fd66c028", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeatherForecastDetailsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WeatherForecastWeb.Models.WeatherForecastDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:400px; height:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
  
    ViewData["Title"] = "Detailed Weather Forecast";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div>\r\n    <h1>Your Detailed Weather Forecast</h1>\r\n    <strong>");
#nullable restore
#line 12 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <br />\r\n    <strong>");
#nullable restore
#line 13 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.forecastDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> <br />\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 484, "\"", 526, 1);
#nullable restore
#line 15 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
WriteAttributeValue("", 490, Url.Content("~/images/joliet2.png"), 490, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:500px; height:400px""> <br />
    <p>This is the Rialto Theater at downtown Joliet. Did you it is also home for art
        made by students at the Univerity of St. Francis? Well, you can take a look
        around the corner to see for yourself!</p> <br />

    <p>In the meantime, how about a song to listen to? Best to stay calm during the day.</p>
    <iframe style=""width:400px; height:300px"" src=""https://www.youtube.com/embed/6l6vqPUM_FE""></iframe>

    <p>And now back to your weather reports, just below this page. The Rialto Theater is
    iconic to Joliet!</p>
</div>

");
            WriteLiteral("<hr />\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>Temperature: </dt>\r\n        <dd>");
#nullable restore
#line 32 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.temperature);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Fahrenheit</dd>\r\n        <dt>Feels Like: </dt>\r\n        <dd>");
#nullable restore
#line 34 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.feelsLike);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Fahrenheit</dd>\r\n        <dt>Descriptor: </dt>\r\n        <dd>");
#nullable restore
#line 36 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.descriptor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Wind Speed: </dt>\r\n        <dd>");
#nullable restore
#line 38 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.windSpeed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mph</dd>\r\n        <dt>Wind Direction: </dt>\r\n        <dd>");
#nullable restore
#line 40 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.windDirection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Pressure: </dt>\r\n        <dd>");
#nullable restore
#line 42 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.pressure);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kPa</dd>\r\n        <dt>Visibility: </dt>\r\n        <dd>");
#nullable restore
#line 44 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.visibility);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</dd>\r\n        <dt>Cloudiness: </dt>\r\n        <dd>");
#nullable restore
#line 46 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.clouds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt>Humidity: </dt>\r\n        <dd>");
#nullable restore
#line 48 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.humidity);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</dd>\r\n        <dt>Chance of Rain: </dt>\r\n        <dd>");
#nullable restore
#line 50 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.rainfall);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</dd>\r\n        <dt>Chance of Snow: </dt>\r\n        <dd>");
#nullable restore
#line 52 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
       Write(Model.snowfall);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5f1372e3e89bf4aebdd37ae94e021dc75af59398738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2056, "~/images/", 2056, 9, true);
#nullable restore
#line 55 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
AddHtmlAttributeValue("", 2065, Model.imagePath, 2065, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 55 "D:\C-Sharp 494\FinalProject\FinalProject\Views\Home\WeatherForecastDetailsView.cshtml"
AddHtmlAttributeValue("", 2088, Model.imagePath, 2088, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherForecastWeb.Models.WeatherForecastDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
