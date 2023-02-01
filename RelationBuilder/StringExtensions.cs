namespace RelationBuilder;

public static class StringExtensions
{
  public static string As(this string value, string alias) => $"{value} AS {alias}";
}