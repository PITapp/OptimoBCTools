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

  [Route("odata/dbOptimoBCLive/BcScanViewItemJournalLineUmlagernNeueZeilenNrs")]
  public partial class BcScanViewItemJournalLineUmlagernNeueZeilenNrsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewItemJournalLineUmlagernNeueZeilenNrsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewItemJournalLineUmlagernNeueZeilenNrs
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr> GetBcScanViewItemJournalLineUmlagernNeueZeilenNrs()
    {
      var items = this.context.BcScanViewItemJournalLineUmlagernNeueZeilenNrs.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr>();
      this.OnBcScanViewItemJournalLineUmlagernNeueZeilenNrsRead(ref items);

      return items;
    }

    partial void OnBcScanViewItemJournalLineUmlagernNeueZeilenNrsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr> items);

    partial void OnBcScanViewItemJournalLineUmlagernNeueZeilenNrGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewItemJournalLineUmlagernNeueZeilenNrs(NeueZeilennummer={NeueZeilennummer})")]
    public SingleResult<BcScanViewItemJournalLineUmlagernNeueZeilenNr> GetBcScanViewItemJournalLineUmlagernNeueZeilenNr(int? key)
    {
        var items = this.context.BcScanViewItemJournalLineUmlagernNeueZeilenNrs.AsNoTracking().Where(i=>i.NeueZeilennummer == key);
        var result = SingleResult.Create(items);

        OnBcScanViewItemJournalLineUmlagernNeueZeilenNrGet(ref result);

        return result;
    }
  }
}
