using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC.Data.Concrete.Context
{
    public class GRPCDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=B166ER;Database=grpc;Trusted_Connection=true;");
        }

        public DbSet<gRPC.Entity.Concrete.Entities.User> Users { get; set; }
        public DbSet<gRPC.Entity.Concrete.Entities.Task> Tasks { get; set; }
        public DbSet<gRPC.Entity.Concrete.Entities.AsignList> AsignLists { get; set; }
    }
}
