using System;
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
    public partial class BcToolsViewVerkaufsauftraegeOhneFNummer02Component : ComponentBase
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
        protected RadzenDataGrid<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02> grid0;

        IEnumerable<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02> _getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult;
        protected IEnumerable<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02> getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult
        {
            get
            {
                return _getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult;
            }
            set
            {
                if (!object.Equals(_getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult", NewValue = value, OldValue = _getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult };
                    _getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount;
        protected int getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount
        {
            get
            {
                return _getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount;
            }
            set
            {
                if (!object.Equals(_getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount", NewValue = value, OldValue = _getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount };
                    _getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {

        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var dbOptimo2003GetBcToolsViewVerkaufsauftraegeOhneFNummer02SResult = await DbOptimo2003.GetBcToolsViewVerkaufsauftraegeOhneFNummer02S(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getBcToolsViewVerkaufsauftraegeOhneFNummer02sResult = dbOptimo2003GetBcToolsViewVerkaufsauftraegeOhneFNummer02SResult.Value.AsODataEnumerable();

                getBcToolsViewVerkaufsauftraegeOhneFNummer02sCount = dbOptimo2003GetBcToolsViewVerkaufsauftraegeOhneFNummer02SResult.Count;
            }
            catch (System.Exception dbOptimo2003GetBcToolsViewVerkaufsauftraegeOhneFNummer02SException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load BcToolsViewVerkaufsauftraegeOhneFNummer02s" });
            }
        }
    }
}
