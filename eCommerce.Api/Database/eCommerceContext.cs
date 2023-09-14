using Microsoft.EntityFrameworkCore;

namespace eCommerce.Api.Database
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) 
        {
        }
    }
}
