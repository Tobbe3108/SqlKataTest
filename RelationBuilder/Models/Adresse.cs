namespace RelationBuilder.Models;

public class Adresse
{
  public readonly string AdresseIdent = $"{nameof(Adresse)}.{nameof(AdresseSchema.AdresseIdent)}";
  public readonly string Adresse1 = $"{nameof(Adresse)}.{nameof(AdresseSchema.Adresse1)}";
  public readonly string Adresse2 = $"{nameof(Adresse)}.{nameof(AdresseSchema.Adresse2)}";
  public readonly string Email = $"{nameof(Adresse)}.{nameof(AdresseSchema.Email)}";
  public readonly string TilDato = $"{nameof(Adresse)}.{nameof(AdresseSchema.TilDato)}";
}