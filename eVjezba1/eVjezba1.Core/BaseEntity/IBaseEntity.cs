using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezba1.Core
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public bool isDeleted { get; set; }
    }
}
