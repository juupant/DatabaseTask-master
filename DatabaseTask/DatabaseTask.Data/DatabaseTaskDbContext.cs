using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Student> Student { get; set; }

        public DbSet<Class> Class { get; set; }

        public DbSet<School> School { get; set; }

        public DbSet<Group_Supervisor> Groups { get; set; }

        public DbSet<Coupons> Coupons { get; set; }

        DbSet<Kitchen> Kitchen { get; set; }


    }
}
