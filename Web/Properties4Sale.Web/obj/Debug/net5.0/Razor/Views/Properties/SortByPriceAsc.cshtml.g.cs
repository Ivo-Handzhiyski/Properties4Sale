#pragma checksum "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_SortByPriceAsc), @"mvc.1.0.view", @"/Views/Properties/SortByPriceAsc.cshtml")]
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
#line 1 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\_ViewImports.cshtml"
using Properties4Sale.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\_ViewImports.cshtml"
using Properties4Sale.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869370c7a697fc793fab2f6d4ca0b7b3fcbd4da8", @"/Views/Properties/SortByPriceAsc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d827048d5cee0f719fa8cac5167e4cdb2840b61e", @"/Views/_ViewImports.cshtml")]
    public class Views_Properties_SortByPriceAsc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Properties4Sale.Web.ViewModels.Property.PropertiesListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Properties", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SortByPriceDesc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da85778", async() => {
                WriteLiteral(@"
    <main id=""main"">

        <!-- ======= Intro Single ======= -->
        <section class=""intro-single"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12 col-lg-8"">
                        <div class=""title-single-box"">
                            <h1 class=""title-single"">Our Amazing Properties</h1>
                            <span class=""color-text-a"">Grid Properties</span>
                        </div>
                    </div>
                    <div class=""col-md-12 col-lg-4"">
                        <nav aria-label=""breadcrumb"" class=""breadcrumb-box d-flex justify-content-lg-end"">
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item"">
                                    <a href=""#"">Home</a>
                                </li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">
                                    All Properties
              ");
                WriteLiteral(@"                  </li>
                            </ol>
                        </nav>
                        <div class=""dropdown-menu-lg-left"">
                            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Dropdown button
                            </button>
                            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da87686", async() => {
                    WriteLiteral("Sort by most recent.");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da89250", async() => {
                    WriteLiteral("Sort by price desc.");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        </section><!-- End Intro Single-->
        <!-- ======= Property Grid ======= -->


        <section class=""property-grid grid"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-12"">

                    </div>
");
#nullable restore
#line 52 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                     foreach (var property in this.Model.Properties)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-md-6\">\n            <div class=\"card-box-a card-shadow\">\n                <div class=\"img-box-a\">\n                    <img height=\"2500px\" width=\"1500px\"");
                BeginWriteAttribute("src", " src=", 2593, "", 2616, 1);
#nullable restore
#line 58 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
WriteAttributeValue("", 2598, property.ImageUrl, 2598, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2616, "\"", 2622, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-a img-fluid"">
                </div>
                <div class=""card-overlay"">
                    <div class=""card-overlay-a-content"">
                        <div class=""card-header-a"">
                            <h2 class=""card-title-a"">
                                <a href=""#"">
                                    ");
#nullable restore
#line 65 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                               Write(property.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <br />
                                </a>
                            </h2>
                        </div>
                        <div class=""card-body-a"">
                            <div class=""price-box d-flex"">
                                <span class=""price-a"">");
#nullable restore
#line 72 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                 Write(property.TypeOfPropertyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("| $ ");
#nullable restore
#line 72 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                                                 Write(property.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                            </div>\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da814014", async() => {
                    WriteLiteral("\n                                Click here to view\n                                <span class=\"ion-ios-arrow-forward\"></span>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                   WriteLiteral(property.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""card-footer-a"">
                            <ul class=""card-info d-flex justify-content-around"">
                                <li>
                                    <h4 class=""card-info-title"">Area</h4>
                                    <span>
                                        ");
#nullable restore
#line 84 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                   Write(property.Area);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" m
                                        <sup>2</sup>
                                    </span>
                                </li>
                                <li>
                                    <h4 class=""card-info-title"">Beds</h4>
                                    <span>");
#nullable restore
#line 90 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                     Write(property.Beds);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                </li>\n                                <li>\n                                    <h4 class=\"card-info-title\">Baths</h4>\n                                    <span>");
#nullable restore
#line 94 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                     Write(property.Baths);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                </li>\n                                <li>\n                                    <h4 class=\"card-info-title\">Garages</h4>\n                                    <span>");
#nullable restore
#line 98 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                     Write(property.Garages);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                </li>\n                            </ul>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>");
#nullable restore
#line 105 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n            </div>\n        </section><!-- End Property Grid Single-->\n\n        <section>\n            <nav aria-label=\"...\">\n                <ul class=\"pagination justify-content-center\">\n                    <li");
                BeginWriteAttribute("class", " class=\"", 5165, "\"", 5238, 3);
                WriteAttributeValue("", 5173, "page-item", 5173, 9, true);
                WriteAttributeValue(" ", 5182, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 113 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                          if (!Model.HasPreviousPage) { 

#line default
#line hidden
#nullable disable
                    WriteLiteral("disabled");
#nullable restore
#line 113 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 5183, 54, false);
                WriteAttributeValue(" ", 5237, "", 5238, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da820866", async() => {
                    WriteLiteral("Previous");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                                WriteLiteral(Model.PreviousPageNumber);

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
                WriteLiteral("\n                    </li>\n");
#nullable restore
#line 116 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                     for (int i = Model.PageNumber - 3; i < Model.PageNumber; i++)
                    {
                        if (i > 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <li class=\"page-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da823772", async() => {
#nullable restore
#line 120 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
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
                WriteLiteral("</li>\n");
#nullable restore
#line 121 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
}

}

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"page-item active\">\n                        <a class=\"page-link\" href=\"#!\">");
#nullable restore
#line 125 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                  Write(Model.PageNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\n                    </li>\n");
#nullable restore
#line 127 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                     for (int i = Model.PageNumber + 1; i <= Model.PageNumber + 3; i++)
                    {
                        if (i <= Model.PagesCount)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <li class=\"page-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da827690", async() => {
#nullable restore
#line 131 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
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
                WriteLiteral("</li>\n");
#nullable restore
#line 132 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
}

}

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li");
                BeginWriteAttribute("class", " class=\"", 6157, "\"", 6225, 3);
                WriteAttributeValue("", 6165, "page-item", 6165, 9, true);
                WriteAttributeValue(" ", 6174, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 135 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                          if(!Model.HasNextPage) { 

#line default
#line hidden
#nullable disable
                    WriteLiteral("disabled");
#nullable restore
#line 135 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
                                                                                         }

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 6175, 49, false);
                WriteAttributeValue(" ", 6224, "", 6225, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "869370c7a697fc793fab2f6d4ca0b7b3fcbd4da831908", async() => {
                    WriteLiteral("Next");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "C:\Users\Ivo\Desktop\VERI IMPROTA STUF\Properties4Sale\Properties4Sale\Web\Properties4Sale.Web\Views\Properties\SortByPriceAsc.cshtml"
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
                WriteLiteral(@"
                    </li>
                </ul>
            </nav>
        </section><!-- End Property Grid Single-->

    </main><!-- End #main -->


    <a href=""#"" class=""back-to-top""><i class=""fa fa-chevron-up""></i></a>
    <div id=""preloader""></div>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Properties4Sale.Web.ViewModels.Property.PropertiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
