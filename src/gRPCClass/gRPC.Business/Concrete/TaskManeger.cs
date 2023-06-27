using Core.Utilities.Results;
using gRPC.Business.Absrtract;
using gRPC.Entity.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Business.Concrete
{
    public class TaskManeger : ITaskService
    {
        public IResult Add(TaskDTO task)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TaskDTO task)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TaskDTO> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(TaskDTO task)
        {
            throw new NotImplementedException();
        }
    }
}
