#pragma checksum "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Areas\Identity\Pages\Account\Manage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c494a86a3b9ffc4d9d6b114d3735cbd9d5215f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_Index), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/Index.cshtml")]
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
#line 1 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Areas\Identity\Pages\_ViewImports.cshtml"
using WebOlayaDigital.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Areas\Identity\Pages\_ViewImports.cshtml"
using WebOlayaDigital.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using WebOlayaDigital.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using WebOlayaDigital.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c494a86a3b9ffc4d9d6b114d3735cbd9d5215f", @"/Areas/Identity/Pages/Account/Manage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a388db76177535eec79c23a0c5ed5201e4b8922", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb06a8ca1c4e617ad7b1557960e4f400f5d15fb", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d6c19873a7ac1703efaf57f10f78ecc32bad6b", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePOST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alexis Guzman R\Source\Repos\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Areas\Identity\Pages\Account\Manage\Index.cshtml"
  
    ViewData["Title"] = "Profile";
    ViewData["ActivePage"] = ManageNavPages.Index;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">

        <div class=""section text-center"">
            <div class=""row"">
                <div class=""col-md-10 ml-auto mr-auto"">
                    <h2 class=""title"">Perfil</h2>
                    <h5 class=""description"">Esta es una beta del programa, si usted encuentra algún error por sabor comuninicarlo a <a href=""mailto:alexa.a.d.a1998@gmail.com"">soporte</a></h5>
                </div>
            </div>
            <div class=""features"">
                <div class=""row"">
                    <div class=""col-md-4"">

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9c494a86a3b9ffc4d9d6b114d3735cbd9d5215f6523", async() => {
                WriteLiteral(@"
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Crear POST</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Artículos de interés a la comunidad</h6>
                                    <p class=""card-text"">Uno de nuestro principal objetivo es dar a conocer todas aquellas actividades que a través de la casa de la cultura se realizan.</p>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>

                    <div class=""col-md-4"">
                        <button type=""button"" style=""border: none; background-color: inherit"" data-container=""body"" data-toggle=""popover"" data-placement=""bottom""
                                data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Consulta en Sala</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card-text"">En esta sección podras encontrar todas los post's publicados, los cuales podra actualizar</p>
                                </div>
                            </div>
                        </button>
                    </div>

                    <div class=""col-md-4"">
                   ");
            WriteLiteral(@"     <button type=""button"" style=""border: none; background-color: inherit"" data-container=""body"" data-toggle=""popover"" data-placement=""bottom""
                                data-content=""Vivamus sagittis lacus vel augue laoreet rutrum faucibus."">
                            <div class=""card m-2"" style=""width:100%;"">
                                <div class=""card-body"">
                                    <h4 class=""card-title"">Prestamos externos</h4>
                                    <h6 class=""card-subtitle mb-2 text-muted"">Sección de publicaciones</h6>
                                    <p class=""card-text"">En esta sección podras encontrar todas los post's publicados, los cuales podra actualizar</p>
                                </div>
                            </div>
                        </button>
                    </div>

                </div>
            </div>
        </div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9c494a86a3b9ffc4d9d6b114d3735cbd9d5215f10650", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591