﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public abstract class EntitiesBase : IEntitiesBase
    {
        public EntitiesBase()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        public virtual Guid Id { get; set; } = Guid.NewGuid();

        public virtual string CreatedBy { get; set; } = "Undefine";

        public virtual string? ModifiedBy { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

        public virtual bool IsDeleted { get; set; }
    }
}
