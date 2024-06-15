using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    //Hereda de la clase DbContext, la cual se importa desde EntityFrameworkCore
    public class AppDbContext : DbContext
    {
        //Contructor y le pasamos la misma configuracion inicial del padre 
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        //Creamos una tabla
        public DbSet<Person> Persons { get; set; }
    }
}
