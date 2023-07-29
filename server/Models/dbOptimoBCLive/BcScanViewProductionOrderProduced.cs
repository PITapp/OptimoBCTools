using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewProductionOrder_Produced", Schema = "dbo")]
  public partial class BcScanViewProductionOrderProduced
  {
    [Key]
    public string Produziert
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
  }
}
