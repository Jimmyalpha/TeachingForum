#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4872bcc2fc03883633526244d5c6977610b3f3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4872bcc2fc03883633526244d5c6977610b3f3bd", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fef4a30348ba682a67f846b399980048c0bf68b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7323065a2e0df1dccfb07d1e63401bd5e4bcb636", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 139, "\"", 196, 4);
            WriteAttributeValue("", 147, "alert", 147, 5, true);
            WriteAttributeValue(" ", 152, "alert-", 153, 7, true);
#line 6 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
WriteAttributeValue("", 159, statusMessageClass, 159, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 178, "alert-dismissible", 179, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        ");
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            WriteLiteral("\n    </div>\n");
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
