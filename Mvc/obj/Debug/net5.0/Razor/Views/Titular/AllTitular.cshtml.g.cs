#pragma checksum "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3470304de5df6f72b3dceb844e690cb4e2703e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Titular_AllTitular), @"mvc.1.0.view", @"/Views/Titular/AllTitular.cshtml")]
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
#line 1 "C:\Projeto_Itau\Mvc\Views\_ViewImports.cshtml"
using Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projeto_Itau\Mvc\Views\_ViewImports.cshtml"
using Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3470304de5df6f72b3dceb844e690cb4e2703e", @"/Views/Titular/AllTitular.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d14c947c23ce1723f7843b90231a2951c10e8cb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Titular_AllTitular : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Titular>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Lista de todas as contas </h1>
<hr>
<table class=""table table-striped table-hover"">
    <thead>
        <th scope=""col"">Código</th>
        <th scope=""col"">Nome</th>
        <th scope=""col"">CPF</th>
        <th scope=""col"">Telefone</th>
        <th scope=""col"">Email</th>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml"
         foreach (Titular cliente2 in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml"
               Write(cliente2.codInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml"
               Write(cliente2.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml"
               Write(cliente2.cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml"
               Write(cliente2.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml"
               Write(cliente2.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Projeto_Itau\Mvc\Views\Titular\AllTitular.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Titular>> Html { get; private set; }
    }
}
#pragma warning restore 1591
