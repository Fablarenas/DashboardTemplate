#pragma checksum "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6928ecb42f93d0a4d9bb48b0fa8322a5a033fe86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Index), @"mvc.1.0.view", @"/Views/Projects/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6928ecb42f93d0a4d9bb48b0fa8322a5a033fe86", @"/Views/Projects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa45cb5f86709dc92e5e3357b0a74ffbe3860d20", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestingAppQa.Models.Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"d-flex justify-content-between\">\r\n        <!-- Animated -->\r\n        <h3 class=\"text-secondary\">Proyectos</h3>\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1465, "\"", 1570, 5);
            WriteAttributeValue("", 1475, "showInPopup(\'", 1475, 13, true);
#nullable restore
#line 49 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
WriteAttributeValue("", 1488, Url.Action("Create", "Projects", null,Context.Request.Scheme), 1488, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1550, "\',", 1550, 2, true);
            WriteAttributeValue(" ", 1552, "\'Proyecto", 1553, 10, true);
            WriteAttributeValue(" ", 1562, "Nuevo\')", 1563, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger text-white\"><i class=\"fa fa-plus\"></i>Nuevo Proyecto</a>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 54 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-4"">
                <div class=""card"">
                    <div class=""card-body d-flex justify-content-around"">
                        <div class=""bg-primary p-2"">
                            <h3 class=""text-white"">BP</h3>
                        </div>
                        <div>
                            <h5>");
#nullable restore
#line 63 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>");
#nullable restore
#line 64 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div><i class=\"fa fa-pencil\"");
            BeginWriteAttribute("onclick", "  onclick=\"", 2311, "\"", 2459, 7);
            WriteAttributeValue("", 2322, "showInPopup(\'", 2322, 13, true);
#nullable restore
#line 66 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
WriteAttributeValue("", 2335, Url.Action("Edit","Projects",new {id=item.IdProject},Context.Request.Scheme), 2335, 77, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2412, "\',\'Modificar", 2412, 12, true);
            WriteAttributeValue(" ", 2424, "Informacion", 2425, 12, true);
            WriteAttributeValue(" ", 2436, "General", 2437, 8, true);
            WriteAttributeValue(" ", 2444, "Del", 2445, 4, true);
            WriteAttributeValue(" ", 2448, "Proyecto\')", 2449, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">\r\n                            </i>\r\n                           <input");
            BeginWriteAttribute("onchange", " onchange=\"", 2562, "\"", 2605, 3);
            WriteAttributeValue("", 2573, "cambiarProyecto(", 2573, 16, true);
#nullable restore
#line 68 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
WriteAttributeValue("", 2589, item.IdProject, 2589, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2604, ")", 2604, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"cartItem\"\r\n                                  type=\"checkbox\" value=\"false\" >\r\n");
            WriteLiteral("                        </div>\r\n                         \r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 77 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <script>\r\n    \r\n    cambiarProyecto = (idProject) => {\r\n\r\nconsole.log(\'hola\')\r\n         $.post(\"");
#nullable restore
#line 84 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
            Write(Url.Action("SelectProject", "Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?idproyecto=\"+idProject,function(re){\r\n\r\n         //redirect now\r\n         window.location.href=\"");
#nullable restore
#line 87 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\Projects\Index.cshtml"
                          Write(Url.Action("Index", "Sprints"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n     });\r\n}</script>\r\n    <!-- .animated -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestingAppQa.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591