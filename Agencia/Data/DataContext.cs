using Agencia.Model;
using Microsoft.EntityFrameworkCore;


namespace Agencia.Data
{

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public DbSet<Destino> Destinos { get; set; }

    
   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Destino>().HasData(
        new Destino
        {
            DestinoId = 1,
            Nome = "Rio de Janeiro",
            Descricao = "Cidade maravilhosa com praias incríveis",
            DestinoURL = "https://images.pexels.com/photos/2868240/pexels-photo-2868240.jpeg",
            Preco = 1500.00M
        },
        new Destino
        {
            DestinoId = 2,
            Nome = "São Paulo",
            Descricao = "Maior cidade do Brasil, centro financeiro",
            DestinoURL = "https://images.pexels.com/photos/2065850/pexels-photo-2065850.jpeg",
            Preco = 1200.00M
        },
        new Destino
        {
            DestinoId = 3,
            Nome = "Minas Gerais",
            Descricao = "Estado com rica história e belas paisagens",
            DestinoURL = "https://destinosnotaveis.com.br/wp-content/uploads/2023/05/Mariana-MG.jpg",
            Preco = 1000.00M
        }
    );

}


}



}