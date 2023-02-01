using SqlKata;

namespace RelationBuilder;

public static class QueryExtensions
{
  public static ScopedQuery From<TTable>(this ScopedQuery query, out TTable table) where TTable : new()
  {
    table = new TTable();
    query.From(typeof(TTable).Name)
      .Where($"{typeof(TTable).Name}.{nameof(query.TenantId)}", query.TenantId)
      .Where($"{typeof(TTable).Name}.{nameof(query.InstanceId)}", query.InstanceId);
    return query;
  }
  
  public static ScopedQuery Join<TTable>(this ScopedQuery query,
    out TTable table,
    Func<TTable, Join, Join> callback)
    where TTable : new() => PrivateJoin(query, out table, callback, "join");

  public static ScopedQuery LeftJoin<TTable>(this ScopedQuery query,
    out TTable table,
    Func<TTable, Join, Join> callback)
    where TTable : new() => PrivateJoin(query, out table, callback, "left join");

  public static ScopedQuery RightJoin<TTable>(this ScopedQuery query,
    out TTable table,
    Func<TTable, Join, Join> callback)
    where TTable : new() => PrivateJoin(query, out table, callback, "right join");

  public static ScopedQuery FullJoin<TTable>(this ScopedQuery query,
    out TTable table,
    Func<TTable, Join, Join> callback)
    where TTable : new() => PrivateJoin(query, out table, callback, "full join");

  public static ScopedQuery CrossJoin<TTable>(this ScopedQuery query,
    out TTable table,
    Func<TTable, Join, Join> callback)
    where TTable : new() => PrivateJoin(query, out table, callback, "cross join");

  private static ScopedQuery PrivateJoin<TTable>(this ScopedQuery query,
    out TTable table,
    Func<TTable, Join, Join> callback,
    string type) where TTable : new()
  {
    table = new TTable();
    var table1 = table;
    query.Join(typeof(TTable).Name,
      join => callback(table1, join)
        .Where($"{typeof(TTable).Name}.{nameof(query.TenantId)}", query.TenantId)
        .Where($"{typeof(TTable).Name}.{nameof(query.InstanceId)}", query.InstanceId),
      type);
    return query;
  }
}