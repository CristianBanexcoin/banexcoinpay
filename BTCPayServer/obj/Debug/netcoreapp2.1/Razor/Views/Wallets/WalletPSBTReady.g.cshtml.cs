#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d776b34e716c5df0b35e63d405b6cd10c7744ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallets_WalletPSBTReady), @"mvc.1.0.view", @"/Views/Wallets/WalletPSBTReady.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wallets/WalletPSBTReady.cshtml", typeof(AspNetCore.Views_Wallets_WalletPSBTReady))]
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
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer;

#line default
#line hidden
#line 3 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Views;

#line default
#line hidden
#line 4 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models;

#line default
#line hidden
#line 5 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.InvoicingModels;

#line default
#line hidden
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.ManageViewModels;

#line default
#line hidden
#line 8 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\_ViewImports.cshtml"
using BTCPayServer.Models.StoreViewModels;

#line default
#line hidden
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\_ViewImports.cshtml"
using BTCPayServer.Views.Wallets;

#line default
#line hidden
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\_ViewImports.cshtml"
using BTCPayServer.Models.WalletViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d776b34e716c5df0b35e63d405b6cd10c7744ce", @"/Views/Wallets/WalletPSBTReady.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92ba4c5be7894d31e45019b21d323a2a5285d5b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d44b91123f6bbf8f201b311de8a5e69133cd11f", @"/Views/Wallets/_ViewImports.cshtml")]
    public class Views_Wallets_WalletPSBTReady : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalletPSBTReadyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WalletPSBTReady", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
  
    Layout = "../Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(78, 38, true);
            WriteLiteral("<section>\n    <div class=\"container\">\n");
            EndContext();
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
         if (Model.GlobalError != null)
        {

#line default
#line hidden
            BeginContext(166, 239, true);
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible\" role=\"alert\">\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n                <span>");
            EndContext();
            BeginContext(406, 17, false);
#line 11 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                 Write(Model.GlobalError);

#line default
#line hidden
            EndContext();
            BeginContext(423, 33, true);
            WriteLiteral("</span><br />\n            </div>\n");
            EndContext();
#line 13 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
        }

#line default
#line hidden
            BeginContext(466, 179, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-lg-12 text-center\">\n                <h2 class=\"section-heading\">Transaction review</h2>\n                <hr class=\"primary\">\n");
            EndContext();
