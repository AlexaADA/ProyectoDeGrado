#pragma checksum "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d8e5da521870b3d274266e52f6ec9ce7a3a5a14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\_ViewImports.cshtml"
using WebOlayaDigital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\_ViewImports.cshtml"
using WebOlayaDigital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8e5da521870b3d274266e52f6ec9ce7a3a5a14", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5131408932077ef0bc27c41dd5b6e01690df8e7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/olaya.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/sucre.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/llanadas.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/post/wallpaper.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    string imagen = Url.Content($"~/img/bg3.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header header-filter\" data-parallax=\"true\"");
            BeginWriteAttribute("style", " style=\"", 176, "\"", 216, 4);
            WriteAttributeValue("", 184, "background-image:", 184, 17, true);
            WriteAttributeValue(" ", 201, "url(\'", 202, 6, true);
#nullable restore
#line 7 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 207, imagen, 207, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 214, "\')", 214, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <h1 class=""title"">BIENVENIDOS</h1>
                <h4>
                    Las casas de la cultura del municipio de Olaya promueve la lectura, escritura, información, y las diferentes manifestaciones artistico-culturales,convirtiendonos en una institución dinámica y fortaleciondo la integración cultural.
                    Este es un lugar donde respetamos los derechos fundamentales y el sentir artístico de cada uno, respaldndo iniciativas qe tengan como fin lograr la identidad cultural del municipio.
                </h4>
                <br>
                <a href=""https://www.youtube.com/watch?v=dQw4w9WgXcQ"" target=""_blank"" class=""btn btn-danger btn-raised btn-lg"">
                    <i class=""fa fa-play""></i> Watch video
                </a>
            </div>
        </div>
    </div>
</div>
<div class=""main main-raised"">
    <div class=""container"">


        <div class=""sec");
            WriteLiteral(@"tion text-center"">
            <div class=""row"">
                <div class=""col-md-10 ml-auto mr-auto"">
                    <h2 class=""title"">Servicios</h2>
                    <h5 class=""description"">En esta sessión encontras toda la información de los servicios que ofrece la casa de la cultura de Olaya</h5>
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
                                    <h6 class=""card-subtitle mb-");
            WriteLiteral(@"2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card-text"">En esta sección podras encontrar todas los post's publicados, los cuales podra actualizar</p>
                                </div>
                            </div>
                        </button>

                    </div>

                    <div class=""col-md-4"">
                        <button type=""button"" style=""border: none; background-color: inherit"" data-container=""body"" data-toggle=""popover"" data-placement=""bottom""
                                data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Consulta en Sala</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card");
            WriteLiteral(@"-text"">En esta sección podras encontrar todas los post's publicados, los cuales podra actualizar</p>
                                </div>
                            </div>
                        </button>
                    </div>

                    <div class=""col-md-4"">
                        <button type=""button"" style=""border: none; background-color: inherit"" data-container=""body"" data-toggle=""popover"" data-placement=""bottom""
                                data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Prestamos externos</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card-text"">En esta sección podras encontrar todas los post's publicados, los cuales podra actualiza");
            WriteLiteral(@"r</p>
                                </div>
                            </div>
                        </button>
                    </div>

                </div>
            </div>
        </div>

        <div class=""section text-center"">
            <div class=""row"">
                <div class=""col-md-8 ml-auto mr-auto"">
                    <h2 class=""title"">Nuestras sedes</h2>
                    <h5 class=""description"">El municipio de Olaya cuenta con tres sedes de casa de la cultura</h5>
                </div>
            </div>
            <div class=""features"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""info"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d8e5da521870b3d274266e52f6ec9ce7a3a5a1411721", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h4 class=\"info-title\">Olaya</h4>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"info\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d8e5da521870b3d274266e52f6ec9ce7a3a5a1413121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h4 class=\"info-title\">Sucre</h4>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"info\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d8e5da521870b3d274266e52f6ec9ce7a3a5a1414521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h4 class=\"info-title\">Llanadas</h4>\r\n");
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""section section-contacts"">
            <div class=""row"">
                <div class=""col-md-8 ml-auto mr-auto"">
                    <h2 class=""text-center title"">Noticias</h2>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 123 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                 foreach (var item in Model.Post.Data)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3 mt-4\">\r\n\r\n                        <div class=\"card h-100\">\r\n");
#nullable restore
#line 128 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                             if (item.MediaDto.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 6796, "\"", 6870, 1);
#nullable restore
#line 130 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 6802, item.MediaDto.Where(x => x.Cover == true).FirstOrDefault().NameFile, 6802, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"");
            BeginWriteAttribute("alt", " alt=\"", 6887, "\"", 6905, 1);
#nullable restore
#line 130 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 6893, item.Tittle, 6893, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 131 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d8e5da521870b3d274266e52f6ec9ce7a3a5a1418149", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7116, item.Tittle, 7116, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 135 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-body\">\r\n                                <h6>");
#nullable restore
#line 137 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                               Write(item.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 138 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7472, "\"", 7488, 1);
#nullable restore
#line 141 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 7479, item.Url, 7479, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-primary\">Ver</a>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 146 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>

        <div class=""section section-contacts"">
            <div class=""row"">
                <div class=""col-md-8 ml-auto mr-auto"">
                    <h2 class=""text-center title"">Otras noticias</h2>
                </div>
            </div>
            <div class=""row"">
");
#nullable restore
#line 157 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                 foreach (var item in Model.Article)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-3 mt-4\">\r\n\r\n                        <div class=\"card h-100\">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 8202, "\"", 8224, 1);
#nullable restore
#line 162 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 8208, item.UrlToImage, 8208, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"");
            BeginWriteAttribute("alt", " alt=\"", 8241, "\"", 8258, 1);
#nullable restore
#line 162 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 8247, item.Title, 8247, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"card-body\">\r\n                                <h6>");
#nullable restore
#line 164 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 165 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 8570, "\"", 8586, 1);
#nullable restore
#line 168 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 8577, item.Url, 8577, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-primary\">Ver</a>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 173 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
