#pragma checksum "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ed5b904107ab017a8765576654f4530e3e36887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MenuPartial), @"mvc.1.0.view", @"/Views/Shared/_MenuPartial.cshtml")]
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
#nullable restore
#line 1 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
using Censio_CMS.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ed5b904107ab017a8765576654f4530e3e36887", @"/Views/Shared/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"sidebar-nav\">\r\n");
#nullable restore
#line 3 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
     if (SessionHelper.GetObjectFromJson<List<Censio_CMS.Models.MenuModel>>(Context.Session, "Menudata") != null)
    {
        var MenuMaster = (List<Censio_CMS.Models.MenuModel>)(IEnumerable<Censio_CMS.Models.MenuModel>)SessionHelper.GetObjectFromJson<List<Censio_CMS.Models.MenuModel>>(Context.Session, "Menudata");

        var data = MenuMaster.Where(x => x.Status == "A");
        var groupByMenu = data.GroupBy(x => x.MainMenuName).ToList();


        foreach (var MenuList in groupByMenu)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"main\">\r\n                <a href=\"#\" class=\"sidebar-nav-menu\"><i class=\"fa fa-angle-left sidebar-nav-indicator sidebar-nav-mini-hide\"></i><i class=\"gi gi-leaf sidebar-nav-icon\"></i><span class=\"sidebar-nav-mini-hide\">");
#nullable restore
#line 14 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
                                                                                                                                                                                                           Write(MenuList.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                <ul>\r\n\r\n");
#nullable restore
#line 17 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
                     foreach (var SubMenuList in MenuList.OrderBy(x => x.Sequence))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1100, 1);
#nullable restore
#line 20 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
WriteAttributeValue("", 1035, Url.Action(@SubMenuList.ActionName, @SubMenuList.ControllerName), 1035, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i ");
            WriteLiteral(" class=\"fa fa-long-arrow-right fa-fw\"></i><span class=\"hide-menu\" style=\"color: black; border-color:black;\">");
#nullable restore
#line 20 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
                                                                                                                                                                                                                                            Write(SubMenuList.SubMenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                        </li>\r\n");
#nullable restore
#line 22 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </li>\r\n");
#nullable restore
#line 26 "F:\Censio_CMS\July\Censio_CMS\Censio_CMS\Web_CMS\Views\Shared\_MenuPartial.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<!-- END Sidebar Navigation -->\r\n");
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