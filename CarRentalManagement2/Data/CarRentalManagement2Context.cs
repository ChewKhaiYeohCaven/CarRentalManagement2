using CarRentalManagement2.Configurations.Entities;
using CarRentalManagement2.Data;
using CarRentalManagement2.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement2.Data
{
	public class CarRentalManagement2Context : IdentityDbContext<CarRentalManagement2User>
	{
		public CarRentalManagement2Context(DbContextOptions<CarRentalManagement2Context> options)
			: base(options)
		{
		}

		public DbSet<Make> Make { get; set; } = default!;
		public DbSet<Model> Model { get; set; } = default!;
		public DbSet<Colour> Colour { get; set; } = default!;
		public DbSet<Vehicle> Vehicle { get; set; } = default!;
		public DbSet<Booking> Booking { get; set; } = default!;
		public DbSet<Customer> Customer { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new ColourSeed());
			builder.ApplyConfiguration(new MakeSeed());
			builder.ApplyConfiguration(new ModelSeed());
		}
	}
}
