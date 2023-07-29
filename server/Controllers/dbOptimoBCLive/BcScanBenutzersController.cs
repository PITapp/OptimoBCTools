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

  [Route("odata/dbOptimoBCLive/BcScanBenutzers")]
  public partial class BcScanBenutzersController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanBenutzersController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanBenutzers
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanBenutzer> GetBcScanBenutzers()
    {
      var items = this.context.BcScanBenutzers.AsQueryable<Models.DbOptimoBcLive.BcScanBenutzer>();
      this.OnBcScanBenutzersRead(ref items);

      return items;
    }

    partial void OnBcScanBenutzersRead(ref IQueryable<Models.DbOptimoBcLive.BcScanBenutzer> items);

    partial void OnBcScanBenutzerGet(ref SingleResult<Models.DbOptimoBcLive.BcScanBenutzer> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanBenutzers(BenutzerID={BenutzerID})")]
    public SingleResult<BcScanBenutzer> GetBcScanBenutzer(int key)
    {
        var items = this.context.BcScanBenutzers.Where(i=>i.BenutzerID == key);
        var result = SingleResult.Create(items);

        OnBcScanBenutzerGet(ref result);

        return result;
    }
    partial void OnBcScanBenutzerDeleted(Models.DbOptimoBcLive.BcScanBenutzer item);
    partial void OnAfterBcScanBenutzerDeleted(Models.DbOptimoBcLive.BcScanBenutzer item);

    [HttpDelete("/odata/dbOptimoBCLive/BcScanBenutzers(BenutzerID={BenutzerID})")]
    public IActionResult DeleteBcScanBenutzer(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.BcScanBenutzers
                .Where(i => i.BenutzerID == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnBcScanBenutzerDeleted(item);
            this.context.BcScanBenutzers.Remove(item);
            this.context.SaveChanges();
            this.OnAfterBcScanBenutzerDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanBenutzerUpdated(Models.DbOptimoBcLive.BcScanBenutzer item);
    partial void OnAfterBcScanBenutzerUpdated(Models.DbOptimoBcLive.BcScanBenutzer item);

    [HttpPut("/odata/dbOptimoBCLive/BcScanBenutzers(BenutzerID={BenutzerID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutBcScanBenutzer(int key, [FromBody]Models.DbOptimoBcLive.BcScanBenutzer newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.BenutzerID != key))
            {
                return BadRequest();
            }

            this.OnBcScanBenutzerUpdated(newItem);
            this.context.BcScanBenutzers.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanBenutzers.Where(i => i.BenutzerID == key);
            this.OnAfterBcScanBenutzerUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("/odata/dbOptimoBCLive/BcScanBenutzers(BenutzerID={BenutzerID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchBcScanBenutzer(int key, [FromBody]Delta<Models.DbOptimoBcLive.BcScanBenutzer> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.BcScanBenutzers.Where(i => i.BenutzerID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnBcScanBenutzerUpdated(item);
            this.context.BcScanBenutzers.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanBenutzers.Where(i => i.BenutzerID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanBenutzerCreated(Models.DbOptimoBcLive.BcScanBenutzer item);
    partial void OnAfterBcScanBenutzerCreated(Models.DbOptimoBcLive.BcScanBenutzer item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.DbOptimoBcLive.BcScanBenutzer item)
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

            this.OnBcScanBenutzerCreated(item);
            this.context.BcScanBenutzers.Add(item);
            this.context.SaveChanges();

        
            this.OnAfterBcScanBenutzerCreated(item);
            
            return Created($"odata/DbOptimoBcLive/BcScanBenutzers/{item.BenutzerID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
