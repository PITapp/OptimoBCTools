using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimo2003
{
  [Table("BCToolsViewVerkaufsauftraegeOhneFNummer02", Schema = "dbo")]
  public partial class BcToolsViewVerkaufsauftraegeOhneFNummer02
  {
    [Key]
    public DateTime Warenausgangsdatum
    {
      get;
      set;
    }
    public string VerkaufsauftragNr
    {
      get;
      set;
    }
    public string ArtikelNr
    {
      get;
      set;
    }
    public string ArtikelBez
    {
      get;
      set;
    }
    public string SetArtikelNr
    {
      get;
      set;
    }
    public string SetArtikelBez
    {
      get;
      set;
    }
    public DateTime GeplantesLieferdatum
    {
      get;
      set;
    }
  }
}
