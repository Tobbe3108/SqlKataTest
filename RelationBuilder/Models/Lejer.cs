namespace RelationBuilder.Models;

public class Lejer
{
  public readonly string SelskabNr = $"{nameof(Lejer)}.{nameof(LejerSchema.SelskabNr)}";
  public readonly string EjendomNr = $"{nameof(Lejer)}.{nameof(LejerSchema.EjendomNr)}";
  public readonly string LejemaalNr = $"{nameof(Lejer)}.{nameof(LejerSchema.LejemaalNr)}";
  public readonly string LejerNr = $"{nameof(Lejer)}.{nameof(LejerSchema.LejerNr)}";
  public readonly string LejerId = $"{nameof(Lejer)}.{nameof(LejerSchema.LejerId)}";
}