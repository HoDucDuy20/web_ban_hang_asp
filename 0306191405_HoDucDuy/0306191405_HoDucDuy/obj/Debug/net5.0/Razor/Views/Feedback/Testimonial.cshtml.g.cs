#pragma checksum "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04c95478b48d48ca39d6951ea424fd46c0bb3ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Testimonial), @"mvc.1.0.view", @"/Views/Feedback/Testimonial.cshtml")]
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
#line 1 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\_ViewImports.cshtml"
using _0306191405_HoDucDuy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\_ViewImports.cshtml"
using _0306191405_HoDucDuy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a04c95478b48d48ca39d6951ea424fd46c0bb3ea", @"/Views/Feedback/Testimonial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb6271650c15ad28d06e7d04c2ac03077fa427e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Testimonial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
  
    ViewData["Title"] = "Minics";
    ViewData["SubPage"] = "sub_page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
  
    IEnumerable<_0306191405_HoDucDuy.Areas.Admin.Models.Testimonial> testimonials = ViewData["Testimonials"] as IEnumerable<_0306191405_HoDucDuy.Areas.Admin.Models.Testimonial>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<!-- client section -->

<section class=""client_section layout_padding"">
    <div class=""container"">
        <div class=""heading_container heading_center"">
            <h2>
                What Says Our Customers
            </h2>
        </div>
    </div>
    <div class=""client_container "">
        <div id=""carouselExample2Controls"" class=""carousel slide"" data-ride=""carousel"">
            <div class=""carousel-inner"">
");
#nullable restore
#line 27 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                  bool i = true;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                 foreach (var item in testimonials)
                {
                    if (item.Status == true)
                    {
                        if (i == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""carousel-item active"">
                                <div class=""container"">
                                    <div class=""box"">
                                        <div class=""detail-box"">
                                            <p>
                                                <i class=""fa fa-quote-left"" aria-hidden=""true""></i>
                                            </p>
                                            <p>
                                                ");
#nullable restore
#line 42 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                        <div class=""client-id"">
                                            <div class=""img-box"" style="" width:160px; height:200px"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a04c95478b48d48ca39d6951ea424fd46c0bb3ea6480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1991, "~/img/testimonial/", 1991, 18, true);
#nullable restore
#line 47 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
AddHtmlAttributeValue("", 2009, Html.DisplayFor(modelItem => item.Avatar), 2009, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"name\">\r\n                                                <h5>\r\n                                                    ");
#nullable restore
#line 51 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </h5>\r\n                                                <h6>\r\n                                                    ");
#nullable restore
#line 54 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </h6>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 61 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                            i = false;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""carousel-item"">
                                <div class=""container"">
                                    <div class=""box"">
                                        <div class=""detail-box"">
                                            <p>
                                                <i class=""fa fa-quote-left"" aria-hidden=""true""></i>
                                            </p>
                                            <p>
                                                ");
#nullable restore
#line 73 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </div>
                                        <div class=""client-id"">
                                            <div class=""img-box"" style="" width:160px; height:200px"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a04c95478b48d48ca39d6951ea424fd46c0bb3ea10940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3831, "~/img/testimonial/", 3831, 18, true);
#nullable restore
#line 78 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
AddHtmlAttributeValue("", 3849, Html.DisplayFor(modelItem => item.Avatar), 3849, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"name\">\r\n                                                <h5>\r\n                                                    ");
#nullable restore
#line 82 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </h5>\r\n                                                <h6>\r\n                                                    ");
#nullable restore
#line 85 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </h6>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 92 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                        }
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Feedback\Testimonial.cshtml"
                   i = true;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""carousel_btn-box"">
                <a class=""carousel-control-prev"" href=""#carouselExample2Controls"" role=""button"" data-slide=""prev"">
                    <span>
                        <i class=""fa fa-angle-left"" aria-hidden=""true""></i>
                    </span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExample2Controls"" role=""button"" data-slide=""next"">
                    <span>
                        <i class=""fa fa-angle-right"" aria-hidden=""true""></i>
                    </span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
    </div>
</section>
<!-- end client section -->");
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