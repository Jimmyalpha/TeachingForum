#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ca2438a71222d0a6514d46ffb0ebb47de545ab"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/forums/{id:int}/edit")]
    public partial class ForumEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Forum</h3>\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content-container");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                      forum

#line default
#line hidden
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 7 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                            UpdateForum

#line default
#line hidden
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "input-group");
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.AddMarkupContent(14, "<div class=\"input-group-prepend\">\n                <label class=\"input-group-text\">Title</label>\n            </div>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "Title");
                __builder2.AddAttribute(17, "class", 
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                                                    titleClass

#line default
#line hidden
                );
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 13 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                               forum.Title

#line default
#line hidden
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => forum.Title = __value, forum.Title))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => forum.Title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n        ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumEdit.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#line 15 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                  () => forum.Title

#line default
#line hidden
                );
                __builder2.AddMarkupContent(25, "\n\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "input-group mt-2");
                __builder2.AddMarkupContent(28, "\n            ");
                __builder2.AddMarkupContent(29, "<div class=\"input-group-prepend\">\n                <label class=\"input-group-text\">支持赞/踩</label>\n            </div>\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddMarkupContent(32, "\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(33);
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 22 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                            forum.EnableUpDownVotes

#line default
#line hidden
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => forum.EnableUpDownVotes = __value, forum.EnableUpDownVotes))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => forum.EnableUpDownVotes));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(40);
                __builder2.AddAttribute(41, "id", "Description");
                __builder2.AddAttribute(42, "rows", "3");
                __builder2.AddAttribute(43, "class", 
#line 26 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                                                                         textAreaClass

#line default
#line hidden
                );
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 26 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                                     forum.Description

#line default
#line hidden
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => forum.Description = __value, forum.Description))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => forum.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\n        ");
                __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumEdit.TypeInference.CreateValidationMessage_1(__builder2, 48, 49, 
#line 27 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                  () => forum.Description

#line default
#line hidden
                );
                __builder2.AddMarkupContent(50, "\n        ");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "class", "btn" + " btn-blazorforum" + " mt-2" + " mr-2" + " " + (
#line 28 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                                      btnVisibility

#line default
#line hidden
                ));
                __builder2.AddAttribute(53, "type", "submit");
                __builder2.AddMarkupContent(54, "更新");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n        ");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "class", "btn" + " btn-blazorforum" + " mt-2" + " " + (
#line 29 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                                 btnVisibility

#line default
#line hidden
                ));
                __builder2.AddAttribute(58, "type", "button");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 29 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                                                                        (() => CancelClick())

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(60, "取消");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\n        ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "rounded" + " bg-blazorforumbtn" + " p-2" + " mt-2" + " text-light" + " " + (
#line 30 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                                                   submitVisibility

#line default
#line hidden
                ));
                __builder2.AddMarkupContent(64, "\n            <i class=\"oi oi-cog se-spin-icon\"></i> Updating...\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\n\n");
#line 35 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
     if (_showError)
    {

#line default
#line hidden
            __builder.AddContent(67, "        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "alert alert-danger mt-2 mb-0");
            __builder.AddMarkupContent(70, "\n            ");
            __builder.OpenElement(71, "span");
            __builder.AddAttribute(72, "class", "text-danger");
            __builder.AddContent(73, 
#line 38 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
                                       _errorMsg

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n");
#line 40 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 43 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Areas\Admin\Pages\Components\Forums\ForumEdit.razor"
       
    [Parameter] public int id { get; set; }
    private Models.Forum forum = new Models.Forum();
    private string titleClass { get; set; } = "form-control";
    private string textAreaClass { get; set; } = "mt-2 form-control";
    private string btnVisibility = "d-inline-block";
    private string submitVisibility = "d-none";
    private bool _showError = false;
    private string _errorMsg;

    protected override async Task OnInitializedAsync()
    {
        forum = await manageForums.GetForumAsync(id);
    }

    private async Task UpdateForum()
    {
        try
        {
            var editedForum = new Models.Forum()
            {
                Title = forum.Title,
                Description = forum.Description,
                EnableUpDownVotes = forum.EnableUpDownVotes,
                ForumId = id
            };

            btnVisibility = "d-none";
            submitVisibility = "d-inline-block";

            var updated = await manageForums.UpdateForumAsync(editedForum);

            btnVisibility = "d-inline-block";
            submitVisibility = "d-none";

            navManager.NavigateTo("/admin/manage/forums/" + id);
        }
        catch(Exception ex)
        {
            btnVisibility = "d-inline-block";
            submitVisibility = "d-none";
            _showError = true;
            _errorMsg = ex.Message;
        }
    }

    private void CancelClick()
    {
        navManager.NavigateTo("/admin/manage/forums/" + id);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForums manageForums { get; set; }
    }
}
namespace __Blazor.BlazorForum.Areas.Admin.Pages.Components.Forums.ForumEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
