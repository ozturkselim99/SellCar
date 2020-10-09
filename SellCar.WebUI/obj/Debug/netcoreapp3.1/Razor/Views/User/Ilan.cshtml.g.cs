#pragma checksum "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2315bdabb938bd812d248711d0c67d94bdd532d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Ilan), @"mvc.1.0.view", @"/Views/User/Ilan.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2315bdabb938bd812d248711d0c67d94bdd532d", @"/Views/User/Ilan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Ilan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sellcar.webui.Models.IlanListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IlanDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
  
    ViewData["Title"] = "ilanlarım";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <h3 class=""mt-1"">İlanlarım</h3>
    <hr class=""my-3"">
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""list-group list-group-flush sticky-top shadow mb-3"">
                <a href=""/user/ozet"" onclick=""myFunction()"" class=""list-group-item list-group-item-action ""><i class=""fas fa-angle-double-right mx-1""></i>İlan Yönetimi</a>
                <a href=""/user/ilanlarim"" class=""list-group-item list-group-item-action active""><i class=""fas fa-angle-double-right mx-1 ""></i>Yayında Olan İlanlarım</a>
                <a href=""/user/favorilerim"" class=""list-group-item list-group-item-action ""><i class=""fas fa-angle-double-right mx-1""></i>Favori İlanlarım</a>
            </div>
        </div>
        <div class=""col-md-9"">
");
#nullable restore
#line 17 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
             if (Model.ilanlar.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12"">
                    <div class=""alert alert-warning"">
                        <i class=""fas fa-exclamation-triangle mr-2""></i>Yayınlanmış herhangi bir ilanınız yok.
                    </div>
                </div>
");
#nullable restore
#line 24 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\" id=\"myItems\">\r\n");
#nullable restore
#line 26 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                 if (TempData["message"] != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1354, "\"", 1401, 4);
            WriteAttributeValue("", 1362, "alert", 1362, 5, true);
            WriteAttributeValue(" ", 1367, "box", 1368, 4, true);
#nullable restore
#line 28 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
WriteAttributeValue(" ", 1371, TempData["alert-type"], 1372, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1395, "w-100", 1396, 6, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n                        <strong><i class=\"fas fa-check mr-2\"></i></strong>");
#nullable restore
#line 30 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                                                                     Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                 foreach (var item in Model.ilanlar)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card mb-3 w-100"">
                        <div class=""card-body"">
                            <div class=""row no-gutters h-100"">
                                <div class=""col-md-4"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 2042, "\"", 2074, 2);
            WriteAttributeValue("", 2049, "/car/details/", 2049, 13, true);
#nullable restore
#line 39 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
WriteAttributeValue("", 2062, item.IlanId, 2062, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b2315bdabb938bd812d248711d0c67d94bdd532d8871", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2086, "~/images/", 2086, 9, true);
#nullable restore
#line 39 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
AddHtmlAttributeValue("", 2095, item.IlanResimleri[0].url, 2095, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                </div>\r\n                                <div class=\"col-md-8\">\r\n                                    <div class=\"card-body\">\r\n                                        <h5>");
#nullable restore
#line 43 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                                       Write(item.ilanBasligi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p>");
#nullable restore
#line 44 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                                      Write(item.Marka.adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                                                      Write(item.seri);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                                                                 Write(item.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <h6 class=\" text-right\">");
#nullable restore
#line 45 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                                                           Write(item.fiyat.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-right\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2674, "\"", 2704, 2);
            WriteAttributeValue("", 2681, "/user/ilan/", 2681, 11, true);
#nullable restore
#line 47 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
WriteAttributeValue("", 2692, item.IlanId, 2692, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit\"></i></a>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2315bdabb938bd812d248711d0c67d94bdd532d12840", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                                                                                               WriteLiteral(item.IlanId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n    \r\n                    </div>\r\n");
#nullable restore
#line 56 "C:\Users\oztur\source\repos\SellCar\SellCar.WebUI\Views\User\Ilan.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        window.setTimeout(function () {\r\n            $(\".box\").fadeTo(500, 0).slideUp(500, function () {\r\n                $(this).remove();\r\n            });\r\n        }, 3000);\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sellcar.webui.Models.IlanListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591