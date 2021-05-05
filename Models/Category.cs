using System.ComponentModel.DataAnnotations;
namespace primeiraApi.Models
{
    // criando a classe Category, para o EFCore representa uma Tabela
    public class Category
    {
        // Métodos têm parênteses
        // ex: [public/private] [tipo de retorno] NomeDoMetodo([tipo e nome do parâmetro])
        // ex: public string ObterValorTotal() { ... }
        // ex: public void DefinirValorTotal(double valorTotal) { ... }

        // Propriedades e atributos têm public/private e tipo (int, string, double...), ex:
        // public int Id {get; set;}
        // private string Nome;

        // colocando o Atributo/Annotation [Key] na propriedade Id, 
        // pois para o EFCORE ela representa uma chave, ela é única;
        [Key]

        // criando a propriedade Id, para o EFCORE representa a coluna de identificador único da tabela Category;
        public int Id { get; set; }

        // criando a string privada 
        private string title;

        // criando um método chamado GetTitle(), cujo tipo de retorno do método é string 
        public string GetTitle()
        {
            return title;
        }

        // criando um método chamado SetTitle(), que recebe um parâmetro do tipo string chamado value
        // e que não retorna nada (ou seja, o tipo de retorno é void)
        public void SetTitle(string value)
        {
            title = value;
        }
        
        public int Quantidade { get; set; }

    
    } 

    
}