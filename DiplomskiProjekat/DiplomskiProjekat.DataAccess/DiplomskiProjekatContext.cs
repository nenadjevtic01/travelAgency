using DiplomskiProjekat.Domain;
using Microsoft.EntityFrameworkCore;

namespace DiplomskiProjekat.DataAccess
{
    public class DiplomskiProjekatContext : DbContext
    {
        public DiplomskiProjekatContext(DbContextOptions options = null) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-JTGBQPI\\SQLEXPRESS;Initial Catalog=DiplomskiProjekat;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            modelBuilder.Entity<User>()
              .HasDiscriminator<string>("Discriminator")
              .HasValue<AgencyEmployee>("Agency employee")
              .HasValue<RegularUser>("Regular user")
              .HasValue<Admin>("Admin");
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<AuditLog> AuditLog { get; set; }
        public DbSet<Accommodation> Accommodation { get; set; }
        public DbSet<RoomPrice> RoomPrice { get; set; }
        public DbSet<AccommodationType> AccommodationsType { get; set; }
        public DbSet<Agency> Agency { get; set; }
        public DbSet<Attraction> Attraction { get; set; }
        public DbSet<AttractionCategory> AttractionCategory { get; set; }
        public DbSet<AttractionImage> AttractionImage { get; set; }
        public DbSet<Climate> Climate { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<DestinationImage> DestinationImage { get; set; }
        public DbSet<Itinerary> Itinerary { get; set; }
        public DbSet<ItineraryActivity> ItineraryActivity { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<ReservationRoom> ReservationRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomNumber> RoomNumber { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Safety> Safety { get; set; }
        public DbSet<Transport> Transport { get; set; }
        public DbSet<Trip> Trip { get; set; }
        public DbSet<TripAccommodation> TripAccommodation { get; set; }
        public DbSet<TripAttraction> TripAttraction { get; set; }
        public DbSet<TripPrice> TripPrice { get; set; }
        public DbSet<UseCase> UseCase { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserFavorites> UserFavorite { get; set; }
        public DbSet<UserUseCase> UserUseCase { get; set; }
        public DbSet<Visa> Visa { get; set; }
        public DbSet<Continent> Continent { get; set; }
    }
}