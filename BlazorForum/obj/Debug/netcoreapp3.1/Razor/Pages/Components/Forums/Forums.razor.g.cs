#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d06f58365b65b15ee29cc2c0fb05b9c7a455a718"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Pages.Components.Forums
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/forums")]
    public partial class Forums : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 8 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
 if (_forums == null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mb-2 loading-div");
            __builder.AddMarkupContent(3, "\n        ");
            __builder.OpenElement(4, "em");
            __builder.AddMarkupContent(5, "<i class=\"oi oi-cog se-spin-icon\"></i> ");
            __builder.AddContent(6, 
#line 11 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                                                    GeneralResources.Loading

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
}
else
{
    

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
     if(_forums.Count == 0)
    {

#line default
#line hidden
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "alert alert-secondary");
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "class", "text-secondary");
            __builder.AddContent(15, 
#line 19 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                                          GeneralResources.NoForumsFound

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
#line 21 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
    }

#line default
#line hidden
#line 21 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
     
    foreach (var forum in _forums)
    {

#line default
#line hidden
            __builder.AddContent(18, "        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "mb-2");
            __builder.AddMarkupContent(21, "\n            ");
            __builder.OpenElement(22, "header");
            __builder.AddAttribute(23, "class", "forum-header");
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "h3");
            __builder.AddContent(26, 
#line 26 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                     forum.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", "forum-description");
            __builder.AddContent(30, 
#line 27 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                                                 forum.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n\n            ");
            __builder.OpenElement(33, "ul");
            __builder.AddAttribute(34, "class", "forum-ul");
            __builder.AddMarkupContent(35, "\n");
#line 31 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                 if(forum.ForumCategories.Count == 0)
                {

#line default
#line hidden
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "text-muted");
            __builder.AddContent(39, 
#line 33 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                                            GeneralResources.NoCategories

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n");
#line 34 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                }

#line default
#line hidden
#line 35 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                 foreach (var category in forum.ForumCategories)
                {

#line default
#line hidden
            __builder.AddContent(41, "                    ");
            __builder.OpenElement(42, "li");
            __builder.AddMarkupContent(43, "\n                        ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "href", 
#line 38 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                                  String.Format("/category/{0}/{1}",
                                  category.ForumCategoryId,
                                  UrlFormatting.PrepareUrlText(category.ForumCategoryUrl))

#line default
#line hidden
            );
            __builder.AddContent(46, 
#line 40 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                                                                                             category.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, " \n                                    ( ");
            __builder.AddContent(48, 
#line 41 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                                        _topicCountList != null ? _topicCountList.Where(p => p.ParentItemId == category.ForumCategoryId)
                                    .FirstOrDefault().ChildCount : 0 

#line default
#line hidden
            );
            __builder.AddMarkupContent(49, " )\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
#line 44 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
                }

#line default
#line hidden
            __builder.AddContent(51, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n");
#line 47 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 50 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\Forums.razor"
       
    private List<Models.Forum> _forums;
    private List<TopicPostCount> _topicCountList = new List<TopicPostCount>();

    protected override async Task OnInitializedAsync()
    {
        head.Title = "Forums";
        _forums = await manageForums.GetForumsAsync();

        await SetTopicsCount();
    }

    protected async Task SetTopicsCount()
    {
        var categories = await manageCategories.GetForumCategoriesAsync();

        foreach (var category in categories)
        {
            var topics = await manageTopics.GetApprovedForumTopicsAsync(category.ForumCategoryId);
            var topicCount = new TopicPostCount
            {
                ParentItemId = category.ForumCategoryId,
                ChildCount = topics.Count
            };
            _topicCountList.Add(topicCount);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumTopics manageTopics { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumCategories manageCategories { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForums manageForums { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HeadBuilderService head { get; set; }
    }
}
#pragma warning restore 1591
