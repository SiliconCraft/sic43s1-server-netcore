#pragma checksum "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2b19c8cffe6a55006f1a59d4850e3cb7f45121"
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
#line 1 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\_ViewImports.cshtml"
using sic43s1_aspnetcore_server;

#line default
#line hidden
#line 2 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\_ViewImports.cshtml"
using sic43s1_aspnetcore_server.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2b19c8cffe6a55006f1a59d4850e3cb7f45121", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6623d2a10895b31dcbf488d03cea4188fe7b2735", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "SIC43S1 Demonstration";
    UrlParameterViewModel param = ViewBag.UrlParameterViewModel;
    ResultViewModel result = ViewBag.ResultViewModel;

#line default
#line hidden
            BeginContext(178, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(185, 17, false);
#line 7 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(202, 90, true);
            WriteLiteral("</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>UID [7]</th>\r\n        <td colspan=\"3\">");
            EndContext();
            BeginContext(293, 9, false);
#line 11 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
                   Write(param.Uid);

#line default
#line hidden
            EndContext();
            BeginContext(302, 82, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Default Key</th>\r\n        <td colspan=\"3\">");
            EndContext();
            BeginContext(385, 9, false);
#line 15 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
                   Write(param.Key);

#line default
#line hidden
            EndContext();
            BeginContext(394, 199, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>-</th>\r\n        <th>From Tag</th>\r\n        <th>From Server</th>\r\n        <th>Result</th>\r\n    </tr>\r\n    <tr>\r\n        <th>Tamper Flag (HEX)</th>\r\n        <td>");
            EndContext();
            BeginContext(594, 8, false);
#line 25 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(param.Tf);

#line default
#line hidden
            EndContext();
            BeginContext(602, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(622, 13, false);
#line 26 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.tamper);

#line default
#line hidden
            EndContext();
            BeginContext(635, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(655, 19, false);
#line 27 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.tamperStatus);

#line default
#line hidden
            EndContext();
            BeginContext(674, 74, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Timestamp (DEC)</th>\r\n        <td>");
            EndContext();
            BeginContext(749, 8, false);
#line 31 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(param.Ts);

#line default
#line hidden
            EndContext();
            BeginContext(757, 134, true);
            WriteLiteral("</td>\r\n        <td>N/A</td>\r\n        <td>N/A</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Smart Authentication Code (HEX)</th>\r\n        <td>");
            EndContext();
            BeginContext(892, 9, false);
#line 37 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(param.Sac);

#line default
#line hidden
            EndContext();
            BeginContext(901, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(921, 17, false);
#line 38 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.aes128cmac);

#line default
#line hidden
            EndContext();
            BeginContext(938, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(958, 20, false);
#line 39 "D:\GitLab\Server\sic43s1_aspnetcore_server\sic43s1_aspnetcore_server\Views\Home\Index.cshtml"
       Write(result.rollingStatus);

#line default
#line hidden
            EndContext();
            BeginContext(978, 32, true);
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