
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
using OptimoBcTools.Models.DbOptimo2003;

namespace OptimoBcTools
{
    public partial class DbOptimo2003Service
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public DbOptimo2003Service(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/dbOptimo2003/");
        }

        public async System.Threading.Tasks.Task ExportBcToolsViewVerkaufsauftraegeOhneFNummer01SToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcToolsViewVerkaufsauftraegeOhneFNummer01SToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcToolsViewVerkaufsauftraegeOhneFNummer01S(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>> GetBcToolsViewVerkaufsauftraegeOhneFNummer01S(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcToolsViewVerkaufsauftraegeOhneFNummer01s");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcToolsViewVerkaufsauftraegeOhneFNummer01S(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>>(response);
        }

        public async System.Threading.Tasks.Task ExportBcToolsViewVerkaufsauftraegeOhneFNummer02SToExcel(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportBcToolsViewVerkaufsauftraegeOhneFNummer02SToCSV(Radzen.Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/dboptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetBcToolsViewVerkaufsauftraegeOhneFNummer02S(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02>> GetBcToolsViewVerkaufsauftraegeOhneFNummer02S(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string), string select = default(string))
        {
            var uri = new Uri(baseUri, $"BcToolsViewVerkaufsauftraegeOhneFNummer02s");
            uri = Radzen.ODataExtensions.GetODataUri(uri: uri, filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:select, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetBcToolsViewVerkaufsauftraegeOhneFNummer02S(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await Radzen.HttpResponseMessageExtensions.ReadAsync<Radzen.ODataServiceResult<OptimoBcTools.Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02>>(response);
        }
    }
}
