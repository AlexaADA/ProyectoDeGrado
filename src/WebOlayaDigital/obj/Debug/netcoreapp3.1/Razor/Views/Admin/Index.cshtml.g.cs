#pragma checksum "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c670d76294bf2d6422a5400d03a343c896516fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\_ViewImports.cshtml"
using WebOlayaDigital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\_ViewImports.cshtml"
using WebOlayaDigital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c670d76294bf2d6422a5400d03a343c896516fc", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5131408932077ef0bc27c41dd5b6e01690df8e7a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Administración de la aplicativo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">


        <div class=""card m-2"" style=""width: 20rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">POST</h4>
                <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                <p class=""card-text"">En esta sección podras encontrar todas los post's publicados, los cuales podra actualizar</p>
                <a href=""javascript:;"" class=""card-link"">Ver post's</a>
                <a");
            BeginWriteAttribute("href", " href=\"", 572, "\"", 604, 1);
#nullable restore
#line 14 "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\Admin\Index.cshtml"
WriteAttributeValue("", 579, Url.Action("CreatePOST"), 579, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-link"">Crear Post</a>
            </div>



        </div>
        <div class=""card m-2"" style=""width: 20rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">BIBLIOTECA</h4>
                <h6 class=""card-subtitle mb-2 text-muted"">Card subtitle</h6>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href=""javascript:;"" class=""card-link"">Card link</a>
                <a href=""javascript:;"" class=""card-link"">Another link</a>
            </div>
        </div>
        <div class=""card m-2"" style=""width: 20rem;"">
            <div class=""card-body"">
                <h4 class=""card-title"">Card title</h4>
                <h6 class=""card-subtitle mb-2 text-muted"">Card subtitle</h6>
                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href=""javascript:;"" c");
            WriteLiteral("lass=\"card-link\">Card link</a>\r\n                <a href=\"javascript:;\" class=\"card-link\">Another link</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