#line 18 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                 if (Model.CanCalculateBalance)
                {

#line default
#line hidden
            BeginContext(711, 109, true);
            WriteLiteral("                    <p>\n                        If you broadcast this transaction, your balance will change: ");
            EndContext();
#line 21 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                                                      if (Model.Positive)
                        {

#line default
#line hidden
            BeginContext(867, 55, true);
            WriteLiteral("                            <span style=\"color:green;\">");
            EndContext();
            BeginContext(923, 19, false);
#line 23 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                  Write(Model.BalanceChange);

#line default
#line hidden
            EndContext();
            BeginContext(942, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 24 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1031, 53, true);
            WriteLiteral("                            <span style=\"color:red;\">");
            EndContext();
            BeginContext(1085, 19, false);
#line 27 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                Write(Model.BalanceChange);

#line default
#line hidden
            EndContext();
            BeginContext(1104, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 28 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                        }

#line default
#line hidden
            BeginContext(1137, 52, true);
            WriteLiteral(", do you want to continue?\n                    </p>\n");
            EndContext();
#line 30 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1246, 122, true);
            WriteLiteral("                    <p>This PSBT is already finalized. We can\'t properly detect which input or output belongs to you.</p>\n");
            EndContext();
#line 34 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                }

#line default
#line hidden
            BeginContext(1386, 617, true);
            WriteLiteral(@"            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3 text-center""></div>
            <div class=""col-lg-6 text-center"">
                <table class=""table table-sm table-responsive-lg"">
                    <thead class=""thead-inverse"">
                        <tr>
                            <th style=""text-align:left"" class=""col-md-auto"">
                                Destination
                            </th>
                            <th style=""text-align:right"">Amount</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 50 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                         foreach (var destination in Model.Destinations)
                        {

#line default
#line hidden
            BeginContext(2102, 93, true);
            WriteLiteral("                            <tr>\n                                <td style=\"text-align:left\">");
            EndContext();
            BeginContext(2196, 23, false);
#line 53 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                       Write(destination.Destination);

#line default
#line hidden
            EndContext();
            BeginContext(2219, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 54 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                 if (destination.Positive)
                                {

#line default
#line hidden
            BeginContext(2318, 79, true);
            WriteLiteral("                                    <td style=\"text-align:right; color:green;\">");
            EndContext();
            BeginContext(2398, 19, false);
#line 56 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                                          Write(destination.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(2417, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 57 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2528, 77, true);
            WriteLiteral("                                    <td style=\"text-align:right; color:red;\">");
            EndContext();
            BeginContext(2606, 19, false);
#line 60 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                                        Write(destination.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(2625, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 61 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                }

#line default
#line hidden
            BeginContext(2665, 34, true);
            WriteLiteral("                            </tr>\n");
            EndContext();
#line 63 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                        }

#line default
#line hidden
            BeginContext(2725, 141, true);
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n            <div class=\"col-lg-3 text-center\"></div>\n        </div>\n");
            EndContext();
#line 69 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
         if (Model.FeeRate != null)
        {

#line default
#line hidden
            BeginContext(2912, 204, true);
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col-lg-3 text-center\"></div>\n                <div class=\"col-lg-6 text-right\">\n                    <p class=\"text-muted\">Transaction fee rate: <b>");
            EndContext();
            BeginContext(3117, 13, false);
#line 74 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                              Write(Model.FeeRate);

#line default
#line hidden
            EndContext();
            BeginContext(3130, 108, true);
            WriteLiteral("</b></p>\n                </div>\n                <div class=\"col-lg-3 text-center\"></div>\n            </div>\n");
            EndContext();
#line 78 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
        }

#line default
#line hidden
            BeginContext(3248, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 79 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
         if (Model.Errors != null)
        {

#line default
#line hidden
            BeginContext(3293, 934, true);
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <h4>Errors</h4>
                    <p>
                        This PSBT can't be finalized for broadcast. Please review the errors.
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-3 text-center""></div>
                <div class=""col-lg-6 text-center"">
                    <table class=""table table-sm table-responsive-lg"">
                        <thead class=""thead-inverse"">
                            <tr>
                                <th style=""text-align:left"" class=""col-md-1"">
                                    Input index
                                </th>
                                <th style=""text-align:right"">Error</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 102 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                             foreach (var err in Model.Errors)
                            {

#line default
#line hidden
            BeginContext(4320, 101, true);
            WriteLiteral("                                <tr>\n                                    <td style=\"text-align:left\">");
            EndContext();
            BeginContext(4422, 9, false);
#line 105 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                                                           Write(err.Index);

#line default
#line hidden
            EndContext();
            BeginContext(4431, 123, true);
            WriteLiteral("</td>\n                                    <td style=\"text-align:right; color:red;\"><span class=\"fa fa-exclamation-triangle\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 4554, "\"", 4572, 1);
#line 106 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
WriteAttributeValue("", 4562, err.Error, 4562, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4573, 52, true);
            WriteLiteral("></span></td>\n                                </tr>\n");
            EndContext();
#line 108 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                            }

#line default
#line hidden
            BeginContext(4655, 161, true);
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n                <div class=\"col-lg-3 text-center\"></div>\n            </div>\n");
            EndContext();
#line 114 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
        }

#line default
#line hidden
            BeginContext(4826, 90, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-lg-12 text-center\">\n                ");
            EndContext();
            BeginContext(4916, 628, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8040c05b23040799ff342b3c1a45937", async() => {
                BeginContext(4965, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(4986, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd88fac49dd3458098da6e7bcad26f16", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 118 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PSBT);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5024, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(5045, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55278973daa84f9096327639410664b1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 119 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SigningKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5089, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(5110, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a5b237a330141709c2aba4a056da89f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 120 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SigningKeyPath);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5158, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 121 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                     if (Model.Errors == null)
                    {

#line default
#line hidden
                BeginContext(5228, 143, true);
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\" name=\"command\" value=\"broadcast\">Broadcast it</button> <span> or </span>\n");
                EndContext();
#line 124 "C:\Users\Rolando\Desktop\BTCPAY\btcpayserver-master\btcpayserver-master\BTCPayServer\Views\Wallets\WalletPSBTReady.cshtml"
                    }

#line default
#line hidden
                BeginContext(5393, 144, true);
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-secondary\" name=\"command\" value=\"analyze-psbt\">Export as PSBT</button>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5544, 57, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalletPSBTReadyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
