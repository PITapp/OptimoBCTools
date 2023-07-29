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

  [Route("odata/dbOptimoBCLive/BcScanViewDevices")]
  public partial class BcScanViewDevicesController : ODataController
  {
    private OptimoBcTools.Data.DbOptimoBcLiveContext context;

    public BcScanViewDevicesController(OptimoBcTools.Data.DbOptimoBcLiveContext context)
    {
      this.context = context;
    }
    // GET /odata/DbOptimoBcLive/BcScanViewDevices
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.DbOptimoBcLive.BcScanViewDevice> GetBcScanViewDevices()
    {
      var items = this.context.BcScanViewDevices.AsNoTracking().AsQueryable<Models.DbOptimoBcLive.BcScanViewDevice>();
      this.OnBcScanViewDevicesRead(ref items);

      return items;
    }

    partial void OnBcScanViewDevicesRead(ref IQueryable<Models.DbOptimoBcLive.BcScanViewDevice> items);

    partial void OnBcScanViewDeviceGet(ref SingleResult<Models.DbOptimoBcLive.BcScanViewDevice> item);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("/odata/dbOptimoBCLive/BcScanViewDevices(DeviceID={DeviceID})")]
    public SingleResult<BcScanViewDevice> GetBcScanViewDevice(int key)
    {
        var items = this.context.BcScanViewDevices.AsNoTracking().Where(i=>i.DeviceID == key);
        var result = SingleResult.Create(items);

        OnBcScanViewDeviceGet(ref result);

        return result;
    }
  }
}
