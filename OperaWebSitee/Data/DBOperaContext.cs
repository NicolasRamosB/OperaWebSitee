using Microsoft.EntityFrameworkCore;
using OperaWebSite.Models;

namespace OperaWebSitee.Data
{
    public class DBOperaContext : DbContext
    {
        public DBOperaContext(DbContextOptions<DBOperaContext> options) : base(options) { }


        public DbSet<Opera> Operas { get; set; }
    }
}
