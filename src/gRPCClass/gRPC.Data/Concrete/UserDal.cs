using gRPC.Data.Abstract;
using gRPC.Data.Concrete.Context;
using gRPC.Entity.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Data.Concrete
{
    public class UserDal :EntityRepositoryBase<User,GRPCDBContext>, IUserDal
    {
    }
}
