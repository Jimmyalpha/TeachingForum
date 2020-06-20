#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d8ae5b40e399ce5b7abe7353c822ed60b55ed3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/category/{id:int}/{slug}")]
    public partial class ForumCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "breadcrumb blazorforum-breadcrumb");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<li class=\"breadcrumb-item\">\n        <a href=\"/forums/\">Forums</a>\n    </li>\n    ");
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "class", "breadcrumb-item");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddContent(7, 
#line 16 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
          _category != null && _category.Title != null ? _category.Title : ""

#line default
#line hidden
            );
            __builder.AddMarkupContent(8, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n");
#line 20 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
 if (_category == null)
{

#line default
#line hidden
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "mb-2 loading-div");
            __builder.AddMarkupContent(14, "\n        ");
            __builder.OpenElement(15, "em");
            __builder.AddMarkupContent(16, "<i class=\"oi oi-cog se-spin-icon\"></i> ");
            __builder.AddContent(17, 
#line 23 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                                    GeneralResources.Loading

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#line 25 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(20, "    ");
            __builder.OpenElement(21, "header");
            __builder.AddAttribute(22, "class", "forum-category-header");
            __builder.AddMarkupContent(23, "\n        ");
            __builder.OpenElement(24, "h3");
            __builder.AddContent(25, 
#line 29 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
             _category.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class", "forum-category-description");
            __builder.AddContent(29, 
#line 30 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                                  _category.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
            __builder.AddContent(32, "    ");
            __builder.OpenElement(33, "ul");
            __builder.AddAttribute(34, "class", "forum-ul");
            __builder.AddMarkupContent(35, "\n");
#line 34 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
         if (_topics == null || _topics.Count == 0)
        {

#line default
#line hidden
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "li");
            __builder.AddContent(38, 
#line 36 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                 GeneralResources.NoTopics

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
#line 37 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
        }
        else
        {
            foreach (var topic in _topics)
            {

#line default
#line hidden
            __builder.AddContent(40, "                ");
            __builder.OpenElement(41, "li");
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", 
#line 43 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                              String.Format("/topic/{0}/{1}",
                        topic.ForumTopicId, UrlFormatting.PrepareUrlText(topic.ForumTopicUrl))

#line default
#line hidden
            );
            __builder.AddMarkupContent(45, "\n                        ");
            __builder.AddContent(46, 
#line 45 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                         topic.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, " \n                        ( ");
            __builder.AddContent(48, 
#line 46 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                            _postCountList != null ? _postCountList.Where(p => p.ParentItemId == topic.ForumTopicId)
                            .FirstOrDefault().ChildCount : 0 

#line default
#line hidden
            );
            __builder.AddMarkupContent(49, " )\n                    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "topic-blazifier");
            __builder.AddMarkupContent(52, "\n                        Posted ");
            __builder.AddContent(53, 
#line 49 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                Domain.Utilities.Formatting.DateTimeFormatting.RelativeDateAgo(topic.PostedDate)

#line default
#line hidden
            );
            __builder.AddMarkupContent(54, "\n                        by ");
            __builder.AddContent(55, 
#line 50 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                            topic.UserName

#line default
#line hidden
            );
            __builder.AddMarkupContent(56, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#line 53 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
            }
        }

#line default
#line hidden
            __builder.AddContent(59, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
            __builder.AddContent(61, "    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "text-center");
            __builder.AddMarkupContent(64, "\n        ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "class", "btn" + " btn-blazorforum" + " " + (
#line 58 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                            _loadMoreVisibility

#line default
#line hidden
            ));
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 58 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                                                           LoadMoreTopicsAsync

#line default
#line hidden
            ));
            __builder.AddMarkupContent(68, "\n            ");
            __builder.AddContent(69, 
#line 59 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
             GeneralResources.LoadMore

#line default
#line hidden
            );
            __builder.AddMarkupContent(70, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n");
            __builder.AddContent(73, "    ");
            __builder.OpenElement(74, "section");
            __builder.AddAttribute(75, "class", "mt-4 mb-3");
            __builder.AddMarkupContent(76, "\n        ");
            __builder.OpenElement(77, "h4");
            __builder.AddContent(78, 
#line 64 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
             GeneralResources.CreateNewTopic

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(80);
            __builder.AddAttribute(81, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(82, "\n                ");
                __builder2.OpenComponent<BlazorForum.Pages.Components.Forums.TopicForm>(83);
                __builder2.AddAttribute(84, "OnTopicAdded", new System.Action(
#line 67 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                         UpdateTopicsAsync

#line default
#line hidden
                ));
                __builder2.AddAttribute(85, "ForumCatId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 67 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                                                         id

#line default
#line hidden
                ));
                __builder2.AddAttribute(86, "CurrentUserId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 67 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                                                                             CurrentUserId

#line default
#line hidden
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n            ");
            }
            ));
            __builder.AddAttribute(88, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(89, "\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "alert alert-secondary");
                __builder2.AddMarkupContent(92, "\n                    ");
                __builder2.OpenElement(93, "span");
                __builder2.AddAttribute(94, "class", "text-secondary");
                __builder2.AddContent(95, 
#line 71 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
                                                  GeneralResources.LoginToPostTopic

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n");
#line 76 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 78 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
       
    [Parameter] public int id { get; set; }
    [Parameter] public string slug { get; set; }
    [Parameter] public string CurrentUserId { get; set; }
    private Models.ForumCategory _category;
    private List<Models.ForumTopic> _topics { get; set; }
    private List<TopicPostCount> _postCountList = new List<TopicPostCount>();
    private int _maxCount = 10;
    private string _loadMoreVisibility;

    protected override async Task OnInitializedAsync()
    {
        _category = await manageForumCategories.GetForumCategoryAsync(id);
        head.Title = _category.Title;
        head.Description = _category.Description;
        _topics = await manageForumTopics.GetApprovedForumTopicsAsync(id);

        if (_maxCount >= _topics.Count)
            _loadMoreVisibility = "d-none";

        _topics = _topics.OrderByDescending(p => p.PostedDate).Take(_maxCount).ToList();
        CurrentUserId = await new Domain.Utilities.Membership.UserInfo(userManager, authStateProvider).GetUserId();
        await AddUserToTopicAsync();

        await SetTopicsCount();
    }

    

#line default
#line hidden
#line 111 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\Forums\ForumCategory.razor"
       

    public async void UpdateTopicsAsync()
    {
        _topics = await manageForumTopics.GetApprovedForumTopicsAsync(id);

        if (_maxCount >= _topics.Count)
            _loadMoreVisibility = "d-none";
        else
            _loadMoreVisibility = "d-inline-block";

        _topics = _topics.OrderByDescending(p => p.PostedDate).Take(_maxCount).ToList();

        await AddUserToTopicAsync();
        await SetTopicsCount();
        StateHasChanged();
    }

    public async Task LoadMoreTopicsAsync()
    {
        _maxCount += 10;
        _topics = await manageForumTopics.GetApprovedForumTopicsAsync(id);

        if (_maxCount >= _topics.Count)
            _loadMoreVisibility = "d-none";
        else
            _loadMoreVisibility = "d-inline-block";

        _topics = _topics.OrderByDescending(p => p.PostedDate).Take(_maxCount).ToList();

        await AddUserToTopicAsync();
        StateHasChanged();
    }

    private async Task AddUserToTopicAsync()
    {
        foreach (var topic in _topics)
        {
            var user = await userManager.FindByIdAsync(topic.UserId);
            topic.UserName = user.UserName;
        }
    }

    protected async Task SetTopicsCount()
    {
        var topics = await manageForumTopics.GetApprovedForumTopicsAsync(id);
        
        foreach (var topic in topics)
        {
            var posts = await manageForumPosts.GetApprovedForumPostsAsync(topic.ForumTopicId);
            var postCount = new TopicPostCount
            {
                ParentItemId = topic.ForumTopicId,
                ChildCount = posts.Count
            };
            _postCountList.Add(postCount);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumPosts manageForumPosts { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumTopics manageForumTopics { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumCategories manageForumCategories { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HeadBuilderService head { get; set; }
    }
}
#pragma warning restore 1591
