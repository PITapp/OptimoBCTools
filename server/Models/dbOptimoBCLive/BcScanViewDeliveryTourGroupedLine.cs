using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewDeliveryTourGroupedLines", Schema = "dbo")]
  public partial class BcScanViewDeliveryTourGroupedLine
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
    public string Address
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

    [Column("Address 2")]
    public string Address2
    {
      get;
      set;
    }
    public string City
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

    [Column("Delivery Tour Priority")]
    public int DeliveryTourPriority
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
    public string FullWeekValue
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

    [Column("Prev_ Deliv_ Tour Plan Hdr No")]
    public int Prev_Deliv_TourPlanHdrNo
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
  }
}
