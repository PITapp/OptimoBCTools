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

  [Route("odata/dbOptimoBCLive/BcScanViewDeliveryTourGroupedLines")]
  public partial class BcScanViewDeliveryTourGroupedLinesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewDeliveryTourGroupedLinesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewDeliveryTourGroupedLines
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine> GetBcScanViewDeliveryTourGroupedLines()
    {
      var items = this.context.BcScanViewDeliveryTourGroupedLines.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>();
      this.OnBcScanViewDeliveryTourGroupedLinesRead(ref items);

      return items;
    }

    partial void OnBcScanViewDeliveryTourGroupedLinesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine> items);

    partial void OnBcScanViewDeliveryTourGroupedLineGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewDeliveryTourGroupedLines(timestamp={timestamp})")]
    public SingleResult<BcScanViewDeliveryTourGroupedLine> GetBcScanViewDeliveryTourGroupedLine(Byte[] key)
    {
        var items = this.context.BcScanViewDeliveryTourGroupedLines.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewDeliveryTourGroupedLineGet(ref result);

        return result;
    }
  }
}
