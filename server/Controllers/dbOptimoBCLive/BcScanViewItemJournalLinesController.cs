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

  [Route("odata/dbOptimoBCLive/BcScanViewItemJournalLines")]
  public partial class BcScanViewItemJournalLinesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewItemJournalLinesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewItemJournalLines
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewItemJournalLine> GetBcScanViewItemJournalLines()
    {
      var items = this.context.BcScanViewItemJournalLines.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewItemJournalLine>();
      this.OnBcScanViewItemJournalLinesRead(ref items);

      return items;
    }

    partial void OnBcScanViewItemJournalLinesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewItemJournalLine> items);

    partial void OnBcScanViewItemJournalLineGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewItemJournalLine> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewItemJournalLines(timestamp={timestamp})")]
    public SingleResult<BcScanViewItemJournalLine> GetBcScanViewItemJournalLine(Byte[] key)
    {
        var items = this.context.BcScanViewItemJournalLines.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcScanViewItemJournalLineGet(ref result);

        return result;
    }
  }
}
