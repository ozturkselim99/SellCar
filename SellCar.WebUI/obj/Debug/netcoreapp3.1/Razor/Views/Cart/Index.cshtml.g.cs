#pragma checksum "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a732bd8e0a79e57814fc2be977f9129bbeec6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a732bd8e0a79e57814fc2be977f9129bbeec6c", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<sellcar.webui.Models.IlanItemModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""container pb-5 "">
    <div class=""text-right mt-2  "">
        <a href=""/cars"" class=""btn btn-primary"">
            <i class=""fa fa-arrow-circle-left fa-fw""></i> Arabalara geri dön
        </a>
    </div>
    <h2 class=""text-center   "">
        <small class=""text-muted "">Araç Karşılaştırma</small>
    </h2>
    <div class=""row my-4"">
");
#nullable restore
#line 12 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-sm-6\">\r\n                    <div class=\"comparison-table\">\r\n                        <div class=\"comparison-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a732bd8e0a79e57814fc2be977f9129bbeec6c4792", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-link\">\r\n                                    <i class=\"fas fa-trash-alt py-2 remove-item\"></i>\r\n                                </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                                                                              WriteLiteral(item.IlanId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            <a class=\"comparison-item-title\" href=\"shop-single.html\">");
#nullable restore
#line 25 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                                                                                Write(item.markaAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                                                                                               Write(item.seri);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                                                                                                          Write(item.model);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </div>
                    </div>
                    <table class=""table table-striped mt-2"">
                        <tbody>
                            <tr>
                                <td><strong>GENEL BAKIŞ<i class=""fas fa-car-alt ml-2""></i></strong> </td>

                            </tr>
                            <tr>
                                <td>
                                    <strong>Kasa Tipi / Kapı Sayısı</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 39 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.kasaTipi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Motor Tipi</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 47 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.yakitTipi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Üretim Yılı</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 55 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.yil);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Yakıt Tüketimi (Şehir içi / Şehir dışı)</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 63 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.sehirIciTuketim);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lt / ");
#nullable restore
#line 63 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                                                          Write(item.sehirDisiTuketim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" lt
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Motor Gücü</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 71 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.motorGücü);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" hp
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Şanzıman</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 79 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.vitesTipi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 79 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                                                 Write(item.vitesSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vites / ");
#nullable restore
#line 79 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                                                                           Write(item.cekisTipi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Hızlanma 0-100 km/saat</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 87 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.hizlanma);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" sn
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Azami Sürat</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 95 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.azamiSurati);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" km/saat
                                </td>
                            </tr>
                            <tr>
                                <td><strong>MOTOR VE PERFORMANS<i class=""fas fa-tachometer-alt ml-2""></i></strong> </td>

                            </tr>
                            <tr>
                                <td>
                                    <strong>Motor Hacmi </strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 107 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.motorHacmi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" cc
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong> Maksimum Güç</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 115 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.motorGücü);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" hp
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong> Maksimum Tork</strong>
                                </td>
                                <td>
                                    250 Nm / 2.000 rpm
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Hızlanma 0-100 km/saat</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 131 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.hizlanma);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" sn
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Azami Sürat </strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 139 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.azamiSurati);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" km/saat
                                </td>
                            </tr>
                            <tr>
                                <td><strong>YAKIT TÜKETİMİ<i class=""fas fa-gas-pump ml-2""></i></strong> </td>

                            </tr>
                            <tr>
                                <td>
                                    <strong>Yakıt Tipi</strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 151 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.yakitTipi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Şehir içi(100 km'de) </strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 159 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.sehirIciTuketim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" lt
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Şehir dışı(100 km'de) </strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 167 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.sehirDisiTuketim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" lt
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Ortalama(100 km'de) </strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 175 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.ortalamaTuketim);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" lt
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <strong>Yakıt Depo Hacmi </strong>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 183 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
                               Write(item.yakitDepoHacmi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" lt\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n");
#nullable restore
#line 189 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
             if (Model.Count < 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6"">
                    <div class=""comparison-table"">
                        <div class=""comparison-item "">
                            <a href=""/cars"">
                                <i class=""fas fa-plus-circle fa-8x""></i>
                            </a>
                            <a class=""comparison-item-title mt-2 "" href=""shop-single.html"">Araç Ekle</a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 202 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-6"">
                <div class=""comparison-table"">
                    <div class=""comparison-item "">
                        <a href=""/cars"">
                            <i class=""fas fa-plus-circle fa-8x""></i>
                        </a>
                        <a class=""comparison-item-title mt-2 "" href=""shop-single.html"">Araç Ekle</a>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 216 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<sellcar.webui.Models.IlanItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
