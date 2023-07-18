using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Entities
{
    public class BaseTrackedEntity:BaseEntity
    {
        public DateTime CreateAt { get; set; }= DateTime.UtcNow;
        public DateTime LastModifiedAt { get; set; } = DateTime.UtcNow;
    }
}
