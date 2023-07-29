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

  [Route("odata/dbOptimoBCLive/BcScanViewProductionOrders")]
  public partial class BcScanViewProductionOrdersController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewProductionOrdersController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewProductionOrders
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewProductionOrder> GetBcScanViewProductionOrders()
    {
      var items = this.context.BcScanViewProductionOrders.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewProductionOrder>();
      this.OnBcScanViewProductionOrdersRead(ref items);

      return items;
    }

    partial void OnBcScanViewProductionOrdersRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewProductionOrder> items);

    partial void OnBcScanViewProductionOrderGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewProductionOrder> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewProductionOrders(timestamp={timestamp})")]
    public SingleResult<BcScanViewProductionOrder> GetBcScanViewProductionOrder(Byte[] key)
    {
        var items = this.context.BcScanViewProductionOrders.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewProductionOrderGet(ref result);

        return result;
    }
  }
}
