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

  [Route("odata/dbOptimoBCLive/BcAnalysenViewProduzierteArtikelJahrMonats")]
  public partial class BcAnalysenViewProduzierteArtikelJahrMonatsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcAnalysenViewProduzierteArtikelJahrMonatsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcAnalysenViewProduzierteArtikelJahrMonats
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat> GetBcAnalysenViewProduzierteArtikelJahrMonats()
    {
      var items = this.context.BcAnalysenViewProduzierteArtikelJahrMonats.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>();
      this.OnBcAnalysenViewProduzierteArtikelJahrMonatsRead(ref items);

      return items;
    }

    partial void OnBcAnalysenViewProduzierteArtikelJahrMonatsRead(ref IQueryable<Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat> items);

    partial void OnBcAnalysenViewProduzierteArtikelJahrMonatGet(ref SingleResult<Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcAnalysenViewProduzierteArtikelJahrMonats(ItemType={ItemType})")]
    public SingleResult<BcAnalysenViewProduzierteArtikelJahrMonat> GetBcAnalysenViewProduzierteArtikelJahrMonat(string key)
    {
        var items = this.context.BcAnalysenViewProduzierteArtikelJahrMonats.AsNoTracking().Where(i=>i.ItemType == Uri.UnescapeDataString(key));
        var result = SingleResult.Create(items);

        OnBcAnalysenViewProduzierteArtikelJahrMonatGet(ref result);

        return result;
    }
  }
}
