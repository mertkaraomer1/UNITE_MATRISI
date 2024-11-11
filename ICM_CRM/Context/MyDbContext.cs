using ICM_CRM.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM_CRM.Context
{
    public class MyDbContext:DbContext
    {

        public DbSet<ÜNİTE_MATRİSİ> ÜNİTE_MATRİSİ { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Burada veritabanı bağlantı bilgilerini tanımlayın.
            // Örnek olarak SQL Server kullanalım:
            string connectionString = "Data Source=SRVMIKRO;Initial Catalog=ICM_CRM;Integrated Security=True;Connect Timeout=10;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ÜNİTE_MATRİSİ>().ToTable("ÜNİTE_MATRİSİ").HasKey(x => x.M_ID);


        }
    }
}
