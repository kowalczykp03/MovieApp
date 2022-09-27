#pragma checksum "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47c45cc1d1f0263db3e094aa3da946ec9b964cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_ShoppingCart), @"mvc.1.0.view", @"/Views/Orders/ShoppingCart.cshtml")]
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
#line 1 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using MoviesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using MoviesApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
using MoviesApp.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47c45cc1d1f0263db3e094aa3da946ec9b964cb", @"/Views/Orders/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1839aec3c9e26996da80634f1eca7ae06d604143", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItemFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItemToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
   
    ViewData["Title"] = "Shopping cart summary";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""text-center"">
            <h2>You shopping cart summary</h2>
        </div>
        <table class=""table"">
            <thead>
                <tr>
                    <th>Selected amount</th>
                    <th>Movie</th>
                    <th>Price</th>
                    <th>Subtotal</th>
                    <th></th>
                </tr>

            </thead>
            <tbody>
");
#nullable restore
#line 24 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                 foreach(var item in Model.ShoppingCart.ShoppingCartItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 27 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                                        Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 28 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                                        Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 29 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                                        Write(item.Movie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 30 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                                         Write((item.Amount * item.Movie.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47c45cc1d1f0263db3e094aa3da946ec9b964cb8417", async() => {
                WriteLiteral("\r\n                            <i class=\"bi bi-cart-dash\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                                                                                                                 WriteLiteral(item.Movie.Id);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47c45cc1d1f0263db3e094aa3da946ec9b964cb11041", async() => {
                WriteLiteral("\r\n                            <i class=\"bi bi-cart-plus\"></i>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                                                                                                             WriteLiteral(item.Movie.Id);

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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td colspan=\"2\"></td>\r\n                    <td><b>Total:</b></td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                   Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td></td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n        <div class=\"text-center\">\r\n            <div class=\"btn-group\">\r\n");
            WriteLiteral("                <div id=\"paypal-btn\"></div>\r\n                <span style=\"padding:5px;\"></span>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47c45cc1d1f0263db3e094aa3da946ec9b964cb14730", async() => {
                WriteLiteral("Add more items");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n\r\n<script src=\"https://www.paypalobjects.com/api/checkout.js\"></script>\r\n<script>\r\n\r\n    let _total = ");
#nullable restore
#line 68 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
            Write(Html.Raw(@Model.ShoppingCartTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    paypal.Button.render({
        //Configure environment
        env: 'sandbox',
        client: {
            sandbox: 'AVAZGy3ZPjV_KQiqz83T0tqxrPKUX2kbYqMTMq0fiHNRpdRPg2rEEFVeWRiT7eZYLNABFGpfBcn4rlko'
        },
        //Configure button
        locale: 'pl_PL',
        style: {
            size: 'small',
            color: 'gold',
            shape: 'pill'
        },
        commit: true,
        payment: function (data, actions) {
            return actions.payment.create({
                transactions: [{
                    amount: {
                        total: _total,
                        currency: 'PLN'
                    }
                }]
            });
        },
        onAuthorize: function (data, actions) {
            return actions.payment.execute().then(function () {
                var url = '");
#nullable restore
#line 95 "D:\Programming\Movies\MoviesApp\MoviesApp\Views\Orders\ShoppingCart.cshtml"
                      Write(Url.Action("CompleteOrder", "Orders", new { }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                window.location.href = url;\r\n            });\r\n        }\r\n    }, \'#paypal-btn\');\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
