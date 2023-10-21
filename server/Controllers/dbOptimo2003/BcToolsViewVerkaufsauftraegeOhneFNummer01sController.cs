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




namespace OptimoBcTools.Controllers.DbOptimo2003
{
  using Models;
  using Data;
  using Models.DbOptimo2003;

  [Route("odata/dbOptimo2003/BcToolsViewVerkaufsauftraegeOhneFNummer01s")]
  public partial class BcToolsViewVerkaufsauftraegeOhneFNummer01sController : ODataController
  {
    private OptimoBcTools.Data.DbOptimo2003Context context;

    public BcToolsViewVerkaufsauftraegeOhneFNummer01sController(OptimoBcTools.Data.DbOptimo2003Context context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimo2003/BcToolsViewVerkaufsauftraegeOhneFNummer01s
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01> GetBcToolsViewVerkaufsauftraegeOhneFNummer01s()
    {
      var items = this.context.BcToolsViewVerkaufsauftraegeOhneFNummer01s.AsNoTracking().AsQueryable<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01>();
      this.OnBcToolsViewVerkaufsauftraegeOhneFNummer01sRead(ref items);

      return items;
    }

    partial void OnBcToolsViewVerkaufsauftraegeOhneFNummer01sRead(ref IQueryable<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01> items);

    partial void OnBcToolsViewVerkaufsauftraegeOhneFNummer01Get(ref SingleResult<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer01> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimo2003/BcToolsViewVerkaufsauftraegeOhneFNummer01s(VerkaufsauftragNr={VerkaufsauftragNr})")]
    public SingleResult<BcToolsViewVerkaufsauftraegeOhneFNummer01> GetBcToolsViewVerkaufsauftraegeOhneFNummer01(string key)
    {
        var items = this.context.BcToolsViewVerkaufsauftraegeOhneFNummer01s.AsNoTracking().Where(i=>i.VerkaufsauftragNr == Uri.UnescapeDataString(key));
        var result = SingleResult.Create(items);

        OnBcToolsViewVerkaufsauftraegeOhneFNummer01Get(ref result);

        return result;
    }
  }
}
