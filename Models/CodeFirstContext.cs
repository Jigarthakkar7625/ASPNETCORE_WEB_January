using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE_WEB.Models
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext() 
        {
        }
        public CodeFirstContext(DbContextOptions<CodeFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblRole> TblRoles { get; set; }
    }
}
