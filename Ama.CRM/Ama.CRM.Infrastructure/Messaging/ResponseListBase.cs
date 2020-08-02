using System.Collections.Generic;

namespace Ama.CRM.Infrastructure.Messaging {
    public abstract class ResponseListBase<TEntity>:ResponseBase {
        public IEnumerable<TEntity> Entities { get; set; }=new List<TEntity>();
    }
}
