namespace RelationBuilder.Models;

public class Kode
{
  public readonly string KodeId = $"{nameof(Kode)}.{nameof(KodeSchema.KodeId)}";
  public readonly string KodeTekst = $"{nameof(Kode)}.{nameof(KodeSchema.KodeTekst)}";
}