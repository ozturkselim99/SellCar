#pragma checksum "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbarAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "223fce0eac551698cb7ff1db184988bd23a4ce7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbarAdmin), @"mvc.1.0.view", @"/Views/Shared/_navbarAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"223fce0eac551698cb7ff1db184988bd23a4ce7a", @"/Views/Shared/_navbarAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbarAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
    <a class=""navbar-brand"" href=""/admin"">Admin Panel</a>
    <ul class=""navbar-nav ml-auto"">
        <li class=""nav-item dropdown"">
            <a class=""nav-link dropdown-toggle"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""mr-2 fas fa-user fa-fw""></i>");
#nullable restore
#line 5 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Shared\_navbarAdmin.cshtml"
                                                                                                                                                                                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""/admin"">Admin Paneli</a>
                <a class=""dropdown-item"" href=""/"">Siteye geri dön</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""/account/logout"">
                    <i class=""fas fa-sign-out-alt mr-1""></i>
                    Çıkış Yap
                </a>
            </div>
        </li>
    </ul>
</nav>");
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
