using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OptimoBcTools.Data;

namespace OptimoBcTools
{
    public partial class ExportDbOptimoBcLiveController : ExportController
    {
        private readonly DbOptimoBcLiveContext context;
        public ExportDbOptimoBcLiveController(DbOptimoBcLiveContext context)
        {
            this.context = context;
        }

        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitems/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitems/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcAnalysenViewItemsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcAnalysenViewItems, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitems/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitems/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcAnalysenViewItemsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcAnalysenViewItems, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitemledgerentries/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitemledgerentries/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcAnalysenViewItemLedgerEntriesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcAnalysenViewItemLedgerEntries, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitemledgerentries/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewitemledgerentries/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcAnalysenViewItemLedgerEntriesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcAnalysenViewItemLedgerEntries, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewproduzierteartikeljahrmonats/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewproduzierteartikeljahrmonats/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcAnalysenViewProduzierteArtikelJahrMonatsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcAnalysenViewProduzierteArtikelJahrMonats, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewproduzierteartikeljahrmonats/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcanalysenviewproduzierteartikeljahrmonats/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcAnalysenViewProduzierteArtikelJahrMonatsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcAnalysenViewProduzierteArtikelJahrMonats, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanbenutzers/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanbenutzers/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanBenutzersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanBenutzers, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanbenutzers/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanbenutzers/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanBenutzersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanBenutzers, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscandevices/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscandevices/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanDevicesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanDevices, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscandevices/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscandevices/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanDevicesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanDevices, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollladelistes/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollladelistes/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanProtokollLadelistesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanProtokollLadelistes, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollladelistes/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollladelistes/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanProtokollLadelistesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanProtokollLadelistes, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollumlagerns/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollumlagerns/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanProtokollUmlagernsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanProtokollUmlagerns, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollumlagerns/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanprotokollumlagerns/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanProtokollUmlagernsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanProtokollUmlagerns, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikels/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikels/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewArtikelsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewArtikels, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikels/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikels/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewArtikelsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewArtikels, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikellagerbestands/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikellagerbestands/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewArtikelLagerbestandsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewArtikelLagerbestands, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikellagerbestands/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewartikellagerbestands/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewArtikelLagerbestandsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewArtikelLagerbestands, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewbenutzers/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewbenutzers/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewBenutzersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewBenutzers, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewbenutzers/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewbenutzers/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewBenutzersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewBenutzers, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytours/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytours/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryToursToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewDeliveryTours, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytours/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytours/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryToursToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewDeliveryTours, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourgroupedlines/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourgroupedlines/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryTourGroupedLinesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewDeliveryTourGroupedLines, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourgroupedlines/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourgroupedlines/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryTourGroupedLinesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewDeliveryTourGroupedLines, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanheaders/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanheaders/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryTourPlanHeadersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewDeliveryTourPlanHeaders, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanheaders/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanheaders/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryTourPlanHeadersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewDeliveryTourPlanHeaders, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanlines/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanlines/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryTourPlanLinesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewDeliveryTourPlanLines, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanlines/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdeliverytourplanlines/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDeliveryTourPlanLinesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewDeliveryTourPlanLines, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdevices/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdevices/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDevicesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewDevices, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewdevices/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewdevices/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewDevicesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewDevices, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitems/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitems/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewItemsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewItems, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewitems/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitems/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewItemsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewItems, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallines/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallines/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewItemJournalLinesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewItemJournalLines, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallines/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallines/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewItemJournalLinesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewItemJournalLines, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallineumlagernneuezeilennrs/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallineumlagernneuezeilennrs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewItemJournalLineUmlagernNeueZeilenNrsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewItemJournalLineUmlagernNeueZeilenNrs, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallineumlagernneuezeilennrs/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewitemjournallineumlagernneuezeilennrs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewItemJournalLineUmlagernNeueZeilenNrsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewItemJournalLineUmlagernNeueZeilenNrs, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistekopfs/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistekopfs/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewLadelisteKopfsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewLadelisteKopfs, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistekopfs/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistekopfs/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewLadelisteKopfsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewLadelisteKopfs, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistezeilens/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistezeilens/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewLadelisteZeilensToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewLadelisteZeilens, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistezeilens/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewladelistezeilens/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewLadelisteZeilensToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewLadelisteZeilens, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorders/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorders/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProductionOrdersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewProductionOrders, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorders/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorders/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProductionOrdersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewProductionOrders, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderlines/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderlines/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProductionOrderLinesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewProductionOrderLines, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderlines/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderlines/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProductionOrderLinesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewProductionOrderLines, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderproduceds/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderproduceds/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProductionOrderProducedsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewProductionOrderProduceds, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderproduceds/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewproductionorderproduceds/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProductionOrderProducedsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewProductionOrderProduceds, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollladelistes/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollladelistes/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProtokollLadelistesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewProtokollLadelistes, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollladelistes/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollladelistes/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProtokollLadelistesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewProtokollLadelistes, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollumlagerns/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollumlagerns/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProtokollUmlagernsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewProtokollUmlagerns, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollumlagerns/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewprotokollumlagerns/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewProtokollUmlagernsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewProtokollUmlagerns, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimoBcLive/bcscanviewumlagerungletztenummers/csv")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewumlagerungletztenummers/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewUmlagerungLetzteNummersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcScanViewUmlagerungLetzteNummers, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimoBcLive/bcscanviewumlagerungletztenummers/excel")]
        [HttpGet("/export/DbOptimoBcLive/bcscanviewumlagerungletztenummers/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcScanViewUmlagerungLetzteNummersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcScanViewUmlagerungLetzteNummers, Request.Query), fileName);
        }
    }
}
