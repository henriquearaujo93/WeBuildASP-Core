#pragma checksum "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7ff0924bcb495b4d3bed48a81b4d7a349a0741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Index.cshtml", typeof(AspNetCore.Views_Employees_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7ff0924bcb495b4d3bed48a81b4d7a349a0741", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d79587867e5554379242554d2c4689a12cca61", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WeBuildASP.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GoAdminMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
            BeginContext(95, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(102, 17, false);
#line 7 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(137, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63d454653fb495fac044b8f119a1528", async() => {
                BeginContext(184, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(198, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(199, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e828195e05e242978e9b572a76b5e9d1", async() => {
                BeginContext(251, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(259, 136, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr class=\"success\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(396, 38, false);
#line 17 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(434, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(490, 42, false);
#line 20 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.E_NAME));

#line default
#line hidden
            EndContext();
            BeginContext(532, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(588, 47, false);
#line 23 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.E_LASTANAME));

#line default
#line hidden
            EndContext();
            BeginContext(635, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(691, 43, false);
#line 26 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.E_IMAGE));

#line default
#line hidden
            EndContext();
            BeginContext(734, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(790, 49, false);
#line 29 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.E_NACIONALITY));

#line default
#line hidden
            EndContext();
            BeginContext(839, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(895, 44, false);
#line 32 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.E_DTANAS));

#line default
#line hidden
            EndContext();
            BeginContext(939, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(995, 42, false);
#line 35 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.E_TEAM));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1093, 44, false);
#line 38 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.E_ACTIVE));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1272, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1321, 37, false);
#line 48 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1414, 41, false);
#line 51 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.E_NAME));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1511, 46, false);
#line 54 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.E_LASTANAME));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1616, "\"", 1680, 1);
#line 57 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
WriteAttributeValue("", 1622, Url.Action("GetImage", "Employees", new { id = item.ID }), 1622, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1681, 128, true);
            WriteLiteral(" alt=\"Image\" style=\"width:100px; height: 100px; max-width: 100%; auto;\"/>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1810, 48, false);
#line 60 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.E_NACIONALITY));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1914, 43, false);
#line 63 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.E_DTANAS));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2013, 41, false);
#line 66 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.E_TEAM));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2110, 43, false);
#line 69 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.E_ACTIVE));

#line default
#line hidden
            EndContext();
            BeginContext(2153, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2208, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4555b9df6e824e4985c9403de027824e", async() => {
                BeginContext(2253, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2261, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2279, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70834ca650314f3bafc5073dbd0f766f", async() => {
                BeginContext(2327, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2338, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2356, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3558f3b8e6e145a69e443698542163b4", async() => {
                BeginContext(2403, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2413, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 77 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Employees\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2460, 26, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
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
