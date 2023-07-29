using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewArtikel", Schema = "dbo")]
  public partial class BcScanViewArtikel
  {
    [Key]
    public Byte[] timestamp
    {
      get;
      set;
    }
    public string ArtikelNr
    {
      get;
      set;
    }
    public string Beschreibung
    {
      get;
      set;
    }
    public string Basiseinheitencode
    {
      get;
      set;
    }
    public string Einheit
    {
      get;
      set;
    }
    public int? Lagerbestand
    {
      get;
      set;
    }
    public string Lagerbuchungsgruppe
    {
      get;
      set;
    }
    public decimal Einstandspreis
    {
      get;
      set;
    }
    public string GlobalerDimensionscode1
    {
      get;
      set;
    }
    public string GlobalerDimensionscode2
    {
      get;
      set;
    }
    public string Produktbuchungsgruppe
    {
      get;
      set;
    }
    public string Artikelkategoriencode
    {
      get;
      set;
    }
  }
}
