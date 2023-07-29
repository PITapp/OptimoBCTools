using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewItemJournalLine", Schema = "dbo")]
  public partial class BcScanViewItemJournalLine
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }

    [Column("Journal Template Name")]
    public string JournalTemplateName
    {
      get;
      set;
    }

    [Column("Journal Batch Name")]
    public string JournalBatchName
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

    [Column("Posting Date")]
    public DateTime PostingDate
    {
      get;
      set;
    }

    [Column("Entry Type")]
    public int EntryType
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

    [Column("Document No_")]
    public string DocumentNo_
    {
      get;
      set;
    }
    public string Description
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

    [Column("Inventory Posting Group")]
    public string InventoryPostingGroup
    {
      get;
      set;
    }

    [Column("Source Posting Group")]
    public string SourcePostingGroup
    {
      get;
      set;
    }
    public decimal Quantity
    {
      get;
      set;
    }

    [Column("Invoiced Quantity")]
    public decimal InvoicedQuantity
    {
      get;
      set;
    }

    [Column("Unit Amount")]
    public decimal UnitAmount
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
    public decimal Amount
    {
      get;
      set;
    }

    [Column("Discount Amount")]
    public decimal DiscountAmount
    {
      get;
      set;
    }

    [Column("Salespers__Purch_ Code")]
    public string Salespers__Purch_Code
    {
      get;
      set;
    }

    [Column("Source Code")]
    public string SourceCode
    {
      get;
      set;
    }

    [Column("Applies-to Entry")]
    public int AppliestoEntry
    {
      get;
      set;
    }

    [Column("Item Shpt_ Entry No_")]
    public int ItemShpt_EntryNo_
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

    [Column("Indirect Cost _")]
    public decimal IndirectCost_
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

    [Column("Shpt_ Method Code")]
    public string Shpt_MethodCode
    {
      get;
      set;
    }

    [Column("Reason Code")]
    public string ReasonCode
    {
      get;
      set;
    }

    [Column("Recurring Method")]
    public int RecurringMethod
    {
      get;
      set;
    }

    [Column("Expiration Date")]
    public DateTime ExpirationDate
    {
      get;
      set;
    }

    [Column("Recurring Frequency")]
    public string RecurringFrequency
    {
      get;
      set;
    }

    [Column("Drop Shipment")]
    public Byte DropShipment
    {
      get;
      set;
    }

    [Column("Transaction Type")]
    public string TransactionType
    {
      get;
      set;
    }

    [Column("Transport Method")]
    public string TransportMethod
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

    [Column("New Location Code")]
    public string NewLocationCode
    {
      get;
      set;
    }

    [Column("New Shortcut Dimension 1 Code")]
    public string NewShortcutDimension1Code
    {
      get;
      set;
    }

    [Column("New Shortcut Dimension 2 Code")]
    public string NewShortcutDimension2Code
    {
      get;
      set;
    }

    [Column("Qty_ (Calculated)")]
    public decimal Qty_Calculated
    {
      get;
      set;
    }

    [Column("Qty_ (Phys_ Inventory)")]
    public decimal Qty_Phys_Inventory
    {
      get;
      set;
    }

    [Column("Last Item Ledger Entry No_")]
    public int LastItemLedgerEntryNo_
    {
      get;
      set;
    }

    [Column("Phys_ Inventory")]
    public Byte Phys_Inventory
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

    [Column("Gen_ Prod_ Posting Group")]
    public string Gen_Prod_PostingGroup
    {
      get;
      set;
    }

    [Column("Entry_Exit Point")]
    public string Entry_ExitPoint
    {
      get;
      set;
    }

    [Column("Document Date")]
    public DateTime DocumentDate
    {
      get;
      set;
    }

    [Column("External Document No_")]
    public string ExternalDocumentNo_
    {
      get;
      set;
    }
    public string Area
    {
      get;
      set;
    }

    [Column("Transaction Specification")]
    public string TransactionSpecification
    {
      get;
      set;
    }

    [Column("Posting No_ Series")]
    public string PostingNo_Series
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

    [Column("Source Currency Code")]
    public string SourceCurrencyCode
    {
      get;
      set;
    }

    [Column("Document Type")]
    public int DocumentType
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

    [Column("VAT Reporting Date")]
    public DateTime VATReportingDate
    {
      get;
      set;
    }

    [Column("Order Type")]
    public int OrderType
    {
      get;
      set;
    }

    [Column("Order No_")]
    public string OrderNo_
    {
      get;
      set;
    }

    [Column("Order Line No_")]
    public int OrderLineNo_
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

    [Column("New Dimension Set ID")]
    public int NewDimensionSetID
    {
      get;
      set;
    }

    [Column("Assemble to Order")]
    public Byte AssembletoOrder
    {
      get;
      set;
    }

    [Column("Job No_")]
    public string JobNo_
    {
      get;
      set;
    }

    [Column("Job Task No_")]
    public string JobTaskNo_
    {
      get;
      set;
    }

    [Column("Job Purchase")]
    public Byte JobPurchase
    {
      get;
      set;
    }

    [Column("Job Contract Entry No_")]
    public int JobContractEntryNo_
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

    [Column("Bin Code")]
    public string BinCode
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

    [Column("New Bin Code")]
    public string NewBinCode
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

    [Column("Derived from Blanket Order")]
    public Byte DerivedfromBlanketOrder
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

    [Column("Quantity (Base)")]
    public decimal QuantityBase
    {
      get;
      set;
    }

    [Column("Invoiced Qty_ (Base)")]
    public decimal InvoicedQty_Base
    {
      get;
      set;
    }
    public int Level
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

    [Column("Changed by User")]
    public Byte ChangedbyUser
    {
      get;
      set;
    }

    [Column("Cross-Reference No_")]
    public string CrossReferenceNo_
    {
      get;
      set;
    }

    [Column("Originally Ordered No_")]
    public string OriginallyOrderedNo_
    {
      get;
      set;
    }

    [Column("Originally Ordered Var_ Code")]
    public string OriginallyOrderedVar_Code
    {
      get;
      set;
    }

    [Column("Out-of-Stock Substitution")]
    public Byte OutofStockSubstitution
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
    public Byte Nonstock
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

    [Column("Product Group Code")]
    public string ProductGroupCode
    {
      get;
      set;
    }

    [Column("Item Reference No_")]
    public string ItemReferenceNo_
    {
      get;
      set;
    }

    [Column("Planned Delivery Date")]
    public DateTime PlannedDeliveryDate
    {
      get;
      set;
    }

    [Column("Order Date")]
    public DateTime OrderDate
    {
      get;
      set;
    }

    [Column("Value Entry Type")]
    public int ValueEntryType
    {
      get;
      set;
    }

    [Column("Item Charge No_")]
    public string ItemChargeNo_
    {
      get;
      set;
    }

    [Column("Inventory Value (Calculated)")]
    public decimal InventoryValueCalculated
    {
      get;
      set;
    }

    [Column("Inventory Value (Revalued)")]
    public decimal InventoryValueRevalued
    {
      get;
      set;
    }

    [Column("Variance Type")]
    public int VarianceType
    {
      get;
      set;
    }

    [Column("Inventory Value Per")]
    public int InventoryValuePer
    {
      get;
      set;
    }

    [Column("Partial Revaluation")]
    public Byte PartialRevaluation
    {
      get;
      set;
    }

    [Column("Applies-from Entry")]
    public int AppliesfromEntry
    {
      get;
      set;
    }

    [Column("Invoice No_")]
    public string InvoiceNo_
    {
      get;
      set;
    }

    [Column("Unit Cost (Calculated)")]
    public decimal UnitCostCalculated
    {
      get;
      set;
    }

    [Column("Unit Cost (Revalued)")]
    public decimal UnitCostRevalued
    {
      get;
      set;
    }

    [Column("Applied Amount")]
    public decimal AppliedAmount
    {
      get;
      set;
    }

    [Column("Update Standard Cost")]
    public Byte UpdateStandardCost
    {
      get;
      set;
    }

    [Column("Amount (ACY)")]
    public decimal AmountACY
    {
      get;
      set;
    }
    public Byte Correction
    {
      get;
      set;
    }
    public Byte Adjustment
    {
      get;
      set;
    }

    [Column("Applies-to Value Entry")]
    public int AppliestoValueEntry
    {
      get;
      set;
    }

    [Column("Invoice-to Source No_")]
    public string InvoicetoSourceNo_
    {
      get;
      set;
    }
    public int Type
    {
      get;
      set;
    }
    public string No_
    {
      get;
      set;
    }

    [Column("Operation No_")]
    public string OperationNo_
    {
      get;
      set;
    }

    [Column("Work Center No_")]
    public string WorkCenterNo_
    {
      get;
      set;
    }

    [Column("Setup Time")]
    public decimal SetupTime
    {
      get;
      set;
    }

    [Column("Run Time")]
    public decimal RunTime
    {
      get;
      set;
    }

    [Column("Stop Time")]
    public decimal StopTime
    {
      get;
      set;
    }

    [Column("Output Quantity")]
    public decimal OutputQuantity
    {
      get;
      set;
    }

    [Column("Scrap Quantity")]
    public decimal ScrapQuantity
    {
      get;
      set;
    }

    [Column("Concurrent Capacity")]
    public decimal ConcurrentCapacity
    {
      get;
      set;
    }

    [Column("Setup Time (Base)")]
    public decimal SetupTimeBase
    {
      get;
      set;
    }

    [Column("Run Time (Base)")]
    public decimal RunTimeBase
    {
      get;
      set;
    }

    [Column("Stop Time (Base)")]
    public decimal StopTimeBase
    {
      get;
      set;
    }

    [Column("Output Quantity (Base)")]
    public decimal OutputQuantityBase
    {
      get;
      set;
    }

    [Column("Scrap Quantity (Base)")]
    public decimal ScrapQuantityBase
    {
      get;
      set;
    }

    [Column("Cap_ Unit of Measure Code")]
    public string Cap_UnitofMeasureCode
    {
      get;
      set;
    }

    [Column("Qty_ per Cap_ Unit of Measure")]
    public decimal Qty_perCap_UnitofMeasure
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

    [Column("Ending Time")]
    public DateTime EndingTime
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

    [Column("Routing Reference No_")]
    public int RoutingReferenceNo_
    {
      get;
      set;
    }

    [Column("Prod_ Order Comp_ Line No_")]
    public int Prod_OrderComp_LineNo_
    {
      get;
      set;
    }
    public Byte Finished
    {
      get;
      set;
    }

    [Column("Unit Cost Calculation")]
    public int UnitCostCalculation
    {
      get;
      set;
    }
    public Byte Subcontracting
    {
      get;
      set;
    }

    [Column("Stop Code")]
    public string StopCode
    {
      get;
      set;
    }

    [Column("Scrap Code")]
    public string ScrapCode
    {
      get;
      set;
    }

    [Column("Work Center Group Code")]
    public string WorkCenterGroupCode
    {
      get;
      set;
    }

    [Column("Work Shift Code")]
    public string WorkShiftCode
    {
      get;
      set;
    }

    [Column("Serial No_")]
    public string SerialNo_
    {
      get;
      set;
    }

    [Column("Lot No_")]
    public string LotNo_
    {
      get;
      set;
    }

    [Column("Warranty Date")]
    public DateTime WarrantyDate
    {
      get;
      set;
    }

    [Column("New Serial No_")]
    public string NewSerialNo_
    {
      get;
      set;
    }

    [Column("New Lot No_")]
    public string NewLotNo_
    {
      get;
      set;
    }

    [Column("New Item Expiration Date")]
    public DateTime NewItemExpirationDate
    {
      get;
      set;
    }

    [Column("Item Expiration Date")]
    public DateTime ItemExpirationDate
    {
      get;
      set;
    }

    [Column("Package No_")]
    public string PackageNo_
    {
      get;
      set;
    }

    [Column("New Package No_")]
    public string NewPackageNo_
    {
      get;
      set;
    }

    [Column("Return Reason Code")]
    public string ReturnReasonCode
    {
      get;
      set;
    }

    [Column("Price Calculation Method")]
    public int PriceCalculationMethod
    {
      get;
      set;
    }

    [Column("Warehouse Adjustment")]
    public Byte WarehouseAdjustment
    {
      get;
      set;
    }

    [Column("Direct Transfer")]
    public Byte DirectTransfer
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

    [Column("Phys Invt Counting Period Type")]
    public int PhysInvtCountingPeriodType
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
