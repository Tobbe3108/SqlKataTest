using SqlKata;
using RelationBuilder;
using RelationBuilder.Models;

namespace ClassLibrary1;

public class RelationBuilder
{
  public static Query Test => new ScopedQuery(Guid.NewGuid(), Guid.NewGuid())
    .From<Adresse>(out var adresse)
    .Join<AdrFunk>(out var adrFunk, (af, j) => j.WhereColumns(af.AdresseIdent, "=", adresse.AdresseIdent))
    .LeftJoin<Kode>(out var kode,
      (k, j) => j
        .WhereColumns(k.KodeId, "=", adrFunk.Funktion)
        .Where(adrFunk.Tabelnavn, "LEJER"))
    .Join<Lejer>(out var lejer, (l, j) => j.WhereColumns(l.LejerId, "=", adrFunk.RecordId))
    .Join<Ejendom>(out var ejendom,
      (e, j) => j
        .WhereColumns(e.SelskabNr, "=", lejer.SelskabNr)
        .WhereColumns(e.EjendomNr, "=", lejer.EjendomNr))
    .Where(q => q
      .Where(adresse.TilDato, ">=", DateTime.Today)
      .OrWhereNull(adresse.TilDato))
    .Where(q => q
      .Where(adrFunk.TilDato, ">=", DateTime.Today)
      .OrWhereNull(adrFunk.TilDato))
    .Select(lejer.SelskabNr,
      lejer.EjendomNr,
      lejer.LejemaalNr,
      lejer.LejerNr,
      adresse.Adresse1,
      adresse.Adresse2,
      adresse.Email,
      ejendom.EjendomNavn,
      kode.KodeTekst.As("FunctionText"));

  public class NewType
  {
    public int SelskabNr { get; set; }
    public int EjendomNr { get; set; }
    public int LejemaalNr { get; set; }
    public int LejerNr { get; set; }
    public string? Adresse1 { get; set; }
    public string? Adresse2 { get; set; }
    public string? Email { get; set; }
    public string EjendomNavn { get; set; }
    public string? FunctionText { get; set; }
  }
}