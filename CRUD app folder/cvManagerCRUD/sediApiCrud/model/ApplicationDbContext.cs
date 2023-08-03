using Microsoft.EntityFrameworkCore;

namespace sediApiCrud.model
{
    public class ApplicationDbContext : DbContext
    {
        //creting a constructor for the class , base is a way to call the constructor of the DBContext class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        // creating a new property for this class, and the datatype is Dbset...
        // datatype DbSet as a type inside <>, Sedi is the name
        public DbSet<Sede> Sedi { get; set; }

        // create a new property for this class 
       // public DbSet<Macchinario> Macchinari { get; set; }
        // this methods is inside the dbcontext and we use it to create a key for the object Macchinari
      //  protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
          //  // this configuration help us create a primary key for the object Macchinario
            //modelBuilder.Entity<Macchinario>().HasKey(m => m.Seriale);
        //}
    }
}
