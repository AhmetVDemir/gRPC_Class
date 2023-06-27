using Core.Utilities.Results;
using gRPC.Entity.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Business.Absrtract
{
    public interface ITaskService
    {
        IDataResult<List<TaskDTO>> GetAll();
        IDataResult<TaskDTO> Get(Guid Id);
        IResult Update(TaskDTO task);
        IResult Add(TaskDTO task);
        IResult Delete(TaskDTO task);
    }
}
