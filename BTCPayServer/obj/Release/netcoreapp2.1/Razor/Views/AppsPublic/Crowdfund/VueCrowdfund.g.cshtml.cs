#pragma checksum "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\AppsPublic\Crowdfund\VueCrowdfund.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d70e45122d67a70d3f51118076814f552478033b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppsPublic_Crowdfund_VueCrowdfund), @"mvc.1.0.view", @"/Views/AppsPublic/Crowdfund/VueCrowdfund.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AppsPublic/Crowdfund/VueCrowdfund.cshtml", typeof(AspNetCore.Views_AppsPublic_Crowdfund_VueCrowdfund))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70e45122d67a70d3f51118076814f552478033b", @"/Views/AppsPublic/Crowdfund/VueCrowdfund.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded28c9c4aa4680a79c38bc0250cd2d03019ed1b", @"/Views/_ViewImports.cshtml")]
    public class Views_AppsPublic_Crowdfund_VueCrowdfund : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 46, true);
            WriteLiteral("<div class=\"container p-0\" id=\"app\" v-cloak>\r\n");
            EndContext();
#line 2 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\AppsPublic\Crowdfund\VueCrowdfund.cshtml"
     if(!Model.Enabled) 
    {

#line default
#line hidden
            BeginContext(79, 157, true);
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\" style=\"text-align: center;\">\r\n        ¡Esta página de crowdfund no se puede ver públicamente!\r\n    </div>\r\n");
            EndContext();
#line 7 "C:\Users\Rolando\Desktop\BTCPAY\banexcoinpay-master-github\banexcoinpay\BTCPayServer\Views\AppsPublic\Crowdfund\VueCrowdfund.cshtml"
    }

