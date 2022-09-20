using Microsoft.EntityFrameworkCore;

using VotacionesEstudiantiles.App.Dominio;

namespace VotacionesEstudiantiles.App.Persistencia
{
    public class AppContext : DbContext{

        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VotacionesEstudiantiles");
            }
        }
    }
}