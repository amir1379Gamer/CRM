using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ama.CRM.Infrastructure.Domain {
    public abstract class ModelBase {

        [Column(Order = 901)]
        public int? CreatedUserId { get; set; }

        [Column(Order = 902)]
        public DateTime CreatedAt { get; set; }

        [Column(Order = 903)]
        public int? UpdatedUserId { get; set; }

        [Column(Order = 904)]
        public DateTime UpdatedAt { get; set; }

        [Column(Order = 905)]
        public bool Editable { get; set; }

        [Column(Order = 906)]
        public bool Deletable { get; set; }

        [Column(Order = 907)]
        public virtual bool IsActive { get; set; }

    }
}
