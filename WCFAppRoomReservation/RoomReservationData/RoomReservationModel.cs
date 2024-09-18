using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RoomReservationData
{
    public partial class RoomReservationModel : DbContext
    {
        public RoomReservationModel()
            : base("name=RoomReservationModel")
        {
        }

        public virtual DbSet<RoomReservation> RoomReservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomReservation>()
                .Property(e => e.RoomName)
                .IsFixedLength();
            
        }
    }
}
