#pragma checksum "C:\Users\sheeh\source\repos\CountriesAroundTheWorld\CountriesAroundTheWorld\Views\Home\Description.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c261c94a351252711442193440682903908ff4d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Description), @"mvc.1.0.view", @"/Views/Home/Description.cshtml")]
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
#line 1 "C:\Users\sheeh\source\repos\CountriesAroundTheWorld\CountriesAroundTheWorld\Views\_ViewImports.cshtml"
using CountriesAroundTheWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sheeh\source\repos\CountriesAroundTheWorld\CountriesAroundTheWorld\Views\_ViewImports.cshtml"
using CountriesAroundTheWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c261c94a351252711442193440682903908ff4d5", @"/Views/Home/Description.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4834de8d6e5122324722c195ca6003cb5f53c945", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Description : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>All about ");
#nullable restore
#line 1 "C:\Users\sheeh\source\repos\CountriesAroundTheWorld\CountriesAroundTheWorld\Views\Home\Description.cshtml"
         Write(TempData.Peek("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>");
#nullable restore
#line 2 "C:\Users\sheeh\source\repos\CountriesAroundTheWorld\CountriesAroundTheWorld\Views\Home\Description.cshtml"
Write(TempData.Peek("description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<img id=\"CountryFlag\"");
            BeginWriteAttribute("src", "src=\"", 102, "\"", 107, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"500\"");
            BeginWriteAttribute("alt", " alt=\"", 120, "\"", 155, 3);
#nullable restore
#line 3 "C:\Users\sheeh\source\repos\CountriesAroundTheWorld\CountriesAroundTheWorld\Views\Home\Description.cshtml"
WriteAttributeValue("", 126, TempData.Peek("name"), 126, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 148, "\'s", 148, 2, true);
            WriteAttributeValue(" ", 150, "flag", 151, 5, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n<script>\r\n    let img = document.getElementById(\"CountryFlag\");\r\n    img.setAttribute(\"src\", \"");
#nullable restore
#line 6 "C:\Users\sheeh\source\repos\CountriesAroundTheWorld\CountriesAroundTheWorld\Views\Home\Description.cshtml"
                        Write(TempData.Peek("flag"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n</script>");
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
