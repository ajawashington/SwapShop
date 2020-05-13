#pragma checksum "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ccb65b64552a788869b0481510628213739fd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\_ViewImports.cshtml"
using BackendCapstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\_ViewImports.cshtml"
using BackendCapstone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ccb65b64552a788869b0481510628213739fd7", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20e65a7573e4034afaca2f59df4993565e4a910", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BackendCapstone.Models.BarterItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 4em; height: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search Results</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.AppUser.TagName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.BarterType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.AppUser.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 40 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
             if (item.ImagePath == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 45 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1282, "\"", 1359, 1);
#nullable restore
#line 49 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
WriteAttributeValue("", 1289, Url.Action("Details", "BarterItems",  new { Id = item.BarterItemId }), 1289, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27ccb65b64552a788869b0481510628213739fd77989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1397, "~/images/", 1397, 9, true);
#nullable restore
#line 50 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 1406, item.ImagePath, 1406, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                </td>\r\n");
#nullable restore
#line 53 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1561, "\"", 1629, 1);
#nullable restore
#line 55 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
WriteAttributeValue("", 1568, Url.Action("Details", "Users",  new { Id = item.AppUserId }), 1568, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 56 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.AppUser.TagName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 1981, "\'", 2049, 3);
#nullable restore
#line 66 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
WriteAttributeValue("", 1988, Url.Action("Search","Home"), 1988, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2016, "?searchBar=", 2016, 11, true);
#nullable restore
#line 66 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
WriteAttributeValue("", 2027, item.BarterType.Title, 2027, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
                                                                                   Write(item.BarterType.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 2230, "\'", 2298, 3);
#nullable restore
#line 72 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
WriteAttributeValue("", 2237, Url.Action("Search","Home"), 2237, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2265, "?searchBar=", 2265, 11, true);
#nullable restore
#line 72 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
WriteAttributeValue("", 2276, item.AppUser.Location, 2276, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
                                                                                   Write(item.AppUser.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Home\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BackendCapstone.Models.BarterItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
