#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ffb50b0f640f845ac1900156084af41bd426394"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/forums/{forumId:int}/categories/{categoryId:int}/topics/{topicId:int}")]
    public partial class ForumTopic : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#line 10 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
     _topic.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "section");
            __builder.AddAttribute(4, "class", "content-container");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddContent(6, 
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
      (MarkupString)_topic.TopicText

#line default
#line hidden
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mt-2");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", 
#line 14 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                  String.Format("/admin/manage/forums/{0}/categories/{1}/topics/{2}/edit", forumId, categoryId, topicId)

#line default
#line hidden
            );
            __builder.AddAttribute(13, "class", "btn btn-blazorforum mr-2");
            __builder.AddMarkupContent(14, "编辑");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-blazorforum-danger");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 16 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                                                             (() => DeleteTopicClicked())

#line default
#line hidden
            ));
            __builder.AddMarkupContent(19, "删除");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.OpenElement(23, "section");
            __builder.AddAttribute(24, "class", "mt-3");
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.AddMarkupContent(26, "<header class=\"secondary-header\">\r\n        <i class=\"oi oi-comment-square mr-2\"></i>帖子\r\n    </header>\r\n    ");
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "forum-ul");
            __builder.AddMarkupContent(29, "\r\n");
#line 25 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
         if (_posts == null)
        {

#line default
#line hidden
            __builder.AddContent(30, "            ");
            __builder.AddMarkupContent(31, "<li>Loading...</li>\r\n");
#line 28 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
        }
        else if (_posts.Count == 0)
        {

#line default
#line hidden
            __builder.AddContent(32, "            ");
            __builder.AddMarkupContent(33, "<li>没有帖子</li>\r\n");
#line 32 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
        }

#line default
#line hidden
#line 33 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
         foreach (var post in _posts)
        {

#line default
#line hidden
            __builder.AddContent(34, "            ");
            __builder.OpenElement(35, "li");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.AddContent(37, 
#line 36 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                  (MarkupString)post.PostText

#line default
#line hidden
            );
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "list-item-details");
            __builder.AddMarkupContent(41, "\r\n                    Posted ");
            __builder.AddContent(42, 
#line 38 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                            DateTimeFormatting.RelativeDateAgo(post.PostedDate)

#line default
#line hidden
            );
            __builder.AddMarkupContent(43, "\r\n                    by ");
            __builder.AddContent(44, 
#line 39 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                        post.UserName

#line default
#line hidden
            );
            __builder.AddContent(45, "  | Flags ");
            __builder.AddContent(46, 
#line 39 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                                                post.Flags

#line default
#line hidden
            );
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "href", 
#line 41 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                                  String.Format("/admin/manage/forums/{0}/categories/{1}/topics/{2}/posts/{3}/edit", forumId, categoryId, topicId, post.ForumPostId)

#line default
#line hidden
            );
            __builder.AddAttribute(52, "class", "btn btn-sm btn-blazorforum mt-1 mr-2");
            __builder.AddMarkupContent(53, "\r\n                            编辑\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-sm btn-blazorforum-danger mt-1");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 45 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
                                                                                           () => DeletePostClicked(post.ForumPostId)

#line default
#line hidden
            ));
            __builder.AddMarkupContent(58, "\r\n                            删除\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#line 51 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
        }

#line default
#line hidden
            __builder.AddContent(63, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 55 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumTopic.razor"
       
    [Parameter] public int forumId { get; set; }
    [Parameter] public int categoryId { get; set; }
    [Parameter] public int topicId { get; set; }
    private Models.ForumTopic _topic = new Models.ForumTopic();
    private List<Models.ForumPost> _posts = new List<Models.ForumPost>();
    private int _postIdToDelete = -1;

    public void Dispose()
    {
        blazorModal.OnConfirmDeleteForumTopic -= DeleteTopicConfirmedAsync;
        blazorModal.OnConfirmDeleteForumPostItem -= DeletePostConfirmedAsync;
    }

    protected override async Task OnInitializedAsync()
    {
        _topic = await manageTopics.GetForumTopicAsync(topicId);
        head.Title = "Forum Topic | Administration";
        await LoadPostsAsync();

        blazorModal.OnConfirmDeleteForumTopic += DeleteTopicConfirmedAsync;
        blazorModal.OnConfirmDeleteForumPostItem += DeletePostConfirmedAsync;
    }

    private async Task LoadPostsAsync()
    {
        _posts = await managePosts.GetForumPostsAsync(topicId);
        _posts = _posts.OrderByDescending(p => p.PostedDate).ToList();
        await AddUserToPost();
    }

    private async Task AddUserToPost()
    {
        foreach (var post in _posts)
        {
            var user = await userManager.FindByIdAsync(post.UserId);
            post.UserName = user.UserName;
        }
    }

    private void DeleteTopicClicked()
    {
        var modalMessage = "确定要删除话题及相应的帖子吗?";
        blazorModal.Show<ConfirmModal>("删除话题",
            BlazorModalParameter.Get("ModalText", modalMessage),
            BlazorModalParameter.Get("ItemToDelete", "topic"));
    }

    private void DeletePostClicked(int id)
    {
        _postIdToDelete = id;
        var modalMessage = "确定要删除帖子吗?";
        blazorModal.Show<ConfirmModal>("删除帖子",
            BlazorModalParameter.Get("ModalText", modalMessage),
            BlazorModalParameter.Get("ItemToDelete", "post-item"));
    }

    public async void DeleteTopicConfirmedAsync()
    {
        blazorModal.Close();

        var deletedTopic = await manageTopics.DeleteForumTopicAsync(topicId);
        if (deletedTopic)
            navManager.NavigateTo(String.Format("/admin/manage/forums/{0}/categories/{1}", forumId, categoryId));
    }

    public async void DeletePostConfirmedAsync()
    {
        if (_postIdToDelete != -1)
        {
            blazorModal.Close();

            var deleted = await managePosts.DeletePostAsync(_postIdToDelete);
            if (deleted)
                await LoadPostsAsync();
            _postIdToDelete = -1;
            StateHasChanged();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorModal blazorModal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumPosts managePosts { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumTopics manageTopics { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HeadBuilderService head { get; set; }
    }
}
#pragma warning restore 1591
