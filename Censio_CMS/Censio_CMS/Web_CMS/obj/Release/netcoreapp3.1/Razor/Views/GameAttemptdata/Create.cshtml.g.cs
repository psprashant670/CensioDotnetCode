#pragma checksum "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa850a499c0ba9211c224bb4041b717adece075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameAttemptdata_Create), @"mvc.1.0.view", @"/Views/GameAttemptdata/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa850a499c0ba9211c224bb4041b717adece075", @"/Views/GameAttemptdata/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_GameAttemptdata_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Censio_CMS.Models.GameAttemptdataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("push"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Jquery3.5.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.sumoselect.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sumoselect.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AppJavascript/GameAttemptdata.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"block full\">\r\n    <div class=\"block-title\">\r\n        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 220, "\"", 285, 3);
            WriteAttributeValue("", 230, "location.href=\'", 230, 15, true);
#nullable restore
#line 9 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
WriteAttributeValue("", 245, Url.Action("Index", "GameAttemptdata"), 245, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 284, "\'", 284, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" style=\"float: right; margin: 0; margin-right: 10px; margin-top: 9px; padding: 1px 13px;\" data-dismiss=\"modal\" aria-hidden=\"true\">Back</button>\r\n        <h2><strong>");
#nullable restore
#line 10 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
               Write(ViewBag.modelTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Game Attemptdata</strong> </h2>\r\n    </div>\r\n    <div class=\"table-responsive\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa850a499c0ba9211c224bb4041b717adece0757686", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"modal-body\">\r\n                <div id=\"myAlert\">\r\n                </div>\r\n                <div class=\"loader \"> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6aa850a499c0ba9211c224bb4041b717adece0758096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-6 col-sm-offset-3\">\r\n                        <div class=\"form-group\">\r\n                            <label for=\"Industry_Name\">Game Name</label>\r\n                            ");
#nullable restore
#line 24 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.IdAttempt, new { @id = "IdAttempt", @style = "display: none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.IdGame, new SelectList(Model.GameList, "Value", "Text"), "", new { @id = "IdGame", @class = "form-control", @onchange = "FillChallenge()" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n");
#nullable restore
#line 28 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                         if (@ViewBag.modelTitle == "Edit")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <label for=\"Industry_Name\">Challenge Name</label>\r\n\r\n                                ");
#nullable restore
#line 33 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                           Write(Html.DropDownListFor(m => m.IdLevel, new SelectList(Model.ChallengeNameList, "Value", "Text"), "", new { @id = "IdLevel", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n");
#nullable restore
#line 36 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <label for=\"checkout-payment-name\">Challenge Name</label>\r\n                                ");
#nullable restore
#line 41 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                           Write(Html.DropDownListFor(m => m.IdLevel, new SelectList(Enumerable.Empty<SelectListItem>(), "IdLevel", "ChallengeName"), "", new { @id = "IdLevel", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n");
#nullable restore
#line 44 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        \r\n                        <div class=\"form-group\">\r\n                            <label for=\"Industry_Name\">Behavior Element</label>\r\n\r\n                            ");
#nullable restore
#line 50 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.IdBehavior, new SelectList(Model.BehaviorElementNameList, "Value", "Text"), "", new { @id = "IdBehavior", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        \r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">AttemptNo</label>\r\n                            ");
#nullable restore
#line 57 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.AttemptNo, new { @id = "AttemptNo", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">GoldCoins</label>\r\n                            ");
#nullable restore
#line 62 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.GoldCoins, new { @id = "GoldCoins", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">BehaviorScore</label>\r\n                            ");
#nullable restore
#line 68 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.BehaviorScore, new { @id = "BehaviorScore", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">TimeInSecond</label>\r\n                            ");
#nullable restore
#line 75 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.TimeInSecond, new { @id = "TimeInSecond", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">ChallengeCompletedTime1</label>\r\n                            ");
#nullable restore
#line 82 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.ChallengeCompletedTime1, new { @id = "ChallengeCompletedTime1", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">RewardCoinsTime1</label>\r\n                            ");
#nullable restore
#line 88 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.RewardCoinsTime1, new { @id = "RewardCoinsTime1", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">ChallengeCompletedTime2</label>\r\n                            ");
#nullable restore
#line 94 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.ChallengeCompletedTime2, new { @id = "ChallengeCompletedTime2", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">RewardCoinsTime2</label>\r\n                            ");
#nullable restore
#line 100 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.RewardCoinsTime2, new { @id = "RewardCoinsTime2", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">FailAttemptMessage</label>\r\n                            ");
#nullable restore
#line 106 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.FailAttemptMessage, new { @id = "FailAttemptMessage", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">SuccessAttemptMessage</label>\r\n                            ");
#nullable restore
#line 115 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.SuccessAttemptMessage, new { @id = "SuccessAttemptMessage", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"checkout-payment-name\">Status</label>\r\n                            ");
#nullable restore
#line 122 "D:\TGC Production CMS\Censio_CMS\Web_CMS\Views\GameAttemptdata\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.IsActive, new List<SelectListItem>
                                   {
                                   new SelectListItem{ Text="Active", Value = "A" },
                                   new SelectListItem{ Text="Deactive", Value = "D" }}, new { @class = "form-control", @style = "width:100%;", @id = "IsActive" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>

                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btn"" class=""btn btn-effect-ripple btn-sm btn-success"">Save</button>
                <button type=""button"" onclick=""Close();"" class=""btn btn-effect-ripple btn-sm btn-danger"">Cancel</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa850a499c0ba9211c224bb4041b717adece07520680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa850a499c0ba9211c224bb4041b717adece07521720", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6aa850a499c0ba9211c224bb4041b717adece07522760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>
    $(document).ready(function () {


        $('#btn').on('click', function () {
            debugger;
            var valid = $(""#form"").valid();
            if (valid == true) {
                AddEdit();
            }
        });
    
       
          
        $(""#Acclimateform"").validate({
                //rules: {


                //    Url: ""required"",
                //    IsActive: ""required"",

                //},
                //messages: {


                //    Url: ""Please Uploade Image "",
                //    IsActive: ""Please Select a Status"",
                //}
            })
    });



</script>

<style type=""text/css"">
    .loader {
        display: none;
        position: absolute;
        top: 75%;
        left: 50%;
        margin: -75px 0px 0px -50px;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa850a499c0ba9211c224bb4041b717adece07524753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Censio_CMS.Models.GameAttemptdataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591