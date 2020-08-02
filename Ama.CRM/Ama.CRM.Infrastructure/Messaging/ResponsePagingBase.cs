using System;
using System.Collections.Generic;

namespace Ama.CRM.Infrastructure.Messaging {
    public abstract class ResponsePagingBase<TEntity>
        : ResponseBase {
        public IEnumerable<TEntity> Entities { get; set; } = new List<TEntity>();
        public int Index { get; set; }
        public int Size { get; set; }
        public int Total { get; set; }
        public int Start => (Index - 1) * Size + 1;
        public int End => Index * Size;
        public int PageCount => Size > 0 ? (Total - 1) / Size + 1 : 0;
        public DateTime? RequestDate { get; set; } = null;
    }

}
