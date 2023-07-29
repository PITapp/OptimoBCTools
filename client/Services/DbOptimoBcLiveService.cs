
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using OptimoBcTools.Models.DbOptimoBcLive;

namespace OptimoBcTools
{
    public partial class DbOptimoBcLiveService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public DbOptimoBcLiveService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/dbOptimoBCLive/");
        }

        public async System.Threading.Tasks.Task ExportBcAnalysenViewItemsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcanalysenviewitems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcanalysenviewitems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcAnalysenViewItemsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcanalysenviewitems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcanalysenviewitems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcAnalysenViewItems(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>> GetBcAnalysenViewItems(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcAnalysenViewItems");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcAnalysenViewItems(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcAnalysenViewItemLedgerEntriesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcanalysenviewitemledgerentries/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcanalysenviewitemledgerentries/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcAnalysenViewItemLedgerEntriesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcanalysenviewitemledgerentries/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcanalysenviewitemledgerentries/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcAnalysenViewItemLedgerEntries(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>> GetBcAnalysenViewItemLedgerEntries(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcAnalysenViewItemLedgerEntries");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcAnalysenViewItemLedgerEntries(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcAnalysenViewProduzierteArtikelJahrMonatsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcanalysenviewproduzierteartikeljahrmonats/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcanalysenviewproduzierteartikeljahrmonats/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcAnalysenViewProduzierteArtikelJahrMonatsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcanalysenviewproduzierteartikeljahrmonats/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcanalysenviewproduzierteartikeljahrmonats/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcAnalysenViewProduzierteArtikelJahrMonats(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>> GetBcAnalysenViewProduzierteArtikelJahrMonats(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcAnalysenViewProduzierteArtikelJahrMonats");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcAnalysenViewProduzierteArtikelJahrMonats(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanBenutzersToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanbenutzers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanbenutzers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanBenutzersToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanbenutzers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanbenutzers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanBenutzers(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>> GetBcScanBenutzers(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanBenutzers");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanBenutzers(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>>(response);
        }
        partial void OnCreateBcScanBenutzer(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer> CreateBcScanBenutzer(OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer bcScanBenutzer = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer))
        {
            var uri = new Uri(baseUri, $"BcScanBenutzers");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanBenutzer), Encoding.UTF8, "application/json");

            OnCreateBcScanBenutzer(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanDevicesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscandevices/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscandevices/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanDevicesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscandevices/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscandevices/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanDevices(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>> GetBcScanDevices(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanDevices");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanDevices(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>>(response);
        }
        partial void OnCreateBcScanDevice(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice> CreateBcScanDevice(OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice bcScanDevice = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice))
        {
            var uri = new Uri(baseUri, $"BcScanDevices");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanDevice), Encoding.UTF8, "application/json");

            OnCreateBcScanDevice(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanProtokollLadelistesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanprotokollladelistes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanprotokollladelistes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanProtokollLadelistesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanprotokollladelistes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanprotokollladelistes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanProtokollLadelistes(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>> GetBcScanProtokollLadelistes(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollLadelistes");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanProtokollLadelistes(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>>(response);
        }
        partial void OnCreateBcScanProtokollLadeliste(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste> CreateBcScanProtokollLadeliste(OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste bcScanProtokollLadeliste = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollLadelistes");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanProtokollLadeliste), Encoding.UTF8, "application/json");

            OnCreateBcScanProtokollLadeliste(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanProtokollUmlagernsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanprotokollumlagerns/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanprotokollumlagerns/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanProtokollUmlagernsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanprotokollumlagerns/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanprotokollumlagerns/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanProtokollUmlagerns(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>> GetBcScanProtokollUmlagerns(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollUmlagerns");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanProtokollUmlagerns(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>>(response);
        }
        partial void OnCreateBcScanProtokollUmlagern(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern> CreateBcScanProtokollUmlagern(OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern bcScanProtokollUmlagern = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollUmlagerns");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanProtokollUmlagern), Encoding.UTF8, "application/json");

            OnCreateBcScanProtokollUmlagern(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewArtikelsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewartikels/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewartikels/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewArtikelsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewartikels/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewartikels/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewArtikels(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikel>> GetBcScanViewArtikels(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewArtikels");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewArtikels(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikel>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewArtikelLagerbestandsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewartikellagerbestands/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewartikellagerbestands/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewArtikelLagerbestandsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewartikellagerbestands/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewartikellagerbestands/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewArtikelLagerbestands(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand>> GetBcScanViewArtikelLagerbestands(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewArtikelLagerbestands");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewArtikelLagerbestands(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewBenutzersToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewbenutzers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewbenutzers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewBenutzersToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewbenutzers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewbenutzers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewBenutzers(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer>> GetBcScanViewBenutzers(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewBenutzers");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewBenutzers(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryToursToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytours/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytours/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryToursToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytours/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytours/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewDeliveryTours(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>> GetBcScanViewDeliveryTours(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewDeliveryTours");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewDeliveryTours(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryTourGroupedLinesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytourgroupedlines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytourgroupedlines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryTourGroupedLinesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytourgroupedlines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytourgroupedlines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewDeliveryTourGroupedLines(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>> GetBcScanViewDeliveryTourGroupedLines(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewDeliveryTourGroupedLines");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewDeliveryTourGroupedLines(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryTourPlanHeadersToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytourplanheaders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytourplanheaders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryTourPlanHeadersToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytourplanheaders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytourplanheaders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewDeliveryTourPlanHeaders(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>> GetBcScanViewDeliveryTourPlanHeaders(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewDeliveryTourPlanHeaders");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewDeliveryTourPlanHeaders(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryTourPlanLinesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytourplanlines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytourplanlines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDeliveryTourPlanLinesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdeliverytourplanlines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdeliverytourplanlines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewDeliveryTourPlanLines(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>> GetBcScanViewDeliveryTourPlanLines(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewDeliveryTourPlanLines");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewDeliveryTourPlanLines(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDevicesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdevices/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdevices/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewDevicesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewdevices/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewdevices/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewDevices(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>> GetBcScanViewDevices(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewDevices");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewDevices(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewItemsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewitems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewitems/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewItemsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewitems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewitems/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewItems(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>> GetBcScanViewItems(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewItems");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewItems(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewItemJournalLinesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewitemjournallines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewitemjournallines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewItemJournalLinesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewitemjournallines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewitemjournallines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewItemJournalLines(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>> GetBcScanViewItemJournalLines(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewItemJournalLines");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewItemJournalLines(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewItemJournalLineUmlagernNeueZeilenNrsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewitemjournallineumlagernneuezeilennrs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewitemjournallineumlagernneuezeilennrs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewItemJournalLineUmlagernNeueZeilenNrsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewitemjournallineumlagernneuezeilennrs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewitemjournallineumlagernneuezeilennrs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewItemJournalLineUmlagernNeueZeilenNrs(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr>> GetBcScanViewItemJournalLineUmlagernNeueZeilenNrs(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewItemJournalLineUmlagernNeueZeilenNrs");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewItemJournalLineUmlagernNeueZeilenNrs(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewLadelisteKopfsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewladelistekopfs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewladelistekopfs/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewLadelisteKopfsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewladelistekopfs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewladelistekopfs/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewLadelisteKopfs(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>> GetBcScanViewLadelisteKopfs(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewLadelisteKopfs");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewLadelisteKopfs(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewLadelisteZeilensToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewladelistezeilens/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewladelistezeilens/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewLadelisteZeilensToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewladelistezeilens/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewladelistezeilens/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewLadelisteZeilens(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>> GetBcScanViewLadelisteZeilens(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewLadelisteZeilens");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewLadelisteZeilens(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProductionOrdersToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewproductionorders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewproductionorders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProductionOrdersToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewproductionorders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewproductionorders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewProductionOrders(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>> GetBcScanViewProductionOrders(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewProductionOrders");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewProductionOrders(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProductionOrderLinesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewproductionorderlines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewproductionorderlines/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProductionOrderLinesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewproductionorderlines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewproductionorderlines/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewProductionOrderLines(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>> GetBcScanViewProductionOrderLines(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewProductionOrderLines");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewProductionOrderLines(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProductionOrderProducedsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewproductionorderproduceds/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewproductionorderproduceds/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProductionOrderProducedsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewproductionorderproduceds/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewproductionorderproduceds/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewProductionOrderProduceds(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderProduced>> GetBcScanViewProductionOrderProduceds(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewProductionOrderProduceds");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewProductionOrderProduceds(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderProduced>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProtokollLadelistesToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewprotokollladelistes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewprotokollladelistes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProtokollLadelistesToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewprotokollladelistes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewprotokollladelistes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewProtokollLadelistes(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>> GetBcScanViewProtokollLadelistes(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewProtokollLadelistes");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewProtokollLadelistes(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProtokollUmlagernsToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewprotokollumlagerns/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewprotokollumlagerns/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewProtokollUmlagernsToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewprotokollumlagerns/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewprotokollumlagerns/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewProtokollUmlagerns(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>> GetBcScanViewProtokollUmlagerns(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewProtokollUmlagerns");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewProtokollUmlagerns(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewUmlagerungLetzteNummersToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewumlagerungletztenummers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewumlagerungletztenummers/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcScanViewUmlagerungLetzteNummersToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimobclive/bcscanviewumlagerungletztenummers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimobclive/bcscanviewumlagerungletztenummers/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcScanViewUmlagerungLetzteNummers(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer>> GetBcScanViewUmlagerungLetzteNummers(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcScanViewUmlagerungLetzteNummers");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanViewUmlagerungLetzteNummers(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer>>(response);
        }
        partial void OnDeleteBcScanBenutzer(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteBcScanBenutzer(int? benutzerId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanBenutzers({benutzerId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteBcScanBenutzer(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetBcScanBenutzerByBenutzerId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer> GetBcScanBenutzerByBenutzerId(string expand = default(string), int? benutzerId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanBenutzers({benutzerId})");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:null, top:null, skip:null, orderby:null, expand:expand, select:null, count:null);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanBenutzerByBenutzerId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>(response);
        }
        partial void OnUpdateBcScanBenutzer(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateBcScanBenutzer(int? benutzerId = default(int?), OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer bcScanBenutzer = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer))
        {
            var uri = new Uri(baseUri, $"BcScanBenutzers({benutzerId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanBenutzer), Encoding.UTF8, "application/json");

            OnUpdateBcScanBenutzer(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeleteBcScanDevice(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteBcScanDevice(int? deviceId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanDevices({deviceId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteBcScanDevice(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetBcScanDeviceByDeviceId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice> GetBcScanDeviceByDeviceId(string expand = default(string), int? deviceId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanDevices({deviceId})");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:null, top:null, skip:null, orderby:null, expand:expand, select:null, count:null);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanDeviceByDeviceId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>(response);
        }
        partial void OnUpdateBcScanDevice(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateBcScanDevice(int? deviceId = default(int?), OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice bcScanDevice = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice))
        {
            var uri = new Uri(baseUri, $"BcScanDevices({deviceId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanDevice), Encoding.UTF8, "application/json");

            OnUpdateBcScanDevice(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeleteBcScanProtokollLadeliste(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteBcScanProtokollLadeliste(int? protokollId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollLadelistes({protokollId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteBcScanProtokollLadeliste(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetBcScanProtokollLadelisteByProtokollId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste> GetBcScanProtokollLadelisteByProtokollId(string expand = default(string), int? protokollId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollLadelistes({protokollId})");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:null, top:null, skip:null, orderby:null, expand:expand, select:null, count:null);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanProtokollLadelisteByProtokollId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>(response);
        }
        partial void OnUpdateBcScanProtokollLadeliste(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateBcScanProtokollLadeliste(int? protokollId = default(int?), OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste bcScanProtokollLadeliste = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollLadelistes({protokollId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanProtokollLadeliste), Encoding.UTF8, "application/json");

            OnUpdateBcScanProtokollLadeliste(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeleteBcScanProtokollUmlagern(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteBcScanProtokollUmlagern(int? protokollId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollUmlagerns({protokollId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteBcScanProtokollUmlagern(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetBcScanProtokollUmlagernByProtokollId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern> GetBcScanProtokollUmlagernByProtokollId(string expand = default(string), int? protokollId = default(int?))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollUmlagerns({protokollId})");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:null, top:null, skip:null, orderby:null, expand:expand, select:null, count:null);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcScanProtokollUmlagernByProtokollId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>(response);
        }
        partial void OnUpdateBcScanProtokollUmlagern(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateBcScanProtokollUmlagern(int? protokollId = default(int?), OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern bcScanProtokollUmlagern = default(OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern))
        {
            var uri = new Uri(baseUri, $"BcScanProtokollUmlagerns({protokollId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);


            httpRequestMessage.Content = new StringContent(Radzen.ODataJsonSerializer.Serialize(bcScanProtokollUmlagern), Encoding.UTF8, "application/json");

            OnUpdateBcScanProtokollUmlagern(httpRequestMessage);

            return await httpClient.SendAsync(httpRequestMessage);
        }
    }
}
