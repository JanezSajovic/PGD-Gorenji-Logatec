#pragma checksum "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "943a8adb9a4c79c47e2b5f13453c8fc09c3c8d59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Intervencije), @"mvc.1.0.view", @"/Views/Home/Intervencije.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"943a8adb9a4c79c47e2b5f13453c8fc09c3c8d59", @"/Views/Home/Intervencije.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1120bcd2fff284d0b230a5ea49950bbdc028acbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Intervencije : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PgdGorenjiLogatec.CustomModels.Intervencija>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml"
  
    ViewData["Title"] = "Intervencije";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""blog"" class=""blog"" style=""padding: 90px !important;"">
    <div class=""section-title"">
        <h2>NAŠE LETNE INTERVENCIJE IN POSREDOVANJA</h2>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 entries"">
");
#nullable restore
#line 15 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml"
                 foreach (var qwe in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <article class=\"entry\" data-aos=\"fade-up\">\r\n                        <h4 class=\"entry-title\">\r\n                            ");
#nullable restore
#line 18 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml"
                       Write(qwe.Naslov.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h4>

                        <div class=""entry-meta"">
                            <ul>
                                <li class=""d-flex align-items-center""><i class=""icofont-wall-clock""></i> <a href=""blog-single.html""><time");
            BeginWriteAttribute("datetime", " datetime=\"", 850, "\"", 871, 1);
#nullable restore
#line 23 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml"
WriteAttributeValue("", 861, qwe.Datum, 861, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml"
                                                                                                                                                           Write(qwe.Datum.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</time></a></li>\r\n                            </ul>\r\n                        </div>\r\n\r\n                        <div class=\"entry-content\">\r\n                            <p>\r\n                                ");
#nullable restore
#line 29 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml"
                           Write(qwe.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                    </article>\r\n");
#nullable restore
#line 34 "F:\___PROJECTS___\PGD-Gorenji-Logatec\PgdGorenjiLogatec\PgdGorenjiLogatec\Views\Home\Intervencije.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PgdGorenjiLogatec.CustomModels.Intervencija>> Html { get; private set; }
    }
}
#pragma warning restore 1591
