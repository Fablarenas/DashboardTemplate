#pragma checksum "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa356b491bee492883e74f4f4bc4a0ea7d103c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserHistories_Index), @"mvc.1.0.view", @"/Views/UserHistories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aa356b491bee492883e74f4f4bc4a0ea7d103c7", @"/Views/UserHistories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa45cb5f86709dc92e5e3357b0a74ffbe3860d20", @"/Views/_ViewImports.cshtml")]
    public class Views_UserHistories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestingAppQa.Models.UserHistory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"d-flex justify-content-between\">\r\n        <!-- Animated -->\r\n        <h3 class=\"text-secondary\">Historias de usuario</h3>\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 227, "\"", 331, 5);
            WriteAttributeValue("", 237, "showInPopup(\'", 237, 13, true);
#nullable restore
#line 7 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
WriteAttributeValue("", 250, Url.Action("Create", "UserHistories", null,Context.Request.Scheme), 250, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 317, "\',", 317, 2, true);
            WriteAttributeValue(" ", 319, "\'HU", 320, 4, true);
            WriteAttributeValue(" ", 323, "Nuevo\')", 324, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger text-white\"><i class=\"fa fa-plus\"></i>Nueva HU</a>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-lg-4\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body d-flex justify-content-around\">\r\n                            \r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 717, "\"", 725, 0);
            EndWriteAttribute();
            WriteLiteral(">1</p>\r\n                            \r\n                            <div>\r\n                                <h5>");
#nullable restore
#line 22 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <div>\r\n                                    <p class=\"m-0 mt-2\">\r\n                                        Dado que: ");
#nullable restore
#line 25 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.IWant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"m-0\">\r\n                                        Cuando que: ");
#nullable restore
#line 28 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Where));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"m-0\">\r\n                                        Entonces: ");
#nullable restore
#line 31 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Then));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                                \r\n                            </div>\r\n                            <div><i");
            BeginWriteAttribute("onclick", "  onclick=\"", 1637, "\"", 1784, 6);
            WriteAttributeValue("", 1648, "showInPopup(\'", 1648, 13, true);
#nullable restore
#line 36 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
WriteAttributeValue("", 1661, Url.Action("Edit","UserHistories",new {id=item.IdUserHistory},Context.Request.Scheme), 1661, 86, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1747, "\',\'Modificar", 1747, 12, true);
            WriteAttributeValue(" ", 1759, "Informacion", 1760, 12, true);
            WriteAttributeValue(" ", 1771, "General", 1772, 8, true);
            WriteAttributeValue(" ", 1779, "HU\')", 1780, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-pencil\"></i>\r\n                            <input");
            BeginWriteAttribute("onchange", " onchange=\"", 1847, "\"", 1892, 3);
            WriteAttributeValue("", 1858, "seleccionarHU(", 1858, 14, true);
#nullable restore
#line 37 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
WriteAttributeValue("", 1872, item.IdUserHistory, 1872, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1891, ")", 1891, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""cartItem""
                                  type=""checkbox"" value=""false"" >
                            </div>
                            <div>
                            
                        </div>
                        </div>

                    </div>
                </div><!-- /# column -->
");
#nullable restore
#line 47 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <script>\r\n    \r\n    seleccionarHU = (idhu) => {\r\n\r\n        $.post(\"");
#nullable restore
#line 53 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
           Write(Url.Action("SelectHU", "UserHistories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?idhu=\" + idhu,function(re){\r\n\r\n         //redirect now\r\n         window.location.href=\"");
#nullable restore
#line 56 "C:\Users\FabianArenas\source\repos\TestingAppQa\TestingAppQa\Views\UserHistories\Index.cshtml"
                          Write(Url.Action("Index", "TestCases"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestingAppQa.Models.UserHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591