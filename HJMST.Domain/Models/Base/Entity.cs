using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJMST.Domain.Models.Base
{
    public abstract class Entity : IEntity
    {
        protected Entity() : base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
