#pragma checksum "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c68aeb1fb99c8e70bff4911253ba8d8379f578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Top5LatesEmploy), @"mvc.1.0.view", @"/Views/Employees/Top5LatesEmploy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Top5LatesEmploy.cshtml", typeof(AspNetCore.Views_Employees_Top5LatesEmploy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c68aeb1fb99c8e70bff4911253ba8d8379f578", @"/Views/Employees/Top5LatesEmploy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d79587867e5554379242554d2c4689a12cca61", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Top5LatesEmploy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WeBuildASP.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
  
    ViewData["Title"] = "Statistics";

#line default
#line hidden
            BeginContext(96, 335, true);
            WriteLiteral(@"
<div class=""panel panel-primary"">
    <div class=""panel-heading"">
        <h3 class=""panel-title"">Top 5 Late Employs</h3>
    </div>
    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr class=""success"">
                    <th>
                        ");
            EndContext();
            BeginContext(432, 38, false);
#line 16 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                   Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(470, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(550, 42, false);
#line 19 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                   Write(Html.DisplayNameFor(model => model.E_NAME));

#line default
#line hidden
            EndContext();
            BeginContext(592, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(672, 47, false);
#line 22 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                   Write(Html.DisplayNameFor(model => model.E_LASTANAME));

#line default
#line hidden
            EndContext();
            BeginContext(719, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(799, 49, false);
#line 25 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                   Write(Html.DisplayNameFor(model => model.E_NACIONALITY));

#line default
#line hidden
            EndContext();
            BeginContext(848, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(928, 44, false);
#line 28 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                   Write(Html.DisplayNameFor(model => model.E_DTANAS));

#line default
#line hidden
            EndContext();
            BeginContext(972, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1052, 44, false);
#line 31 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                   Write(Html.DisplayNameFor(model => model.E_ACTIVE));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1287, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1372, 37, false);
#line 41 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1501, 41, false);
#line 44 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.E_NAME));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1634, 46, false);
#line 47 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.E_LASTANAME));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1772, 48, false);
#line 50 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.E_NACIONALITY));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1912, 43, false);
#line 53 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.E_DTANAS));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2047, 43, false);
#line 56 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                       Write(Html.DisplayFor(modelItem => item.E_ACTIVE));

#line default
#line hidden
            EndContext();
            BeginContext(2090, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 59 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Top5LatesEmploy.cshtml"
                }

#line default
#line hidden
            BeginContext(2169, 66, true);
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WeBuildASP.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
