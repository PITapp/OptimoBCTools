using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewDeliveryTour", Schema = "dbo")]
  public partial class BcScanViewDeliveryTour
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }
    public string Code
    {
      get;
      set;
    }

    [Column("Day of Departure")]
    public int DayofDeparture
    {
      get;
      set;
    }

    [Column("Employee No_")]
    public string EmployeeNo_
    {
      get;
      set;
    }
    public int ProductionLeadTimeDays
    {
      get;
      set;
    }
    public Byte PlanTourAutomatically
    {
      get;
      set;
    }
    public string TruckLicensePlate
    {
      get;
      set;
    }
    public Byte NoCalculation
    {
      get;
      set;
    }
    public string ProductionLeadTimeDaysDF
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
    public string Description
    {
      get;
      set;
    }
  }
}
