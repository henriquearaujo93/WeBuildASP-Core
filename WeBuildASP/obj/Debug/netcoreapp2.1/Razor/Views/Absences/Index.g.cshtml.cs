#pragma checksum "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce2a769a46f69694c5afc3e0a4feb82b6168808d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Absences_Index), @"mvc.1.0.view", @"/Views/Absences/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Absences/Index.cshtml", typeof(AspNetCore.Views_Absences_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce2a769a46f69694c5afc3e0a4feb82b6168808d", @"/Views/Absences/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44d79587867e5554379242554d2c4689a12cca61", @"/Views/_ViewImports.cshtml")]
    public class Views_Absences_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WeBuildASP.Models.Absence>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GoAdminMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
  
    ViewData["Title"] = "Absence";

#line default
#line hidden
            BeginContext(94, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(101, 17, false);
#line 8 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(118, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(136, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce7cf85836c74571a22a1e4c2f6af991", async() => {
                BeginContext(188, 4, true);
                WriteLiteral("Home");
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
            BeginContext(196, 136, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr class=\"success\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(333, 43, false);
#line 18 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ab_Date));

#line default
#line hidden
            EndContext();
            BeginContext(376, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(432, 46, false);
#line 21 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ab_Justify));

#line default
#line hidden
            EndContext();
            BeginContext(478, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(534, 47, false);
#line 24 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ab_IdEmploy));

#line default
#line hidden
            EndContext();
            BeginContext(581, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(716, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(777, 42, false);
#line 34 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ab_Date));

#line default
#line hidden
            EndContext();
            BeginContext(819, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(887, 45, false);
#line 37 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ab_Justify));

#line default
#line hidden
            EndContext();
            BeginContext(932, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1000, 46, false);
#line 40 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ab_IdEmploy));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1113, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1af47c4af14e38a0322ccc69ec0c73", async() => {
                BeginContext(1158, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
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
            BeginContext(1166, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1188, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b228945e0e3b41d6bb148acd0549bb90", async() => {
                BeginContext(1236, 7, true);
                WriteLiteral("Details");
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
#line 44 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
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
            BeginContext(1247, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1269, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd00abb590f44164bd3e50750dcdd7c5", async() => {
                BeginContext(1316, 6, true);
                WriteLiteral("Delete");
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
#line 45 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
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
            BeginContext(1326, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 48 "C:\Users\henri\Desktop\WeBuildASP-Core-master\WeBuild.ASp.Core\WeBuild.ASp.Core\WeBuildASP\Views\Absences\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1381, 28, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WeBuildASP.Models.Absence>> Html { get; private set; }
    }
}
#pragma warning restore 1591
