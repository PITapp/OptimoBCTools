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

  [Route("odata/dbOptimoBCLive/BcScanViewProtokollUmlagerns")]
  public partial class BcScanViewProtokollUmlagernsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewProtokollUmlagernsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewProtokollUmlagerns
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewProtokollUmlagern> GetBcScanViewProtokollUmlagerns()
    {
      var items = this.context.BcScanViewProtokollUmlagerns.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>();
      this.OnBcScanViewProtokollUmlagernsRead(ref items);

      return items;
    }

    partial void OnBcScanViewProtokollUmlagernsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewProtokollUmlagern> items);

    partial void OnBcScanViewProtokollUmlagernGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewProtokollUmlagern> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewProtokollUmlagerns(ProtokollID={ProtokollID})")]
    public SingleResult<BcScanViewProtokollUmlagern> GetBcScanViewProtokollUmlagern(int key)
    {
        var items = this.context.BcScanViewProtokollUmlagerns.AsNoTracking().Where(i=>i.ProtokollID == key);
        var result = SingleResult.Create(items);

        OnBcScanViewProtokollUmlagernGet(ref result);

        return result;
    }
  }
}
