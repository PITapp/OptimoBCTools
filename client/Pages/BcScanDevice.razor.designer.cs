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
using OptimoBcTools.Client.Pages;

namespace OptimoBcTools.Pages
{
    public partial class BcScanDeviceComponent : ComponentBase
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
        protected RadzenDataGrid<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice> grid0;

        OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice _bcscandevice;
        protected OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice bcscandevice
        {
            get
            {
                return _bcscandevice;
            }
            set
            {
                if (!object.Equals(_bcscandevice, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "bcscandevice", NewValue = value, OldValue = _bcscandevice };
                    _bcscandevice = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice> _getBcScanDevicesResult;
        protected IEnumerable<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice> getBcScanDevicesResult
        {
            get
            {
                return _getBcScanDevicesResult;
            }
            set
            {
                if (!object.Equals(_getBcScanDevicesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getBcScanDevicesResult", NewValue = value, OldValue = _getBcScanDevicesResult };
                    _getBcScanDevicesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getBcScanDevicesCount;
        protected int getBcScanDevicesCount
        {
            get
            {
                return _getBcScanDevicesCount;
            }
            set
            {
                if (!object.Equals(_getBcScanDevicesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getBcScanDevicesCount", NewValue = value, OldValue = _getBcScanDevicesCount };
                    _getBcScanDevicesCount = value;
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
            bcscandevice = new OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice(){};
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await this.grid0.InsertRow(new OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice());
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var dbOptimoBcLiveGetBcScanDevicesResult = await DbOptimoBcLive.GetBcScanDevices(filter:$"{args.Filter}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getBcScanDevicesResult = dbOptimoBcLiveGetBcScanDevicesResult.Value.AsODataEnumerable();

                getBcScanDevicesCount = dbOptimoBcLiveGetBcScanDevicesResult.Count;
            }
            catch (System.Exception dbOptimoBcLiveGetBcScanDevicesException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load BcScanDevices" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowUpdate(dynamic args)
        {
            var dbOptimoBcLiveUpdateBcScanDeviceResult = await DbOptimoBcLive.UpdateBcScanDevice(deviceId:args.DeviceID, bcScanDevice:args);
        }

        protected async System.Threading.Tasks.Task Grid0RowCreate(dynamic args)
        {
            var dbOptimoBcLiveCreateBcScanDeviceResult = await DbOptimoBcLive.CreateBcScanDevice(bcScanDevice:args);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task EditButtonClick(MouseEventArgs args, dynamic data)
        {
            this.grid0.EditRow(data);
        }

        protected async System.Threading.Tasks.Task SaveButtonClick(MouseEventArgs args, dynamic data)
        {
            this.grid0.UpdateRow(data);
        }

        protected async System.Threading.Tasks.Task CancelButtonClick(MouseEventArgs args, dynamic data)
        {
            this.grid0.CancelEditRow(data);

            await this.Load();

            await this.grid0.Reload();
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var dbOptimoBcLiveDeleteBcScanDeviceResult = await DbOptimoBcLive.DeleteBcScanDevice(deviceId:data.DeviceID);
                    if (dbOptimoBcLiveDeleteBcScanDeviceResult != null && dbOptimoBcLiveDeleteBcScanDeviceResult.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await grid0.Reload();
                    }

                    if (dbOptimoBcLiveDeleteBcScanDeviceResult != null && dbOptimoBcLiveDeleteBcScanDeviceResult.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete BcScanDevice" });
                    }
                }
            }
            catch (System.Exception dbOptimoBcLiveDeleteBcScanDeviceException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete BcScanDevice" });
            }
        }
    }
}
