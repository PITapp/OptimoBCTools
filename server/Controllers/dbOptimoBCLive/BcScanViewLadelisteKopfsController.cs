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

  [Route("odata/dbOptimoBCLive/BcScanViewLadelisteKopfs")]
  public partial class BcScanViewLadelisteKopfsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewLadelisteKopfsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewLadelisteKopfs
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewLadelisteKopf> GetBcScanViewLadelisteKopfs()
    {
      var items = this.context.BcScanViewLadelisteKopfs.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewLadelisteKopf>();
      this.OnBcScanViewLadelisteKopfsRead(ref items);

      return items;
    }

    partial void OnBcScanViewLadelisteKopfsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewLadelisteKopf> items);

    partial void OnBcScanViewLadelisteKopfGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewLadelisteKopf> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewLadelisteKopfs(TourCode={TourCode})")]
    public SingleResult<BcScanViewLadelisteKopf> GetBcScanViewLadelisteKopf(string key)
    {
        var items = this.context.BcScanViewLadelisteKopfs.AsNoTracking().Where(i=>i.TourCode == Uri.UnescapeDataString(key));
        var result = SingleResult.Create(items);

        OnBcScanViewLadelisteKopfGet(ref result);

        return result;
    }
  }
}
