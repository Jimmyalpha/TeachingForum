#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8503b91d9ea09700fa0e919dab4591f2e950ee"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Areas.Admin.Pages.Components.Forums
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/forums")]
    public partial class Forums : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
 if (_pageError)
{

#line default
#line hidden
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-danger");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "span");
            __builder.AddAttribute(4, "class", "text-danger");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.AddContent(6, 
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
         _pageErrorMsg

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
      }

#line default
#line hidden
            __builder.AddMarkupContent(9, "\n");
            __builder.AddMarkupContent(10, "<header>\n    <h3>版面</h3>\n</header>\n");
            __builder.OpenElement(11, "section");
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "forum-ul");
            __builder.AddMarkupContent(15, "\n");
#line 19 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
         if (_forums == null)
        {

#line default
#line hidden
            __builder.AddMarkupContent(16, "<li>Loading Forums...</li> ");
#line 21 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
                           }
            else if (_forums.Count == 0)
            {

#line default
#line hidden
            __builder.AddMarkupContent(17, "<li>No Forums Found</li> ");
#line 24 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
                         }
            else
            {
                foreach (var forum in _forums)
                {

#line default
#line hidden
            __builder.OpenElement(18, "li");
            __builder.AddMarkupContent(19, "\n    ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", 
#line 30 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
              String.Format("/admin/manage/forums/{0}", forum.ForumId)

#line default
#line hidden
            );
            __builder.AddMarkupContent(22, "\n        ");
            __builder.AddContent(23, 
#line 31 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
         forum.Title

#line default
#line hidden
            );
            __builder.AddMarkupContent(24, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
            __builder.CloseElement();
#line 33 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
     }
            }

#line default
#line hidden
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
            __builder.OpenElement(29, "section");
            __builder.AddMarkupContent(30, "\n    ");
            __builder.OpenComponent<BlazorForum.Areas.Admin.Pages.Components.Forums.AddNewForumForm>(31);
            __builder.AddAttribute(32, "OnForumCreated", new System.Action(
#line 38 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
                                     UpdateForums

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n<br>\n");
            __builder.OpenElement(35, "section");
            __builder.AddMarkupContent(36, "\n    ");
            __builder.OpenComponent<BlazorForum.Areas.Admin.Pages.Components.Forums.AddForumTemplate>(37);
            __builder.AddAttribute(38, "OnForumCreated", new System.Action(
#line 42 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
                                      UpdateForums

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 45 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\Forums.razor"
        private List<Models.Forum> _forums;
            private bool _pageError = false;
            private string _pageErrorMsg;

            protected override async Task OnInitializedAsync()
            {
                head.Title = "Forums | Administration";
                _forums = await manageForums.GetForumsAsync();
            }

            public async void UpdateForums()
            {
                _forums = await manageForums.GetForumsAsync();
                StateHasChanged();
            } 

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForums manageForums { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HeadBuilderService head { get; set; }
    }
}
#pragma warning restore 1591