#line default
#line hidden
            BeginContext(243, 16944, true);
            WriteLiteral(@"    <div class=""row h-100 w-100 py-sm-0 py-md-4 mx-0"">
        <div class=""card w-100 p-0 mx-0"">
            <img class=""card-img-top"" :src=""srvModel.mainImageUrl"" v-if=""srvModel.mainImageUrl"" id=""crowdfund-main-image"">
            <div class=""d-flex justify-content-between px-2"" id=""crowdfund-header-container"">
                <h1>
                    {{srvModel.title}} 
                    <span class=""h6 text-muted"" v-if=""!started && srvModel.startDate"" v-b-tooltip :title=""startDate"" id=""crowdfund-header-start-date"">
                        Empieza en {{startDiff}}
                    </span>
                    <span class=""h6 text-muted"" v-else-if=""started && !ended && srvModel.endDate"" v-b-tooltip :title=""endDate"" id=""crowdfund-header-end-date"">
                        Termina en {{endDiff}}
                    </span>
                    <span class=""h6 text-muted"" v-else-if=""started && !ended && !srvModel.endDate"" v-b-tooltip title=""No set end date"" id=""crowdfund-header-active"">
         ");
            WriteLiteral(@"               ¡Actualmente activo!
                    </span>

                </h1>

                <span v-if=""srvModel.targetAmount"" class=""mt-3"" id=""crowdfund-header-target"">
                    <span class=""h5"" id=""crowdfund-header-target-amount"">{{srvModel.targetAmount}} {{targetCurrency}}</span>
                    <span v-if=""srvModel.resetEvery !== 'Never'"" 
                          id=""crowdfund-header-target-dynamic""
                          v-b-tooltip 
                          :title=""'Goal resets every ' + srvModel.resetEveryAmount + ' ' + srvModel.resetEvery + ((srvModel.resetEveryAmount>1)?'s': '')""  >Dynamic </span>
                    <span v-if=""srvModel.enforceTargetAmount"" 
                          id=""crowdfund-header-target-softcap"">Hardcap Goal <span class=""fa fa-question-circle"" v-b-tooltip title=""No contributions allowed after the goal has been reached""></span></span>
                    <span v-else 
                          id=""crowdfund-header-target-hardcap""");
            WriteLiteral(@">Softcap Goal <span class=""fa fa-question-circle"" v-b-tooltip title=""Contributions allowed even after goal is reached""></span> </span>
                </span>


            </div>
            <div class=""progress w-100 rounded-0 "" v-if=""srvModel.targetAmount"" 
                 id=""crowdfund-progress-bar"">
                <div class=""progress-bar"" role=""progressbar""
                     :aria-valuenow=""srvModel.info.progressPercentage""
                     v-bind:style=""{ width: srvModel.info.progressPercentage + '%' }""
                     aria-valuemin=""0""
                     id=""crowdfund-progress-bar-confirmed-bar""
                     v-b-tooltip :title=""parseFloat(srvModel.info.progressPercentage).toFixed(2) + '% contributions'""
                     aria-valuemax=""100"">
                </div>
                <div class=""progress-bar bg-warning"" role=""progressbar""
                     id=""crowdfund-progress-bar-pending-bar""
                     :aria-valuenow=""srvModel.info.pendingProgre");
            WriteLiteral(@"ssPercentage""
                     v-bind:style=""{ width: srvModel.info.pendingProgressPercentage + '%' }""
                     v-b-tooltip :title=""parseFloat(srvModel.info.pendingProgressPercentage).toFixed(2) + '% contributions pending confirmation'""
                     aria-valuemin=""0""
                     aria-valuemax=""100"">
                </div>
            </div>
           
            <div class=""card-body"">
                <div class=""row py-2 text-center crowdfund-stats"">
                    <div class=""col-sm border-right"" id=""crowdfund-body-raised-amount"">
                        <h5>{{ raisedAmount }} {{targetCurrency}} </h5>
                        <h5 class=""text-muted"">Elevar</h5>
                    </div>
                    <div  class=""col-sm  border-right"" id=""crowdfund-body-goal-raised"">
                        <h5>{{ percentageRaisedAmount }}%</h5>
                        <h5 class=""text-muted"">De objetivo</h5>
                    </div>
                    <div  c");
            WriteLiteral(@"lass=""col-sm  border-right"" id=""crowdfund-body-total-contributors"">
                        <h5>
                            {{srvModel.info.totalContributors}}
                        </h5>
                        <h5 class=""text-muted"">Contribuyentes</h5>
                    </div> 
                    <div  class=""col-sm  border-right"" v-if=""startDiff"" id=""crowdfund-body-campaign-dates-not-started"">
                        <h5>
                            {{startDiff}}
                        </h5>
                        <h5 class=""text-muted"">Izquierda para comenzar</h5>
                        
                        <b-tooltip target=""crowdfund-body-campaign-dates-not-started"" >
                            <ul class=""p-0"">
                                <li v-if=""startDate"" class=""list-unstyled"">
                                    {{started? ""Started"" : ""Starts""}} {{startDate}}
                                </li>
                                <li v-if=""endDate"" class=""list-unsty");
            WriteLiteral(@"led"">
                                    {{ended? ""Ended"" : ""Ends""}} {{endDate}}
                                </li>
                            </ul>
                        </b-tooltip>
                    </div>
                    <div  class=""col-sm  border-right"" v-if=""endDiff"" id=""crowdfund-body-campaign-dates-started"">
                        <h5>
                            {{endDiff}}
                        </h5>
                        <h5 class=""text-muted"">Izquierda</h5>
                        <b-tooltip target=""crowdfund-body-campaign-dates-started"" >
                            <ul class=""p-0"">
                                <li v-if=""startDate"" class=""list-unstyled"">
                                    {{started? ""Started"" : ""Starts""}} {{startDate}}
                                </li>
                                <li v-if=""endDate"" class=""list-unstyled"">
                                    {{ended? ""Ended"" : ""Ends""}} {{endDate}}
                                </li");
            WriteLiteral(@">
                            </ul>
                        </b-tooltip>
                    </div>
                    <div  class=""col-sm border-right"" v-if=""ended"" id=""crowdfund-body-campaign-dates-not-active"">
                        <h5>
                            Campaña
                        </h5>
                        <h5 >No activo</h5>
                        
                        <b-tooltip target=""crowdfund-body-campaign-dates-not-active"" >
                            <ul class=""p-0"">
                                <li v-if=""startDate"" class=""list-unstyled"">
                                    {{started? ""Started"" : ""Starts""}} {{startDate}}
                                </li>
                                <li v-if=""endDate"" class=""list-unstyled"">
                                    {{ended? ""Ended"" : ""Ends""}} {{endDate}}
                                </li>
                            </ul>
                        </b-tooltip>
                    </div>
         ");
            WriteLiteral(@"       </div>
                
                <b-tooltip target=""crowdfund-body-raised-amount"" v-if=""paymentStats && paymentStats.length > 0"">
                    <ul class=""p-0 text-uppercase"">
                        <li v-for=""stat of paymentStats"" class=""list-unstyled"">
                            
                            {{stat.label}} <span v-if=""stat.lightning"" class=""fa fa-bolt""></span> {{stat.value}}
                        </li>
                    </ul>
                </b-tooltip>      
                <b-tooltip target=""crowdfund-body-goal-raised""  v-if=""srvModel.resetEvery !== 'Never'"">
                    El objetivo se reinicia cada {{srvModel.resetEveryAmount}} {{srvModel.resetEvery}} {{srvModel.resetEveryAmount>1?'s': ''}}
                </b-tooltip>
                
               
                <div class=""card-title"" id=""crowdfund-body-header"">

                    <div class=""row"">
                        <div class=""col-sm-12 col-md-8 col-lg-9"" id=""crowdfund-bo");
            WriteLiteral(@"dy-header-tagline-container"">
                            <h2 class=""text-muted"" v-if=""srvModel.tagline"" id=""crowdfund-body-header-tagline"">{{srvModel.tagline}}</h2>
                        </div>
                        <div class=""col-sm-12 col-md-4 col-lg-3"" id=""crowdfund-body-header-cta-container"">
                            <button v-if=""active"" id=""crowdfund-body-header-cta"" class=""btn btn-lg btn-primary w-100 font-weight-bold"" v-on:click=""contributeModalOpen = true"">Contribuir</button>
                        </div>
                    </div>
                </div>
                <template v-if=""srvModel.disqusEnabled"">
                    <b-tabs>
                        <b-tab title=""Details""active>
                            <div class=""row mt-2"">
                                <div class=""col-md-8 col-sm-12"" id=""crowdfund-body-description-container"">
                                    <div class=""card-text overflow-hidden"" v-html=""srvModel.description"" id=""crowdfund-body-descripti");
            WriteLiteral(@"on""></div>
                                </div>
                                <div class=""col-md-4 col-sm-12"" id=""crowdfund-body-contribution-container"">
                                    <contribute :target-currency=""srvModel.targetCurrency""
                                                :display-perks-ranking=""srvModel.displayPerksRanking""
                                                :active=""active""
                                                :loading=""loading""
                                                :in-modal=""false""
                                                :perks=""perks"">
    
                                    </contribute>
                                </div>
                            </div>
                        </b-tab>
                        <b-tab title=""Discussion"" >
                            <div id=""disqus_thread"" class="" mt-2""></div>
                        </b-tab>
                    </b-tabs>
                    
                </tem");
            WriteLiteral(@"plate>
                <template v-else>
                    <hr/>
                    <div class=""row mt-2"">
                        <div class=""col-md-8 col-sm-12"" id=""crowdfund-body-description-container"">
                            <div class=""card-text overflow-hidden"" v-html=""srvModel.description"" id=""crowdfund-body-description""></div>
                        </div>
                        <div class=""col-md-4 col-sm-12"" id=""crowdfund-body-contribution-container"">
                            <contribute :target-currency=""srvModel.targetCurrency""
                                        :loading=""loading""
                                        :display-perks-ranking=""srvModel.displayPerksRanking""
                                        :active=""active""
                                        :in-modal=""false""
                                        :perks=""perks"">
    
                            </contribute>
                        </div>
                    </div>
                </");
            WriteLiteral(@"template>
            </div>
            <div class=""card-footer text-muted d-flex"" v-if=""srvModel.animationsEnabled || srvModel.soundsEnabled"">
              
                <div class=""align-self-end pr-4"">Actualizado {{lastUpdated}}</div>
                <div class=""form-check mx-1""  v-if=""srvModel.animationsEnabled || animation"">
                    <input class=""form-check-input"" type=""checkbox"" id=""cbAnime"" v-model=""animation"">
                    <label class=""form-check-label"" for=""cbAnime"">
                        Animaciones
                    </label>
                </div>
                <div class=""form-check mx-1""  v-if=""srvModel.soundsEnabled|| sound"">
                    <input class=""form-check-input"" type=""checkbox""  id=""cbSounds"" v-model=""sound"">
                    <label class=""form-check-label"" for=""cbSounds"">
                        Sonidos
                    </label>
                </div>
            </div>
        </div>
    </div>
    <b-modal title=""Contribu");
            WriteLiteral(@"te"" v-model=""contributeModalOpen"" size=""lg"" ok-only=""true"" ok-variant=""secondary"" ok-title=""Close"" ref=""modalContribute"">
        <contribute v-if=""contributeModalOpen""
                    :target-currency=""srvModel.targetCurrency""
                    :active=""active""
                    :perks=""srvModel.perks""
                    :loading=""loading""
                    :in-modal=""true"">
        </contribute>
    </b-modal>

</div>

<script type=""text/x-template"" id=""perks-template"">
<div class=""perks-container"">
    <perk v-if=""!perks || perks.length ===0"" 
        :perk=""{title: 'Donate Custom Amount', price: { value: null}, custom: true}"" 
        :target-currency=""targetCurrency"" 
        :active=""active"" 
        :loading=""loading""
        :in-modal=""inModal"">
    </perk>
    <perk v-for=""(perk, index) in perks"" :perk=""perk"" :key=""perk.id"" 
        :target-currency=""targetCurrency"" 
        :active=""active"" 
        :display-perks-ranking=""displayPerksRanking"" 
        :index=""ind");
            WriteLiteral(@"ex""
        :loading=""loading""
        :in-modal=""inModal"">
    </perk>
</div>
</script>

<script type=""text/x-template"" id=""perk-template""> 
<div class=""card mb-4 perk""  v-bind:class=""{ 'expanded': expanded, 'unexpanded': !expanded }"" v-on:click=""expand"" :id=""perk.id"">
<span v-if=""displayPerksRanking && perk.sold"" 
    class=""btn btn-sm rounded-circle px-0 perk-badge"" 
    v-bind:class=""{ 'btn-primary': index==0, 'btn-secondary': index!=0}"">#{{index+1}}</span> 
         

    <div class=""perk-zoom "" v-if=""canExpand"">
        <div class=""perk-zoom-bg bg-primary""> </div>
        <div class=""perk-zoom-text w-100 text-center text-white font-weight-bold"">
            Seleccione esta contribución perk
        </div>
    </div>
    <form v-on:submit='onContributeFormSubmit'>
        <input type=""hidden"" :value=""perk.id"" id=""choiceKey""/> 
        <img v-if=""perk.image && perk.image != 'null' ""  class=""card-img-top"" :src=""perk.image"" />
        <div class=""card-body"">
            <div class=""c");
            WriteLiteral(@"ard-title d-flex justify-content-between"" >
                <span class=""h5"">{{perk.title? perk.title : perk.id}} </span>
                <span class=""text-muted"" > 
                    <template v-if=""perk.price.value"">{{perk.price.value.noExponents()}} 
                        {{targetCurrency}} 
                        <template v-if=""perk.custom"">or more</template>
                    </template>
                    <template v-else-if=""!perk.price.value && perk.custom"">
                        Cualquier cantidad
                    </template>
                    
                </span>
            </div>
            <p  class=""card-text overflow-hidden"" v-if=""perk.description"" v-html=""perk.description""></p>
            
            <div class=""input-group"" style=""max-width: 500px;"" v-if=""expanded"" :id=""'perk-form'+ perk.id"">
                <input 
                    :disabled=""!active""
                    :readonly=""!perk.custom""
                    class=""form-control"" 
         ");
            WriteLiteral(@"           type=""number"" 
                    v-model=""amount""
                    :min=""perk.price.value""  
                    step=""any""  
                    placeholder=""Cantidad de la contribución""
                    required >
                <div class=""input-group-append"">                    
                    <span class='input-group-text'>{{targetCurrency}}</span>
                    <button 
                        class=""btn btn-primary"" 
                        v-bind:class=""{ 'btn-disabled': loading}""
                        :disabled=""!active || loading"" 
                        type=""submit"">
                         <div v-if=""loading""  class=""spinner-grow spinner-grow-sm""   role=""status"">
                            <span class=""sr-only"">Cargando...</span>
                        </div>
                        Continuar
                    </button>
                </div>
            </div>
        </div>
        <div class=""card-footer d-flex justify-content-between");
            WriteLiteral(@""" v-if=""perk.sold"">
           <span ></span>
           <span x >{{perk.sold}} Contribuyente{{perk.sold > 1? ""s"": """"}}</span>
        </div>
    </form>
</div> 
</script>


<script type=""text/x-template"" id=""contribute-template"">
  <div>
    <h3 v-if=""!inModal"" class=""mb-3"">Contribuir</h3>
    <perks 
        :perks=""perks"" 
        :loading=""loading""
        :in-modal=""inModal""
        :display-perks-ranking=""displayPerksRanking""
        :target-currency=""targetCurrency"" 
        :active=""active"">
     </perks>
  </div>
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
