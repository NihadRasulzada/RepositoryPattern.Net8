using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Entity
{
    public class BaseEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual string? CraetedBy { get; set; }
        public virtual DateTime? UpdatedAt { get; set; }
        public virtual string? UpdatedBy { get; set; }

    }
}
