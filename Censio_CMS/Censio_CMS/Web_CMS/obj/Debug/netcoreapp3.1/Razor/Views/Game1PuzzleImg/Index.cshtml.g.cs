#pragma checksum "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2cce4ee7dfff946f09438eb0182845237cc46ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game1PuzzleImg_Index), @"mvc.1.0.view", @"/Views/Game1PuzzleImg/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2cce4ee7dfff946f09438eb0182845237cc46ba", @"/Views/Game1PuzzleImg/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Game1PuzzleImg_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Censio_CMS.Models.PuzzleGameModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AppJavascript/Game1PuzzleImg.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
   var hrefURL = Censio_CMS.Startup.GethrefURL();

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"block full\">\r\n    <div class=\"block-title\">\r\n        <h2><strong> ");
#nullable restore
#line 11 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                Write(ViewBag.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </h2>\r\n    </div>\r\n    <div class=\"table-responsive\">\r\n\r\n        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 386, "\"", 451, 3);
            WriteAttributeValue("", 396, "location.href=\'", 396, 15, true);
#nullable restore
#line 15 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
WriteAttributeValue("", 411, Url.Action("Create", "Game1PuzzleImg"), 411, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 450, "\'", 450, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm btn-primary""><i class=""fa fa-plus""></i>Add</button>
        <table id=""example-datatable"" class=""table table-vcenter table-condensed table-bordered"">
            <thead>
                <tr>
                    <th class=""text-center"">Id</th>
                    <th class=""text-center"">Challenge Name</th>
                    <th class=""text-center"">Row Column </th>
                    <th class=""text-center"">Images</th>
                    <th class=""text-center"">Answer Sequence</th>
                    <th class=""text-center"">Coins</th>
                    <th class=""text-center"">Status</th>
                    <th class=""text-center"">Date and Time</th>
                    <th class=""text-center"">Actions</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 35 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.IdPuzzle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 36 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ChallengeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 37 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.RowColumn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 1698, "\"", 1729, 1);
#nullable restore
#line 38 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
WriteAttributeValue("", 1704, hrefURL  + item.Images, 1704, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" height=100 width=100 /></td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 39 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.AnswerSequence));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 40 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Coins));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 42 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                     if (item.IsActive == "A")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-center\">Active</td>\r\n");
#nullable restore
#line 45 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-center\"> DeActive</td>\r\n");
#nullable restore
#line 49 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-center\">");
#nullable restore
#line 50 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UpdatedDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        <div class=\"btn-group\">\r\n                            ");
#nullable restore
#line 53 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { id = item.IdPuzzle }, new { @title = "Edit", @class = "glyphicon glyphicon-pencil" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 59 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game1PuzzleImg\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2cce4ee7dfff946f09438eb0182845237cc46ba10056", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Censio_CMS.Models.PuzzleGameModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
