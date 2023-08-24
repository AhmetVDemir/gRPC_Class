using gRPC.WFProto;
using Grpc.Core;

namespace gRPC.GRPCSERVICE.Services
{
    public class TaskService : gRPCTask.gRPCTaskBase
    {
        public override Task<AddTaskResponsePTO> AddTask(AddTaskRequestPTO request, ServerCallContext context)
        {
            return base.AddTask(request, context);
        }
    }
}
