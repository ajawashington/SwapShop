#pragma checksum "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0875a006729f44d8d916fd22d3615d7c56125c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0875a006729f44d8d916fd22d3615d7c56125c2", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20e65a7573e4034afaca2f59df4993565e4a910", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BackendCapstone.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Community</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TagName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Users\Index.cshtml"
         foreach (var item in Model)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n        <td>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 400, "\"", 461, 1);
#nullable restore
#line 22 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Users\Index.cshtml"
WriteAttributeValue("", 407, Url.Action("Details", "Users",  new { Id = item.Id }), 407, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 23 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TagName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Users\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BackendCapstone.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
