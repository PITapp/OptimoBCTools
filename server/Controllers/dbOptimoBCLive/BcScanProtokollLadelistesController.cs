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

  [Route("odata/dbOptimoBCLive/BcScanProtokollLadelistes")]
  public partial class BcScanProtokollLadelistesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanProtokollLadelistesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanProtokollLadelistes
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanProtokollLadeliste> GetBcScanProtokollLadelistes()
    {
      var items = this.context.BcScanProtokollLadelistes.AsQueryable<Models.DbOptimoBcLive.BcScanProtokollLadeliste>();
      this.OnBcScanProtokollLadelistesRead(ref items);

      return items;
    }

    partial void OnBcScanProtokollLadelistesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanProtokollLadeliste> items);

    partial void OnBcScanProtokollLadelisteGet(ref SingleResult<Models.DbOptimoBcLive.BcScanProtokollLadeliste> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanProtokollLadelistes(ProtokollID={ProtokollID})")]
    public SingleResult<BcScanProtokollLadeliste> GetBcScanProtokollLadeliste(int key)
    {
        var items = this.context.BcScanProtokollLadelistes.Where(i=>i.ProtokollID == key);
        var result = SingleResult.Create(items);

        OnBcScanProtokollLadelisteGet(ref result);

        return result;
    }
    partial void OnBcScanProtokollLadelisteDeleted(Models.DbOptimoBcLive.BcScanProtokollLadeliste item);
    partial void OnAfterBcScanProtokollLadelisteDeleted(Models.DbOptimoBcLive.BcScanProtokollLadeliste item);

    [HttpDelete("/odata/dbOptimoBCLive/BcScanProtokollLadelistes(ProtokollID={ProtokollID})")]
    public IActionResult DeleteBcScanProtokollLadeliste(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.BcScanProtokollLadelistes
                .Where(i => i.ProtokollID == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnBcScanProtokollLadelisteDeleted(item);
            this.context.BcScanProtokollLadelistes.Remove(item);
            this.context.SaveChanges();
            this.OnAfterBcScanProtokollLadelisteDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanProtokollLadelisteUpdated(Models.DbOptimoBcLive.BcScanProtokollLadeliste item);
    partial void OnAfterBcScanProtokollLadelisteUpdated(Models.DbOptimoBcLive.BcScanProtokollLadeliste item);

    [HttpPut("/odata/dbOptimoBCLive/BcScanProtokollLadelistes(ProtokollID={ProtokollID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutBcScanProtokollLadeliste(int key, [FromBody]Models.DbOptimoBcLive.BcScanProtokollLadeliste newItem)
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

            this.OnBcScanProtokollLadelisteUpdated(newItem);
            this.context.BcScanProtokollLadelistes.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanProtokollLadelistes.Where(i => i.ProtokollID == key);
            this.OnAfterBcScanProtokollLadelisteUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("/odata/dbOptimoBCLive/BcScanProtokollLadelistes(ProtokollID={ProtokollID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchBcScanProtokollLadeliste(int key, [FromBody]Delta<Models.DbOptimoBcLive.BcScanProtokollLadeliste> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.BcScanProtokollLadelistes.Where(i => i.ProtokollID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnBcScanProtokollLadelisteUpdated(item);
            this.context.BcScanProtokollLadelistes.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanProtokollLadelistes.Where(i => i.ProtokollID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanProtokollLadelisteCreated(Models.DbOptimoBcLive.BcScanProtokollLadeliste item);
    partial void OnAfterBcScanProtokollLadelisteCreated(Models.DbOptimoBcLive.BcScanProtokollLadeliste item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.DbOptimoBcLive.BcScanProtokollLadeliste item)
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

            this.OnBcScanProtokollLadelisteCreated(item);
            this.context.BcScanProtokollLadelistes.Add(item);
            this.context.SaveChanges();

        
            this.OnAfterBcScanProtokollLadelisteCreated(item);
            
            return Created($"odata/DbOptimoBcLive/BcScanProtokollLadelistes/{item.ProtokollID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
