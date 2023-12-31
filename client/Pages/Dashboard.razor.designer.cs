﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using OptimoBcTools.Models.DbOptimoBcLive;
using OptimoBcTools.Models.DbOptimo2003;
using OptimoBcTools.Client.Pages;

namespace OptimoBcTools.Pages
{
    public partial class DashboardComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

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

        [Inject]
        protected DbOptimo2003Service DbOptimo2003 { get; set; }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("bc-analysen");
        }

        protected async System.Threading.Tasks.Task Button1Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("bc-analysen-admin");
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("bc-scan-admin");
        }

        protected async System.Threading.Tasks.Task Button3Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("ai-informationssystem");
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("it-support");
        }

        protected async System.Threading.Tasks.Task Button5Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("it-wissensdatenbank");
        }

        protected async System.Threading.Tasks.Task Button6Click(MouseEventArgs args)
        {
            UriHelper.NavigateTo("bc-tools-view-verkaufsauftraege-ohne-f-nummer-02");
        }
    }
}
