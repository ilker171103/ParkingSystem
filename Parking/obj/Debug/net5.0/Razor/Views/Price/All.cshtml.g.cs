#pragma checksum "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Price\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc61b8ffb91357cab535a5aee4e746afc5880efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Price_All), @"mvc.1.0.view", @"/Views/Price/All.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\_ViewImports.cshtml"
using Parking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\_ViewImports.cshtml"
using Parking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc61b8ffb91357cab535a5aee4e746afc5880efd", @"/Views/Price/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1635ee56c2c3ba2bda787a9c14f7daad69912860", @"/Views/_ViewImports.cshtml")]
    public class Views_Price_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parking.Models.ParkingAllPriceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""u-align-center u-clearfix u-section-7"" id=""carousel_1128"">
    <div class=""u-clearfix u-sheet u-sheet-1"">
        <h2 class=""u-custom-font u-font-montserrat u-text u-text-1"">Pricing Table Template</h2>

        <div class=""u-expanded-width u-table u-table-responsive u-table-1"">
            <table class=""u-table-entity u-table-entity-1"">
                <colgroup>
                    <col width=""22.7%"">
                    <col width=""25.5%"">
                    <col width=""26.6%"">
                    <col width=""25.2%"">
                </colgroup>
                <tbody class=""u-align-center u-table-body"">
                    <tr style=""height: 57px;"">
                        <td class=""u-align-left u-first-column u-palette-3-base u-table-cell u-table-cell-1""></td>
                        <td class=""u-palette-3-base u-table-cell u-table-cell-2"">За 1 час </td>
                        <td class=""u-palette-3-base u-table-cell u-table-cell-3"">За 12 часа</td>
                      ");
            WriteLiteral("  <td class=\"u-palette-3-base u-table-cell u-table-cell-4\">За 24 часа</td>\r\n                    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Price\All.cshtml"
                     foreach (var item in Model.Names)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr style=\"height: 89px;\">\r\n                            <td class=\"u-align-left u-first-column u-grey-5 u-table-cell u-table-cell-5\">");
#nullable restore
#line 29 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Price\All.cshtml"
                                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"u-table-cell u-table-cell-6\">");
#nullable restore
#line 30 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Price\All.cshtml"
                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"u-grey-5 u-table-cell u-table-cell-7\">");
#nullable restore
#line 31 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Price\All.cshtml"
                                                                        Write(item.Price12h);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"u-table-cell u-table-cell-8\">");
#nullable restore
#line 32 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Price\All.cshtml"
                                                               Write(item.Price24h);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Price\All.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parking.Models.ParkingAllPriceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
