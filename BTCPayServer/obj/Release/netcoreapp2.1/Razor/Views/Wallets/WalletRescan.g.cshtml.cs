#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b7ebd228ca101458c6cfff75049877cda06dc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallets_WalletRescan), @"mvc.1.0.view", @"/Views/Wallets/WalletRescan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wallets/WalletRescan.cshtml", typeof(AspNetCore.Views_Wallets_WalletRescan))]
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
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer;

#line default
#line hidden
#line 3 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Views;

#line default
#line hidden
#line 4 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models;

#line default
#line hidden
#line 5 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.InvoicingModels;

#line default
#line hidden
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.ManageViewModels;

#line default
#line hidden
#line 8 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.StoreViewModels;

#line default
#line hidden
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\_ViewImports.cshtml"
using BTCPayServer.Views.Wallets;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\_ViewImports.cshtml"
using BTCPayServer.Models.WalletViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b7ebd228ca101458c6cfff75049877cda06dc0", @"/Views/Wallets/WalletRescan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded28c9c4aa4680a79c38bc0250cd2d03019ed1b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1f20312169b30a46841d2ebefe3784562bcba56", @"/Views/Wallets/_ViewImports.cshtml")]
    public class Views_Wallets_WalletRescan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RescanWalletModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
  
    Layout = "../Shared/_NavLayout.cshtml";
    ViewData["Title"] = "Monedero rescan";
    ViewData.SetActivePageAndTitle(WalletsNavPages.Rescan);

