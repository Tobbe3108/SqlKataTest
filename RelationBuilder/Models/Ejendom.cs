namespace RelationBuilder.Models;

public class Ejendom
{
  public readonly string SelskabNr = $"{nameof(Ejendom)}.{nameof(EjendomSchema.SelskabNr)}";
  public readonly string EjendomNr = $"{nameof(Ejendom)}.{nameof(EjendomSchema.EjendomNr)}";
  public readonly string EjendomNavn = $"{nameof(Ejendom)}.{nameof(EjendomSchema.EjendomNavn)}";
}