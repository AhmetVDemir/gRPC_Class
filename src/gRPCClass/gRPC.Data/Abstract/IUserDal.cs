using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Data.Abstract
{
    public interface IUserDal:IEntityRepository<Entity.Concrete.Entities.User>
    {
    }
}
