namespace CarManageMVCEFDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarEntity : DbContext
    {
        public CarEntity()
            : base("name=CarEntity")
        {
        }

        public virtual DbSet<CarRecord> CarRecord { get; set; }
        public virtual DbSet<CommunityInfo> CommunityInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
