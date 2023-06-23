using gRPC.Entity.Abstracts.Abstract;
using gRPC.Entity.Abstracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Entity.Concrete.Entities
{
    public class User : BaseEntity, IEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }


    
}
