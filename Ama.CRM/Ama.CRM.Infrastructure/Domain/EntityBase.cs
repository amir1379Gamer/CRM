namespace Ama.CRM.Infrastructure.Domain {
    public abstract class EntityBase<TId>:ModelBase {
        public virtual TId Id { get; set; }
    }
}
