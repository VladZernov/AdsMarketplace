namespace AdsMarketplace.Domain.Concrete
{
    using System;
    using System.Data.Entity;
    using AdsMarketplace.Domain.Entities;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdsContext : DbContext
    {
        public AdsContext()
            : base("name=AdsContext")
        {
        }

        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<DealType> DealTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TopCategory> TopCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisement>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.Price)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Advertisement>()
                .Property(e => e.ImageName)
                .IsUnicode(false);

            modelBuilder.Entity<Advertisement>()
                .HasMany(e => e.Users)
                .WithMany(e => e.FavoriteAdvertisements)
                .Map(m => m.ToTable("Favorites").MapLeftKey("AdId").MapRightKey("UserId"));

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Advertisements)
                .WithMany(e => e.Categories)
                .Map(m => m.ToTable("AdvertisementCategories").MapLeftKey("CategoryId").MapRightKey("AdId"));

            modelBuilder.Entity<Condition>()
                .Property(e => e.ConditionName)
                .IsFixedLength();

            modelBuilder.Entity<DealType>()
                .Property(e => e.DealTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<TopCategory>()
                .Property(e => e.TopCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<TopCategory>()
                .HasMany(e => e.Categories)
                .WithOptional(e => e.TopCategory)
                .HasForeignKey(e => e.ParentCategory);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.DateOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Advertisements)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.webpages_Roles)
                .WithMany(e => e.Users)
                .Map(m => m.ToTable("webpages_UsersInRoles").MapLeftKey("UserId").MapRightKey("RoleId"));
        }
    }
}
