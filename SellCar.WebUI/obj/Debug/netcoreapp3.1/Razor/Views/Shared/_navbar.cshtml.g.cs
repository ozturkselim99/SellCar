#pragma checksum "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ecbb5410132f9701ba12d25526d600997543f7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ecbb5410132f9701ba12d25526d600997543f7e", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark bg-dark "">
    <a class=""navbar-brand"" href=""/""><h5 class=""my-0 d-inline"">SELLCAR</h5><i class=""ml-2 fas fa-car-side""></i></a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
        <ul class=""navbar-nav mr-auto"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/cars""><h6 class=""my-0"">Araçlar</h6></a>
            </li>
        </ul>
        <ul class=""navbar-nav mx-auto"">
            <li class=""nav-item"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ecbb5410132f9701ba12d25526d600997543f7e4072", async() => {
                WriteLiteral("\r\n                    <input name=\"q\" class=\"form-control mr-2\" type=\"search\" placeholder=\"Ara..\" aria-label=\"Ara\" style=\"width:275px\">\r\n                    <button class=\"btn btn-success my-2 my-0\" type=\"submit\">Ara</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n        <ul class=\"navbar-nav ml-auto\">\r\n            <li class=\"nav-item\">\r\n                <a class=\"btn btn-success mr-1\" href=\"/user/createilan\">Ücretsiz İlan Ver</a>\r\n            </li>\r\n");
#nullable restore
#line 25 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
             if (User.Identity.IsAuthenticated)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
                 if (User.IsInRole("admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""mr-2 fas fa-user fa-fw""></i>");
#nullable restore
#line 30 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
                                                                                                                                                                                                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                            <a class=""dropdown-item"" href=""/admin"">Admin Paneli</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""/account/logout"">
                                <i class=""fas fa-sign-out-alt mr-1""></i>
                                Çıkış Yap
                            </a>
                        </div>
                    </li>
");
#nullable restore
#line 40 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""mr-2 fas fa-user fa-fw""></i>");
#nullable restore
#line 44 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
                                                                                                                                                                                                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                            <a class=""dropdown-item"" href=""/user/profile"">Üyeliğim</a>
                            <a class=""dropdown-item"" href=""/user/ilanlarim"">İlanlarım</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""/account/logout"">
                                <i class=""fas fa-sign-out-alt mr-1""></i>
                                Çıkış Yap
                            </a>
                        </div>
                    </li>
");
#nullable restore
#line 55 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/account/login"">
                        <i class=""fas fa-sign-in-alt mr-1""></i>
                        Giriş Yap
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/account/register"">
                        <i class=""fas fa-user-plus mx-1""></i>
                        Üye Ol
                    </a>
                </li>
");
#nullable restore
#line 71 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</nav>\r\n\r\n");
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
