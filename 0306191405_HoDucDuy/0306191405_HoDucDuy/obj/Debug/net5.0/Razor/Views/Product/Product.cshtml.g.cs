#pragma checksum "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c04a3e4d914e33c58adbe4f6400a116cc525ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product), @"mvc.1.0.view", @"/Views/Product/Product.cshtml")]
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
#nullable restore
#line 4 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c04a3e4d914e33c58adbe4f6400a116cc525ffa", @"/Views/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb6271650c15ad28d06e7d04c2ac03077fa427e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<_0306191405_HoDucDuy.Areas.Admin.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddltype"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "type", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("document.getElementById(\'btnSubmit\').click();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
  
    IEnumerable<_0306191405_HoDucDuy.Areas.Admin.Models.Rate> rates = ViewData["Rates"]as IEnumerable<_0306191405_HoDucDuy.Areas.Admin.Models.Rate>;
    var star = from rate in rates group rate by rate.ProductId into grouping select new { ProductId = grouping.Key, Star = grouping.Average(ed => ed.Star) };

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
  
    ViewData["Title"] = "Minics";
    ViewData["SubPage"] = "sub_page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
</div>

<!-- product section -->

<section class=""product_section layout_padding"">
    <div class=""container"">
        <div class=""heading_container heading_center"">
            <h2>
                Our Products
            </h2>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c04a3e4d914e33c58adbe4f6400a116cc525ffa9282", async() => {
                WriteLiteral("\r\n            <label class=\"control-label\">Product Type</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c04a3e4d914e33c58adbe4f6400a116cc525ffa9619", async() => {
                    WriteLiteral("\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c04a3e4d914e33c58adbe4f6400a116cc525ffa9903", async() => {
                        WriteLiteral("All");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 33 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ProductTypeId;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input id=\"btnSubmit\" hidden type=\"submit\" value=\"submit\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 39 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
             if (Model != null)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                 foreach (var item in Model)
                {
                    if (item.status == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-6 col-lg-4\">\r\n                            <div class=\"box\">\r\n                                <div class=\"img-box\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c04a3e4d914e33c58adbe4f6400a116cc525ffa15087", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1958, "~/img/product/", 1958, 14, true);
#nullable restore
#line 49 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
AddHtmlAttributeValue("", 1972, Html.DisplayFor(modelItem => item.Image), 1972, 41, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c04a3e4d914e33c58adbe4f6400a116cc525ffa16744", async() => {
                WriteLiteral("\r\n                                        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 2171, "\"", 2187, 1);
#nullable restore
#line 51 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
WriteAttributeValue("", 2179, item.Id, 2179, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden name=\"id\" />\r\n");
#nullable restore
#line 52 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                         if (item.Stock > 0)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <button class=\"add_cart_btn btn-outline-light\">Add To Cart</button>\r\n");
#nullable restore
#line 55 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <p class=\"add_cart_btn btn-outline-light bg-danger\">Out of stock</p>\r\n");
#nullable restore
#line 59 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                                </div>\r\n                                <div class=\"detail-box\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c04a3e4d914e33c58adbe4f6400a116cc525ffa20234", async() => {
                WriteLiteral("\r\n                                        <h5>\r\n                                            ");
#nullable restore
#line 70 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </h5>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    <div class=\"product_info\">\r\n                                        <h5>\r\n");
            WriteLiteral("                                            ");
#nullable restore
#line 76 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </h5>\r\n");
#nullable restore
#line 78 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                          int numstar = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                         foreach (var s in star)
                                        {
                                            if(s.ProductId == item.Id)
                                            {
                                                numstar = ((int)s.Star);
                                                break;
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"star_container\">\r\n");
#nullable restore
#line 88 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                             for (int i = 1; i <= numstar; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fa fa-star\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 91 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                             for (int i = 1; i <= 5 - numstar; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <i class=\"fa fa-star-o\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 95 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 101 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 107 "D:\CKC\HK_5\LT Web ASPNET\Do_an\0306191405_HoDucDuy\0306191405_HoDucDuy\Views\Product\Product.cshtml"
       Write(Html.PagedListPager(Model, c => Href("~/Product/Product?page=" + c), new PagedListRenderOptions
            {
               LiElementClasses = new string[] { "page-item" },
               PageClasses = new string[] { "page-link" }
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("    </div>\r\n</section>\r\n");
            DefineSection("JS", async() => {
                WriteLiteral("\r\n ");
            }
            );
            WriteLiteral("\r\n<!-- end product section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<_0306191405_HoDucDuy.Areas.Admin.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
