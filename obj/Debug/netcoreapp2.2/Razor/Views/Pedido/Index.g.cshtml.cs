#pragma checksum "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff340476275fd7f3ac6d560c1a1bd3172d78811"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff340476275fd7f3ac6d560c1a1bd3172d78811", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 29, true);
            WriteLiteral("<main>\r\n        <h2>Pede aí, ");
            EndContext();
            BeginContext(78, 17, false);
#line 3 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                Write(Model.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(95, 16, true);
            WriteLiteral("!</h2>\r\n        ");
            EndContext();
            BeginContext(111, 2213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff340476275fd7f3ac6d560c1a1bd3172d788114485", async() => {
                BeginContext(174, 175, true);
                WriteLiteral("\r\n            <div>\r\n                <label for=\"nome\">Nome Completo</label>\r\n                <br />\r\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 349, "\"", 376, 1);
#line 8 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 357, Model.Cliente.Nome, 357, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(377, 214, true);
                WriteLiteral(" name=\"nome\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"endereco\">Endereço</label>\r\n                <br />\r\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 591, "\"", 622, 1);
#line 14 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 599, Model.Cliente.Endereco, 599, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(623, 230, true);
                WriteLiteral(" name=\"endereco\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"telefone\">Telefone para contato</label>\r\n                <br />\r\n                <input id=\"telefone\" type=\"text\" placeholder=\"11 12345 6789\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 853, "\"", 884, 1);
#line 20 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 861, Model.Cliente.Telefone, 861, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(885, 195, true);
                WriteLiteral(" name=\"telefone\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"email\">E-mail</label>\r\n                <br />\r\n                <input id=\"email\" type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1080, "\"", 1108, 1);
#line 26 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1088, Model.Cliente.Email, 1088, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1109, 250, true);
                WriteLiteral("/>\r\n            </div>\r\n\r\n            <div class=\"double-field\">\r\n                <div>\r\n                    <label for=\"hamburguer\">Hamburguer</label>\r\n                    <select id=\"hamburguer\" name=\"hamburguer\" required>\r\n                        ");
                EndContext();
                BeginContext(1359, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff340476275fd7f3ac6d560c1a1bd3172d788117750", async() => {
                    BeginContext(1394, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1412, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                         foreach (var hamburguer in Model.Hamburgueres)
                        {

#line default
#line hidden
                BeginContext(1514, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1542, 142, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff340476275fd7f3ac6d560c1a1bd3172d7881110233", async() => {
                    BeginContext(1574, 15, false);
#line 36 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                      Write(hamburguer.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1589, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1595, 16, false);
#line 36 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                                           Write(hamburguer.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1611, 64, true);
                    WriteLiteral("\r\n                                \r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                              WriteLiteral(hamburguer.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1684, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1713, 210, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"shake\">Shake</label>\r\n                    <select id=\"shake\" name=\"shake\">\r\n                        ");
                EndContext();
                BeginContext(1923, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff340476275fd7f3ac6d560c1a1bd3172d7881113434", async() => {
                    BeginContext(1958, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1976, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                         foreach (var s in Model.Shakes)
                        {

#line default
#line hidden
                BeginContext(2063, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2091, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff340476275fd7f3ac6d560c1a1bd3172d7881115902", async() => {
                    BeginContext(2114, 6, false);
#line 48 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                             Write(s.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2120, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2126, 7, false);
#line 48 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                                                         Write(s.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 48 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                              WriteLiteral(s.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2142, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 49 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2171, 146, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n            <input type=\"submit\" value=\"Finalizar pedido!\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 4 "C:\Users\24055965800\Documents\Exercicios\MVC\McBonaldsMVC\Views\Pedido\Index.cshtml"
AddHtmlAttributeValue("", 139, Url.Action("Registrar","Pedido"), 139, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2324, 15, true);
            WriteLiteral("\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
