using gRPC.Data.Abstract;
using gRPC.Data.Concrete.Context;
using gRPC.Entity.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = gRPC.Entity.Concrete.Entities.Task;

namespace gRPC.Data.Concrete
{
    public class TaskDal: EntityRepositoryBase<Task, GRPCDBContext>, ITaskDal
    {
    }
}
