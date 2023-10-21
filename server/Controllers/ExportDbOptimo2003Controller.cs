using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OptimoBcTools.Data;

namespace OptimoBcTools
{
    public partial class ExportDbOptimo2003Controller : ExportController
    {
        private readonly DbOptimo2003Context context;
        public ExportDbOptimo2003Controller(DbOptimo2003Context context)
        {
            this.context = context;
        }

        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/csv")]
        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcToolsViewVerkaufsauftraegeOhneFNummer01sToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcToolsViewVerkaufsauftraegeOhneFNummer01s, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/excel")]
        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer01s/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcToolsViewVerkaufsauftraegeOhneFNummer01sToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcToolsViewVerkaufsauftraegeOhneFNummer01s, Request.Query), fileName);
        }
        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/csv")]
        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/csv(fileName='{fileName}')")]
        public FileStreamResult ExportBcToolsViewVerkaufsauftraegeOhneFNummer02sToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.BcToolsViewVerkaufsauftraegeOhneFNummer02s, Request.Query), fileName);
        }

        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/excel")]
        [HttpGet("/export/DbOptimo2003/bctoolsviewverkaufsauftraegeohnefnummer02s/excel(fileName='{fileName}')")]
        public FileStreamResult ExportBcToolsViewVerkaufsauftraegeOhneFNummer02sToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.BcToolsViewVerkaufsauftraegeOhneFNummer02s, Request.Query), fileName);
        }
    }
}
