#pragma checksum "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c3558854bbcff19452278abfdeddd35f3339887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game4LevelMaster_Index), @"mvc.1.0.view", @"/Views/Game4LevelMaster/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c3558854bbcff19452278abfdeddd35f3339887", @"/Views/Game4LevelMaster/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Game4LevelMaster_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Entities.TblGame4LevelMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AppJavascript/Game4LevelMaster.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
   var hrefURL = Censio_CMS.Startup.GethrefURL();

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"block full\">\r\n    <div class=\"block-title\">\r\n        <h2><strong> ");
#nullable restore
#line 11 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                Write(ViewBag.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </h2>\r\n    </div>\r\n    <div class=\"table-responsive\">\r\n\r\n        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 388, "\"", 455, 3);
            WriteAttributeValue("", 398, "location.href=\'", 398, 15, true);
#nullable restore
#line 15 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
WriteAttributeValue("", 413, Url.Action("Create", "Game4LevelMaster"), 413, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 454, "\'", 454, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-sm btn-primary""><i class=""fa fa-plus""></i>Add</button>
        <table id=""example-datatable"" class=""table table-vcenter table-condensed table-bordered"">
            <thead>
                <tr>
                    <th class=""text-center"">Sr No.</th>
                    <th class=""text-center"">Level Name</th>
                    <th class=""text-center"">Level WordCount</th>
                    <th class=""text-center"">Level Time Required</th>
                    <th class=""text-center"">Level Bonus Points</th>
                    <th class=""text-center"">Status</th>
                    <th class=""text-center"">Updated Date Time</th>
                    <th class=""text-center"">Actions</th>


                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 35 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.IdLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 36 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LevelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 37 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LevelWordcount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 38 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LevelTimerequired));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">");
#nullable restore
#line 39 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LevelBonuspts));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                      \r\n");
#nullable restore
#line 41 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                         if (item.IdLevelStatus == "A")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"text-center\">Active</td>\r\n");
#nullable restore
#line 44 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"text-center\"> DeActive</td>\r\n");
#nullable restore
#line 48 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <td class=\"text-center\">");
#nullable restore
#line 49 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.UpdateDatetime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td class=\"text-center\">\r\n                            <div class=\"btn-group\">\r\n                                ");
#nullable restore
#line 53 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { id = item.IdLevel }, new { @title = "Edit", @class = "glyphicon glyphicon-pencil" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                 if (item.IdLevelStatus == "A")
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                               Write(Html.ActionLink("DeActivate", "DeActivate", new { id = item.IdLevel }, new { @title = "DeActivate", @class = "glyphicon glyphicon-pencil" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                                                                                                                                                                 
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                               Write(Html.ActionLink("Activate", "Activate", new { id = item.IdLevel }, new { @title = "DeActivate", @class = "glyphicon glyphicon-pencil" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                                                                                                                                                                             
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Game4LevelMaster\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c3558854bbcff19452278abfdeddd35f333988711642", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Entities.TblGame4LevelMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591