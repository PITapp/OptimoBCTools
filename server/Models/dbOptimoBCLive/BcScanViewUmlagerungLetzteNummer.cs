using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewUmlagerungLetzteNummer", Schema = "dbo")]
  public partial class BcScanViewUmlagerungLetzteNummer
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }

    [Column("Series Code")]
    public string SeriesCode
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

    [Column("Last No_ Used")]
    public string LastNo_Used
    {
      get;
      set;
    }

    [Column("Last Date Used")]
    public DateTime LastDateUsed
    {
      get;
      set;
    }
  }
}
