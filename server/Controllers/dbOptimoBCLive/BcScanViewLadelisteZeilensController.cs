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

  [Route("odata/dbOptimoBCLive/BcScanViewLadelisteZeilens")]
  public partial class BcScanViewLadelisteZeilensController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewLadelisteZeilensController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewLadelisteZeilens
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewLadelisteZeilen> GetBcScanViewLadelisteZeilens()
    {
      var items = this.context.BcScanViewLadelisteZeilens.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>();
      this.OnBcScanViewLadelisteZeilensRead(ref items);

      return items;
    }

    partial void OnBcScanViewLadelisteZeilensRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewLadelisteZeilen> items);

    partial void OnBcScanViewLadelisteZeilenGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewLadelisteZeilen> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewLadelisteZeilens(TourNr={TourNr})")]
    public SingleResult<BcScanViewLadelisteZeilen> GetBcScanViewLadelisteZeilen(int key)
    {
        var items = this.context.BcScanViewLadelisteZeilens.AsNoTracking().Where(i=>i.TourNr == key);
        var result = SingleResult.Create(items);

        OnBcScanViewLadelisteZeilenGet(ref result);

        return result;
    }
  }
}
