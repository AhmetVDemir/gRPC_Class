using Core.Utilities.Results;
using gRPC.Business.Absrtract;
using gRPC.Data.Abstract;
using gRPC.Entity.Concrete.DTOs;
using gRPC.Entity.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return ErrorResult("Hata oluştu : " +ex.Message);
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
