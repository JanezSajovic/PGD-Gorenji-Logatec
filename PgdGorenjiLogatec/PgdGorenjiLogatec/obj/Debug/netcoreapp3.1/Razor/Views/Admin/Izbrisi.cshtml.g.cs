#pragma checksum "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0279857d9034922561c285e8588592ef34141159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Izbrisi), @"mvc.1.0.view", @"/Views/Admin/Izbrisi.cshtml")]
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
#line 1 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\_ViewImports.cshtml"
using PgdGorenjiLogatec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\_ViewImports.cshtml"
using PgdGorenjiLogatec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0279857d9034922561c285e8588592ef34141159", @"/Views/Admin/Izbrisi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1120bcd2fff284d0b230a5ea49950bbdc028acbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Izbrisi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PgdGorenjiLogatec.CustomModels.Intervencija>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Izbrisi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
  
    ViewData["Title"] = "Izbrisi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section id=\"blog\" class=\"blog\" style=\"padding: 90px !important;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0279857d9034922561c285e8588592ef341411594709", async() => {
                WriteLiteral("\r\n        <h1>Izbrisi</h1>\r\n        <div>\r\n            <h4>Intervencija</h4>\r\n            <hr />\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 16 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 19 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.TextBoxFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 22 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.DisplayNameFor(model => model.Naslov));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 25 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.TextBoxFor(model => model.Naslov));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 28 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.DisplayNameFor(model => model.Datum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 31 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.TextBoxFor(model => model.Datum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 34 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 37 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
               Write(Html.TextBoxFor(model => model.Opis));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n\r\n            <input type=\"submit\" value=\"Izbriši\" class=\"btn btn-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0279857d9034922561c285e8588592ef341411598214", async() => {
                    WriteLiteral("Nazaj na seznam");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PgdGorenjiLogatec.CustomModels.Intervencija> Html { get; private set; }
    }
}
#pragma warning restore 1591