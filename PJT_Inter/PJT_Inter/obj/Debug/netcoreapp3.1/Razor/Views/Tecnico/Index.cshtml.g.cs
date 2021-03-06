#pragma checksum "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6033300dd6b1e5b23a766af7837aae012b36714c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tecnico_Index), @"mvc.1.0.view", @"/Views/Tecnico/Index.cshtml")]
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
#line 1 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\_ViewImports.cshtml"
using PJT_Inter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\_ViewImports.cshtml"
using PJT_Inter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6033300dd6b1e5b23a766af7837aae012b36714c", @"/Views/Tecnico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37880ce461336e9aaf543db08add0c48ede4994e", @"/Views/_ViewImports.cshtml")]
    public class Views_Tecnico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tecnico>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">
            Lista de Técnicos
            <a class=""btn btn-primary"" style=""float: right"" href=""/Tecnico/Create"">Adicionar</a>
        </h6>
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Celular</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Editar</th>
                <th scope=""col"">Excluir</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
             foreach (var tec in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 25 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
                               Write(tec.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"row\">");
#nullable restore
#line 26 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
                               Write(tec.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"row\">");
#nullable restore
#line 27 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
                               Write(tec.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"row\">");
#nullable restore
#line 28 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
                               Write(tec.StatusNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1053, "\"", 1087, 2);
            WriteAttributeValue("", 1060, "/Tecnico/Update/", 1060, 16, true);
#nullable restore
#line 30 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
WriteAttributeValue("", 1076, tec.Codigo, 1076, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-circle btn-sm\">\r\n                            <i class=\"fas fa-info-circle\"></i>\r\n                        </a>\r\n                    </th>\r\n                    <th>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1303, "\"", 1337, 2);
            WriteAttributeValue("", 1310, "/Tecnico/Delete/", 1310, 16, true);
#nullable restore
#line 35 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
WriteAttributeValue("", 1326, tec.Codigo, 1326, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-circle btn-sm\">\r\n                            <i class=\"fas fa-trash\"></i>\r\n                        </a>\r\n                    </th>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 41 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Tecnico\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tecnico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
