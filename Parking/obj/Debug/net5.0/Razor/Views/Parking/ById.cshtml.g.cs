#pragma checksum "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88be27e9df0fc0255241a673cb8bbd6f9b3d556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parking_ById), @"mvc.1.0.view", @"/Views/Parking/ById.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Parking\Parking\Views\_ViewImports.cshtml"
using Parking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Parking\Parking\Views\_ViewImports.cshtml"
using Parking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88be27e9df0fc0255241a673cb8bbd6f9b3d556", @"/Views/Parking/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1635ee56c2c3ba2bda787a9c14f7daad69912860", @"/Views/_ViewImports.cshtml")]
    public class Views_Parking_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parking.Models.SingleParkingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("servings-quantity"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""single-recipe-wrap-layout1 padding-top-74 padding-bottom-50"">
    <div class=""container"">
        <div class=""row gutters-60"">
            <div class=""col-lg-8"">
                <div class=""single-recipe-layout1"">
                    <div class=""ctg-name"">");
#nullable restore
#line 8 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
                                     Write(Model.ProductType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <h2 class=\"item-title\">");
#nullable restore
#line 9 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <div class=""row mb-4"">
                        <div class=""col-xl-9 col-12"">
                            <ul class=""entry-meta"">
                                <li class=""single-meta"">
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i>Nov 14,
                                        2018
                                    </a>
                                </li>
                                <li class=""single-meta"">
                                    <a href=""#"">
                                        <i class=""fas fa-user""></i>by <span>
                                            Kazi
                                            Fahim
                                        </span>
                                    </a>
                                </li>
                                <li class=""single-meta"">
                                    <ul class=""item-rating"">
         ");
            WriteLiteral(@"                               <li class=""star-fill""><i class=""fas fa-star""></i></li>
                                        <li class=""star-fill""><i class=""fas fa-star""></i></li>
                                        <li class=""star-fill""><i class=""fas fa-star""></i></li>
                                        <li class=""star-fill""><i class=""fas fa-star""></i></li>
                                        <li class=""star-empty""><i class=""fas fa-star""></i></li>
                                        <li><span>9<span> / 10</span></span> </li>
                                    </ul>
                                </li>
                                <li class=""single-meta"">
                                    <a href=""#"">
                                        <i class=""fas fa-heart""></i><span>02</span>
                                        Likes
                                    </a>
                                </li>
                            </ul>
                        </div>");
            WriteLiteral(@"
                        <div class=""col-xl-3 col-12"">
                            <ul class=""action-item"">
                                <li><button><i class=""fas fa-print""></i></button></li>
                                <li><button><i class=""fas fa-expand-arrows-alt""></i></button></li>
                                <li class=""action-share-hover"">
                                    <button><i class=""fas fa-share-alt""></i></button>
                                    <div class=""action-share-wrap"">
                                        <a href=""#"" title=""facebook""><i class=""fab fa-facebook-f""></i></a>
                                        <a href=""#"" title=""twitter""><i class=""fab fa-twitter""></i></a>
                                        <a href=""#"" title=""linkedin""><i class=""fab fa-linkedin-in""></i></a>
                                        <a href=""#"" title=""pinterest""><i class=""fab fa-pinterest-p""></i></a>
                                        <a href=""#"" title=""skype""><i clas");
            WriteLiteral(@"s=""fab fa-skype""></i></a>
                                        <a href=""#"" title=""rss""><i class=""fas fa-rss""></i></a>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""item-figure"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 3853, "\"", 3874, 1);
#nullable restore
#line 64 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
WriteAttributeValue("", 3859, Model.ImageURL, 3859, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Product"">
                    </div>
                    <div class=""item-feature"">
                        <ul>
                            <li>
                                <div class=""feature-wrap"">
                                    <div class=""media"">
                                        <div class=""feature-icon"">
                                            <i class=""far fa-clock""></i>
                                        </div>
                                        <div class=""media-body space-sm"">
                                            <div class=""feature-title"">Брой места</div>
                                            <div class=""feature-sub-title"">");
#nullable restore
#line 76 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
                                                                      Write(Model.CountPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""feature-wrap"">
                                    <div class=""media"">
                                        <div class=""feature-icon"">
                                            <i class=""fas fa-utensils""></i>
                                        </div>
                                        <div class=""media-body space-sm"">
                                            <div class=""feature-title"">Цена</div>
                                            <div class=""feature-sub-title"">");
#nullable restore
#line 89 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
                                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""feature-wrap"">
                                    <div class=""media"">
                                        <div class=""feature-icon"">
                                            <i class=""fas fa-users""></i>
                                        </div>
                                        <div class=""media-body space-sm"">
                                            <div class=""feature-title"">SERVING</div>
                                        
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""feature-wrap"">
                                    <div cla");
            WriteLiteral(@"ss=""media"">
                                        <div class=""feature-icon"">
                                            <i class=""far fa-eye""></i>
                                        </div>
                                        <div class=""media-body space-sm"">
                                            <div class=""feature-title"">VIEWS</div>
                                            <div class=""feature-sub-title"">3,450</div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    

                    <div class=""making-elements-wrap"">
                        <div class=""row"">
                            <div class=""col-xl-6 col-12"">
                                <div class=""ingridients-wrap"">
                                    <h3 class=""item-title""><i class=""fas fa-list-ul""></i>Ingridients</h3");
            WriteLiteral(">\r\n                                   \r\n                                    <div class=\"adjust-servings\">\r\n                                        <div class=\"servings-title\">Adjust Servings</div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88be27e9df0fc0255241a673cb8bbd6f9b3d55612830", async() => {
                WriteLiteral(@"
                                            <div class=""input-group quantity-holder"" id=""quantity-holder"">
                                                <input type=""text"" name='quantity' class=""form-control quantity-input""
                                                       value=""1"" placeholder=""1"">
                                                <div class=""btn-quantity-select"">
                                                    <button class=""quantity-plus"" type=""button"">
                                                        <i class=""fas fa-plus""></i>
                                                    </button>
                                                    <button class=""quantity-minus"" type=""button"">
                                                        <i class=""fas fa-minus""></i>
                                                    </button>
                                                </div>
                                            </div>
                          ");
                WriteLiteral("              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>

                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parking.Models.SingleParkingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
