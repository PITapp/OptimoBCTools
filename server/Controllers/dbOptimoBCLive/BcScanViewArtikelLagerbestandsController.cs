using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Deltas;
using Microsoft.AspNetCore.OData.Formatter;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;




namespace OptimoBcTools.Controllers.DbOptimoBcLive
{
  using Models;
  using Data;
  using Models.DbOptimoBcLive;

  [Route("odata/dbOptimoBCLive/BcScanViewArtikelLagerbestands")]
  public partial class BcScanViewArtikelLagerbestandsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewArtikelLagerbestandsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewArtikelLagerbestands
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand> GetBcScanViewArtikelLagerbestands()
    {
      var items = this.context.BcScanViewArtikelLagerbestands.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand>();
      this.OnBcScanViewArtikelLagerbestandsRead(ref items);

      return items;
    }

    partial void OnBcScanViewArtikelLagerbestandsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand> items);

    partial void OnBcScanViewArtikelLagerbestandGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewArtikelLagerbestands(ArtikelNr={ArtikelNr})")]
    public SingleResult<BcScanViewArtikelLagerbestand> GetBcScanViewArtikelLagerbestand(string key)
    {
        var items = this.context.BcScanViewArtikelLagerbestands.AsNoTracking().Where(i=>i.ArtikelNr == Uri.UnescapeDataString(key));
        var result = SingleResult.Create(items);

        OnBcScanViewArtikelLagerbestandGet(ref result);

        return result;
    }
  }
}
