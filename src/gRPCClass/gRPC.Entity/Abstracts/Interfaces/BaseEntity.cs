using gRPC.Entity.Abstracts.Abstract;


namespace gRPC.Entity.Abstracts.Interfaces
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
