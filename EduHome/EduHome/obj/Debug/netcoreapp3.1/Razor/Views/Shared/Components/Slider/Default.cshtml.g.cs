#pragma checksum "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c0d69800f0f59e1d8cb00c1ad1a5cc71f2880ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Slider/Default.cshtml")]
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
#line 1 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Utilities.Pagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c0d69800f0f59e1d8cb00c1ad1a5cc71f2880ee", @"/Views/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baf95de69f13912eebef4696c394542d5b7f6c0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"slider-container\" class=\"slider-area two\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n");
#nullable restore
#line 4 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\Shared\Components\Slider\Default.cshtml"
         foreach (var slider in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- Start Slingle Slide -->\r\n            <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 266, "\"", 328, 4);
            WriteAttributeValue("", 274, "background-image:", 274, 17, true);
            WriteAttributeValue(" ", 291, "url(assets/img/slider/", 292, 23, true);
#nullable restore
#line 7 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 314, slider.Image, 314, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 327, ")", 327, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <!-- Start Slider Content -->
                <div class=""slider-content-area"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-md-10 col-md-offset-1"">
                                <div class=""slide-content-wrapper"">
                                    <div class=""slide-content text-center"">
                                        <h2>");
#nullable restore
#line 15 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\Shared\Components\Slider\Default.cshtml"
                                       Write(slider.sliderDetail.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <p>");
#nullable restore
#line 16 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\Shared\Components\Slider\Default.cshtml"
                                      Write(slider.sliderDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <a class=""default-btn"" href=""about.html"">Learn more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Start Slider Content -->
            </div>
            <!-- End Slingle Slide -->
");
#nullable restore
#line 27 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Views\Shared\Components\Slider\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591