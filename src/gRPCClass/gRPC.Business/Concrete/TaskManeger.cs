using Core.Utilities.Results;
using gRPC.Business.Absrtract;
using gRPC.Core.Utils.Mapper;
using gRPC.Data.Abstract;
using gRPC.Entity.Concrete.DTOs;
using gRPC.Entity.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = gRPC.Entity.Concrete.Entities.Task;

namespace gRPC.Business.Concrete
{
    public class TaskManeger : ITaskService
    {
        ITaskDal _taskDal;

        public TaskManeger(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }


        public IResult Add(TaskDTO task)
        {
            try
            {
                Task destinationAuto = ModelConverter.Convert<TaskDTO, Task>(task);

                var c = destinationAuto;

                return new SuccessResult("Ekleme Başarılı");
            }
            catch(Exception ex)
            {
                return new ErrorResult("Hata oluştu : " + ex.Message);
            }
        }

        public IResult Delete(TaskDTO task)
        {
            try
            {
                
                return new SuccessResult("Silme Başarılı");
            }
            catch (Exception ex)
            {
                return new ErrorResult("Hata oluştu : " + ex.Message);
            }
        }

        public IDataResult<TaskDTO> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskDTO>> GetAll()
        {
            return new SuccessDataResult<List<TaskDTO>>(new List<TaskDTO>(), "Ok");
        }

        public IResult Update(TaskDTO task)
        {
            throw new NotImplementedException();
        }
    }
}
