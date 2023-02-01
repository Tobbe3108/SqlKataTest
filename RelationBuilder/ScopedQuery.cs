using SqlKata;

namespace RelationBuilder;

public class ScopedQuery : Query
{
  public string TenantId { get; }
  public string InstanceId { get; }

  public ScopedQuery(Guid tenantId, Guid instanceId)
  {
    TenantId = tenantId.ToString();
    InstanceId = instanceId.ToString();
  }
}