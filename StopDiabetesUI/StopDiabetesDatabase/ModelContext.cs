namespace StopDiabetesDatabase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
            Database.SetInitializer<ModelContext>(new CreateDatabaseIfNotExists<ModelContext>());
            Database.SetInitializer<ModelContext>(new DropCreateDatabaseIfModelChanges<ModelContext>());

        }

        public virtual DbSet<Laporan> Laporans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
