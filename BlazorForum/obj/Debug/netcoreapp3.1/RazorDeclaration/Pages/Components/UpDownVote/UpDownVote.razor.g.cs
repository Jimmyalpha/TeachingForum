#pragma checksum "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\UpDownVote\UpDownVote.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce881aa95ddafaa30819650266462e72c7a1d90"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorForum.Pages.Components.UpDownVote
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
    public partial class UpDownVote : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 12 "D:\CLASS\软件工程\大程\论坛\TeachingForum\BlazorForum\Pages\Components\UpDownVote\UpDownVote.razor"
       
    /// <summary>
    /// The UniqueIdentifier is what keeps the results assigned properly and prevents PostId conflicts. 
    /// NEVER change this after it has been used and logged into storage.
    /// </summary>
    [Parameter] public string UniqueIdentifier { get; set; }
    [Parameter] public int PostId { get; set; }
    [Parameter] public string PosterId { get; set; }
    [Parameter] public string VoterId { get; set; }
    public int totalCount = 0;
    private bool disabled = true;
    private string disabledClass;

    protected override async Task OnInitializedAsync()
    {
        totalCount = await manageUpDownVotes.GetPostUpDownVoteCountAsync(PostId);

        await SetUpDownVoteVisibility();
    }

    private async Task OnClickIncrement(int voteIncrement)
    {
        if(VoterId != null)
        {
            var added = await manageUpDownVotes.AddPostUpDownVoteAsync(BuildNewPostVote(voteIncrement));
            if (added)
            {
                totalCount = await manageUpDownVotes.GetPostUpDownVoteCountAsync(PostId);
                await SetUpDownVoteVisibility();
            }
        }
    }

    private Models.UpDownVote BuildNewPostVote(int voteIncrement)
    {
        var newUpDownVote = new Models.UpDownVote
        {
            PostId = PostId,
            PosterId = PosterId,
            VoterId = VoterId,
            UniqueIdentifier = UniqueIdentifier,
            DateVoted = DateTime.Now.ToUniversalTime(),
            VoteIncrement = voteIncrement
        };
        return newUpDownVote;
    }

    private async Task SetUpDownVoteVisibility()
    {
        if (VoterId != null && PosterId != VoterId && await manageUpDownVotes.VoterHasVoted(VoterId, PostId) == false)
            disabled = false;
        else
        {
            disabled = true;
            disabledClass = "disabled";
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.ApplicationDbContext context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IManageUpDownVotes manageUpDownVotes { get; set; }
    }
}
#pragma warning restore 1591
