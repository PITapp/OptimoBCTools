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

  [Route("odata/dbOptimoBCLive/BcScanViewDeliveryTours")]
  public partial class BcScanViewDeliveryToursController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewDeliveryToursController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewDeliveryTours
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewDeliveryTour> GetBcScanViewDeliveryTours()
    {
      var items = this.context.BcScanViewDeliveryTours.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTour>();
      this.OnBcScanViewDeliveryToursRead(ref items);

      return items;
    }

    partial void OnBcScanViewDeliveryToursRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewDeliveryTour> items);

    partial void OnBcScanViewDeliveryTourGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewDeliveryTour> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewDeliveryTours(timestamp={timestamp})")]
    public SingleResult<BcScanViewDeliveryTour> GetBcScanViewDeliveryTour(Byte[] key)
    {
        var items = this.context.BcScanViewDeliveryTours.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewDeliveryTourGet(ref result);

        return result;
    }
  }
}
