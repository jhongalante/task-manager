#pragma checksum "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\Home\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2835695481c1cf7584fed7cfc3767d3a9c30eb91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Historico), @"mvc.1.0.view", @"/Views/Home/Historico.cshtml")]
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
#line 1 "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\_ViewImports.cshtml"
using task_manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\_ViewImports.cshtml"
using task_manager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\_ViewImports.cshtml"
using task_manager.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2835695481c1cf7584fed7cfc3767d3a9c30eb91", @"/Views/Home/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f85d6a8e15a0f78c01621aab9e183c3f9698ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\Home\Historico.cshtml"
  
    ViewData["Title"] = "Histórico";
    Layout = "_LayoutHistorico";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n    <div class=\"container\">\n\n        <div id=\"tabela-historico-view\">\n");
#nullable restore
#line 11 "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\Home\Historico.cshtml"
              await Html.RenderPartialAsync("_TabelaHistorico", Model.TarefasUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n\n        <div id=\"modal-detalhe-tarefa-historico\">\n");
#nullable restore
#line 15 "C:\Users\Global Corporate TI\source\repos\task-manager\task-manager\Views\Home\Historico.cshtml"
              await Html.RenderPartialAsync("_ModalDetalheTarefaHistorico", Model.Responsaveis);

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n\n    </div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
