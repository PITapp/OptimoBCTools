using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimoBcTools.Models.DbOptimoBcLive
{
  [Table("BCScanViewLadelisteZeilen", Schema = "dbo")]
  public partial class BcScanViewLadelisteZeilen
  {
    [Key]
    public int TourNr
    {
      get;
      set;
    }
    public string VerkaufsauftragNr
    {
      get;
      set;
    }
    public string KundeNr
    {
      get;
      set;
    }
    public string KundeName
    {
      get;
      set;
    }
    public string PLZ
    {
      get;
      set;
    }
    public string Ort
    {
      get;
      set;
    }
    public string Land
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
    public decimal MengeLiefern
    {
      get;
      set;
    }
    public int MengeGescant
    {
      get;
      set;
    }
    public string Fertigungsnummer
    {
      get;
      set;
    }
    public int Wiederbeschaffungsverfahren
    {
      get;
      set;
    }
    public string Produziert
    {
      get;
      set;
    }
    public string ProduziertTyp
    {
      get;
      set;
    }
    public string ReferenzNummer
    {
      get;
      set;
    }
    public int TourSortierungKunde
    {
      get;
      set;
    }
  }
}
