#pragma checksum "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\Admin\Services.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0c7bfd6f26e87b40c47925186a462ce190613f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Services), @"mvc.1.0.view", @"/Views/Admin/Services.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0c7bfd6f26e87b40c47925186a462ce190613f", @"/Views/Admin/Services.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5131408932077ef0bc27c41dd5b6e01690df8e7a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Services : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\Admin\Services.cshtml"
  
    ViewData["Title"] = "Servicios";
    string imagen = Url.Content($"~/img/bg3.jpg");
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header header-filter\" data-parallax=\"true\"");
            BeginWriteAttribute("style", " style=\"", 205, "\"", 245, 4);
            WriteAttributeValue("", 213, "background-image:", 213, 17, true);
            WriteAttributeValue(" ", 230, "url(\'", 231, 6, true);
#nullable restore
#line 7 "C:\Users\Jhota\Source\Repos\ProyectoDeGrado\src\WebOlayaDigital\Views\Admin\Services.cshtml"
WriteAttributeValue("", 236, imagen, 236, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 243, "\')", 243, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <h1 class=""title"">Servicios</h1>
                <h4>
                    Las casas de la cultura del municipio de Olaya promueve la lectura, escritura, información, y las diferentes manifestaciones artistico-culturales,convirtiendonos en una institución dinámica y fortaleciondo la integración cultural.
                    Este es un lugar donde respetamos los derechos fundamentales y el sentir artístico de cada uno, respaldndo iniciativas qe tengan como fin lograr la identidad cultural del municipio.
                </h4>
                <br>
                <a href=""https://www.youtube.com/watch?v=58cwtIhZY5w"" target=""_blank"" class=""btn btn-danger btn-raised btn-lg"">
                    <i class=""fa fa-play""></i> Ver video
                </a>
            </div>
        </div>
    </div>
</div>

<div class=""main main-raised"">
    <div class=""container"">


        <div class=""secti");
            WriteLiteral("on text-center\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10 ml-auto mr-auto\">\r\n");
            WriteLiteral(@"                    <h5 class=""description""></h5>
                </div>
            </div>
            <div class=""features"">
                <div class=""row"">
                    <div class=""col-md-4"">

                        <button type=""button"" style=""border: none; background-color: inherit"" data-container=""body"" data-toggle=""popover"" data-placement=""bottom""
                                data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Punto de atención</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card-text""></p>
                                </div>
                            </div>
                        </button>

                    </div>

               ");
            WriteLiteral(@"     <div class=""col-md-4"">
                        <button type=""button"" style=""border: none; background-color: inherit"" data-container=""body"" data-toggle=""popover"" data-placement=""bottom""
                                data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Consulta en Sala</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card-text""></p>
                                </div>
                            </div>
                        </button>
                    </div>

                    <div class=""col-md-4"">
                        <button type=""button"" style=""border: none; background-color: inherit"" data-container=""body"" data-toggle=""popover"" data-placement=""bot");
            WriteLiteral(@"tom""
                                data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Prestamos externos</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card-text""></p>
                                </div>
                            </div>
                        </button>
                    </div>

                </div>
            </div>
        </div>


    </div>
    <br />
    <br />
</div>");
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
