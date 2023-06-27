﻿using gRPC.Entity.Concrete.Entities;
using gRPC.Entity.Concrete.Global.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Entity.Concrete.DTOs
{
    public class TaskDTO
    {
        string TaskName { get; set; }

        string Decription { get; set; }

        DateTime StartTime { get; set; }

        DateTime TerminTime { get; set; }

        Enums Proggress { get; set; }

        List<AsignList> AsignTo { get; set; }
    }
}
