using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewProductionOrder", Schema = "dbo")]
  public partial class BcScanViewProductionOrder
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }
    public int Status
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }

    [Column("Search Description")]
    public string SearchDescription
    {
      get;
      set;
    }

    [Column("Description 2")]
    public string Description2
    {
      get;
      set;
    }

    [Column("Creation Date")]
    public DateTime CreationDate
    {
      get;
      set;
    }

    [Column("Last Date Modified")]
    public DateTime LastDateModified
    {
      get;
      set;
    }

    [Column("Source Type")]
    public int SourceType
    {
      get;
      set;
    }

    [Column("Source No_")]
    public string SourceNo_
    {
      get;
      set;
    }

    [Column("Routing No_")]
    public string RoutingNo_
    {
      get;
      set;
    }

    [Column("Variant Code")]
    public string VariantCode
    {
      get;
      set;
    }

    [Column("Inventory Posting Group")]
    public string InventoryPostingGroup
    {
      get;
      set;
    }

    [Column("Gen_ Prod_ Posting Group")]
    public string Gen_Prod_PostingGroup
    {
      get;
      set;
    }

    [Column("Gen_ Bus_ Posting Group")]
    public string Gen_Bus_PostingGroup
    {
      get;
      set;
    }

    [Column("Starting Time")]
    public DateTime StartingTime
    {
      get;
      set;
    }

    [Column("Starting Date")]
    public DateTime StartingDate
    {
      get;
      set;
    }

    [Column("Ending Time")]
    public DateTime EndingTime
    {
      get;
      set;
    }

    [Column("Ending Date")]
    public DateTime EndingDate
    {
      get;
      set;
    }

    [Column("Due Date")]
    public DateTime DueDate
    {
      get;
      set;
    }

    [Column("Finished Date")]
    public DateTime FinishedDate
    {
      get;
      set;
    }
    public Byte Blocked
    {
      get;
      set;
    }

    [Column("Shortcut Dimension 1 Code")]
    public string ShortcutDimension1Code
    {
      get;
      set;
    }

    [Column("Shortcut Dimension 2 Code")]
    public string ShortcutDimension2Code
    {
      get;
      set;
    }

    [Column("Location Code")]
    public string LocationCode
    {
      get;
      set;
    }

    [Column("Bin Code")]
    public string BinCode
    {
      get;
      set;
    }

    [Column("Replan Ref_ No_")]
    public string ReplanRef_No_
    {
      get;
      set;
    }

    [Column("Replan Ref_ Status")]
    public int ReplanRef_Status
    {
      get;
      set;
    }

    [Column("Low-Level Code")]
    public int LowLevelCode
    {
      get;
      set;
    }
    public decimal Quantity
    {
      get;
      set;
    }

    [Column("Unit Cost")]
    public decimal UnitCost
    {
      get;
      set;
    }

    [Column("Cost Amount")]
    public decimal CostAmount
    {
      get;
      set;
    }

    [Column("No_ Series")]
    public string No_Series
    {
      get;
      set;
    }

    [Column("Planned Order No_")]
    public string PlannedOrderNo_
    {
      get;
      set;
    }

    [Column("Firm Planned Order No_")]
    public string FirmPlannedOrderNo_
    {
      get;
      set;
    }

    [Column("Simulated Order No_")]
    public string SimulatedOrderNo_
    {
      get;
      set;
    }

    [Column("Starting Date-Time")]
    public DateTime StartingDateTime
    {
      get;
      set;
    }

    [Column("Ending Date-Time")]
    public DateTime EndingDateTime
    {
      get;
      set;
    }

    [Column("Dimension Set ID")]
    public int DimensionSetID
    {
      get;
      set;
    }

    [Column("Assigned User ID")]
    public string AssignedUserID
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

    [Column("Work Description")]
    public Byte[] WorkDescription
    {
      get;
      set;
    }
    public Byte ShouldBePrinted
    {
      get;
      set;
    }

    [Column("Last Date Printed")]
    public DateTime LastDatePrinted
    {
      get;
      set;
    }
    public string WorkCenterGroupCode
    {
      get;
      set;
    }

    [Column("Step 1")]
    public string Step1
    {
      get;
      set;
    }

    [Column("Step 2")]
    public string Step2
    {
      get;
      set;
    }

    [Column("Step 3")]
    public string Step3
    {
      get;
      set;
    }

    [Column("Step 4")]
    public string Step4
    {
      get;
      set;
    }

    [Column("For Group")]
    public int ForGroup
    {
      get;
      set;
    }

    [Column("Tour Code")]
    public string TourCode
    {
      get;
      set;
    }

    [Column("Sales Line Number")]
    public int SalesLineNumber
    {
      get;
      set;
    }
    public string No_
    {
      get;
      set;
    }

    [Column("Root No_")]
    public string RootNo_
    {
      get;
      set;
    }
    public string Produziert
    {
      get;
      set;
    }
  }
}
