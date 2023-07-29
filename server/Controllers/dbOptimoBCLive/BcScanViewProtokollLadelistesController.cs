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

  [Route("odata/dbOptimoBCLive/BcScanViewProtokollLadelistes")]
  public partial class BcScanViewProtokollLadelistesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewProtokollLadelistesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewProtokollLadelistes
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewProtokollLadeliste> GetBcScanViewProtokollLadelistes()
    {
      var items = this.context.BcScanViewProtokollLadelistes.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>();
      this.OnBcScanViewProtokollLadelistesRead(ref items);

      return items;
    }

    partial void OnBcScanViewProtokollLadelistesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewProtokollLadeliste> items);

    partial void OnBcScanViewProtokollLadelisteGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewProtokollLadeliste> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewProtokollLadelistes(ProtokollID={ProtokollID})")]
    public SingleResult<BcScanViewProtokollLadeliste> GetBcScanViewProtokollLadeliste(int key)
    {
        var items = this.context.BcScanViewProtokollLadelistes.AsNoTracking().Where(i=>i.ProtokollID == key);
        var result = SingleResult.Create(items);

        OnBcScanViewProtokollLadelisteGet(ref result);

        return result;
    }
  }
}
