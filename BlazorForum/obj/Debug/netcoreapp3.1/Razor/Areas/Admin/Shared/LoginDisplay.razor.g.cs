#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89465b8ec4b59fb2df58f850be1163c5f9748661"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Areas.Admin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Domain.Resources;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Interfaces;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Domain.Utilities.Formatting;

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal;

#line default
#line hidden
#line 17 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal.Components;

#line default
#line hidden
#line 1 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Domain.Services;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using System.Linq;

#line default
#line hidden
#line 14 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        ");
                __builder2.OpenElement(3, "a");
                __builder2.AddAttribute(4, "href", "/Identity/Account/Manage");
                __builder2.AddContent(5, " ");
                __builder2.AddContent(6, 
#line 3 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Shared\LoginDisplay.razor"
                                             context.User.Identity.Name

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.AddMarkupContent(8, "<form method=\"post\" action=\"/Identity/Account/LogOut\">\n            <button type=\"submit\" class=\"nav-link btn btn-link\">登出</button>\n        </form>\n    ");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.AddMarkupContent(11, "<a href=\"/Identity/Account/Register\">注册</a>\n        ");
                __builder2.AddMarkupContent(12, "<a href=\"/Identity/Account/Login\">登录</a>\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
