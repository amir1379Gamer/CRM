using System;

namespace Ama.CRM.Infrastructure.Messaging {
  public abstract class RequestPagingBase : RequestBase
  {
    public int Index { get; set; } = 1;
    public int Size { get; set; } = 10;
    public DateTime? RequestDate { get; set; } = null;
  }
  public abstract class RequestPagingBase<TEntity> :RequestPagingBase
  {
    public TEntity Entity { get; set; }
    public bool IsGetAll { get; set; }
  }

}
