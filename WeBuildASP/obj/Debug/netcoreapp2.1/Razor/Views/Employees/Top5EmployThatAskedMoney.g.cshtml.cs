#pragma checksum "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb93894e6719f12cf85d12c7cd1107f52d5072e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Top5EmployThatAskedMoney), @"mvc.1.0.view", @"/Views/Employees/Top5EmployThatAskedMoney.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Top5EmployThatAskedMoney.cshtml", typeof(AspNetCore.Views_Employees_Top5EmployThatAskedMoney))]
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
#line 1 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\_ViewImports.cshtml"
using WeBuildASP;

#line default
#line hidden
#line 2 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\_ViewImports.cshtml"
using WeBuildASP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cb93894e6719f12cf85d12c7cd1107f52d5072e", @"/Views/Employees/Top5EmployThatAskedMoney.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d79587867e5554379242554d2c4689a12cca61", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Top5EmployThatAskedMoney : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WeBuildASP.Models.LoanForEmploy>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
  
    ViewData["Title"] = "Statistics";

#line default
#line hidden
            BeginContext(101, 347, true);
            WriteLiteral(@"
<div class=""panel panel-primary"">
    <div class=""panel-heading"">
        <h3 class=""panel-title"">Top 5 Employ That Asked Money.</h3>
    </div>
    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr class=""success"">
                    <th>
                        ");
            EndContext();
            BeginContext(449, 38, false);
#line 16 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(487, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(567, 46, false);
#line 19 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                   Write(Html.DisplayNameFor(model => model.L_F_AMOUNT));

#line default
#line hidden
            EndContext();
            BeginContext(613, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(693, 46, false);
#line 22 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                   Write(Html.DisplayNameFor(model => model.L_F_EMPLOY));

#line default
#line hidden
            EndContext();
            BeginContext(739, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(930, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1015, 37, false);
#line 32 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1144, 45, false);
#line 35 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                       Write(Html.DisplayFor(modelItem => item.L_F_AMOUNT));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1281, 45, false);
#line 38 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                       Write(Html.DisplayFor(modelItem => item.L_F_EMPLOY));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 41 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5EmployThatAskedMoney.cshtml"
                }

#line default
#line hidden
            BeginContext(1405, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WeBuildASP.Models.LoanForEmploy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
