#pragma checksum "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f18793e859e29eefc581c48a9eee184a2243a3f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servico_Index), @"mvc.1.0.view", @"/Views/Servico/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18793e859e29eefc581c48a9eee184a2243a3f0", @"/Views/Servico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37880ce461336e9aaf543db08add0c48ede4994e", @"/Views/_ViewImports.cshtml")]
    public class Views_Servico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Servico>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Lista de Servicos</h6>
        <a class=""btn btn-primary"" style=""float: right"" href=""/Servico/Create"">Adicionar</a>
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">Nome de Serviço</th>
                <th scope=""col"">Descrição</th>
                <th scope=""col"">Valor</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Editar</th>
                <th scope=""col"">Excluir</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
             foreach (var serv in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 22 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
                           Write(serv.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 23 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
                           Write(serv.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 24 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
                           Write(Decimal.Round((decimal)serv.Valor, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 25 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
                           Write(serv.StatusNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>\r\n                    <a class=\"btn btn-info btn-circle btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1111, 2);
            WriteAttributeValue("", 1087, "/Servico/Update/", 1087, 16, true);
#nullable restore
#line 27 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
WriteAttributeValue("", 1103, serv.Id, 1103, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-info-circle\"></i>\r\n                    </a>\r\n                </th>\r\n                <th>\r\n                    <a class=\"btn btn-danger btn-circle btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1309, "\"", 1340, 2);
            WriteAttributeValue("", 1316, "/Servico/Delete/", 1316, 16, true);
#nullable restore
#line 32 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
WriteAttributeValue("", 1332, serv.Id, 1332, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-trash\"></i>\r\n                    </a>\r\n                </th>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 38 "D:\Users\HankZ\Projetos C#\PJT_Inter\PJT_Inter\Views\Servico\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Servico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
