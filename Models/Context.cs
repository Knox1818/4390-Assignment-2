using Microsoft.EntityFrameworkCore;

namespace _4390_Assignment_2.Models
{
	public class Context : DbContext
	{
		public Context (DbContextOptions<Context> options)
			: base(options)
		{
		}
        public DbSet<Customer> customers {get; set;} = default!;
		public DbSet<Delivery> deliveries {get; set;} = default!;
        public DbSet<Order> orders {get; set;} = default!;
	}
}