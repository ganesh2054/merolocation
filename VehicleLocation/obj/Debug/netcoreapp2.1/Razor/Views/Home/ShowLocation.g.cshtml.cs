#pragma checksum "C:\Users\Ganesh\source\repos\VehicleLocation\VehicleLocation\Views\Home\ShowLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb4bb0695a0cae5cda61351d37b9d102484e8b0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowLocation), @"mvc.1.0.view", @"/Views/Home/ShowLocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowLocation.cshtml", typeof(AspNetCore.Views_Home_ShowLocation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb4bb0695a0cae5cda61351d37b9d102484e8b0f", @"/Views/Home/ShowLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450c6200cca576ec80d87f2d7507bca1f154ea11", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VehicleLocation.Models.Location>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(82, 480, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80ad9148f3aa412c849d81056e449d71", async() => {
                BeginContext(88, 467, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""initial-scale=1,maximum-scale=1,user-scalable=no"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/leaflet/1.3.1/leaflet.css"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/leaflet/1.3.1/leaflet.js""></script>
    <style>
        #map {
            position: absolute;
            top: 55px;
            right: 0;
            bottom: 0;
            left: 0;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(562, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(564, 1712, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6501c8bf6e541fb9373bd16673a680c", async() => {
                BeginContext(570, 99, true);
                WriteLiteral("\r\n    <table id=\"locationtable\" border=\"1\">\r\n        <thead>\r\n\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 26 "C:\Users\Ganesh\source\repos\VehicleLocation\VehicleLocation\Views\Home\ShowLocation.cshtml"
             foreach (var loc in Model)
            {

#line default
#line hidden
                BeginContext(725, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(772, 13, false);
#line 29 "C:\Users\Ganesh\source\repos\VehicleLocation\VehicleLocation\Views\Home\ShowLocation.cshtml"
                   Write(loc.longitude);

#line default
#line hidden
                EndContext();
                BeginContext(785, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(817, 12, false);
#line 30 "C:\Users\Ganesh\source\repos\VehicleLocation\VehicleLocation\Views\Home\ShowLocation.cshtml"
                   Write(loc.latitude);

#line default
#line hidden
                EndContext();
                BeginContext(829, 32, true);
                WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
                EndContext();
#line 33 "C:\Users\Ganesh\source\repos\VehicleLocation\VehicleLocation\Views\Home\ShowLocation.cshtml"
            }

#line default
#line hidden
                BeginContext(876, 1393, true);
                WriteLiteral(@"        </tbody>
    </table>
    <div id=""map""></div>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <p><a href=""https://www.maptiler.com/copyright/"" target=""_blank"">© MapTiler</a> <a href=""https://www.openstreetmap.org/copyright"" target=""_blank"">© OpenStreetMap contributors</a></p>
    <script>
       var la
        var lo;
        var i;
          var markers = new Array();
        $(""#locationtable TBODY TR"").each(function () {
            var row = $(this);
            var marker = {};
            marker.lo =row.find(""TD"").eq(0).html();
            marker.la= row.find(""TD"").eq(1).html();
            markers.push(marker);
        });


        var map = L.map('map').setView([markers[0].la, markers[0].lo], 1);
        L.tileLayer('https://api.maptiler.com/maps/streets/{z}/{x}/{y}.png?key=IEbBjXx2f8YmWhzRvKz4', {
            tileSize: 512,
            zoomOffset: -1,
            minZoom: 12,
            attribution: '<a href=""https://");
                WriteLiteral(@"www.maptiler.com/copyright/"" target=""_blank"">© MapTiler</a> <a href=""https://www.openstreetmap.org/copyright"" target=""_blank"">© OpenStreetMap contributors</a>',
            crossOrigin: true
        }).addTo(map);
        for (i = 0; i < markers.length; ++i)
        {
              L.marker([markers[i].la,markers[i].lo]).addTo(map);
        }

    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2276, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VehicleLocation.Models.Location>> Html { get; private set; }
    }
}
#pragma warning restore 1591
