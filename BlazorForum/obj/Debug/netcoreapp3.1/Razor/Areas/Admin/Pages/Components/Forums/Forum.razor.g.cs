#pragma checksum "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f557730602c1655497baf187a923c79c07954ebf"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForum.Areas.Admin.Pages.Components.Forums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Shared;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Domain.Resources;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Domain.Interfaces;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using Domain.Utilities.Formatting;

#line default
#line hidden
#line 16 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal;

#line default
#line hidden
#line 17 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\_Imports.razor"
using BlazorForum.Pages.Components.BlazorModal.Components;

#line default
#line hidden
#line 1 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 3 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 5 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 6 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 7 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin;

#line default
#line hidden
#line 10 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Areas.Admin.Shared;

#line default
#line hidden
#line 11 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Models;

#line default
#line hidden
#line 12 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Domain.Services;

#line default
#line hidden
#line 13 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using System.Linq;

#line default
#line hidden
#line 14 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#line 15 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\_Imports.razor"
using BlazorForum.Pages.Components.Head;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/manage/forums/{id:int}")]
    public partial class Forum : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "mb-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#line 8 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
              String.Format("/admin/manage/forums/{0}/edit", id)

#line default
#line hidden
            );
            __builder.AddAttribute(5, "class", "btn btn-blazorforum");
            __builder.AddMarkupContent(6, "编辑细节");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-danger float-right");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 9 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
                                                           () => DeleteClicked()

#line default
#line hidden
            ));
            __builder.AddMarkupContent(11, "删除版面");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "section");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "header");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "h3");
            __builder.AddContent(19, 
#line 13 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
             forum.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "forum-details");
            __builder.AddContent(23, 
#line 14 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
                                    forum.Description

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "section");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.AddMarkupContent(28, "<header class=\"secondary-header\">\r\n            <i class=\"oi oi-folder mr-2\"></i>子版块\r\n        </header>\r\n        ");
            __builder.OpenElement(29, "ul");
            __builder.AddAttribute(30, "class", "forum-ul");
            __builder.AddMarkupContent(31, "\r\n");
#line 21 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
             if (categories == null)
            {

#line default
#line hidden
            __builder.AddContent(32, "                ");
            __builder.AddMarkupContent(33, "<li><i class=\"oi oi-cog se-spin-icon\"></i> Loading Categories...</li>\r\n");
#line 24 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
            }
            else if (categories.Count == 0)
            {

#line default
#line hidden
            __builder.AddContent(34, "                ");
            __builder.AddMarkupContent(35, "<li>没有子版块</li>\r\n");
#line 28 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
            }
            else
            {
                foreach (var category in categories)
                {

#line default
#line hidden
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "li");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", 
#line 34 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
                                  String.Format("/admin/manage/forums/{0}/categories/{1}",
                          forum.ForumId, category.ForumCategoryId)

#line default
#line hidden
            );
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.AddContent(42, 
#line 36 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
                             category.Title

#line default
#line hidden
            );
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#line 39 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
                }
            }

#line default
#line hidden
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.OpenElement(50, "section");
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenComponent<BlazorForum.Areas.Admin.Pages.Components.Forums.AddNewCategoryForm>(52);
            __builder.AddAttribute(53, "OnCategoryCreated", new System.Action(
#line 46 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
                                           UpdateCategories

#line default
#line hidden
            ));
            __builder.AddAttribute(54, "ForumId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 46 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
                                                                       id

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 49 "D:\CLASS\软件工程\大程\论坛\BlazorForum-new\BlazorForum\Areas\Admin\Pages\Components\Forums\Forum.razor"
       
    [Parameter] public int id { get; set; }
    private Models.Forum forum = new Models.Forum();
    private List<Models.ForumCategory> categories = new List<Models.ForumCategory>();

    protected override async Task OnInitializedAsync()
    {
        forum = await manageForums.GetForumAsync(id);
        categories = await manageCategories.GetForumCategoriesAsync(id);

        blazorModal.OnConfirmDeleteForum += DeleteForumConfirmed;
    }

    public void Dispose()
    {
        blazorModal.OnConfirmDeleteForum -= DeleteForumConfirmed;
    }

    public async void UpdateCategories()
    {
        categories = await manageCategories.GetForumCategoriesAsync(id);
        StateHasChanged();
    }

    private void DeleteClicked()
    {
        var modalMessage = "你确定要删除版面吗？这同时会删除掉相关的子版块、话题、帖子";
        blazorModal.Show<ConfirmModal>("删除版面", BlazorModalParameter.Get("ModalText", modalMessage),
            BlazorModalParameter.Get("ItemToDelete", "forum"));
    }

    public async void DeleteForumConfirmed()
    {
        blazorModal.Close();
        var deleted = await manageForums.DeleteForumAsync(id);
        if (deleted)
            navManager.NavigateTo("/admin/manage/forums");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBlazorModal blazorModal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForumCategories manageCategories { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageForums manageForums { get; set; }
    }
}
#pragma warning restore 1591
