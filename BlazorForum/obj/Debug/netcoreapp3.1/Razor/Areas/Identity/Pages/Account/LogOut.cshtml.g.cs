#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\LogOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1b8e9fc2bc6d43ed386dd2dc331a7664209c846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_LogOut), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/LogOut.cshtml")]
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
#line 2 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\LogOut.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\LogOut.cshtml"
           [IgnoreAntiforgeryToken]

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b8e9fc2bc6d43ed386dd2dc331a7664209c846", @"/Areas/Identity/Pages/Account/LogOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fef4a30348ba682a67f846b399980048c0bf68b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7323065a2e0df1dccfb07d1e63401bd5e4bcb636", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_LogOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
        }
        #pragma warning restore 1998
#line 5 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\LogOut.cshtml"
            
    public async Task<IActionResult> OnPost()
    {
        if (SignInManager.IsSignedIn(User))
        {
            await SignInManager.SignOutAsync();
        }

        return Redirect("~/");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_LogOut> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_LogOut> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_LogOut>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_LogOut Model => ViewData.Model;
    }
}
#pragma warning restore 1591
