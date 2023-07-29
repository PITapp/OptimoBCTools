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

  [Route("odata/dbOptimoBCLive/BcScanViewProductionOrderProduceds")]
  public partial class BcScanViewProductionOrderProducedsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewProductionOrderProducedsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewProductionOrderProduceds
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewProductionOrderProduced> GetBcScanViewProductionOrderProduceds()
    {
      var items = this.context.BcScanViewProductionOrderProduceds.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewProductionOrderProduced>();
      this.OnBcScanViewProductionOrderProducedsRead(ref items);

      return items;
    }

    partial void OnBcScanViewProductionOrderProducedsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewProductionOrderProduced> items);

    partial void OnBcScanViewProductionOrderProducedGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewProductionOrderProduced> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewProductionOrderProduceds(Produziert={Produziert})")]
    public SingleResult<BcScanViewProductionOrderProduced> GetBcScanViewProductionOrderProduced(string key)
    {
        var items = this.context.BcScanViewProductionOrderProduceds.AsNoTracking().Where(i=>i.Produziert == Uri.UnescapeDataString(key));
        var result = SingleResult.Create(items);

        OnBcScanViewProductionOrderProducedGet(ref result);

        return result;
    }
  }
}
