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

  [Route("odata/dbOptimoBCLive/BcScanViewArtikels")]
  public partial class BcScanViewArtikelsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewArtikelsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewArtikels
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewArtikel> GetBcScanViewArtikels()
    {
      var items = this.context.BcScanViewArtikels.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewArtikel>();
      this.OnBcScanViewArtikelsRead(ref items);

      return items;
    }

    partial void OnBcScanViewArtikelsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewArtikel> items);

    partial void OnBcScanViewArtikelGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewArtikel> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewArtikels(timestamp={timestamp})")]
    public SingleResult<BcScanViewArtikel> GetBcScanViewArtikel(Byte[] key)
    {
        var items = this.context.BcScanViewArtikels.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewArtikelGet(ref result);

        return result;
    }
  }
}
