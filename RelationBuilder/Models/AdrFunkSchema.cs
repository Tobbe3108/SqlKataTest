namespace RelationBuilder.Models;

public class AdrFunkSchema
{
  public string Tabelnavn { get; set; }
  public int RecordId { get; set; }
  public int Funktion { get; set; }
  public int AdresseIdent { get; set; }
  public DateTime? TilDato { get; set; }
}

public class AdrFunk
{
  public readonly string Tabelnavn = $"{nameof(AdrFunk)}.{nameof(AdrFunkSchema.Tabelnavn)}";
  public readonly string RecordId = $"{nameof(AdrFunk)}.{nameof(AdrFunkSchema.RecordId)}";
  public readonly string Funktion = $"{nameof(AdrFunk)}.{nameof(AdrFunkSchema.Funktion)}";
  public readonly string AdresseIdent = $"{nameof(AdrFunk)}.{nameof(AdrFunkSchema.AdresseIdent)}";
  public readonly string TilDato = $"{nameof(AdrFunk)}.{nameof(AdrFunkSchema.TilDato)}";
}