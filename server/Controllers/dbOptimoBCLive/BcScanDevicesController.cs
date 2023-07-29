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

  [Route("odata/dbOptimoBCLive/BcScanDevices")]
  public partial class BcScanDevicesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanDevicesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanDevices
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanDevice> GetBcScanDevices()
    {
      var items = this.context.BcScanDevices.AsQueryable<Models.DbOptimoBcLive.BcScanDevice>();
      this.OnBcScanDevicesRead(ref items);

      return items;
    }

    partial void OnBcScanDevicesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanDevice> items);

    partial void OnBcScanDeviceGet(ref SingleResult<Models.DbOptimoBcLive.BcScanDevice> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanDevices(DeviceID={DeviceID})")]
    public SingleResult<BcScanDevice> GetBcScanDevice(int key)
    {
        var items = this.context.BcScanDevices.Where(i=>i.DeviceID == key);
        var result = SingleResult.Create(items);

        OnBcScanDeviceGet(ref result);

        return result;
    }
    partial void OnBcScanDeviceDeleted(Models.DbOptimoBcLive.BcScanDevice item);
    partial void OnAfterBcScanDeviceDeleted(Models.DbOptimoBcLive.BcScanDevice item);

    [HttpDelete("/odata/dbOptimoBCLive/BcScanDevices(DeviceID={DeviceID})")]
    public IActionResult DeleteBcScanDevice(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.BcScanDevices
                .Where(i => i.DeviceID == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnBcScanDeviceDeleted(item);
            this.context.BcScanDevices.Remove(item);
            this.context.SaveChanges();
            this.OnAfterBcScanDeviceDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanDeviceUpdated(Models.DbOptimoBcLive.BcScanDevice item);
    partial void OnAfterBcScanDeviceUpdated(Models.DbOptimoBcLive.BcScanDevice item);

    [HttpPut("/odata/dbOptimoBCLive/BcScanDevices(DeviceID={DeviceID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutBcScanDevice(int key, [FromBody]Models.DbOptimoBcLive.BcScanDevice newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.DeviceID != key))
            {
                return BadRequest();
            }

            this.OnBcScanDeviceUpdated(newItem);
            this.context.BcScanDevices.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanDevices.Where(i => i.DeviceID == key);
            this.OnAfterBcScanDeviceUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("/odata/dbOptimoBCLive/BcScanDevices(DeviceID={DeviceID})")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchBcScanDevice(int key, [FromBody]Delta<Models.DbOptimoBcLive.BcScanDevice> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.BcScanDevices.Where(i => i.DeviceID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnBcScanDeviceUpdated(item);
            this.context.BcScanDevices.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.BcScanDevices.Where(i => i.DeviceID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBcScanDeviceCreated(Models.DbOptimoBcLive.BcScanDevice item);
    partial void OnAfterBcScanDeviceCreated(Models.DbOptimoBcLive.BcScanDevice item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.DbOptimoBcLive.BcScanDevice item)
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

            this.OnBcScanDeviceCreated(item);
            this.context.BcScanDevices.Add(item);
            this.context.SaveChanges();

        
            this.OnAfterBcScanDeviceCreated(item);
            
            return Created($"odata/DbOptimoBcLive/BcScanDevices/{item.DeviceID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
