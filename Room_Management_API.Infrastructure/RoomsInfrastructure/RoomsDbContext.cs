using Microsoft.EntityFrameworkCore;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure {
    public class RoomsDbContext(
        DbContextOptions<RoomsDbContext> Options
    ) : DbContext(Options)
    {
        public DbSet<Rooms> ROOMS { get; set; }
        public DbSet<RoomFacility> ROOM_FACILITY { get; set; }
        public DbSet<RoomMedia> ROOM_MEDIA { get; set; }
        public DbSet<RoomStatus> ROOM_STATUS { get; set; }
        public DbSet<RoomType> ROOM_TYPE { get; set; }
        public DbSet<RoomFacilities> ROOM_FACILITIES { get; set; }
        public DbSet<RoomMedias> ROOM_MEDIAS { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Rooms
            modelBuilder.Entity<Rooms>()
                .HasOne(r => r.RoomType)
                .WithMany(rt => rt.Rooms)
                .HasForeignKey(r => r.RoomTypeId);

            modelBuilder.Entity<Rooms>()
                .HasOne(r => r.RoomStatus)
                .WithMany(rs => rs.Rooms)
                .HasForeignKey(r => r.RoomStatusId);

            modelBuilder.Entity<Rooms>()
                .Property( p => p.RoomArea )
                .HasPrecision(10, 2);

            // Room Facility
            modelBuilder.Entity<RoomFacility>()
                .HasKey(rf => new { rf.RoomId, rf.RoomFacilitiesId });

            // Room Media
            modelBuilder.Entity<RoomMedia>()
                .HasKey(rm => new { rm.RoomId, rm.RoomMediasId });
        }
    }
}