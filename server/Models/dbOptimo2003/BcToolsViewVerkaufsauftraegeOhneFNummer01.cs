using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimo2003
{
  [Table("BCToolsViewVerkaufsauftraegeOhneFNummer01", Schema = "dbo")]
  public partial class BcToolsViewVerkaufsauftraegeOhneFNummer01
  {
    [Key]
    public string VerkaufsauftragNr
    {
      get;
      set;
    }
    public string ArtikelNrSalesLine
    {
      get;
      set;
    }
    public string ArtikelBezSalesLine
    {
      get;
      set;
    }
    public DateTime Warenausgangsdatum
    {
      get;
      set;
    }
    public DateTime Fertigstellungsdatum
    {
      get;
      set;
    }

    [Column("GewünschtesLieferdatum")]
    public DateTime GewnschtesLieferdatum
    {
      get;
      set;
    }
    public DateTime GeplantesLieferdatum
    {
      get;
      set;
    }
    public DateTime GeplantesWarenausgangsdatum
    {
      get;
      set;
    }
    public string ArtikelNrBom
    {
      get;
      set;
    }
    public string ArtikelBezBom
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
    public decimal MengeGeliefert
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
  }
}
