#pragma checksum "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b20f8a1d72056c008ef337769a6fdc800db9c235efbc09fdfeb4c9dd6bb2a3df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Risks_Index), @"mvc.1.0.view", @"/Views/Risks/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\_ViewImports.cshtml"
using TestingAppQa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\_ViewImports.cshtml"
using TestingAppQa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\_ViewImports.cshtml"
using TestingAppQa.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b20f8a1d72056c008ef337769a6fdc800db9c235efbc09fdfeb4c9dd6bb2a3df", @"/Views/Risks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f159ce4e3e2b36048059ba0a366ba95523445f7739e8c022cde3f1020e60692d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Risks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestingAppQa.Models.Risk>>
    #nullable disable
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
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"d-flex justify-content-between\">\r\n        <!-- Animated -->\r\n        <h3 class=\"text-secondary\">Riesgos</h3>\r\n\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 209, "\"", 309, 5);
            WriteAttributeValue("", 219, "showInPopup(\'", 219, 13, true);
#nullable restore
#line 8 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
WriteAttributeValue("", 232, Url.Action("Create", "Risks", null,Context.Request.Scheme), 232, 59, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 291, "\',", 291, 2, true);
            WriteAttributeValue(" ", 293, "\'Nuevo", 294, 7, true);
            WriteAttributeValue(" ", 300, "Riesgo\')", 301, 9, true);
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
                                    <th class=""serial"">Nombre del Riesgo</th>
                                    <th class=""avatar"">Estrategia de mitigación</th>
                                    <th>Dependencia</th>
                                    <th>Acción</th>
                                </tr>
                            </thead>
                            <tbody>


");
#nullable restore
#line 31 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td class=\"serial\">");
#nullable restore
#line 35 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"serial\">");
#nullable restore
#line 36 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.MitigationStrategy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"serial\">");
#nullable restore
#line 37 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.RiskDependency));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"serial\">\r\n                                            <a>\r\n                                                <i class=\"fa fa-pencil\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1784, "\"", 1923, 7);
            WriteAttributeValue("", 1794, "showInPopup(\'", 1794, 13, true);
#nullable restore
#line 40 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
WriteAttributeValue("", 1807, Url.Action("Edit","Risks",new {id=item.IdRisk},Context.Request.Scheme), 1807, 71, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1878, "\',\'Modificar", 1878, 12, true);
            WriteAttributeValue(" ", 1890, "Informacion", 1891, 12, true);
            WriteAttributeValue(" ", 1902, "General", 1903, 8, true);
            WriteAttributeValue(" ", 1910, "Del", 1911, 4, true);
            WriteAttributeValue(" ", 1914, "Riesgo\')", 1915, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-pencil p-2\">\r\n                                                </i>\r\n                                            </a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20f8a1d72056c008ef337769a6fdc800db9c235efbc09fdfeb4c9dd6bb2a3df8687", async() => {
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
#line 43 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
                                                                     WriteLiteral(item.IdRisk);

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
#line 47 "C:\Users\Asus\Source\Repos\proyectoMiguel\TestingAppQa\Views\Risks\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b20f8a1d72056c008ef337769a6fdc800db9c235efbc09fdfeb4c9dd6bb2a3df11540", async() => {
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestingAppQa.Models.Risk>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
