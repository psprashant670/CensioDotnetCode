#pragma checksum "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14281012855f70d911855e660287804b192d0f72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameChallengelevel_Create), @"mvc.1.0.view", @"/Views/GameChallengelevel/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14281012855f70d911855e660287804b192d0f72", @"/Views/GameChallengelevel/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_GameChallengelevel_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Censio_CMS.Models.GameChallengelevelModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("push"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Jquery3.5.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AppJavascript/GameChallengelevel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"block full\">\r\n    <div class=\"block-title\">\r\n        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 223, "\"", 291, 3);
            WriteAttributeValue("", 233, "location.href=\'", 233, 15, true);
#nullable restore
#line 9 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
WriteAttributeValue("", 248, Url.Action("Index", "GameChallengelevel"), 248, 42, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 290, "\'", 290, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" style=\"float: right; margin: 0; margin-right: 10px; margin-top: 9px; padding: 1px 13px;\" data-dismiss=\"modal\" aria-hidden=\"true\">Back</button>\r\n        <h2><strong>");
#nullable restore
#line 10 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
               Write(ViewBag.modelTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Game Challengelevel</strong> </h2>\r\n    </div>\r\n    <div class=\"table-responsive\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14281012855f70d911855e660287804b192d0f726677", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"modal-body\">\r\n                <div id=\"myAlert\">\r\n                </div>\r\n                <div class=\"loader \"> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14281012855f70d911855e660287804b192d0f727087", async() => {
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
                WriteLiteral(@"</div>
                <div class=""row"">
                    <div class=""col-sm-6 col-sm-offset-3"">

                        <div class=""form-group"">
                            <label for=""Industry_Name"">Game Name</label>
                            ");
#nullable restore
#line 25 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.IdLevel, new { @id = "IdLevel", @style = "display: none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 26 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.IdGame, new SelectList(Model.GameNameList, "Value", "Text"), "", new { @id = "IdGame", @class = "form-control", @onchange = "Gamechange();" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">ChallengeName</label>\r\n                            ");
#nullable restore
#line 32 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.ChallengeName, new { @id = "ChallengeName", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>

                        <div class=""form-group"">
                            <div class=""col-sm-6"">
                                <label for=""checkout-payment-name"">ChallengeSmallImgUrl</label>
                                ");
#nullable restore
#line 39 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.ChallengeSmallImgUrl, new { @id = "ChallengeSmallImgUrl", @style = "display: none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <input type=""file"" title=""Upload File"" class=""form-control"" id=""ChallengeSmallImgUrlfile"" name=""file"" onchange=""ChallengeSmallImgUrlshow(this)"" />
                            </div>

                            <div class=""col-sm-6"">
                                <img id=""ChallengeSmallImgUrl_img"" style=""height:100px;width:100px;"" class=""form-control"" Style=""border:solid"" />
                            </div>
                        </div>

                        <div class=""form-group"">
                            <div class=""col-sm-6"">
                                <label for=""checkout-payment-name"">ChallengeBigImgUrl</label>
                                ");
#nullable restore
#line 51 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.ChallengeBigImgUrl, new { @id = "ChallengeBigImgUrl", @style = "display: none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <input type=""file"" title=""Upload File"" class=""form-control"" id=""ChallengeBigImgUrlfile"" name=""file"" onchange=""ChallengeBigImgUrlshow(this)"" />
                            </div>

                            <div class=""col-sm-6"">
                                <img id=""ChallengeBigImgUrl_img"" style=""height:100px;width:100px;"" class=""form-control"" Style=""border:solid"" />
                            </div>
                        </div>


                        <div class=""form-group"">
                            <label for=""password"">BigImgText</label>
                            ");
#nullable restore
#line 63 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.BigImgText, new { @id = "BigImgText", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">ChallengeIntroMessage</label>\r\n                            ");
#nullable restore
#line 69 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.ChallengeIntroMessage, new { @id = "ChallengeIntroMessage", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">BottomCompleteMessage</label>\r\n                            ");
#nullable restore
#line 75 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.BottomCompleteMessage, new { @id = "BottomCompleteMessage", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">BottomFailMessage</label>\r\n                            ");
#nullable restore
#line 81 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.BottomFailMessage, new { @id = "BottomFailMessage", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>


                        <div class=""form-group"">
                            <div class=""col-sm-6"">
                                <label for=""checkout-payment-name"">ChallengePieceMapImgUrl</label>
                                ");
#nullable restore
#line 89 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.ChallengePieceMapImgUrl, new { @id = "ChallengePieceMapImgUrl", @style = "display: none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <input type=""file"" title=""Upload File"" class=""form-control"" id=""ChallengePieceMapImgUrlfile"" name=""file"" onchange=""ChallengePieceMapImgUrlshow(this)"" />
                            </div>

                            <div class=""col-sm-6"">
                                <img id=""ChallengePieceMapImgUrl_img"" style=""height:100px;width:100px;"" class=""form-control"" Style=""border:solid"" />
                            </div>
                        </div>

                        <div class=""form-group"">
                            <label for=""password"">ChallengePieceMapMsg</label>
                            ");
#nullable restore
#line 100 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.ChallengePieceMapMsg, new { @id = "ChallengePieceMapMsg", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">NotBackingOutMsg</label>\r\n                            ");
#nullable restore
#line 105 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.NotBackingOutMsg, new { @id = "NotBackingOutMsg", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">AgainPlayCoins</label>\r\n                            ");
#nullable restore
#line 110 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.AgainPlayCoins, new { @id = "AgainPlayCoins", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">AttemptsAllowed</label>\r\n                            ");
#nullable restore
#line 116 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.AttemptsAllowed, new { @id = "AttemptsAllowed", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">AttemptTimer</label>\r\n                            ");
#nullable restore
#line 123 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.AttemptTimer, new { @id = "AttemptTimer", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>

                        <div style='display:none;' id='Game3'>

                            <div class=""form-group"">
                                <label for=""password"">Third GameScore</label>
                                ");
#nullable restore
#line 131 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.ThirdGameScore, new { @id = "ThirdGameScore", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <label for=\"password\">Special Point</label>\r\n                                ");
#nullable restore
#line 137 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.SpecialPoint, new { @id = "SpecialPoint", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <label for=\"password\">SuperpowerCoin Game3</label>\r\n                                ");
#nullable restore
#line 143 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.SuperpowerCoinGame3, new { @id = "SuperpowerCoinGame3", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"checkout-payment-name\">Status</label>\r\n                            ");
#nullable restore
#line 149 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\GameChallengelevel\Create.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14281012855f70d911855e660287804b192d0f7222170", async() => {
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
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        if ($(""#ChallengeSmallImgUrl"").val() != """") {
            $('#ChallengeSmallImgUrl_img').attr('src', $(""#ChallengeSmallImgUrl"").val());
        }
        if ($(""#ChallengeBigImgUrl"").val() != """") {
            $('#ChallengeBigImgUrl_img').attr('src', $(""#ChallengeBigImgUrl"").val());
        }
        if ($(""#ChallengePieceMapImgUrl"").val() != """") {
            $('#ChallengePieceMapImgUrl_img').attr('src', $(""#ChallengePieceMapImgUrl"").val());
        }

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
            //    IsActive: ""Please Select a St");
            WriteLiteral("atus\",\r\n            //}\r\n        })\r\n    });\r\n\r\n\r\n\r\n</script>\r\n<style type=\"text/css\">\r\n    .loader {\r\n        display: none;\r\n        position: absolute;\r\n        top: 75%;\r\n        left: 50%;\r\n        margin: -75px 0px 0px -50px;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14281012855f70d911855e660287804b192d0f7224578", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Censio_CMS.Models.GameChallengelevelModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
