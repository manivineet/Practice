#pragma checksum "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea92ddd2987cf10fcafc71e5701fa777eb569c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/_ViewImports.cshtml"
using BethanysPieShop;

#line default
#line hidden
#line 2 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/_ViewImports.cshtml"
using BethanysPieShop.Models;

#line default
#line hidden
#line 3 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea92ddd2987cf10fcafc71e5701fa777eb569c6", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0d4de53f18c625a6684796d97ecb9856199e289", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(11, 6, true);
            WriteLiteral("\n\n<h2>");
            EndContext();
            BeginContext(18, 10, false);
#line 4 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(28, 39, true);
            WriteLiteral("</h2>\n\n<div class=\"thumbnail\">\n    <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 67, "\"", 84, 1);
#line 7 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml"
WriteAttributeValue("", 73, Model.Name, 73, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 85, "\"", 106, 1);
#line 7 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml"
WriteAttributeValue("", 91, Model.ImageUrl, 91, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(107, 64, true);
            WriteLiteral(">\n    <div class=\"caption-full\">\n        <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(172, 11, false);
#line 9 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml"
                          Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(183, 43, true);
            WriteLiteral("</h3>\n        <h3>\n            <a href=\"#\">");
            EndContext();
            BeginContext(227, 10, false);
#line 11 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(237, 31, true);
            WriteLiteral("</a>\n        </h3>\n        <h4>");
            EndContext();
            BeginContext(269, 22, false);
#line 13 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(291, 17, true);
            WriteLiteral("</h4>\n        <p>");
            EndContext();
            BeginContext(309, 21, false);
#line 14 "/Users/vineetsingh/Desktop/Code/Practice/ASP.NET Core/MVC/BethanysPieShop/Views/Home/Details.cshtml"
      Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(330, 23, true);
            WriteLiteral("</p>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pie> Html { get; private set; }
    }
}
#pragma warning restore 1591
