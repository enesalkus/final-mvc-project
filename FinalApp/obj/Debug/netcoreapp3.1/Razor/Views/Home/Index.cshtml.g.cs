#pragma checksum "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a8847f03a47c8e07d0c24b745627ffc925b6f7"
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
#line 1 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\_ViewImports.cshtml"
using FinalApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\_ViewImports.cshtml"
using FinalApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a8847f03a47c8e07d0c24b745627ffc925b6f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8fbe6848d88ffe95ac8bac2a00039f73880daa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FinalApp.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""slideshow-container"">

    <div class=""bbb"">
        <img class=""iii"" src=""https://i.hizliresim.com/g6ZeMC.png"" style=""width:100%"">
        <div class=""text"">Basit TV Ünitesi</div>
    </div>

    <div class=""bbb"">
        <img class=""iii"" src=""https://i.hizliresim.com/2M7dza.png"" style=""width:100%"">
        <div class=""text"">Basit Yemek Odası</div>
    </div>

    <div class=""bbb"">
        <img class=""iii"" src=""https://i.hizliresim.com/kd5vUN.png"" style=""width:100%"">
        <div class=""text"">Basit Yatak Odası</div>
    </div>

    <a class=""zzz"" onclick=""plusSlides(-1)"">&#10094;</a>
    <a class=""ill"" onclick=""plusSlides(1)"">&#10095;</a>
</div>
<br>

<div style=""text-align:center"">
    <span class=""ccc"" onclick=""currentSlide(1)""></span>
    <span class=""ccc"" onclick=""currentSlide(2)""></span>
    <span class=""ccc"" onclick=""currentSlide(3)""></span>
</div>


<script>
    var slideIndex = 1;
    showSlides(slideIndex);

    function plusSlides(n) {
        showSli");
            WriteLiteral(@"des(slideIndex += n);
    }

    function currentSlide(n) {
        showSlides(slideIndex = n);
    }

    function showSlides(n) {
        var i;
        var slides = document.getElementsByClassName(""bbb"");
        var dots = document.getElementsByClassName(""ccc"");
        if (n > slides.length) { slideIndex = 1 }
        if (n < 1) { slideIndex = slides.length }
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = ""none"";
        }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace("" aaa"", """");
        }
        slides[slideIndex - 1].style.display = ""block"";
        dots[slideIndex - 1].className += "" aaa"";
    }
</script>
<br />
<div class=""text-center"">
    <h2 style=""font-family: 'Rubik', sans-serif;""><b>Çok</b> Satanlar</h2>
</div>

");
            WriteLiteral("\r\n<div class=\"cok-satanlar\">\r\n");
#nullable restore
#line 70 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"urunler\">\r\n            <div class=\"kutu\">\r\n");
#nullable restore
#line 74 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                 if (item.Indirim != "0")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"indirim\">%");
#nullable restore
#line 76 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                                     Write(item.Indirim);

#line default
#line hidden
#nullable disable
            WriteLiteral(" indirim</div>\r\n");
#nullable restore
#line 77 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"resim\">\r\n                    <img style=\"width: 100%; max-height: 100%;\"");
            BeginWriteAttribute("src", " src=\"", 2348, "\"", 2378, 1);
#nullable restore
#line 79 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2354, Url.Content(item.Resim), 2354, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"baslik\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2468, "\"", 2498, 2);
            WriteAttributeValue("", 2475, "Product?Urun=", 2475, 13, true);
#nullable restore
#line 82 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2488, item.Urun, 2488, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"icerik-yazi\"><b>");
#nullable restore
#line 83 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                                               Write(item.Kategori);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n                        <div class=\"icerik-yazi\">");
#nullable restore
#line 84 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                                            Write(item.Urun);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 87 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                 if (item.Indirim != "0")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"fiyat\"><b>");
#nullable restore
#line 89 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                                      Write(item.IndirimliFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                    <span class=\"eski-fiyat\"><b>");
#nullable restore
#line 90 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                                           Write(item.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n");
#nullable restore
#line 91 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"fiyat\"><b>");
#nullable restore
#line 94 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                                      Write(item.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n");
#nullable restore
#line 95 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 98 "C:\Users\NS\GitHub\FinalApp\FinalApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br style=\"clear:both;\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FinalApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
