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

  [Route("odata/dbOptimoBCLive/BcAnalysenViewItems")]
  public partial class BcAnalysenViewItemsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcAnalysenViewItemsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcAnalysenViewItems
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcAnalysenViewItem> GetBcAnalysenViewItems()
    {
      var items = this.context.BcAnalysenViewItems.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcAnalysenViewItem>();
      this.OnBcAnalysenViewItemsRead(ref items);

      return items;
    }

    partial void OnBcAnalysenViewItemsRead(ref IQueryable<Models.DbOptimoBcLive.BcAnalysenViewItem> items);

    partial void OnBcAnalysenViewItemGet(ref SingleResult<Models.DbOptimoBcLive.BcAnalysenViewItem> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcAnalysenViewItems(timestamp={timestamp})")]
    public SingleResult<BcAnalysenViewItem> GetBcAnalysenViewItem(Byte[] key)
    {
        var items = this.context.BcAnalysenViewItems.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcAnalysenViewItemGet(ref result);

        return result;
    }
  }
}
