using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewItemJournalLineUmlagernNeueZeilenNr", Schema = "dbo")]
  public partial class BcScanViewItemJournalLineUmlagernNeueZeilenNr
  {
    [Key]
    public int? NeueZeilennummer
    {
      get;
      set;
    }
  }
}
