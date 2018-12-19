#pragma checksum "D:\netcore\WebBanHang\Views\TrangChus\TimKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0684f38e9283038e859b22f4a241868b187d6575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrangChus_TimKiem), @"mvc.1.0.view", @"/Views/TrangChus/TimKiem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TrangChus/TimKiem.cshtml", typeof(AspNetCore.Views_TrangChus_TimKiem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0684f38e9283038e859b22f4a241868b187d6575", @"/Views/TrangChus/TimKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4596769894547467fa804c57f78ed1d3ff57c864", @"/Views/_ViewImports.cshtml")]
    public class Views_TrangChus_TimKiem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\netcore\WebBanHang\Views\TrangChus\TimKiem.cshtml"
  
    ViewData["Title"] = "TimKiem";
    Layout = "~/Views/Shared/Layout_Sanpham.cshtml";

#line default
#line hidden
            BeginContext(99, 530, true);
            WriteLiteral(@"
<h2>Tìm Kiếm Nâng Cao</h2>

<input type=""text"" id=""txtTen"" placeholder=""Nhập tên"" /><br />
Giá từ <input type=""number"" min=""0"" id=""txtGiaTu"" />
đến <input type=""number"" min=""0"" id=""txtGiaDen"" />
    <input type=""button"" id=""btnTim"" value=""Tìm"" />
<h2>Kết quả</h2>
<table class=""table table-condensed"">
    <thead>
        <tr>
            <th>STT</th>
            <th>Tên hàng hóa</th>
            <th>Đơn giá</th>
            <th>Loại</th>
        </tr>
    </thead>
    <tbody id=""content""></tbody>
</table>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(646, 1279, true);
                WriteLiteral(@"
    <script>
        $(""#btnTim"").click(function () {
            var ten = $(""#txtTen"").val().trim();
            var giaTu = $(""#txtGiaTu"").val();
            var giaDen = $(""#txtGiaDen"").val();
            $.ajax({
                url: ""/TrangChus/JSONSearch"",
                type: ""GET"",
                data: {
                    ""Name"": ten, ""From"": giaTu, ""To"": giaDen
                },
                success: function (data) {
                    //console.log(data);
                    $(""#content"").html("""");
                    //duyệt qua từng phần tử của tập kết quả
                    $(data).each(function (index, value) {
                        //tạo thẻ tr
                        var tr = $(""<tr />"");
                        //tạo nội dung cho thẻ tr
                        $(""<td/>"").html(index + 1).appendTo(tr);
                        $(""<td/>"").html(value.tenHH).appendTo(tr);
                       
                        $(""<td/>"").html(value.donGia).appendTo(tr)");
                WriteLiteral(";\r\n                        $(\"<td/>\").html(value.loai).appendTo(tr);\r\n                        //thêm vào tbody\r\n                        tr.appendTo(\"#content\");\r\n                    });\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n    ");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
