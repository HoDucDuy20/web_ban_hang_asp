#pragma checksum "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Areas\Admin\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1547d7eb52582033e152e363e3651eff849c15b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Login), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Login.cshtml")]
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
#line 1 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Areas\Admin\Views\_ViewImports.cshtml"
using _0306191405_HoDucDuy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Areas\Admin\Views\_ViewImports.cshtml"
using _0306191405_HoDucDuy.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1547d7eb52582033e152e363e3651eff849c15b0", @"/Areas/Admin/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b56a4c3c5dd07663ce454cf3b62e87d2e76279", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/ad_login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Areas\Admin\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container justify-content-center\">\r\n    <div class=\"col align-self-center p\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1547d7eb52582033e152e363e3651eff849c15b05489", async() => {
                WriteLiteral("\r\n            <div class=\"form-floating mb-3\">\r\n                <label for=\"floatingInput\">Tài khoản</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"floatingInput\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 515, "\"", 529, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"username\">\r\n            </div>\r\n            <div class=\"form-floating mb-3\">\r\n                <label for=\"floatingPassword\">Mật khẩu</label>\r\n                <input type=\"password\" class=\"form-control\" id=\"floatingPassword\" minlength=\"6\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 774, "\"", 788, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"password\">\r\n            </div>\r\n");
                WriteLiteral("        <br />\r\n            <button type=\"submit\" class=\"btn btn-primary mb-3\">Đăng nhập</button>\r\n");
#nullable restore
#line 32 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Areas\Admin\Views\Home\Login.cshtml"
             if (ViewBag.Result == false)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"alert alert-danger mt-3\" role=\"alert\">Đăng nhập thất bại!</div>\r\n");
#nullable restore
#line 35 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Areas\Admin\Views\Home\Login.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1547d7eb52582033e152e363e3651eff849c15b09051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