#line default
#line hidden
            BeginContext(183, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(190, 17, false);
#line 8 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(207, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
 if (!Model.Ok)
{

#line default
#line hidden
            BeginContext(236, 115, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-10\">\r\n            <p>Esta característica está deshabilitada</p>\r\n");
            EndContext();
#line 15 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
             if (Model.IsFullySync)
            {

#line default
#line hidden
            BeginContext(403, 135, true);
            WriteLiteral("                <p><span class=\"fa fa-check-circle\" style=\"color:green;\"></span> <span>El nodo completo está sincronizado.</span></p>\r\n");
            EndContext();
#line 18 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(586, 135, true);
            WriteLiteral("                <p><span class=\"fa fa-times-circle\" style=\"color:red;\"></span> <span>El nodo completo no está sincronizado</span></p>\r\n");
            EndContext();
#line 22 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
            }

#line default
#line hidden
            BeginContext(736, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 23 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
             if (Model.IsServerAdmin)
            {

#line default
#line hidden
            BeginContext(790, 135, true);
            WriteLiteral("                <p><span class=\"fa fa-check-circle\" style=\"color:green;\"></span> <span>Usted es administrador del servidor</span></p>\r\n");
            EndContext();
#line 26 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(973, 136, true);
            WriteLiteral("                <p><span class=\"fa fa-times-circle\" style=\"color:red;\"></span> <span>Usted no es administrador del servidor</span></p>\r\n");
            EndContext();
#line 30 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
            }

#line default
#line hidden
            BeginContext(1124, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 31 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
             if (Model.IsSupportedByCurrency)
            {

#line default
#line hidden
            BeginContext(1186, 161, true);
            WriteLiteral("                <p><span class=\"fa fa-check-circle\" style=\"color:green;\"></span> <span>Este nodo completo soporta la reexploración del conjunto UTXO</span></p>\r\n");
            EndContext();
#line 34 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1395, 161, true);
            WriteLiteral("                <p><span class=\"fa fa-times-circle\" style=\"color:red;\"></span> <span>Este nodo completo no admite la reexploración del conjunto UTXO</span></p>\r\n");
            EndContext();
#line 38 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
            }

#line default
#line hidden
            BeginContext(1571, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 41 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
}
else if (!Model.Progress.HasValue)
{

#line default
#line hidden
            BeginContext(1641, 23, true);
            WriteLiteral("    <div class=\"row\">\r\n");
            EndContext();
#line 45 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
         if (Model.PreviousError != null)
        {

#line default
#line hidden
            BeginContext(1718, 285, true);
            WriteLiteral(@"            <div class=""alert alert-danger alert-dismissible"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <span>El escaneo anterior se detuvo con un error: ");
            EndContext();
            BeginContext(2004, 19, false);
#line 49 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
                                                             Write(Model.PreviousError);

#line default
#line hidden
            EndContext();
            BeginContext(2023, 29, true);
            WriteLiteral("</span>\r\n            </div>\r\n");
            EndContext();
#line 51 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
        }
        else if (Model.LastSuccess != null)
        {

#line default
#line hidden
            BeginContext(2119, 289, true);
            WriteLiteral(@"            <div class=""alert alert-success alert-dismissible"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <span>El escaneo anterior completado y encontrado <b>");
            EndContext();
            BeginContext(2409, 23, false);
#line 56 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
                                                                Write(Model.LastSuccess.Found);

#line default
#line hidden
            EndContext();
            BeginContext(2432, 17, true);
            WriteLiteral("</b> UTXOs en <b>");
            EndContext();
            BeginContext(2450, 16, false);
#line 56 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
                                                                                                         Write(Model.TimeOfScan);

#line default
#line hidden
            EndContext();
            BeginContext(2466, 43, true);
            WriteLiteral("</b> (El tamaño total del conjunto UTXO es ");
            EndContext();
            BeginContext(2510, 42, false);
#line 56 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
                                                                                                                                                                     Write(Model.LastSuccess.TotalSizeOfUTXOSet.Value);

#line default
#line hidden
            EndContext();
            BeginContext(2552, 30, true);
            WriteLiteral(")</span>\r\n            </div>\r\n");
            EndContext();
#line 58 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
        }

#line default
#line hidden
            BeginContext(2593, 685, true);
            WriteLiteral(@"        <div class=""col-md-8"">
            <p>
                Escanear el conjunto UTXO le permite restaurar el saldo de su billetera, pero no todo el historial de transacciones.
            </p>
            <p>
                Esta operación escaneará la ruta HD <b>0/*</b>, <b>1/*</b> and <b>*</b> from a starting index, until no UTXO are found in a whole gap limit.
            </p>
            <p>The batch size make sure the scan do not consume too much RAM at once by rescanning several time with smaller subset of addresses.</p>
            <p>If you do not understand above, just keep the default values and click on <b>Start Scan</b></p>
        </div>
    </div>
");
            EndContext();
            BeginContext(3280, 67, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(3347, 757, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfcb48428a80408496a1ebb9a345d087", async() => {
                BeginContext(3367, 64, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(3431, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1494acc6fc845cbbf554c14320d8aed", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 75 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StartingIndex);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3470, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3492, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67bab61485b34bf7a048442d24b72f47", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 76 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StartingIndex);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3560, 88, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(3648, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054ccffed6e943f196fd7f4245186669", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 79 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GapLimit);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3682, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3704, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85de25cc2a8a4f05a8a53ed8678d5d1b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 80 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GapLimit);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3767, 88, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(3855, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b02ea1b51a412993ad8e84685b9447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 83 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BatchSize);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3890, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(3912, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7aca28e3d8cb4fbbb43b7d03891b8900", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 84 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BatchSize);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3976, 121, true);
                WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary\">Start scan</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4104, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 90 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4146, 150, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-10\">\r\n            <p>Scanning in progress, refresh the page to see the progress... (Estimated time: ");
            EndContext();
            BeginContext(4297, 19, false);
#line 95 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
                                                                                         Write(Model.RemainingTime);

#line default
#line hidden
            EndContext();
            BeginContext(4316, 103, true);
            WriteLiteral(")</p>\r\n            <div class=\"progress\">\r\n                <div class=\"progress-bar\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 4419, "\"", 4458, 1);
#line 97 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
WriteAttributeValue("", 4435, Model.Progress.Value, 4435, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4459, 60, true);
            WriteLiteral("\r\n                     aria-valuemin=\"0\" aria-valuemax=\"100\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4519, "\"", 4622, 9);
            WriteAttributeValue("", 4527, "white-space:", 4527, 12, true);
            WriteAttributeValue(" ", 4539, "nowrap;", 4540, 8, true);
            WriteAttributeValue(" ", 4547, "overflow:", 4548, 10, true);
            WriteAttributeValue(" ", 4557, "hidden;", 4558, 8, true);
            WriteAttributeValue(" ", 4565, "text-overflow:", 4566, 15, true);
            WriteAttributeValue(" ", 4580, "ellipsis;", 4581, 10, true);
            WriteAttributeValue(" ", 4590, "width:", 4591, 7, true);
#line 98 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
WriteAttributeValue("", 4597, Model.Progress.Value, 4597, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 4620, "%;", 4620, 2, true);
            EndWriteAttribute();
            BeginContext(4623, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(4648, 20, false);
#line 99 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
                Write(Model.Progress.Value);

#line default
#line hidden
            EndContext();
            BeginContext(4669, 19, true);
            WriteLiteral("% (estimated time: ");
            EndContext();
            BeginContext(4689, 19, false);
#line 99 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
                                                         Write(Model.RemainingTime);

#line default
#line hidden
            EndContext();
            BeginContext(4708, 75, true);
            WriteLiteral(")\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 104 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Wallets\WalletRescan.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RescanWalletModel> Html { get; private set; }
    }
}
#pragma warning restore 1591