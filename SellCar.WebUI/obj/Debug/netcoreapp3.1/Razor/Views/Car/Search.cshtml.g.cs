#pragma checksum "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "811efed816864619b6097666d9cb06aa514d5004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Search), @"mvc.1.0.view", @"/Views/Car/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811efed816864619b6097666d9cb06aa514d5004", @"/Views/Car/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sellcar.webui.Models.IlanListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main class=\"my-3\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3 col-md-4 \">\r\n                <div class=\"bg-light border-right markalar  \">\r\n                    ");
#nullable restore
#line 10 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
               Write(await Component.InvokeAsync("Markalar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 12 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
           Write(await Html.PartialAsync("_filter"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""col-lg-9 col-md-8"">
                <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th>İlan Resmi</th>
                            <th>Fiyatı</th>
                            <th>İlan Başlığı</th>
                            <th>Marka</th>
                            <th>Seri</th>
                            <th>Model</th>
                            <th>Yıl</th>
                            <th>Km</th>
                            <th>Renk</th>
                            <th>İlan Tarihi</th>
                            <th>İl</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 32 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                         for (int i = 0; i < Model.ilanlar.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1419, "\"", 1463, 2);
            WriteAttributeValue("", 1426, "/car/details/", 1426, 13, true);
#nullable restore
#line 35 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
WriteAttributeValue("", 1439, Model.ilanlar[i].IlanId, 1439, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1469, "\"", 1513, 1);
#nullable restore
#line 35 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
WriteAttributeValue("", 1475, Model.ilanlar[i].IlanResimleri[0].url, 1475, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=90></a> </td>\r\n                                <td><i class=\"fas fa-lira-sign mr-1\"></i>");
#nullable restore
#line 36 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                                                                    Write(Model.ilanlar[i].fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].ilanBasligi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].Marka.adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].seri);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].yil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].kilometre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].renk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                               Write(Model.ilanlar[i].ilanTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n<div class=\"container-fluid\">\r\n    ");
#nullable restore
#line 55 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Car\Search.cshtml"
Write(await Html.PartialAsync("_footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
