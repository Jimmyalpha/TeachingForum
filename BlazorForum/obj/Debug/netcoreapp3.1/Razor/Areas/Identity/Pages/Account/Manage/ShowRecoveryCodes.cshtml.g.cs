#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d507e29ac752e88ab09a9873df912878920a6853"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_ShowRecoveryCodes), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
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
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\_ViewImports.cshtml"
using BlazorForum.Models;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\_ViewImports.cshtml"
using BlazorForum.Areas.Identity;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\_ViewImports.cshtml"
using BlazorForum.Areas.Identity.Pages;

#line default
#line hidden
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using BlazorForum.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using BlazorForum.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d507e29ac752e88ab09a9873df912878920a6853", @"/Areas/Identity/Pages/Account/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fef4a30348ba682a67f846b399980048c0bf68b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7323065a2e0df1dccfb07d1e63401bd5e4bcb636", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8fe6a1643b02e4041f5c73247648c4fea000643", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = "Recovery codes";
    ViewData["ActivePage"] = "TwoFactorAuthentication";

#line default
#line hidden
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d507e29ac752e88ab09a9873df912878920a68534878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusMessage);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h4>");
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <strong>Put these codes in a safe place.</strong>
    </p>
    <p>
        If you lose your device and don't have the recovery codes you will lose access to your account.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-12"">
");
#line 20 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
            WriteLiteral("            <code class=\"recovery-code\">");
#line 22 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                   Write(Model.RecoveryCodes[row]);

#line default
#line hidden
            WriteLiteral("</code>");
            WriteLiteral("&nbsp;");
            WriteLiteral("<code class=\"recovery-code\">");
#line 22 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
                                                                                                                  Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
            WriteLiteral("</code><br />\n");
#line 23 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowRecoveryCodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShowRecoveryCodesModel>)PageContext?.ViewData;
        public ShowRecoveryCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591