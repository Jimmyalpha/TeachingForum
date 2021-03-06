#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f6f8decefcbde8031562cfe455ed5535207abe"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/forums/{forumId:int}/categories/{categoryId:int}/topics/{topicId:int}/posts/{postId:int}/edit")]
    public partial class ForumPostEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Post</h3>\n");
#line 9 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
 if(_forumPost != null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "content-container");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
                         _forumPost

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
                                                    UpdatePostAsync

#line default
#line hidden
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "ckeditor-container");
                __builder2.AddMarkupContent(14, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(15);
                __builder2.AddAttribute(16, "id", "PostText");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 15 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
                                                          _forumPost.PostText

#line default
#line hidden
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _forumPost.PostText = __value, _forumPost.PostText))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _forumPost.PostText));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "container-fluid p-0");
                __builder2.AddMarkupContent(25, "\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "row");
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-12 col-md-6");
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "input-group mt-2");
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.AddMarkupContent(35, "<div class=\"input-group-prepend\">\r\n                                <label class=\"input-group-text\">是否显示</label>\r\n                            </div>\r\n                            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddMarkupContent(38, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(39);
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 25 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
                                                            _forumPost.IsApproved

#line default
#line hidden
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _forumPost.IsApproved = __value, _forumPost.IsApproved))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => _forumPost.IsApproved));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                    \r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "input-group mt-2");
                __builder2.AddMarkupContent(51, "\n                ");
                __builder2.AddMarkupContent(52, "<div class=\"input-group-prepend\">\n                    <label class=\"input-group-text\">编辑理由</label>\n                </div>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 45 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
                                        _forumPost.EditReason

#line default
#line hidden
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _forumPost.EditReason = __value, _forumPost.EditReason))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _forumPost.EditReason));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\n            ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumPostEdit.TypeInference.CreateValidationMessage_0(__builder2, 60, 61, 
#line 47 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
                                      () => _forumPost.EditReason

#line default
#line hidden
                , 62, "text-danger");
                __builder2.AddMarkupContent(63, "\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "mt-2");
                __builder2.AddMarkupContent(66, "\n                ");
                __builder2.AddMarkupContent(67, "<button class=\"btn btn-blazorforum mr-2\" type=\"submit\">更新</button>\n                ");
                __builder2.OpenElement(68, "a");
                __builder2.AddAttribute(69, "class", "btn btn-blazorforum");
                __builder2.AddAttribute(70, "href", 
#line 51 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
                          String.Format("/admin/manage/forums/{0}/categories/{1}/topics/{2}",
                          forumId, categoryId, topicId)

#line default
#line hidden
                );
                __builder2.AddContent(71, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n");
#line 56 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 58 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumPostEdit.razor"
       
    [Parameter] public int forumId { get; set; }
    [Parameter] public int categoryId { get; set; }
    [Parameter] public int topicId { get; set; }
    [Parameter] public int postId { get; set; }
    private Models.ForumPost _forumPost = new Models.ForumPost();

    protected override async Task OnInitializedAsync()
    {
        _forumPost = await managePosts.GetForumPostAsync(postId);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("methods.loadEditor", "PostText");
        }
    }

    private async void UpdatePostAsync()
    {
        // Should probably eventually validate to make sure post text isn't empty (CKEditor has a placeholder tag)...but only administrators can edit it at this point.
        _forumPost.PostText = await jsRuntime.InvokeAsync<string>("methods.getEditorText");
        _forumPost.IsModeratorChanged = true;
        _forumPost.EditedDate = DateTime.Now.ToUniversalTime();
        _forumPost.EditedBy = await new Domain.Utilities.Membership.UserInfo(userManager, authStateProvider).GetUserId();

        var updated = await managePosts.UpdatePostAsync(_forumPost);
        if(updated)
            navManager.NavigateTo(String.Format("/admin/manage/forums/{0}/categories/{1}/topics/{2}", forumId, categoryId, topicId));
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumPosts managePosts { get; set; }
    }
}
namespace __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumPostEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
