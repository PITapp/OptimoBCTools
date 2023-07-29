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

  [Route("odata/dbOptimoBCLive/BcScanViewProductionOrderLines")]
  public partial class BcScanViewProductionOrderLinesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewProductionOrderLinesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewProductionOrderLines
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewProductionOrderLine> GetBcScanViewProductionOrderLines()
    {
      var items = this.context.BcScanViewProductionOrderLines.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewProductionOrderLine>();
      this.OnBcScanViewProductionOrderLinesRead(ref items);

      return items;
    }

    partial void OnBcScanViewProductionOrderLinesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewProductionOrderLine> items);

    partial void OnBcScanViewProductionOrderLineGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewProductionOrderLine> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewProductionOrderLines(timestamp={timestamp})")]
    public SingleResult<BcScanViewProductionOrderLine> GetBcScanViewProductionOrderLine(Byte[] key)
    {
        var items = this.context.BcScanViewProductionOrderLines.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewProductionOrderLineGet(ref result);

        return result;
    }
  }
}
