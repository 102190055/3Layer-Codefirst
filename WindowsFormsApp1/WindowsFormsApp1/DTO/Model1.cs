using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer<Model1>(new CreateDB());
        }
        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<LSH> LSHes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
