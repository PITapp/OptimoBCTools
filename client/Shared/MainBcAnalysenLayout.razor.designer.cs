using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using OptimoBcTools.Models.DbOptimoBcLive;
using OptimoBcTools.Pages;

namespace OptimoBcTools.Layouts
{
    public partial class MainBcAnalysenLayoutComponent : LayoutComponentBase
    {
        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected DbOptimoBcLiveService DbOptimoBcLive { get; set; }

        protected RadzenSidebar sidebar0;
        protected RadzenBody body0;


        protected async System.Threading.Tasks.Task Button1Click(MouseEventArgs args)
        {
            await InvokeAsync(() => { sidebar0.Toggle(); });
await InvokeAsync(() => { body0.Toggle(); });
        }

        protected async System.Threading.Tasks.Task Image0Click(dynamic args)
        {
            await InvokeAsync(() => { sidebar0.Toggle(); });

            await InvokeAsync(() => { body0.Toggle(); });
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            await InvokeAsync(() => { sidebar0.Toggle(); });
await InvokeAsync(() => { body0.Toggle(); });
        }
    }
}
