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

  [Route("odata/dbOptimoBCLive/BcScanProtokollUmlagerns")]
  public partial class BcScanProtokollUmlagernsController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanProtokollUmlagernsController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanProtokollUmlagerns
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanProtokollUmlagern> GetBcScanProtokollUmlagerns()
    {
      var items = this.context.BcScanProtokollUmlagerns.AsQueryable<Models.DbOptimoBcLive.BcScanProtokollUmlagern>();
      this.OnBcScanProtokollUmlagernsRead(ref items);

      return items;
    }

    partial void OnBcScanProtokollUmlagernsRead(ref IQueryable<Models.DbOptimoBcLive.BcScanProtokollUmlagern> items);

    partial void OnBcScanProtokollUmlagernGet(ref SingleResult<Models.DbOptimoBcLive.BcScanProtokollUmlagern> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanProtokollUmlagerns(ProtokollID={ProtokollID})")]
    public SingleResult<BcScanProtokollUmlagern> GetBcScanProtokollUmlagern(int key)
    {
        var items = this.context.BcScanProtokollUmlagerns.Where(i=>i.ProtokollID == key);
        var result = SingleResult.Create(items);

        OnBcScanProtokollUmlagernGet(ref result);

        return result;
    }
    partial void OnBcScanProtokollUmlagernDeleted(Models.DbOptimoBcLive.BcScanProtokollUmlagern item);
    partial void OnAfterBcScanProtokollUmlagernDeleted(Models.DbOptimoBcLive.BcScanProtokollUmlagern item);

    [HttpDelete("/odata/dbOptimoBCLive/BcScanProtokollUmlagerns(ProtokollID={ProtokollID})")]
    public IActionResult DeleteBcScanProtokollUmlagern(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.BcScanProtokollUmlagerns
                .Where(i => i.ProtokollID == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnBcScanProtokollUmlagernDeleted(item);
            this.context.BcScanProtokollUmlagerns.Remove(item);
            this.context.SaveChanges();
            this.OnAfterBcScanProtokollUmlagernDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanProtokollUmlagernUpdated(Models.DbOptimoBcLive.BcScanProtokollUmlagern item);
    partial void OnAfterBcScanProtokollUmlagernUpdated(Models.DbOptimoBcLive.BcScanProtokollUmlagern item);

    [HttpPut("/odata/dbOptimoBCLive/BcScanProtokollUmlagerns(ProtokollID={ProtokollID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutBcScanProtokollUmlagern(int key, [FromBody]Models.DbOptimoBcLive.BcScanProtokollUmlagern newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.ProtokollID != key))
            {
                return BadRequest();
            }

            this.OnBcScanProtokollUmlagernUpdated(newItem);
            this.context.BcScanProtokollUmlagerns.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanProtokollUmlagerns.Where(i => i.ProtokollID == key);
            this.OnAfterBcScanProtokollUmlagernUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("/odata/dbOptimoBCLive/BcScanProtokollUmlagerns(ProtokollID={ProtokollID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchBcScanProtokollUmlagern(int key, [FromBody]Delta<Models.DbOptimoBcLive.BcScanProtokollUmlagern> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.BcScanProtokollUmlagerns.Where(i => i.ProtokollID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnBcScanProtokollUmlagernUpdated(item);
            this.context.BcScanProtokollUmlagerns.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanProtokollUmlagerns.Where(i => i.ProtokollID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanProtokollUmlagernCreated(Models.DbOptimoBcLive.BcScanProtokollUmlagern item);
    partial void OnAfterBcScanProtokollUmlagernCreated(Models.DbOptimoBcLive.BcScanProtokollUmlagern item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.DbOptimoBcLive.BcScanProtokollUmlagern item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnBcScanProtokollUmlagernCreated(item);
            this.context.BcScanProtokollUmlagerns.Add(item);
            this.context.SaveChanges();

        
            this.OnAfterBcScanProtokollUmlagernCreated(item);
            
            return Created($"odata/DbOptimoBcLive/BcScanProtokollUmlagerns/{item.ProtokollID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
