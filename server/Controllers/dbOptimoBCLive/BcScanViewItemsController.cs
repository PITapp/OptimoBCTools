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

  [Route("odata/dbOptimoBCLive/BcScanViewItems")]
  public partial class BcScanViewItemsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewItemsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewItems
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewItem> GetBcScanViewItems()
    {
      var items = this.context.BcScanViewItems.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewItem>();
      this.OnBcScanViewItemsRead(ref items);

      return items;
    }

    partial void OnBcScanViewItemsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewItem> items);

    partial void OnBcScanViewItemGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewItem> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewItems(timestamp={timestamp})")]
    public SingleResult<BcScanViewItem> GetBcScanViewItem(Byte[] key)
    {
        var items = this.context.BcScanViewItems.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewItemGet(ref result);

        return result;
    }
  }
}
