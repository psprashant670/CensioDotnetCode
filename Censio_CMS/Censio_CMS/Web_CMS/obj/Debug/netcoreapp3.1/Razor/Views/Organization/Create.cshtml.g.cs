#pragma checksum "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "301de85acca0e5b632205f1f22fdeb12f295fa38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organization_Create), @"mvc.1.0.view", @"/Views/Organization/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"301de85acca0e5b632205f1f22fdeb12f295fa38", @"/Views/Organization/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Organization_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Censio_CMS.Models.OrganizationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;width:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Organizationform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("push"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Jquery3.5.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AppJavascript/Organization.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"block full\">\r\n    <div class=\"block-title\">\r\n        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 217, "\"", 279, 3);
            WriteAttributeValue("", 227, "location.href=\'", 227, 15, true);
#nullable restore
#line 9 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
WriteAttributeValue("", 242, Url.Action("Index", "Organization"), 242, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 278, "\'", 278, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" style=\"float: right; margin: 0; margin-right: 10px; margin-top: 9px; padding: 1px 13px;\" data-dismiss=\"modal\" aria-hidden=\"true\">Back</button>\r\n        <h2><strong>");
#nullable restore
#line 10 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
               Write(ViewBag.modelTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Organization</strong> </h2>\r\n    </div>\r\n    <div class=\"table-responsive\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301de85acca0e5b632205f1f22fdeb12f295fa386616", async() => {
                WriteLiteral("\r\n\r\n            <div class=\"modal-body\">\r\n                <div id=\"myAlert\">\r\n                </div>\r\n                <div class=\"loader \"> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "301de85acca0e5b632205f1f22fdeb12f295fa387026", async() => {
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
                            <label for=""Industry_Name"">Organization Name</label>
                            ");
#nullable restore
#line 26 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.IdOrganization, new { @id = "IdOrganization", @style = "display: none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.OrganizationName, new { @id = "OrganizationName", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">Description</label>\r\n                            ");
#nullable restore
#line 35 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.TextAreaFor(m => m.Description, new { @id = "Description", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        </div>


                        <div class=""form-group"">
                            <div class=""col-sm-6"">
                                <label for=""checkout-payment-name"">Logo Organization</label>
                                ");
#nullable restore
#line 43 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.Logo, new { @id = "Logo", @style = "display: none;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <input type=""file"" title=""search image"" class=""form-control"" id=""file"" name=""file"" onchange=""show(this)"" />
                            </div>
                            <div class=""col-sm-6"">
                                <img id=""user_img"" style=""height:100px;width:100px;"" class=""form-control"" Style=""border:solid"" />
                            </div>
                        </div>



                        <div class=""form-group"">
                            <label for=""password"">Name</label>
                            ");
#nullable restore
#line 55 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.Name, new { @id = "Name", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">PhoneNo</label>\r\n                            ");
#nullable restore
#line 62 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.PhoneNo, new { @id = "PhoneNo", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">Contact Email</label>\r\n                            ");
#nullable restore
#line 69 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.ContactEmail, new { @id = "ContactEmail", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"password\">Default Email</label>\r\n                            ");
#nullable restore
#line 75 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.DefaultEmail, new { @id = "DefaultEmail", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n\r\n\r\n                        <div class=\"form-group \">\r\n                            <label for=\"password\">Status</label>\r\n                            ");
#nullable restore
#line 82 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Organization\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.Status, new List<SelectListItem>
                                   {
                                   new SelectListItem{ Text="Active", Value = "A" },
                                   new SelectListItem{ Text="Deactive", Value = "D" }}, new { @class = "form-control show-tick", @style = "width:100%;", @id = "Status" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301de85acca0e5b632205f1f22fdeb12f295fa3815165", async() => {
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
        if ($(""#Logo"").val() != """") {
            $('#user_img').attr('src', $(""#Logo"").val());
        }
        $('#btn').on('click', function () {
            debugger;
            var valid = $(""#Organizationform"").valid();
            if (valid == true) {
                AddEdit();
            }
        });

        $(""#Organizationform"").validate({
            rules: {

              
                OrganizationName: ""required"",
                Description: ""required"",
                Name: ""required"",
                PhoneNo: ""required"",
                ContactEmail: ""required"",
                DefaultEmail: ""required"",
                Status: ""required"",
               
            },
            messages: {

               
                OrganizationName: ""please Enter Organization Name"",
                Description: ""Please Enter a Description"",
                Name: ""Please Enter Name"",
                PhoneNo: ""Pleas");
            WriteLiteral(@"e Enter Your PhoneNo "",
                ContactEmail: ""Please Enter your Emailid"",
                DefaultEmail: ""Please Enter Email"",
                Status: ""Please Select a Status"",
                
            }
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "301de85acca0e5b632205f1f22fdeb12f295fa3817747", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Censio_CMS.Models.OrganizationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591