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

  [Route("odata/dbOptimo2003/BcToolsViewVerkaufsauftraegeOhneFNummer02s")]
  public partial class BcToolsViewVerkaufsauftraegeOhneFNummer02sController : ODataController
  {
    private OptimoBcTools.Data.DbOptimo2003Context context;

    public BcToolsViewVerkaufsauftraegeOhneFNummer02sController(OptimoBcTools.Data.DbOptimo2003Context context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimo2003/BcToolsViewVerkaufsauftraegeOhneFNummer02s
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02> GetBcToolsViewVerkaufsauftraegeOhneFNummer02s()
    {
      var items = this.context.BcToolsViewVerkaufsauftraegeOhneFNummer02s.AsNoTracking().AsQueryable<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02>();
      this.OnBcToolsViewVerkaufsauftraegeOhneFNummer02sRead(ref items);

      return items;
    }

    partial void OnBcToolsViewVerkaufsauftraegeOhneFNummer02sRead(ref IQueryable<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02> items);

    partial void OnBcToolsViewVerkaufsauftraegeOhneFNummer02Get(ref SingleResult<Models.DbOptimo2003.BcToolsViewVerkaufsauftraegeOhneFNummer02> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimo2003/BcToolsViewVerkaufsauftraegeOhneFNummer02s(Warenausgangsdatum={Warenausgangsdatum})")]
    public SingleResult<BcToolsViewVerkaufsauftraegeOhneFNummer02> GetBcToolsViewVerkaufsauftraegeOhneFNummer02(DateTime key)
    {
        var items = this.context.BcToolsViewVerkaufsauftraegeOhneFNummer02s.AsNoTracking().Where(i=>i.Warenausgangsdatum == key);
        var result = SingleResult.Create(items);

        OnBcToolsViewVerkaufsauftraegeOhneFNummer02Get(ref result);

        return result;
    }
  }
}
