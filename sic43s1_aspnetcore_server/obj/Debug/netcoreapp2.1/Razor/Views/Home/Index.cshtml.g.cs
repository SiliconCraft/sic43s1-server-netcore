#pragma checksum "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa02ae52d4be33b876dddd1be1ae8933c7671dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\_ViewImports.cshtml"
using sic43s1_aspnetcore_server;

#line default
#line hidden
#line 2 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\_ViewImports.cshtml"
using sic43s1_aspnetcore_server.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa02ae52d4be33b876dddd1be1ae8933c7671dc9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6623d2a10895b31dcbf488d03cea4188fe7b2735", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
  
    UrlParameterViewModel param = ViewBag.UrlParameterViewModel;
    ResultViewModel result = ViewBag.ResultViewModel;

#line default
#line hidden
            BeginContext(128, 117, true);
            WriteLiteral("\r\n<h1>SIC43S1 Demonstration</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>UID [7]</th>\r\n        <td colspan=\"3\">");
            EndContext();
            BeginContext(246, 9, false);
#line 10 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
                   Write(param.Uid);

#line default
#line hidden
            EndContext();
            BeginContext(255, 82, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Default Key</th>\r\n        <td colspan=\"3\">");
            EndContext();
            BeginContext(338, 9, false);
#line 14 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
                   Write(param.Key);

#line default
#line hidden
            EndContext();
            BeginContext(347, 199, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>-</th>\r\n        <th>From Tag</th>\r\n        <th>From Server</th>\r\n        <th>Result</th>\r\n    </tr>\r\n    <tr>\r\n        <th>Tamper Flag (HEX)</th>\r\n        <td>");
            EndContext();
            BeginContext(547, 8, false);
#line 24 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(param.Tf);

#line default
#line hidden
            EndContext();
            BeginContext(555, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(575, 13, false);
#line 25 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.tamper);

#line default
#line hidden
            EndContext();
            BeginContext(588, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(608, 19, false);
#line 26 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.tamperStatus);

#line default
#line hidden
            EndContext();
            BeginContext(627, 74, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Timestamp (DEC)</th>\r\n        <td>");
            EndContext();
            BeginContext(702, 8, false);
#line 30 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(param.Ts);

#line default
#line hidden
            EndContext();
            BeginContext(710, 134, true);
            WriteLiteral("</td>\r\n        <td>N/A</td>\r\n        <td>N/A</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Smart Authentication Code (HEX)</th>\r\n        <td>");
            EndContext();
            BeginContext(845, 9, false);
#line 36 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(param.Sac);

#line default
#line hidden
            EndContext();
            BeginContext(854, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(874, 17, false);
#line 37 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.aes128cmac);

#line default
#line hidden
            EndContext();
            BeginContext(891, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(911, 20, false);
#line 38 "G:\SIC work\sic43s1-server-netcore\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.rollingStatus);

#line default
#line hidden
            EndContext();
            BeginContext(931, 32, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
