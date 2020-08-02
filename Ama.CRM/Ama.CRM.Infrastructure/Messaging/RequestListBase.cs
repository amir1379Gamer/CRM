using System.Collections.Generic;

namespace Ama.CRM.Infrastructure.Messaging {
    public abstract class RequestListBase<TEntity>:RequestBase {
        public IEnumerable<TEntity> Entities { get; set; }
    }
}
