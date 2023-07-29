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

  [Route("odata/dbOptimoBCLive/BcScanViewDeliveryTourPlanLines")]
  public partial class BcScanViewDeliveryTourPlanLinesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewDeliveryTourPlanLinesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewDeliveryTourPlanLines
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine> GetBcScanViewDeliveryTourPlanLines()
    {
      var items = this.context.BcScanViewDeliveryTourPlanLines.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>();
      this.OnBcScanViewDeliveryTourPlanLinesRead(ref items);

      return items;
    }

    partial void OnBcScanViewDeliveryTourPlanLinesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine> items);

    partial void OnBcScanViewDeliveryTourPlanLineGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewDeliveryTourPlanLines(timestamp={timestamp})")]
    public SingleResult<BcScanViewDeliveryTourPlanLine> GetBcScanViewDeliveryTourPlanLine(Byte[] key)
    {
        var items = this.context.BcScanViewDeliveryTourPlanLines.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewDeliveryTourPlanLineGet(ref result);

        return result;
    }
  }
}
