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

  [Route("odata/dbOptimoBCLive/BcAnalysenViewItemLedgerEntries")]
  public partial class BcAnalysenViewItemLedgerEntriesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcAnalysenViewItemLedgerEntriesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcAnalysenViewItemLedgerEntries
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry> GetBcAnalysenViewItemLedgerEntries()
    {
      var items = this.context.BcAnalysenViewItemLedgerEntries.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>();
      this.OnBcAnalysenViewItemLedgerEntriesRead(ref items);

      return items;
    }

    partial void OnBcAnalysenViewItemLedgerEntriesRead(ref IQueryable<Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry> items);

    partial void OnBcAnalysenViewItemLedgerEntryGet(ref SingleResult<Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcAnalysenViewItemLedgerEntries(timestamp={timestamp})")]
    public SingleResult<BcAnalysenViewItemLedgerEntry> GetBcAnalysenViewItemLedgerEntry(Byte[] key)
    {
        var items = this.context.BcAnalysenViewItemLedgerEntries.AsNoTracking().Where(i=>i.timestamp == key);
        var result = SingleResult.Create(items);

        OnBcAnalysenViewItemLedgerEntryGet(ref result);

        return result;
    }
  }
}
