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

  [Route("odata/dbOptimoBCLive/BcScanViewUmlagerungLetzteNummers")]
  public partial class BcScanViewUmlagerungLetzteNummersController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewUmlagerungLetzteNummersController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewUmlagerungLetzteNummers
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer> GetBcScanViewUmlagerungLetzteNummers()
    {
      var items = this.context.BcScanViewUmlagerungLetzteNummers.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer>();
      this.OnBcScanViewUmlagerungLetzteNummersRead(ref items);

      return items;
    }

    partial void OnBcScanViewUmlagerungLetzteNummersRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer> items);

    partial void OnBcScanViewUmlagerungLetzteNummerGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewUmlagerungLetzteNummers(timestamp={timestamp})")]
    public SingleResult<BcScanViewUmlagerungLetzteNummer> GetBcScanViewUmlagerungLetzteNummer(Byte[] key)
    {
        var items = this.context.BcScanViewUmlagerungLetzteNummers.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewUmlagerungLetzteNummerGet(ref result);

        return result;
    }
  }
}
