#pragma checksum "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69201ffcc1914153fa0deffd15eca53b9bc8cbfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UrejanjeIntervencij), @"mvc.1.0.view", @"/Views/Admin/UrejanjeIntervencij.cshtml")]
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
#line 1 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\_ViewImports.cshtml"
using PgdGorenjiLogatec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\_ViewImports.cshtml"
using PgdGorenjiLogatec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69201ffcc1914153fa0deffd15eca53b9bc8cbfa", @"/Views/Admin/UrejanjeIntervencij.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1120bcd2fff284d0b230a5ea49950bbdc028acbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UrejanjeIntervencij : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PgdGorenjiLogatec.CustomModels.All_Intervencije>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
  
    ViewData["Title"] = "UrejanjeIntervencij";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""povezave"">
    <h1>Urejanje Intervencij</h1>
    <table class=""table"">
        <thead>
            <tr>
                <td><b>ID intervencije</b></td>
                <td><b>Naslov intervencije</b></td>
                <td><b>Datum intervencije</b></td>
                <td><b>Opis intervencije</b></td>
            </tr>

        </thead>
        <tbody>
");
#nullable restore
#line 21 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
             foreach (var item in Model.SeznamIntervencij)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
                   Write(item.Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
                   Write(item.Datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
                   Write(item.Opis.Substring(0, 5));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ...\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
                   Write(Html.ActionLink("Uredi", "Uredi", "Admin", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 38 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
                   Write(Html.ActionLink("Podrobnosti", "Details", "Admin", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 39 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
                   Write(Html.ActionLink("Izbriši", "Delete", "Admin", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "F:\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Admin\UrejanjeIntervencij.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PgdGorenjiLogatec.CustomModels.All_Intervencije> Html { get; private set; }
    }
}
#pragma warning restore 1591