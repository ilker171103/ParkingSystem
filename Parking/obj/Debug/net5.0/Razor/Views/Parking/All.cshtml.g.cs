#pragma checksum "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88deabbf85fdb702186081c8ae4a9ff0a93b6c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parking_All), @"mvc.1.0.view", @"/Views/Parking/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88deabbf85fdb702186081c8ae4a9ff0a93b6c0", @"/Views/Parking/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1635ee56c2c3ba2bda787a9c14f7daad69912860", @"/Views/_ViewImports.cshtml")]
    public class Views_Parking_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parking.Models.ParkingListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<br />
<br />
<div class=""u-align-center u-container-style u-expanded-width-sm u-expanded-width-xs u-group u-group-1"">
    <div class=""u-container-layout u-valign-top u-container-layout-1"">
        <h2 class=""u-custom-font u-font-montserrat u-text u-text-1"">

            <span class=""u-text-palette-3-base"">Всички паркинги</span>
        </h2>

    </div>
</div>
<hr />
<div class=""row"">
");
#nullable restore
#line 20 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
     foreach (var item in Model.Parkings)
    { // @($"/img/{item.Id}.png")
      // "@item.ImageURL"

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media col-md-3 col-xs-12 col-sm-6 \">\r\n            <img class=\"mr-3\" width=\"100\"");
            BeginWriteAttribute("src", " src=", 705, "", 734, 1);
#nullable restore
#line 24 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
WriteAttributeValue("", 710, $"/img/{item.Id}.png", 710, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"ImgHere\">\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88deabbf85fdb702186081c8ae4a9ff0a93b6c05535", async() => {
#nullable restore
#line 26 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
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
            WriteLiteral("</h5>\r\n                ");
#nullable restore
#line 27 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n<nav aria-label=\"...\">\r\n    <ul class=\"pagination justify-content-center\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 1070, "\"", 1141, 3);
            WriteAttributeValue("", 1078, "page-item", 1078, 9, true);
            WriteAttributeValue(" ", 1087, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 35 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                              if (!Model.HasPreviousPage) {

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 35 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                                                }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1088, 52, false);
            WriteAttributeValue(" ", 1140, "", 1141, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span class=\"page-link\" asp-action=\"All\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1197, "\"", 1237, 1);
#nullable restore
#line 36 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
WriteAttributeValue("", 1212, Model.PreviousPageNumber, 1212, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Предишен</span>\r\n        </li>\r\n");
#nullable restore
#line 38 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
         for (int i = Model.PageNumber - 3; i < Model.PageNumber; i++)
        {
            if (i > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88deabbf85fdb702186081c8ae4a9ff0a93b6c010444", async() => {
#nullable restore
#line 42 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                                              WriteLiteral(i);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item active\">\r\n            <span class=\"page-link\">\r\n                ");
#nullable restore
#line 47 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
           Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"sr-only\">(current)</span>\r\n            </span>\r\n        </li>\r\n");
#nullable restore
#line 51 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
         for (int i = Model.PageNumber + 1; i <= Model.PageNumber + 3; i++)
        {
            if (i < Model.PagesCount)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88deabbf85fdb702186081c8ae4a9ff0a93b6c013971", async() => {
#nullable restore
#line 55 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                                              WriteLiteral(i);

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
            WriteLiteral("</li>\r\n");
#nullable restore
#line 56 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 2016, "\"", 2083, 3);
            WriteAttributeValue("", 2024, "page-item", 2024, 9, true);
            WriteAttributeValue(" ", 2033, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 58 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                              if (!Model.HasNextPage) {

#line default
#line hidden
#nullable disable
                WriteLiteral("disabled");
#nullable restore
#line 58 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 2034, 48, false);
            WriteAttributeValue(" ", 2082, "", 2083, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88deabbf85fdb702186081c8ae4a9ff0a93b6c017772", async() => {
                WriteLiteral("Следващ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                                                    WriteLiteral(Model.NextPageNumber);

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
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</nav>\r\n<p>Следваща страница: ");
#nullable restore
#line 63 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                 Write(Model.NextPageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Брой страници: ");
#nullable restore
#line 64 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
             Write(Model.PagesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Предишна страница: ");
#nullable restore
#line 65 "C:\Users\User\source\repos\Parking\ParkingSystem\Parking\Views\Parking\All.cshtml"
                 Write(Model.PreviousPageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parking.Models.ParkingListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
