#pragma checksum "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5084f366900aa2ef7be6f2a11d4777b6274fcda0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5084f366900aa2ef7be6f2a11d4777b6274fcda0", @"/Views/Admin/Izbrisi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1120bcd2fff284d0b230a5ea49950bbdc028acbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Izbrisi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PgdGorenjiLogatec.CustomModels.Intervencija>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UrejanjeIntervencij", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Izbrisi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5084f366900aa2ef7be6f2a11d4777b6274fcda05380", async() => {
                WriteLiteral(@"
        <div class=""section-title"">
            <h2>Urejanje Intervencije</h2>
        </div>

        <div class=""container"">
            <div class=""col-xl-12"">
                <div class=""row"">
                    <div class=""col-6 w-100 text-left"">
                        Prijavljeni kot: <b>");
#nullable restore
#line 18 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
                                       Write(TempData["user"].ToString().ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b>
                    </div>
                    <div class=""col-6 w-100 text-right"">
                        <input type=""submit"" value=""Izbri??i intervencijo"" class=""btn btn-danger"" />
                    </div>
                </div>
                <br />
                <div class=""row"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <td><b>Naslov intervencije</b></td>
                                <td><b>Datum intervencije</b></td>
                                <td><b>Opis intervencije</b></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style=""display:none;"">
                                    ");
#nullable restore
#line 37 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
                               Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 40 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
                               Write(Html.TextAreaFor(x => x.Naslov, new { @readonly = true, rows = "5", cols = "30", style = "resize: none; width: 100%;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 43 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
                               Write(Html.TextBoxFor(x => x.Datum, new { @readonly = true }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 46 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\Izbrisi.cshtml"
                               Write(Html.TextAreaFor(x => x.Opis, new { @readonly = true, rows = "10", cols = "50", style = "resize: none; width: 100%;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class=""row"">
                    <div class=""col-12 w-100 text-right"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5084f366900aa2ef7be6f2a11d4777b6274fcda09121", async() => {
                    WriteLiteral("Nazaj na seznam");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
