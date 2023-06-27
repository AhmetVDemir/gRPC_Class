using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Entity.Concrete.Entities
{
    public class AsignList
    {
        public Guid Id { get; set; }

        public Guid TaskId { get; set; }

        public Guid AsignTo { get; set; }
    }
}
