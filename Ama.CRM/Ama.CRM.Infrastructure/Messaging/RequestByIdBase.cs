namespace Ama.CRM.Infrastructure.Messaging {
    public abstract class RequestByIdBase<TId>:RequestBase {
        public TId Id { get; set; }
    }
    
}
