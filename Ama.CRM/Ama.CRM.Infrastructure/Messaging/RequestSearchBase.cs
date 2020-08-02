namespace Ama.CRM.Infrastructure.Messaging {
    public abstract class RequestSearchBase:RequestPagingBase
    {
        public string Query { get; set; }
        //public Expression<Func<TEntity, bool>> Expression { get; set; }
    }
    public abstract class RequestSearchBase<TEntity>:RequestSearchBase
    {
        public TEntity Entity { get; set; }
    }
   
}
