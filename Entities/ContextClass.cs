using Core;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ContextClass:DbContext
    {
      public ContextClass(DbContextOptions<ContextClass> opt) : base(opt) { }
       protected override void OnModelCreating(ModelBuilder mb)
        {
            foreach(var reltionship in mb.Model.GetEntityTypes().SelectMany(p=>p.GetForeignKeys()))
            {
                reltionship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            mb.Entity<Admin>().HasData(
                new Admin() { AdminId = 1, FirstName = "Priyanka", LastName = "Chaure", Address = "Pune", EmailId = "priya@gmail.com", MobileNo = "9876543210", Password = "1234" }
                );
            //mb.Entity<Store>().HasData(
            //   new Store() { StoreId = 1, StoreName="PetStore",FirstName = "Sweety", LastName = "Chaure", Address = "Pune", EmailId = "Sweety@gmail.com", MobileNo = "9876544444", IsActive=true, CityId=2, Password = "1111" }
            //   );
        }
        public DbSet<Admin> Admins {  get; set; } 
        public DbSet<Cart> Carts { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DispatchAgency> DispatchAgencies { get; set; }
        public DbSet<DispatchOrder> DispatchOrders { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDet> OrderDets {  get; set; }
        public DbSet<OrderTax> OrderTaxes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetFamily> PetsFamily { get; set; }
        public DbSet<PetFood> PetFoods { get; set; }
        public DbSet<PetPhotos> PetsPhotos { get; set; }   
        public DbSet<PetProduct> PetsProducts { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<Solution> Solutions { get; set; }  
        public DbSet<State> States { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<StoreReview> StoreReviews { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
