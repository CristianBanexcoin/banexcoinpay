#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcbe10bef5bf8d699ac5632a777661b6ca30ca90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apps_ListApps), @"mvc.1.0.view", @"/Views/Apps/ListApps.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Apps/ListApps.cshtml", typeof(AspNetCore.Views_Apps_ListApps))]
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
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\_ViewImports.cshtml"
using BTCPayServer.Models.AppViewModels;

#line default
#line hidden
#line 1 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
using BTCPayServer.Services.Apps;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcbe10bef5bf8d699ac5632a777661b6ca30ca90", @"/Views/Apps/ListApps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded28c9c4aa4680a79c38bc0250cd2d03019ed1b", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5442d3e99dbc1eddbf8521fe9b6f16c8ac0bacee", @"/Views/Apps/_ViewImports.cshtml")]
    public class Views_Apps_ListApps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListAppsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateApp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CreateNewApp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Apps", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AppsPublic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteApp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
  
    ViewData["Title"] = "Aplicaciones";

#line default
#line hidden
            BeginContext(109, 136, true);
            WriteLiteral("\r\n<section>\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                ");
            EndContext();
            BeginContext(245, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "530b0a7ff09f4a0ab7df75bf7995632a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => TempData["TempDataProperty-StatusMessage"]);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 160, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <h2 class=\"section-heading\">");
            EndContext();
            BeginContext(489, 17, false);
#line 18 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(506, 254, true);
            WriteLiteral("</h2>\r\n                <hr class=\"primary\">\r\n                <p>Crea y gestiona aplicaciones.</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row no-gutter\" style=\"margin-bottom: 5px;\">\r\n            <div class=\"col-lg-6\">\r\n                ");
            EndContext();
            BeginContext(760, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f7043ac7a28494e8f14844dd3843ebc", async() => {
                BeginContext(842, 59, true);
                WriteLiteral("<span class=\"fa fa-plus\"></span> Crear una nueva aplicación");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(905, 625, true);
            WriteLiteral(@"
                <a href=""https://docs.btcpayserver.org/features/apps"" target=""_blank""><span class=""fa fa-question-circle-o"" title=""Más información...""></span></a>
            </div>
        </div>
        <div class=""row"">
            <table class=""table table-sm table-responsive-md"">
                <thead>
                    <tr>
                        <th>Tienda</th>
                        <th>Nombre</th>
                        <th>Tipo de aplicación</th>
                        <th style=""text-align:right"">Acciones</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 41 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                     foreach (var app in Model.Apps)
                    {

#line default
#line hidden
            BeginContext(1607, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
            EndContext();
#line 45 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                 if (app.IsOwner)
                                {

#line default
#line hidden
            BeginContext(1757, 42, true);
            WriteLiteral("                                    <span>");
            EndContext();
            BeginContext(1799, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cb81690e8014f2f86c735c318a99dd3", async() => {
                BeginContext(1885, 13, false);
#line 47 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                                                                                                          Write(app.StoreName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-storeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                                                                                     WriteLiteral(app.StoreId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-storeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["storeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1902, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 48 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2019, 42, true);
            WriteLiteral("                                    <span>");
            EndContext();
            BeginContext(2062, 13, false);
#line 51 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                     Write(app.StoreName);

#line default
#line hidden
            EndContext();
            BeginContext(2075, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 52 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                }

#line default
#line hidden
            BeginContext(2119, 67, true);
            WriteLiteral("                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(2187, 11, false);
#line 54 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                           Write(app.AppName);

#line default
#line hidden
            EndContext();
            BeginContext(2198, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2238, 11, false);
#line 55 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                           Write(app.AppType);

#line default
#line hidden
            EndContext();
            BeginContext(2249, 66, true);
            WriteLiteral("</td>\r\n                            <td style=\"text-align:right\">\r\n");
            EndContext();
#line 57 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                 if (app.IsOwner)
                                {

#line default
#line hidden
            BeginContext(2401, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2437, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a483e649b774edca0a5aecc0917d686", async() => {
                BeginContext(2519, 7, true);
                WriteLiteral("Ajustes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                       WriteLiteral(app.UpdateAction);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-appId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                                                                                 WriteLiteral(app.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-appId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2530, 18, true);
            WriteLiteral("<span> - </span>\r\n");
            EndContext();
#line 60 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                }

#line default
#line hidden
            BeginContext(2583, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2615, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "619e35be86934cf7bd85729acf994257", async() => {
                BeginContext(2701, 3, true);
                WriteLiteral("Ver");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                   WriteLiteral(app.ViewAction);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-appId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                                                                                 WriteLiteral(app.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-appId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2708, 50, true);
            WriteLiteral("<span> - </span>\r\n                                ");
            EndContext();
            BeginContext(2758, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54e354eaacd24444941258e82e75ad4e", async() => {
                BeginContext(2810, 7, true);
                WriteLiteral("Retirar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-appId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                                                               WriteLiteral(app.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-appId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2821, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 65 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\Apps\ListApps.cshtml"
                    }

#line default
#line hidden
            BeginContext(2912, 88, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListAppsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591