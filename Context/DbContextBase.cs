using Microsoft.EntityFrameworkCore;



    public class DbContextBase : DbContext
    {
        public DbSet<Duty>? Duties { get; set; }
        public DbSet<UserNote>? UserNotes { get; set; }
        public DbSet<User>? Users{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
            optionsBuilder.UseMySql("server=localhost;database=todoapi;user=root;port=3306;password=toortoor", serverVersion);
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserNote>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e=>e.Title);
                entity.HasMany(e=>e.Duties).WithMany(e=>e!.UserNotes).UsingEntity(e=>e.ToTable("UserDuty"));
                entity.HasOne(e=>e.User).WithMany(e=>e!.UserNotes).HasForeignKey(e=>e.UserId);
            });
            modelBuilder.Entity<Duty>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e=>e.Name);
                entity.Property(e => e.DueDate).IsRequired();
                entity.Property(e => e.StartedDate).IsRequired();
                entity.Property(e => e.Status);
                entity.Property(e => e.CompletedDate).IsRequired();
            });
             modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e=>e.FirstName);
                entity.Property(e => e.LastName);
                entity.Property(e => e.Email);
                entity.Property(e => e.Username);
                entity.Property(e => e.Password);
                
            });
            
        }
    }

