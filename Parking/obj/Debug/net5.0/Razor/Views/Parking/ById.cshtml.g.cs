#pragma checksum "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d12a2db930cac9c66e12f4d25f149a29acec0e7a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d12a2db930cac9c66e12f4d25f149a29acec0e7a", @"/Views/Parking/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1635ee56c2c3ba2bda787a9c14f7daad69912860", @"/Views/_ViewImports.cshtml")]
    public class Views_Parking_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parking.Models.SingleParkingViewModel>
    {
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
                               
                               
                               
                            </ul>
                        </div>
                        
                    </div>
                    <div class=""item-figure"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 859, "\"", 880, 1);
#nullable restore
#line 21 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
WriteAttributeValue("", 865, Model.ImageURL, 865, 15, false);

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
#line 33 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
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
#line 46 "C:\Users\User\source\repos\Parking\Parking\Views\Parking\ById.cshtml"
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
                                       
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""feature-wrap"">
                                    <div class=""media"">
                                        <div class=""feature-icon"">
                                            <i class=""far fa-eye""></i>
                                        </div>
         ");
            WriteLiteral(@"                             
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    

                    <div class=""making-elements-wrap"">
                        <div class=""row"">
                            <div class=""col-xl-6 col-12"">
                                
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
