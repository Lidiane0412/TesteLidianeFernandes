#pragma checksum "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6ef1c06701bbf9b73ff9295d7b84dd67237f94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Index), @"mvc.1.0.view", @"/Views/Alunos/Index.cshtml")]
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
#line 1 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\_ViewImports.cshtml"
using NovaVidaTecnologia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\_ViewImports.cshtml"
using NovaVidaTecnologia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6ef1c06701bbf9b73ff9295d7b84dd67237f94", @"/Views/Alunos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f15169b8077f3dfdd672d617d7fb0f79c1b8933b", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NovaVidaTecnologia.Models.Alunos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FileImport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Alunos</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6ef1c06701bbf9b73ff9295d7b84dd67237f944971", async() => {
                WriteLiteral(" <i class=\"fa fa-upload\" aria-hidden=\"true\"></i> Importar Alunos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
                                                                                WriteLiteral(ViewBag.IdProfessor);

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
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 13 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
 if (TempData["success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-success alert-dismissible fade show col-4"" role=""alert"">
        <strong>Aluno(s) cadastrado(s) com sucesso!</strong>
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
#nullable restore
#line 21 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"

    TempData["success"] = null;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
 if (TempData["Deletesuccess"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-danger alert-dismissible fade show col-4"" role=""alert"">
        <strong>Aluno excluído com sucesso!</strong>
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
#nullable restore
#line 33 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"

    TempData["Deletesuccess"] = null;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
 if (TempData["TimeShort"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-warning alert-dismissible fade show col-8"" role=""alert"">
        <strong>Por favor, aguarde 5 minutos para fazer uma nova importação!</strong>
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
#nullable restore
#line 45 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"

    TempData["TimeShort"] = null;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 50 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Não há alunos cadastrados para o professor selecionado!</p>\r\n");
#nullable restore
#line 53 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
}
else
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>
                    Nome do Aluno
                </th>
                <th>
                    Valor da Mensalidade
                </th>
                <th>
                    Data de Vencimento
                </th>
                <th>
                    Professor
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 77 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 81 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 84 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
                   Write(item.PagamentoMensal.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
                   Write(item.DataVencimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
                   Write(item.Professores.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2696, "\"", 2798, 1);
#nullable restore
#line 93 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
WriteAttributeValue("", 2703, Url.Action("DeleteStudent", "Alunos", new { id = item.Id, ProfessorId = item.Professores.Id }), 2703, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\r\n                            <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                            Excluir\r\n                        </a>\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 100 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6ef1c06701bbf9b73ff9295d7b84dd67237f9413329", async() => {
                WriteLiteral("<i class=\"fa fa-arrow-left\" aria-hidden=\"true\"></i> Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 104 "F:\NovaVidaTecnologia\NovaVidaTecnologia\Views\Alunos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NovaVidaTecnologia.Models.Alunos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
