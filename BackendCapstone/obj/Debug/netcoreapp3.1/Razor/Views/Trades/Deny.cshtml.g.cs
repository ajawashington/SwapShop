#pragma checksum "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a21d9330625df864014bbbc28631496866387f38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trades_Deny), @"mvc.1.0.view", @"/Views/Trades/Deny.cshtml")]
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
#line 7 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a21d9330625df864014bbbc28631496866387f38", @"/Views/Trades/Deny.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f20e65a7573e4034afaca2f59df4993565e4a910", @"/Views/_ViewImports.cshtml")]
    public class Views_Trades_Deny : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BackendCapstone.Models.Trade>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelTrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
  
    ViewData["Title"] = "Deny";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Delete</h1>\r\n");
#nullable restore
#line 11 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
 if (UserManager.GetUserAsync(User).Result.Id == Model.SenderId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Would you like to delete your trade with ");
#nullable restore
#line 13 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
                                            Write(Model.Receiver.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a21d9330625df864014bbbc28631496866387f385085", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a21d9330625df864014bbbc28631496866387f385351", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.TradeId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Yes\" class=\"btn btn-danger\" /> |\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\'", 525, "\'", 661, 7);
#nullable restore
#line 20 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 532, Url.Action("Trade", "Trades"), 532, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 562, "?receiverId=", 562, 12, true);
#nullable restore
#line 20 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 574, Model.ReceiverId.ToString(), 574, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 602, "&senderId=", 602, 10, true);
#nullable restore
#line 20 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 612, Model.SenderId.ToString(), 612, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 638, "&tradeId=", 638, 9, true);
#nullable restore
#line 20 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 647, Model.TradeId, 647, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No, I would like to edit my trade items</a>\r\n");
#nullable restore
#line 21 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Would you like to delete your trade with ");
#nullable restore
#line 25 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
                                            Write(Model.Sender.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a21d9330625df864014bbbc28631496866387f3810242", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a21d9330625df864014bbbc28631496866387f3810509", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 27 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.TradeId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Yes\" class=\"btn btn-danger\" /> |\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\'", 988, "\'", 1124, 7);
#nullable restore
#line 32 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 995, Url.Action("Trade", "Trades"), 995, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1025, "?receiverId=", 1025, 12, true);
#nullable restore
#line 32 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 1037, Model.ReceiverId.ToString(), 1037, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1065, "&senderId=", 1065, 10, true);
#nullable restore
#line 32 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 1075, Model.SenderId.ToString(), 1075, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1101, "&tradeId=", 1101, 9, true);
#nullable restore
#line 32 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
WriteAttributeValue("", 1110, Model.TradeId, 1110, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No, I would like to edit my trade items</a>\r\n");
#nullable restore
#line 33 "C:\Users\info\Source\Repos\BackendCapstone\BackendCapstone\Views\Trades\Deny.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BackendCapstone.Models.Trade> Html { get; private set; }
    }
}
#pragma warning restore 1591