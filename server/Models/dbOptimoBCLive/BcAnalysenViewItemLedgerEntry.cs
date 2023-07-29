using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCAnalysenViewItemLedgerEntry", Schema = "dbo")]
  public partial class BcAnalysenViewItemLedgerEntry
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }

    [Column("Entry No_")]
    public int EntryNo_
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
    public decimal Quantity
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

    [Column("Invoiced Quantity")]
    public decimal InvoicedQuantity
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
    public Byte Open
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
    public Byte Positive
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

    [Column("Source Type")]
    public int SourceType
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

    [Column("No_ Series")]
    public string No_Series
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

    [Column("Variant Code")]
    public string VariantCode
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

    [Column("Completely Invoiced")]
    public Byte CompletelyInvoiced
    {
      get;
      set;
    }

    [Column("Last Invoice Date")]
    public DateTime LastInvoiceDate
    {
      get;
      set;
    }

    [Column("Applied Entry to Adjust")]
    public Byte AppliedEntrytoAdjust
    {
      get;
      set;
    }
    public Byte Correction
    {
      get;
      set;
    }

    [Column("Shipped Qty_ Not Returned")]
    public decimal ShippedQty_NotReturned
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

    [Column("Expiration Date")]
    public DateTime ExpirationDate
    {
      get;
      set;
    }

    [Column("Item Tracking")]
    public int ItemTracking
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

    [Column("Return Reason Code")]
    public string ReturnReasonCode
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

    [Column("Item No_")]
    public string ItemNo_
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
  }
}
