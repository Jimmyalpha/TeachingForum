#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2527232be11eba25e08b1367d5be8946260d415"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Models;

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
#line 14 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Services;

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
#line 18 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Shared\MainLayout.razor"
using BlazorForum.Pages.Components.Google;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<BlazorForum.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "section");
            __builder.AddAttribute(10, "class", "top-row px-4 auth");
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenComponent<BlazorForum.Shared.LoginDisplay>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "section");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddMarkupContent(17, "\n        ");
            __builder.AddContent(18, 
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(19, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
            __builder.OpenComponent<BlazorForum.Pages.Components.Google.GoogleAnalytics>(22);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
