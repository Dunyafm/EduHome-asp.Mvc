#pragma checksum "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296c4ec589d9921322b0f6b70c721e741d752f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Course_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Course/Detail.cshtml")]
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
#line 1 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using EduHome.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296c4ec589d9921322b0f6b70c721e741d752f38", @"/Areas/AdminArea/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deae99fbfd9e0b0a3a68e7b8cb2083042ebb7df5", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm my-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px; height: 150px; border-radius: unset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Slider"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
   ViewData["Title"] = "Slider Detail";
                Layout = "~/Areas/AdminArea/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <h4>Category</h4>
        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""header d-flex justify-content-between my-5"">
                        <h1 class=""card-title my-3"">Slider</h1>
                        <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296c4ec589d9921322b0f6b70c721e741d752f386766", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>




                    </div>
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <thead>

                            </thead>
                            <tbody style=""width:300px"">

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "296c4ec589d9921322b0f6b70c721e741d752f388333", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 987, "~/assets/img/course/", 987, 20, true);
#nullable restore
#line 27 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 1007, Model.Image, 1007, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n                                <h5 class=\"mt-5\"> ");
#nullable restore
#line 28 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 29 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 30 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 31 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Apply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 32 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Certification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 33 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 34 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 35 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 36 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 37 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 38 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.Lanuguage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 39 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.Student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <h6 class=\"mt-3\">");
#nullable restore
#line 40 "C:\Users\dima-\Desktop\AspCoreProject\EduHome\EduHome\Areas\AdminArea\Views\Course\Detail.cshtml"
                                            Write(Model.Feature.Assesments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296c4ec589d9921322b0f6b70c721e741d752f3814480", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </tbody>\r\n\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
