using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using OptimoBcTools.Models.DbOptimoBcLive;

namespace OptimoBcTools.Data
{
  public partial class DbOptimoBcLiveContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public DbOptimoBcLiveContext(DbContextOptions<DbOptimoBcLiveContext> options):base(options)
    {
    }

    public DbOptimoBcLiveContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikel>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderProduced>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>().HasNoKey();
        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer>().HasNoKey();


        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LastDateTimeModified)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LastDateModified)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LastTimeModified)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LastUnitCostCalc_Date)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LastCountingPeriodUpdate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.NextCountingStartDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.NextCountingEndDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.PostingDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.DocumentDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.LastInvoiceDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.WarrantyDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.ExpirationDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>()
              .Property(p => p.Geburtsdatum)
              .HasColumnType("date");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>()
              .Property(p => p.RegistriertAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>()
              .Property(p => p.AnmeldungAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>()
              .Property(p => p.AbmeldungAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.AbfahrtAm)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.ProtokollAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>()
              .Property(p => p.ProtokollAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer>()
              .Property(p => p.Geburtsdatum)
              .HasColumnType("date");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.DateFrom)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.DateTo)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.ClosedTimestamp)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.DepartureDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.LastChanged)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>()
              .Property(p => p.RegistriertAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>()
              .Property(p => p.AnmeldungAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>()
              .Property(p => p.AbmeldungAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LastDateTimeModified)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LastDateModified)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LastTimeModified)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LastUnitCostCalc_Date)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LastCountingPeriodUpdate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.NextCountingStartDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.NextCountingEndDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.PostingDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ExpirationDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DocumentDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.VATReportingDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.PlannedDeliveryDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.OrderDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.StartingTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.EndingTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.WarrantyDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.NewItemExpirationDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ItemExpirationDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>()
              .Property(p => p.AbfahrtAm)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.CreationDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.LastDateModified)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.StartingTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.StartingDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.EndingTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.EndingDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.DueDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.FinishedDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.StartingDateTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.EndingDateTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.LastDatePrinted)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.DueDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.StartingDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.StartingTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.EndingDate)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.EndingTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.StartingDateTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.EndingDateTime)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.systemCreatedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.systemModifiedAt)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.ProtokollAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.AbfahrtAm)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>()
              .Property(p => p.ProtokollAm)
              .HasColumnType("datetime2");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer>()
              .Property(p => p.LastDateUsed)
              .HasColumnType("datetime");

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.PriceUnitConversion)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.Type)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.AllowInvoiceDisc_)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.StatisticsGroup)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.CommissionGroup)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.UnitPrice)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.Price_ProfitCalculation)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.Profit_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.CostingMethod)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.UnitCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.StandardCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LastDirectCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.IndirectCost_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.CostisAdjusted)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.AllowOnlineAdjustment)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.ReorderPoint)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.MaximumInventory)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.ReorderQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.UnitListPrice)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.DutyDue_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.GrossWeight)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.NetWeight)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.UnitsperParcel)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.UnitVolume)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.DutyUnitConversion)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.BudgetQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.BudgetedAmount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.BudgetProfit)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.Blocked)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.PriceIncludesVAT)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.AutomaticExt_Texts)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.Reserve)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.StockoutWarning)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.PreventNegativeInventory)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.VariantMandatoryifExists)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.CoupledtoCRM)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.AssemblyPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LowLevelCode)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.LotSize)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.RolledupMaterialCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.RolledupCapacityCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.Scrap_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.InventoryValueZero)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.DiscreteOrderQuantity)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.MinimumOrderQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.MaximumOrderQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.SafetyStockQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.OrderMultiple)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.FlushingMethod)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.ReplenishmentSystem)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.RoundingPrecision)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.ReorderingPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.IncludeInventory)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.ManufacturingPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.DampenerQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.OverflowLevel)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.CreatedFromNonstockItem)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.UseCrossDocking)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.SalesBlocked)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.PurchasingBlocked)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.SingleLevelMaterialCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.SingleLevelCapacityCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.SingleLevelSubcontrd_Cost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.SingleLevelCap_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.SingleLevelMfg_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.OverheadRate)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.RolledupSubcontractedCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.RolledupMfg_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.RolledupCap_OverheadCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.OrderTrackingPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem>()
              .Property(p => p.Critical)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.EntryNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.Quantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.RemainingQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.InvoicedQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.AppliestoEntry)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.Open)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.Positive)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.SourceType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.DropShipment)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.DocumentType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.DocumentLineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.OrderType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.OrderLineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.DimensionSetID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.AssembletoOrder)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.JobPurchase)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.Qty_perUnitofMeasure)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.DerivedfromBlanketOrder)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.OutofStockSubstitution)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.Nonstock)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.CompletelyInvoiced)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.AppliedEntrytoAdjust)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.Correction)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.ShippedQty_NotReturned)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.Prod_OrderComp_LineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.ItemTracking)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry>()
              .Property(p => p.EntryType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Year)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Jnner)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Februar)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Mrz)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.April)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Mai)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Juni)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Juli)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.August)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.September)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Oktober)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.November)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Dezember)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat>()
              .Property(p => p.Jahrssumme)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>()
              .Property(p => p.AnredeID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer>()
              .Property(p => p.BenutzerID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice>()
              .Property(p => p.DeviceID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.TourNr)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.ProtokollID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.DeviceID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.Kalenderwoche)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.Menge)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste>()
              .Property(p => p.BenutzerID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>()
              .Property(p => p.Menge)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>()
              .Property(p => p.BenutzerID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>()
              .Property(p => p.DeviceID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern>()
              .Property(p => p.ProtokollID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikel>()
              .Property(p => p.Lagerbestand)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikel>()
              .Property(p => p.Einstandspreis)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand>()
              .Property(p => p.Lagerbestand)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer>()
              .Property(p => p.BenutzerID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer>()
              .Property(p => p.AnredeID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>()
              .Property(p => p.DayofDeparture)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>()
              .Property(p => p.ProductionLeadTimeDays)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>()
              .Property(p => p.PlanTourAutomatically)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour>()
              .Property(p => p.NoCalculation)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.DeliveryTourPlanHeaderNo)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.DeliveryTourPriority)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.DeliveryDay)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.UnitVolume)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.TrailerTour)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine>()
              .Property(p => p.Prev_Deliv_TourPlanHdrNo)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.DeliveryTourPlanNo)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.Year)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.Closed)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.NotPlannedLines)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.NotPlannedLinesOpen)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.Status)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.ScanStatus)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader>()
              .Property(p => p.Calendarweek)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.DeliveryTourPlanHeaderNo)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.SetItemIndex)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.DeliveryDay)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.UnitVolume)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.ScanCompleted)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.LineVolume)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.TrailerTour)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.LineWeight)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.DocumentLineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.DeliveryTourPriority)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.ASScannedQty_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine>()
              .Property(p => p.Qty_toShip)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice>()
              .Property(p => p.DeviceID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.PriceUnitConversion)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.Type)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.AllowInvoiceDisc_)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.StatisticsGroup)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.CommissionGroup)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.UnitPrice)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.Price_ProfitCalculation)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.Profit_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.CostingMethod)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.UnitCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.StandardCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LastDirectCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.IndirectCost_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.CostisAdjusted)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.AllowOnlineAdjustment)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.ReorderPoint)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.MaximumInventory)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.ReorderQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.UnitListPrice)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.DutyDue_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.GrossWeight)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.NetWeight)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.UnitsperParcel)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.UnitVolume)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.DutyUnitConversion)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.BudgetQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.BudgetedAmount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.BudgetProfit)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.Blocked)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.PriceIncludesVAT)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.AutomaticExt_Texts)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.Reserve)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.StockoutWarning)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.PreventNegativeInventory)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.VariantMandatoryifExists)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.CoupledtoCRM)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.AssemblyPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LowLevelCode)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.LotSize)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.RolledupMaterialCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.RolledupCapacityCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.Scrap_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.InventoryValueZero)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.DiscreteOrderQuantity)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.MinimumOrderQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.MaximumOrderQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.SafetyStockQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.OrderMultiple)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.FlushingMethod)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.ReplenishmentSystem)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.RoundingPrecision)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.ReorderingPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.IncludeInventory)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.ManufacturingPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.DampenerQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.OverflowLevel)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.CreatedFromNonstockItem)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.UseCrossDocking)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.SalesBlocked)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.PurchasingBlocked)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.SingleLevelMaterialCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.SingleLevelCapacityCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.SingleLevelSubcontrd_Cost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.SingleLevelCap_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.SingleLevelMfg_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.OverheadRate)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.RolledupSubcontractedCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.RolledupMfg_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.RolledupCap_OverheadCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.OrderTrackingPolicy)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem>()
              .Property(p => p.Critical)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.LineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.EntryType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Quantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.InvoicedQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.UnitAmount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.UnitCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Amount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DiscountAmount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.AppliestoEntry)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ItemShpt_EntryNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.IndirectCost_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SourceType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RecurringMethod)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DropShipment)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Qty_Calculated)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Qty_Phys_Inventory)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.LastItemLedgerEntryNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Phys_Inventory)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.UnitCostACY)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DocumentType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DocumentLineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.OrderType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.OrderLineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DimensionSetID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.NewDimensionSetID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.AssembletoOrder)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.JobPurchase)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.JobContractEntryNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Qty_perUnitofMeasure)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DerivedfromBlanketOrder)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Qty_RoundingPrecision)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Qty_RoundingPrecisionBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.QuantityBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.InvoicedQty_Base)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Level)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.FlushingMethod)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ChangedbyUser)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.OutofStockSubstitution)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Nonstock)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ValueEntryType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.InventoryValueCalculated)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.InventoryValueRevalued)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.VarianceType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.InventoryValuePer)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.PartialRevaluation)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.AppliesfromEntry)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.UnitCostCalculated)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.UnitCostRevalued)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.AppliedAmount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.UpdateStandardCost)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.AmountACY)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Correction)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Adjustment)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.AppliestoValueEntry)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Type)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SetupTime)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RunTime)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.StopTime)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.OutputQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ScrapQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ConcurrentCapacity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SetupTimeBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RunTimeBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.StopTimeBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.OutputQuantityBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.ScrapQuantityBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Qty_perCap_UnitofMeasure)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RoutingReferenceNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Prod_OrderComp_LineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Finished)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.UnitCostCalculation)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.Subcontracting)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.PriceCalculationMethod)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.WarehouseAdjustment)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.DirectTransfer)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.PhysInvtCountingPeriodType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.OverheadRate)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SingleLevelMaterialCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SingleLevelCapacityCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SingleLevelSubcontrd_Cost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SingleLevelCap_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.SingleLevelMfg_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RolledupMaterialCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RolledupCapacityCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RolledupSubcontractedCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RolledupMfg_OvhdCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine>()
              .Property(p => p.RolledupCap_OverheadCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr>()
              .Property(p => p.NeueZeilennummer)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>()
              .Property(p => p.TourNr)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>()
              .Property(p => p.Kalenderwoche)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>()
              .Property(p => p.MengeLiefern)
              .HasPrecision(18, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>()
              .Property(p => p.MengeGescant)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf>()
              .Property(p => p.Zeilenvolumen)
              .HasPrecision(30, 2);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>()
              .Property(p => p.TourNr)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>()
              .Property(p => p.MengeLiefern)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>()
              .Property(p => p.MengeGescant)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>()
              .Property(p => p.Wiederbeschaffungsverfahren)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen>()
              .Property(p => p.TourSortierungKunde)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.Status)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.SourceType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.Blocked)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.ReplanRef_Status)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.LowLevelCode)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.Quantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.UnitCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.CostAmount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.DimensionSetID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.ShouldBePrinted)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.ForGroup)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder>()
              .Property(p => p.SalesLineNumber)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.LineNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.Quantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.FinishedQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.RemainingQuantity)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.Scrap_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.PlanningLevelCode)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.Priority)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.RoutingReferenceNo_)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.UnitCost)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.CostAmount)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.Qty_RoundingPrecision)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.Qty_RoundingPrecisionBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.QuantityBase)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.FinishedQty_Base)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.RemainingQty_Base)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.DimensionSetID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.CostAmountACY)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.UnitCostACY)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.RoutingType)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.Qty_perUnitofMeasure)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.PlanningFlexibility)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.IndirectCost_)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.OverheadRate)
              .HasPrecision(38, 20);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.Status)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine>()
              .Property(p => p.MPSOrder)
              .HasPrecision(3, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderProduced>()
              .Property(p => p.Status)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.ProtokollID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.DeviceID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.BenutzerID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.TourNr)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.Kalenderwoche)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste>()
              .Property(p => p.Menge)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>()
              .Property(p => p.ProtokollID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>()
              .Property(p => p.DeviceID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>()
              .Property(p => p.BenutzerID)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern>()
              .Property(p => p.Menge)
              .HasPrecision(10, 0);

        builder.Entity<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer>()
              .Property(p => p.LineNo_)
              .HasPrecision(10, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItem> BcAnalysenViewItems
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewItemLedgerEntry> BcAnalysenViewItemLedgerEntries
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcAnalysenViewProduzierteArtikelJahrMonat> BcAnalysenViewProduzierteArtikelJahrMonats
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanBenutzer> BcScanBenutzers
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanDevice> BcScanDevices
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollLadeliste> BcScanProtokollLadelistes
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanProtokollUmlagern> BcScanProtokollUmlagerns
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikel> BcScanViewArtikels
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewArtikelLagerbestand> BcScanViewArtikelLagerbestands
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewBenutzer> BcScanViewBenutzers
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTour> BcScanViewDeliveryTours
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourGroupedLine> BcScanViewDeliveryTourGroupedLines
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanHeader> BcScanViewDeliveryTourPlanHeaders
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDeliveryTourPlanLine> BcScanViewDeliveryTourPlanLines
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewDevice> BcScanViewDevices
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItem> BcScanViewItems
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLine> BcScanViewItemJournalLines
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewItemJournalLineUmlagernNeueZeilenNr> BcScanViewItemJournalLineUmlagernNeueZeilenNrs
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteKopf> BcScanViewLadelisteKopfs
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewLadelisteZeilen> BcScanViewLadelisteZeilens
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrder> BcScanViewProductionOrders
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderLine> BcScanViewProductionOrderLines
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProductionOrderProduced> BcScanViewProductionOrderProduceds
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollLadeliste> BcScanViewProtokollLadelistes
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewProtokollUmlagern> BcScanViewProtokollUmlagerns
    {
      get;
      set;
    }

    public DbSet<OptimoBcTools.Models.DbOptimoBcLive.BcScanViewUmlagerungLetzteNummer> BcScanViewUmlagerungLetzteNummers
    {
      get;
      set;
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Conventions.Add(_ => new BlankTriggerAddingConvention());
    }
  }
}
