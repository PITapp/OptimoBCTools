using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewDeliveryTourPlanLine", Schema = "dbo")]
  public partial class BcScanViewDeliveryTourPlanLine
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }

    [Column("Delivery Tour Plan Header No")]
    public int DeliveryTourPlanHeaderNo
    {
      get;
      set;
    }

    [Column("Set Item Index")]
    public int SetItemIndex
    {
      get;
      set;
    }
    public string Name
    {
      get;
      set;
    }

    [Column("Name 2")]
    public string Name2
    {
      get;
      set;
    }
    public string Address
    {
      get;
      set;
    }

    [Column("Address 2")]
    public string Address2
    {
      get;
      set;
    }
    public string County
    {
      get;
      set;
    }

    [Column("Country_Region Code")]
    public string Country_RegionCode
    {
      get;
      set;
    }

    [Column("Customer No_")]
    public string CustomerNo_
    {
      get;
      set;
    }
    public string Code
    {
      get;
      set;
    }

    [Column("Delivery Day")]
    public int DeliveryDay
    {
      get;
      set;
    }

    [Column("Unit Volume")]
    public decimal UnitVolume
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }

    [Column("Item No_")]
    public string ItemNo_
    {
      get;
      set;
    }

    [Column("Scan Completed")]
    public Byte ScanCompleted
    {
      get;
      set;
    }

    [Column("Line Volume")]
    public decimal LineVolume
    {
      get;
      set;
    }

    [Column("Trailer Tour")]
    public Byte TrailerTour
    {
      get;
      set;
    }

    [Column("Set Item No_")]
    public string SetItemNo_
    {
      get;
      set;
    }

    [Column("Last Changed")]
    public DateTime LastChanged
    {
      get;
      set;
    }

    [Column("Line Weight")]
    public decimal LineWeight
    {
      get;
      set;
    }

    [Column("$systemId")]
    public Guid systemId
    {
      get;
      set;
    }

    [Column("$systemCreatedAt")]
    public DateTime systemCreatedAt
    {
      get;
      set;
    }

    [Column("$systemCreatedBy")]
    public Guid systemCreatedBy
    {
      get;
      set;
    }

    [Column("$systemModifiedAt")]
    public DateTime systemModifiedAt
    {
      get;
      set;
    }

    [Column("$systemModifiedBy")]
    public Guid systemModifiedBy
    {
      get;
      set;
    }

    [Column("Document Line No_")]
    public int DocumentLineNo_
    {
      get;
      set;
    }
    public string City
    {
      get;
      set;
    }

    [Column("Delivery Tour Priority")]
    public int DeliveryTourPriority
    {
      get;
      set;
    }

    [Column("AS Scanned Qty_")]
    public int ASScannedQty_
    {
      get;
      set;
    }

    [Column("Document No_")]
    public string DocumentNo_
    {
      get;
      set;
    }

    [Column("Post Code")]
    public string PostCode
    {
      get;
      set;
    }

    [Column("Qty_ to Ship")]
    public decimal Qty_toShip
    {
      get;
      set;
    }
  }
}
