#pragma checksum "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29d316bd36b2c050d462caa5846a807d227a68fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depoimento_ListarDepoimentos), @"mvc.1.0.view", @"/Views/Depoimento/ListarDepoimentos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Depoimento/ListarDepoimentos.cshtml", typeof(AspNetCore.Views_Depoimento_ListarDepoimentos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29d316bd36b2c050d462caa5846a807d227a68fb", @"/Views/Depoimento/ListarDepoimentos.cshtml")]
    public class Views_Depoimento_ListarDepoimentos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Checkpoint_PontoDigital.ViewModel.DepoimentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/macbook-air-1366x768-apple-macbook-pro-4k-16623.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("770 px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
  
Html.RenderPartial("_Head");

#line default
#line hidden
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(102, 2158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57b2187648014445886deae7cb3ddf78", async() => {
                BeginContext(108, 48, true);
                WriteLiteral("\r\n    <header class=\"topo_container\">\r\n       \r\n");
                EndContext();
#line 9 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
          
        Html.RenderPartial("_HeaderNavBar",ViewData["User"]);
        

#line default
#line hidden
                BeginContext(242, 124, true);
                WriteLiteral("        <button id=\"btn_menu\"><img src=\"/~img/menu.png\" alt=\"Menu\"></button>\r\n        <section class=\"banner\">\r\n            ");
                EndContext();
                BeginContext(366, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f64c516ce79449faa88ce84d475d82d7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(471, 373, true);
                WriteLiteral(@"
        </section>
    </header>
    <section class=""dep"">
        <h2>Depoimentos</h2>
        <table>
            <thead>
                <tr>

                    <th>Nome</th>
                    <th>Estado</th>
                    <th>Titulo</th>
                    <th>Descrição</th>

                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 31 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
                 foreach (var item in Model.depoimentos)
                {
                if (item ==null)
                {
                continue;
                }

#line default
#line hidden
                BeginContext(1020, 114, true);
                WriteLiteral("                <tr>\r\n                    \r\n                    <div class=\"topico\">\r\n                        <td>");
                EndContext();
                BeginContext(1135, 9, false);
#line 40 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
                       Write(item.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1144, 105, true);
                WriteLiteral("</td>\r\n                    </div>\r\n                    <div class=\"topico\">\r\n                        <td>");
                EndContext();
                BeginContext(1250, 11, false);
#line 43 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
                       Write(item.Estado);

#line default
#line hidden
                EndContext();
                BeginContext(1261, 105, true);
                WriteLiteral("</td>\r\n                    </div>\r\n                    <div class=\"topico\">\r\n                        <td>");
                EndContext();
                BeginContext(1367, 11, false);
#line 46 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
                       Write(item.Titulo);

#line default
#line hidden
                EndContext();
                BeginContext(1378, 105, true);
                WriteLiteral("</td>\r\n                    </div>\r\n                    <div class=\"topico\">\r\n                        <td>");
                EndContext();
                BeginContext(1484, 14, false);
#line 49 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
                       Write(item.Descricao);

#line default
#line hidden
                EndContext();
                BeginContext(1498, 95, true);
                WriteLiteral("</td>\r\n                    </div>\r\n                        <td>\r\n                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1593, "\"", 1630, 2);
                WriteAttributeValue("", 1600, "/Depoimento/Apagar?id=", 1600, 22, true);
#line 52 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
WriteAttributeValue("", 1622, item.Id, 1622, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1631, 68, true);
                WriteLiteral(">Excluir</a>\r\n                        </td>\r\n                </tr>\r\n");
                EndContext();
#line 55 "C:\Users\46864796817\Desktop\Checkpoint\Checkpoint1\Checkpoint_PontoDigital\Views\Depoimento\ListarDepoimentos.cshtml"
                }

#line default
#line hidden
                BeginContext(1718, 535, true);
                WriteLiteral(@"            </tbody>
        </table>
    </section>
    <section class=""contato"">
        <h2>Contato</h2>
        <div class=""contato_content"">
            <p><img src=""img/telefone.png"" height=""20px"" width=""20px"" alt=""""> Tel: (11) 7454-9665</p>
            <p><img src=""img/email.png"" height=""20px"" width=""20px"" alt=""""> E-mail: pontodigital@outlook.com</p>
            <p><img src=""img/location.png"" height=""25px"" width=""20px"" alt=""""> Endereço: Avenida Paulista,nº21 - SP</p>
        </div>
    </section>

    </html>
");
                EndContext();
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
            EndContext();
            BeginContext(2260, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Checkpoint_PontoDigital.ViewModel.DepoimentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
