
using gRPC.Entity.Abstracts.Abstract;
using gRPC.Entity.Abstracts.Interfaces;
using gRPC.Entity.Concrete.Global.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Entity.Concrete.Entities
{
    public class Task : BaseEntity, IEntity
    {

        string TaskName { get; set; }

        string Decription { get; set; }

        DateTime StartTime { get; set; }

        DateTime TerminTime { get; set; }

        Guid CreatedBy { get; set; }

        TaskProgresses Proggress { get; set; }


    }
}

