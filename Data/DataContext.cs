using Microsoft.EntityFrameworkCore;
using primeiraApi.Models;

namespace primeiraApi.Data
{
    // Como convertemos um BD em um DataContext?
    // EFCore: pacote; 
    // ORM: Mapeamento ENTRE o Objeto (classes/atributos) E O Relacional (tabeas/colunas)
    // Mapeamento Objeto Relacional
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
            // Instanciar um objeto a partir da classe
            // Instanciar tem que ter a palavra new
            var category = new Category();

            category.SetTitle("Joaninha");

            category.Quantidade = 10;
        }

        // tabela 
        // DbSet -> converte tabela em objetos/classes 
        public DbSet<Product> Products { get; set; }

        // tabela
        // DbSet -> converte tabela em objetos/classes
        public DbSet<Category> Categories { get; set; }
    }
}