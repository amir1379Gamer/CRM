namespace Ama.CRM.Infrastructure.Messaging {
    public abstract class ResponseBase {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public ResultType Result { get; set; }
    }

    
    public abstract class ResponseBase<TEntity>:ResponseBase {
        
        public TEntity Entity { get; set; }

    }
  
}
