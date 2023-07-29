using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCAnalysenViewItem", Schema = "dbo")]
  public partial class BcAnalysenViewItem
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }
    public string No_
    {
      get;
      set;
    }

    [Column("No_ 2")]
    public string No_2
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

    [Column("Base Unit of Measure")]
    public string BaseUnitofMeasure
    {
      get;
      set;
    }

    [Column("Price Unit Conversion")]
    public int PriceUnitConversion
    {
      get;
      set;
    }
    public int Type
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

    [Column("Shelf No_")]
    public string ShelfNo_
    {
      get;
      set;
    }

    [Column("Item Disc_ Group")]
    public string ItemDisc_Group
    {
      get;
      set;
    }

    [Column("Allow Invoice Disc_")]
    public Byte AllowInvoiceDisc_
    {
      get;
      set;
    }

    [Column("Statistics Group")]
    public int StatisticsGroup
    {
      get;
      set;
    }

    [Column("Commission Group")]
    public int CommissionGroup
    {
      get;
      set;
    }

    [Column("Unit Price")]
    public decimal UnitPrice
    {
      get;
      set;
    }

    [Column("Price_Profit Calculation")]
    public int Price_ProfitCalculation
    {
      get;
      set;
    }

    [Column("Profit _")]
    public decimal Profit_
    {
      get;
      set;
    }

    [Column("Costing Method")]
    public int CostingMethod
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

    [Column("Standard Cost")]
    public decimal StandardCost
    {
      get;
      set;
    }

    [Column("Last Direct Cost")]
    public decimal LastDirectCost
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

    [Column("Cost is Adjusted")]
    public Byte CostisAdjusted
    {
      get;
      set;
    }

    [Column("Allow Online Adjustment")]
    public Byte AllowOnlineAdjustment
    {
      get;
      set;
    }

    [Column("Vendor No_")]
    public string VendorNo_
    {
      get;
      set;
    }

    [Column("Vendor Item No_")]
    public string VendorItemNo_
    {
      get;
      set;
    }

    [Column("Lead Time Calculation")]
    public string LeadTimeCalculation
    {
      get;
      set;
    }

    [Column("Reorder Point")]
    public decimal ReorderPoint
    {
      get;
      set;
    }

    [Column("Maximum Inventory")]
    public decimal MaximumInventory
    {
      get;
      set;
    }

    [Column("Reorder Quantity")]
    public decimal ReorderQuantity
    {
      get;
      set;
    }

    [Column("Alternative Item No_")]
    public string AlternativeItemNo_
    {
      get;
      set;
    }

    [Column("Unit List Price")]
    public decimal UnitListPrice
    {
      get;
      set;
    }

    [Column("Duty Due _")]
    public decimal DutyDue_
    {
      get;
      set;
    }

    [Column("Duty Code")]
    public string DutyCode
    {
      get;
      set;
    }

    [Column("Gross Weight")]
    public decimal GrossWeight
    {
      get;
      set;
    }

    [Column("Net Weight")]
    public decimal NetWeight
    {
      get;
      set;
    }

    [Column("Units per Parcel")]
    public decimal UnitsperParcel
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
    public string Durability
    {
      get;
      set;
    }

    [Column("Freight Type")]
    public string FreightType
    {
      get;
      set;
    }

    [Column("Tariff No_")]
    public string TariffNo_
    {
      get;
      set;
    }

    [Column("Duty Unit Conversion")]
    public decimal DutyUnitConversion
    {
      get;
      set;
    }

    [Column("Country_Region Purchased Code")]
    public string Country_RegionPurchasedCode
    {
      get;
      set;
    }

    [Column("Budget Quantity")]
    public decimal BudgetQuantity
    {
      get;
      set;
    }

    [Column("Budgeted Amount")]
    public decimal BudgetedAmount
    {
      get;
      set;
    }

    [Column("Budget Profit")]
    public decimal BudgetProfit
    {
      get;
      set;
    }
    public Byte Blocked
    {
      get;
      set;
    }

    [Column("Block Reason")]
    public string BlockReason
    {
      get;
      set;
    }

    [Column("Last DateTime Modified")]
    public DateTime LastDateTimeModified
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

    [Column("Last Time Modified")]
    public DateTime LastTimeModified
    {
      get;
      set;
    }

    [Column("Price Includes VAT")]
    public Byte PriceIncludesVAT
    {
      get;
      set;
    }

    [Column("VAT Bus_ Posting Gr_ (Price)")]
    public string VATBus_PostingGr_Price
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
    public Guid Picture
    {
      get;
      set;
    }

    [Column("Country_Region of Origin Code")]
    public string Country_RegionofOriginCode
    {
      get;
      set;
    }

    [Column("Automatic Ext_ Texts")]
    public Byte AutomaticExt_Texts
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

    [Column("Tax Group Code")]
    public string TaxGroupCode
    {
      get;
      set;
    }

    [Column("VAT Prod_ Posting Group")]
    public string VATProd_PostingGroup
    {
      get;
      set;
    }
    public int Reserve
    {
      get;
      set;
    }

    [Column("Global Dimension 1 Code")]
    public string GlobalDimension1Code
    {
      get;
      set;
    }

    [Column("Global Dimension 2 Code")]
    public string GlobalDimension2Code
    {
      get;
      set;
    }

    [Column("Stockout Warning")]
    public int StockoutWarning
    {
      get;
      set;
    }

    [Column("Prevent Negative Inventory")]
    public int PreventNegativeInventory
    {
      get;
      set;
    }

    [Column("Variant Mandatory if Exists")]
    public int VariantMandatoryifExists
    {
      get;
      set;
    }

    [Column("Application Wksh_ User ID")]
    public string ApplicationWksh_UserID
    {
      get;
      set;
    }

    [Column("Coupled to CRM")]
    public Byte CoupledtoCRM
    {
      get;
      set;
    }

    [Column("Assembly Policy")]
    public int AssemblyPolicy
    {
      get;
      set;
    }
    public string GTIN
    {
      get;
      set;
    }

    [Column("Default Deferral Template Code")]
    public string DefaultDeferralTemplateCode
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

    [Column("Lot Size")]
    public decimal LotSize
    {
      get;
      set;
    }

    [Column("Serial Nos_")]
    public string SerialNos_
    {
      get;
      set;
    }

    [Column("Last Unit Cost Calc_ Date")]
    public DateTime LastUnitCostCalc_Date
    {
      get;
      set;
    }

    [Column("Rolled-up Material Cost")]
    public decimal RolledupMaterialCost
    {
      get;
      set;
    }

    [Column("Rolled-up Capacity Cost")]
    public decimal RolledupCapacityCost
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

    [Column("Inventory Value Zero")]
    public Byte InventoryValueZero
    {
      get;
      set;
    }

    [Column("Discrete Order Quantity")]
    public int DiscreteOrderQuantity
    {
      get;
      set;
    }

    [Column("Minimum Order Quantity")]
    public decimal MinimumOrderQuantity
    {
      get;
      set;
    }

    [Column("Maximum Order Quantity")]
    public decimal MaximumOrderQuantity
    {
      get;
      set;
    }

    [Column("Safety Stock Quantity")]
    public decimal SafetyStockQuantity
    {
      get;
      set;
    }

    [Column("Order Multiple")]
    public decimal OrderMultiple
    {
      get;
      set;
    }

    [Column("Safety Lead Time")]
    public string SafetyLeadTime
    {
      get;
      set;
    }

    [Column("Flushing Method")]
    public int FlushingMethod
    {
      get;
      set;
    }

    [Column("Replenishment System")]
    public int ReplenishmentSystem
    {
      get;
      set;
    }

    [Column("Rounding Precision")]
    public decimal RoundingPrecision
    {
      get;
      set;
    }

    [Column("Sales Unit of Measure")]
    public string SalesUnitofMeasure
    {
      get;
      set;
    }

    [Column("Purch_ Unit of Measure")]
    public string Purch_UnitofMeasure
    {
      get;
      set;
    }

    [Column("Time Bucket")]
    public string TimeBucket
    {
      get;
      set;
    }

    [Column("Reordering Policy")]
    public int ReorderingPolicy
    {
      get;
      set;
    }

    [Column("Include Inventory")]
    public Byte IncludeInventory
    {
      get;
      set;
    }

    [Column("Manufacturing Policy")]
    public int ManufacturingPolicy
    {
      get;
      set;
    }

    [Column("Rescheduling Period")]
    public string ReschedulingPeriod
    {
      get;
      set;
    }

    [Column("Lot Accumulation Period")]
    public string LotAccumulationPeriod
    {
      get;
      set;
    }

    [Column("Dampener Period")]
    public string DampenerPeriod
    {
      get;
      set;
    }

    [Column("Dampener Quantity")]
    public decimal DampenerQuantity
    {
      get;
      set;
    }

    [Column("Overflow Level")]
    public decimal OverflowLevel
    {
      get;
      set;
    }

    [Column("Manufacturer Code")]
    public string ManufacturerCode
    {
      get;
      set;
    }

    [Column("Item Category Code")]
    public string ItemCategoryCode
    {
      get;
      set;
    }

    [Column("Created From Nonstock Item")]
    public Byte CreatedFromNonstockItem
    {
      get;
      set;
    }

    [Column("Product Group Code")]
    public string ProductGroupCode
    {
      get;
      set;
    }

    [Column("Purchasing Code")]
    public string PurchasingCode
    {
      get;
      set;
    }

    [Column("Service Item Group")]
    public string ServiceItemGroup
    {
      get;
      set;
    }

    [Column("Item Tracking Code")]
    public string ItemTrackingCode
    {
      get;
      set;
    }

    [Column("Lot Nos_")]
    public string LotNos_
    {
      get;
      set;
    }

    [Column("Expiration Calculation")]
    public string ExpirationCalculation
    {
      get;
      set;
    }

    [Column("Warehouse Class Code")]
    public string WarehouseClassCode
    {
      get;
      set;
    }

    [Column("Special Equipment Code")]
    public string SpecialEquipmentCode
    {
      get;
      set;
    }

    [Column("Put-away Template Code")]
    public string PutawayTemplateCode
    {
      get;
      set;
    }

    [Column("Put-away Unit of Measure Code")]
    public string PutawayUnitofMeasureCode
    {
      get;
      set;
    }

    [Column("Phys Invt Counting Period Code")]
    public string PhysInvtCountingPeriodCode
    {
      get;
      set;
    }

    [Column("Last Counting Period Update")]
    public DateTime LastCountingPeriodUpdate
    {
      get;
      set;
    }

    [Column("Use Cross-Docking")]
    public Byte UseCrossDocking
    {
      get;
      set;
    }

    [Column("Next Counting Start Date")]
    public DateTime NextCountingStartDate
    {
      get;
      set;
    }

    [Column("Next Counting End Date")]
    public DateTime NextCountingEndDate
    {
      get;
      set;
    }
    public Guid Id
    {
      get;
      set;
    }

    [Column("Unit of Measure Id")]
    public Guid UnitofMeasureId
    {
      get;
      set;
    }

    [Column("Tax Group Id")]
    public Guid TaxGroupId
    {
      get;
      set;
    }

    [Column("Sales Blocked")]
    public Byte SalesBlocked
    {
      get;
      set;
    }

    [Column("Purchasing Blocked")]
    public Byte PurchasingBlocked
    {
      get;
      set;
    }

    [Column("Item Category Id")]
    public Guid ItemCategoryId
    {
      get;
      set;
    }

    [Column("Inventory Posting Group Id")]
    public Guid InventoryPostingGroupId
    {
      get;
      set;
    }

    [Column("Gen_ Prod_ Posting Group Id")]
    public Guid Gen_Prod_PostingGroupId
    {
      get;
      set;
    }

    [Column("Over-Receipt Code")]
    public string OverReceiptCode
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

    [Column("Production BOM No_")]
    public string ProductionBOMNo_
    {
      get;
      set;
    }

    [Column("Single-Level Material Cost")]
    public decimal SingleLevelMaterialCost
    {
      get;
      set;
    }

    [Column("Single-Level Capacity Cost")]
    public decimal SingleLevelCapacityCost
    {
      get;
      set;
    }

    [Column("Single-Level Subcontrd_ Cost")]
    public decimal SingleLevelSubcontrd_Cost
    {
      get;
      set;
    }

    [Column("Single-Level Cap_ Ovhd Cost")]
    public decimal SingleLevelCap_OvhdCost
    {
      get;
      set;
    }

    [Column("Single-Level Mfg_ Ovhd Cost")]
    public decimal SingleLevelMfg_OvhdCost
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

    [Column("Rolled-up Subcontracted Cost")]
    public decimal RolledupSubcontractedCost
    {
      get;
      set;
    }

    [Column("Rolled-up Mfg_ Ovhd Cost")]
    public decimal RolledupMfg_OvhdCost
    {
      get;
      set;
    }

    [Column("Rolled-up Cap_ Overhead Cost")]
    public decimal RolledupCap_OverheadCost
    {
      get;
      set;
    }

    [Column("Order Tracking Policy")]
    public int OrderTrackingPolicy
    {
      get;
      set;
    }
    public Byte Critical
    {
      get;
      set;
    }

    [Column("Common Item No_")]
    public string CommonItemNo_
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
    public string ItemType
    {
      get;
      set;
    }
  }
}
