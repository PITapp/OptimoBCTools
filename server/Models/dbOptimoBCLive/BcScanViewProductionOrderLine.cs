using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewProductionOrderLine", Schema = "dbo")]
  public partial class BcScanViewProductionOrderLine
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }

    [Column("Line No_")]
    public int LineNo_
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

    [Column("Variant Code")]
    public string VariantCode
    {
      get;
      set;
    }
    public string Description
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

    [Column("Location Code")]
    public string LocationCode
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

    [Column("Bin Code")]
    public string BinCode
    {
      get;
      set;
    }
    public decimal Quantity
    {
      get;
      set;
    }

    [Column("Finished Quantity")]
    public decimal FinishedQuantity
    {
      get;
      set;
    }

    [Column("Remaining Quantity")]
    public decimal RemainingQuantity
    {
      get;
      set;
    }

    [Column("Scrap _")]
    public decimal Scrap_
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

    [Column("Starting Date")]
    public DateTime StartingDate
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

    [Column("Ending Date")]
    public DateTime EndingDate
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

    [Column("Planning Level Code")]
    public int PlanningLevelCode
    {
      get;
      set;
    }
    public int Priority
    {
      get;
      set;
    }

    [Column("Production BOM No_")]
    public string ProductionBOMNo_
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

    [Column("Inventory Posting Group")]
    public string InventoryPostingGroup
    {
      get;
      set;
    }

    [Column("Routing Reference No_")]
    public int RoutingReferenceNo_
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

    [Column("Qty_ Rounding Precision")]
    public decimal Qty_RoundingPrecision
    {
      get;
      set;
    }

    [Column("Qty_ Rounding Precision (Base)")]
    public decimal Qty_RoundingPrecisionBase
    {
      get;
      set;
    }

    [Column("Unit of Measure Code")]
    public string UnitofMeasureCode
    {
      get;
      set;
    }

    [Column("Quantity (Base)")]
    public decimal QuantityBase
    {
      get;
      set;
    }

    [Column("Finished Qty_ (Base)")]
    public decimal FinishedQty_Base
    {
      get;
      set;
    }

    [Column("Remaining Qty_ (Base)")]
    public decimal RemainingQty_Base
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

    [Column("Cost Amount (ACY)")]
    public decimal CostAmountACY
    {
      get;
      set;
    }

    [Column("Unit Cost (ACY)")]
    public decimal UnitCostACY
    {
      get;
      set;
    }

    [Column("Production BOM Version Code")]
    public string ProductionBOMVersionCode
    {
      get;
      set;
    }

    [Column("Routing Version Code")]
    public string RoutingVersionCode
    {
      get;
      set;
    }

    [Column("Routing Type")]
    public int RoutingType
    {
      get;
      set;
    }

    [Column("Qty_ per Unit of Measure")]
    public decimal Qty_perUnitofMeasure
    {
      get;
      set;
    }

    [Column("Planning Flexibility")]
    public int PlanningFlexibility
    {
      get;
      set;
    }

    [Column("Indirect Cost _")]
    public decimal IndirectCost_
    {
      get;
      set;
    }

    [Column("Overhead Rate")]
    public decimal OverheadRate
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

    [Column("Prod_ Order No_")]
    public string Prod_OrderNo_
    {
      get;
      set;
    }
    public int Status
    {
      get;
      set;
    }

    [Column("MPS Order")]
    public Byte MPSOrder
    {
      get;
      set;
    }
  }
}
