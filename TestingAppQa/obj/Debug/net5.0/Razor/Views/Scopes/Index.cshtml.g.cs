#pragma checksum "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Scopes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87218acef5e29d256e752ff416230f6c249725ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Scopes_Index), @"mvc.1.0.view", @"/Views/Scopes/Index.cshtml")]
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
#line 1 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\_ViewImports.cshtml"
using TestingAppQa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\_ViewImports.cshtml"
using TestingAppQa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\_ViewImports.cshtml"
using TestingAppQa.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87218acef5e29d256e752ff416230f6c249725ff", @"/Views/Scopes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9236b2083388687c613f927809694d90881139b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Scopes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestingAppQa.Models.Scope>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modales/modales.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"d-flex justify-content-between\">\r\n        <!-- Animated -->\r\n        <h3 class=\"text-secondary\">Alcances</h3>\r\n\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 211, "\"", 312, 5);
            WriteAttributeValue("", 221, "showInPopup(\'", 221, 13, true);
#nullable restore
#line 8 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Scopes\Index.cshtml"
WriteAttributeValue("", 234, Url.Action("Create", "Risks", null,Context.Request.Scheme), 234, 59, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 293, "\',", 293, 2, true);
            WriteAttributeValue(" ", 295, "\'Nuevo", 296, 7, true);
            WriteAttributeValue(" ", 302, "Alcance\')", 303, 10, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger text-white""><i class=""fa fa-plus""></i>Nuevo Riesgo</a>

    </div>

    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""card"">
                <div class=""card-body "">


                    <div class=""table-stats order-table ov-h"">
                        <table class=""table "">
                            <thead>
                                <tr>
                                    <th class=""serial"">Nombre del Alcance</th>
                                    <th class=""avatar"">Estrategia de mitigación</th>
                                    <th>Dependencia</th>
                                    <th>Acción</th>
                                </tr>
                            </thead>
                            <tbody>


");
#nullable restore
#line 31 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Scopes\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td class=\"serial\">");
#nullable restore
#line 35 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Scopes\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td class=\"serial\">\r\n                                            <a>\r\n                                                <i class=\"fa fa-pencil\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1554, "\"", 1693, 7);
            WriteAttributeValue("", 1564, "showInPopup(\'", 1564, 13, true);
#nullable restore
#line 39 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Scopes\Index.cshtml"
WriteAttributeValue("", 1577, Url.Action("Edit","Risks",new {id=item.IdTool},Context.Request.Scheme), 1577, 71, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1648, "\',\'Modificar", 1648, 12, true);
            WriteAttributeValue(" ", 1660, "Informacion", 1661, 12, true);
            WriteAttributeValue(" ", 1672, "General", 1673, 8, true);
            WriteAttributeValue(" ", 1680, "Del", 1681, 4, true);
            WriteAttributeValue(" ", 1684, "Riesgo\')", 1685, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-pencil p-2\">\r\n                                                </i>\r\n                                            </a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87218acef5e29d256e752ff416230f6c249725ff7821", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Scopes\Index.cshtml"
                                                                     WriteLiteral(item.IdTool);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Scopes\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87218acef5e29d256e752ff416230f6c249725ff10664", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestingAppQa.Models.Scope>> Html { get; private set; }
    }
}
#pragma warning restore 1591
