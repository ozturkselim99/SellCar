#pragma checksum "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4999b27abbbbe29df315e1f2fc7c117c8dc114e1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4999b27abbbbe29df315e1f2fc7c117c8dc114e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sellcar.webui.Models.IlanListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container-fluid my-2\">\r\n    <div class=\"row \">\r\n");
#nullable restore
#line 5 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
         if (TempData["message"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""alert alert-success box w-100"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <strong><i class=""fas fa-check mr-2""></i></strong>");
#nullable restore
#line 9 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
                                                             Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 11 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3 mb-2 \">\r\n            ");
#nullable restore
#line 13 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Markalar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-9 \">\r\n            ");
#nullable restore
#line 16 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("_ads"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n    <h4 class=\"text-center my-4\">Sizin İçin Önerilenler</h4>\r\n    <div class=\"row\" id=\"car\">\r\n");
#nullable restore
#line 23 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
         foreach (var ilan in Model.ilanlar)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-4 col-sm-6 d-flex align-items-stretch\">\r\n                ");
#nullable restore
#line 26 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("_recommendedCar", ilan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <h4 class=""text-center my-4"">Popüler Araba Markaları</h4>
    <div class=""row"">
        <div class=""col-md-12 text-center"">
            <a href=""/cars/alfa-romeo""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/icons8-alfa-romeo-65.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow ""></a>
            <a href=""/cars/audi""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/audi.png "" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/bmw""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/bmw.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/bugatti""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/bugatti.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/ferrar");
            WriteLiteral(@"i""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/fe.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/ford""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/icons8-ford-65.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/hyundai""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/hyundai.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/jaguar""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/icons8-jaguar-65.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/lada""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/lada-2.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>");
            WriteLiteral(@"
            <a href=""/cars/lamborghini""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/icons8-lamborghini-65.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/mazda""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/mazda.png"" style=""width: 74px; height: 74px;"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/mercedes-benz""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/icons8-mercedes-benz-65.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/nissan""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/icons8-nissan-65.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/porsche""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plug");
            WriteLiteral(@"ins/listing/assets/images/categories_icons/po.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/suzuki""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/suzuki.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/volkswagen""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/volkswagen.png"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/renault""><img src=""https://www.gusegarage.com/images/brands/renault.png"" style=""width: 74px; height: 74px;"" alt=""..."" class=""img-thumbnail mr-2 mb-3 shadow""></a>
            <a href=""/cars/kia""><img src=""http://motoro.wpsixer.com/motoro-spide/wp-content/plugins/listing/assets/images/categories_icons/kia.png"" style=""width: 74px; height: 74px;"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/fiat""><img src=""https://cdn.freebiesu");
            WriteLiteral(@"pply.com/logos/large/2x/fiat-3-logo-png-transparent.png"" style=""width: 74px; height: 74px;"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
            <a href=""/cars/toyota""><img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSUfkAjKuZKQkd33T8s-DcxGmmgGiU7bWNlKw&usqp=CAU"" style=""width: 74px; height: 74px;"" alt=""..."" class=""img-thumbnail mb-3 mr-2 shadow""></a>
        </div>
    </div>
    ");
#nullable restore
#line 55 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        window.setTimeout(function () {\r\n            $(\".box\").fadeTo(500, 0).slideUp(500, function () {\r\n                $(this).remove();\r\n            });\r\n        }, 1250);\r\n    </script>\r\n");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sellcar.webui.Models.IlanListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
