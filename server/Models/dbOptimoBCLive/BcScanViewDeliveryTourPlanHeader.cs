using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewDeliveryTourPlanHeader", Schema = "dbo")]
  public partial class BcScanViewDeliveryTourPlanHeader
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }

    [Column("Delivery Tour Plan No")]
    public int DeliveryTourPlanNo
    {
      get;
      set;
    }
    public int Year
    {
      get;
      set;
    }

    [Column("Delivery Tour Code")]
    public string DeliveryTourCode
    {
      get;
      set;
    }

    [Column("Date From")]
    public DateTime DateFrom
    {
      get;
      set;
    }

    [Column("Date To")]
    public DateTime DateTo
    {
      get;
      set;
    }

    [Column("Week of Year ID")]
    public string WeekofYearID
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

    [Column("Closed Timestamp")]
    public DateTime ClosedTimestamp
    {
      get;
      set;
    }
    public Byte Closed
    {
      get;
      set;
    }
    public string TruckLicensePlate
    {
      get;
      set;
    }
    public string WAB
    {
      get;
      set;
    }
    public int NotPlannedLines
    {
      get;
      set;
    }
    public int NotPlannedLinesOpen
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

    [Column("Departure Date")]
    public DateTime DepartureDate
    {
      get;
      set;
    }
    public int Status
    {
      get;
      set;
    }

    [Column("Scan Status")]
    public int ScanStatus
    {
      get;
      set;
    }
    public int Calendarweek
    {
      get;
      set;
    }
  }
}
