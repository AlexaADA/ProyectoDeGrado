#pragma checksum "D:\VISUAL STUDIO\OlayaDigital\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff52d28d59296a775b911569063621e6120f16fa"
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
#line 1 "D:\VISUAL STUDIO\OlayaDigital\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\_ViewImports.cshtml"
using WebOlayaDigital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VISUAL STUDIO\OlayaDigital\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\_ViewImports.cshtml"
using WebOlayaDigital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff52d28d59296a775b911569063621e6120f16fa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5131408932077ef0bc27c41dd5b6e01690df8e7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/faces/avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Thumbnail Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-raised rounded-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/faces/christian.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/faces/kendall.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VISUAL STUDIO\OlayaDigital\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    string imagen = Url.Content($"~/img/bg3.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header header-filter\" data-parallax=\"true\"");
            BeginWriteAttribute("style", " style=\"", 158, "\"", 198, 4);
            WriteAttributeValue("", 166, "background-image:", 166, 17, true);
            WriteAttributeValue(" ", 183, "url(\'", 184, 6, true);
#nullable restore
#line 6 "D:\VISUAL STUDIO\OlayaDigital\JhotamsDeveloper\OlayaDigital\src\WebOlayaDigital\Views\Home\Index.cshtml"
WriteAttributeValue("", 189, imagen, 189, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 196, "\')", 196, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <h1 class=""title"">Your Story Starts With Us.</h1>
                <h4>Every landing page needs a small description after the big bold title, that&apos;s why we added this text here. Add here all the information that can make you or your product create the first impression.</h4>
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
        <div class=""section text-center"">
            <div class=""row"">
                <div class=""col-md-8 ml-auto mr-auto"">
                    <h2 class=""title"">Let&apos;s talk product</h2>
                    <h5 class=""description"">This is the paragraph where you can writ");
            WriteLiteral(@"e more details about your product. Keep you user engaged by providing meaningful information. Remember that by this time, the user is curious, otherwise he wouldn&apos;t scroll to get here. Add a button if you want the user to see more.</h5>
                </div>
            </div>
            <div class=""features"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""info"">
                            <div class=""icon icon-info"">
                                <i class=""material-icons"">chat</i>
                            </div>
                            <h4 class=""info-title"">Free Chat</h4>
                            <p>Divide details about your product or agency work into parts. Write a few lines about each one. A paragraph describing a feature will be enough.</p>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""info"">
                     ");
            WriteLiteral(@"       <div class=""icon icon-success"">
                                <i class=""material-icons"">verified_user</i>
                            </div>
                            <h4 class=""info-title"">Verified Users</h4>
                            <p>Divide details about your product or agency work into parts. Write a few lines about each one. A paragraph describing a feature will be enough.</p>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""info"">
                            <div class=""icon icon-danger"">
                                <i class=""material-icons"">fingerprint</i>
                            </div>
                            <h4 class=""info-title"">Fingerprint</h4>
                            <p>Divide details about your product or agency work into parts. Write a few lines about each one. A paragraph describing a feature will be enough.</p>
                        </div>
                   ");
            WriteLiteral(@" </div>
                </div>
            </div>
        </div>
        <div class=""section text-center"">
            <h2 class=""title"">Here is our team</h2>
            <div class=""team"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""team-player"">
                            <div class=""card card-plain"">
                                <div class=""col-md-6 ml-auto mr-auto"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff52d28d59296a775b911569063621e6120f16fa10294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <h4 class=""card-title"">
                                    Gigi Hadid
                                    <br>
                                    <small class=""card-description text-muted"">Model</small>
                                </h4>
                                <div class=""card-body"">
                                    <p class=""card-description"">
                                        You can write here details about one of your team members. You can give more details about what they do. Feel free to add some
                                        <a href=""#"">links</a> for people to be able to follow them outside the site.
                                    </p>
                                </div>
                                <div class=""card-footer justify-content-center"">
                                    <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-twitter""></i></a>
      ");
            WriteLiteral(@"                              <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-instagram""></i></a>
                                    <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-facebook-square""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""team-player"">
                            <div class=""card card-plain"">
                                <div class=""col-md-6 ml-auto mr-auto"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff52d28d59296a775b911569063621e6120f16fa13231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <h4 class=""card-title"">
                                    Christian Louboutin
                                    <br>
                                    <small class=""card-description text-muted"">Designer</small>
                                </h4>
                                <div class=""card-body"">
                                    <p class=""card-description"">
                                        You can write here details about one of your team members. You can give more details about what they do. Feel free to add some
                                        <a href=""#"">links</a> for people to be able to follow them outside the site.
                                    </p>
                                </div>
                                <div class=""card-footer justify-content-center"">
                                    <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-twitter""></i>");
            WriteLiteral(@"</a>
                                    <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-linkedin""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""team-player"">
                            <div class=""card card-plain"">
                                <div class=""col-md-6 ml-auto mr-auto"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ff52d28d59296a775b911569063621e6120f16fa16042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <h4 class=""card-title"">
                                    Kendall Jenner
                                    <br>
                                    <small class=""card-description text-muted"">Model</small>
                                </h4>
                                <div class=""card-body"">
                                    <p class=""card-description"">
                                        You can write here details about one of your team members. You can give more details about what they do. Feel free to add some
                                        <a href=""#"">links</a> for people to be able to follow them outside the site.
                                    </p>
                                </div>
                                <div class=""card-footer justify-content-center"">
                                    <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-twitter""></i></a>
  ");
            WriteLiteral(@"                                  <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-instagram""></i></a>
                                    <a href=""#pablo"" class=""btn btn-link btn-just-icon""><i class=""fa fa-facebook-square""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""section section-contacts"">
            <div class=""row"">
                <div class=""col-md-8 ml-auto mr-auto"">
                    <h2 class=""text-center title"">Work with us</h2>
                    <h4 class=""text-center description"">Divide details about your product or agency work into parts. Write a few lines about each one and contact us about any further collaboration. We will responde get back to you in a couple of hours.</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff52d28d59296a775b911569063621e6120f16fa19266", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Your Name</label>
                                    <input type=""email"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Your Email</label>
                                    <input type=""email"" class=""form-control"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleMessage"" class=""bmd-label-floating"">Your Message</label>
                            <textarea type=""email"" class=""form-control"" rows=""4"" id");
                WriteLiteral(@"=""exampleMessage""></textarea>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-4 ml-auto mr-auto text-center"">
                                <button class=""btn btn-primary btn-raised"">
                                    Send Message
                                </button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
