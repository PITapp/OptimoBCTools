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

  [Route("odata/dbOptimoBCLive/BcScanViewBenutzers")]
  public partial class BcScanViewBenutzersController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewBenutzersController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewBenutzers
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewBenutzer> GetBcScanViewBenutzers()
    {
      var items = this.context.BcScanViewBenutzers.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewBenutzer>();
      this.OnBcScanViewBenutzersRead(ref items);

      return items;
    }

    partial void OnBcScanViewBenutzersRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewBenutzer> items);

    partial void OnBcScanViewBenutzerGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewBenutzer> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewBenutzers(BenutzerID={BenutzerID})")]
    public SingleResult<BcScanViewBenutzer> GetBcScanViewBenutzer(int key)
    {
        var items = this.context.BcScanViewBenutzers.AsNoTracking().Where(i=>i.BenutzerID == key);
        var result = SingleResult.Create(items);

        OnBcScanViewBenutzerGet(ref result);

        return result;
    }
  }
}
