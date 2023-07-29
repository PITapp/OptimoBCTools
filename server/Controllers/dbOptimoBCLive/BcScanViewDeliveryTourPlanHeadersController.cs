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

  [Route("odata/dbOptimoBCLive/BcScanViewDeliveryTourPlanHeaders")]
  public partial class BcScanViewDeliveryTourPlanHeadersController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewDeliveryTourPlanHeadersController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewDeliveryTourPlanHeaders
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader> GetBcScanViewDeliveryTourPlanHeaders()
    {
      var items = this.context.BcScanViewDeliveryTourPlanHeaders.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>();
      this.OnBcScanViewDeliveryTourPlanHeadersRead(ref items);

      return items;
    }

    partial void OnBcScanViewDeliveryTourPlanHeadersRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader> items);

    partial void OnBcScanViewDeliveryTourPlanHeaderGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewDeliveryTourPlanHeaders(timestamp={timestamp})")]
    public SingleResult<BcScanViewDeliveryTourPlanHeader> GetBcScanViewDeliveryTourPlanHeader(Byte[] key)
    {
        var items = this.context.BcScanViewDeliveryTourPlanHeaders.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewDeliveryTourPlanHeaderGet(ref result);

        return result;
    }
  }
}
