#pragma checksum "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb743fa71e766645a2bab26e7cd881591c59244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrangChus_Showsp), @"mvc.1.0.view", @"/Views/TrangChus/Showsp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TrangChus/Showsp.cshtml", typeof(AspNetCore.Views_TrangChus_Showsp))]
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
#line 1 "D:\netcore\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang;

#line default
#line hidden
#line 2 "D:\netcore\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb743fa71e766645a2bab26e7cd881591c59244", @"/Views/TrangChus/Showsp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4596769894547467fa804c57f78ed1d3ff57c864", @"/Views/_ViewImports.cshtml")]
    public class Views_TrangChus_Showsp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebBanHang.Models.HangHoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
  
    ViewData["Title"] = "Showsp";
    Layout = "~/Views/Shared/Layout_Sanpham.cshtml";

#line default
#line hidden
            BeginContext(147, 233, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"heading\"><h2>DANH SÁCH SẢN PHẨM </h2></div>\r\n                <div class=\"products\">\r\n\r\n\r\n");
            EndContext();
#line 18 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(453, 216, true);
            WriteLiteral("                        <div class=\"col-lg-3 col-md-3 col-sm-6 col-xs-12\">\r\n                            <div class=\"product\">\r\n                                <div class=\"image\">\r\n                                    ");
            EndContext();
            BeginContext(669, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c3e4b783e524269960b1295171aed2a", async() => {
                BeginContext(748, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(749, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f7cb4a8be564d10a22a2c3c4109bbbc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 759, "~/Hinh/", 759, 7, true);
#line 23 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
AddHtmlAttributeValue("", 766, item.Hinh, 766, 10, false);

#line default
#line hidden
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
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                                                              WriteLiteral(item.MaHH);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 23 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                                                                                         WriteLiteral(item.MaLoai);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id2"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id2", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id2"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(809, 137, true);
            WriteLiteral("\r\n                                </div>\r\n\r\n\r\n                                <div class=\"buttons\">\r\n                                    ");
            EndContext();
            BeginContext(946, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2537d7b9266486b9e31a8a565c0f222", async() => {
                BeginContext(1031, 55, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-shopping-cart\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                                                                                                 WriteLiteral(item.MaHH);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1090, 406, true);
            WriteLiteral(@"
                                    <a class=""btn wishlist"" href=""#""><span class=""glyphicon glyphicon-heart""></span></a>
                                    <a class=""btn compare"" href=""#""><span class=""glyphicon glyphicon-transfer""></span></a>
                                </div>
                                <div class=""caption"">
                                    <div class=""name""><h3><a>  ");
            EndContext();
            BeginContext(1497, 40, false);
#line 33 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.TenHH));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 73, true);
            WriteLiteral("</a></h3></div>\r\n                                    <div class=\"price\">$");
            EndContext();
            BeginContext(1611, 41, false);
#line 34 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 6, true);
            WriteLiteral("<span>");
            EndContext();
            BeginContext(1659, 42, false);
#line 34 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => item.GiamGia));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 426, true);
            WriteLiteral(@"%</span></div>
                                    <div class=""rating""><span class=""glyphicon glyphicon-star""></span><span class=""glyphicon glyphicon-star""></span><span class=""glyphicon glyphicon-star""></span><span class=""glyphicon glyphicon-star""></span><span class=""glyphicon glyphicon-star-empty""></span></div>
                                </div>

                            </div>
                        </div>
");
            EndContext();
#line 40 "D:\netcore\WebBanHang\Views\TrangChus\Showsp.cshtml"
                    }

#line default
#line hidden
            BeginContext(2150, 92, true);
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    </div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebBanHang.Models.HangHoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
