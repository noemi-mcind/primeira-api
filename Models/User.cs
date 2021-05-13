using System.ComponentModel.DataAnnotations;

namespace primeiraApi.Models
{
    // Criando uma classe chamada User, para o EFCore representa uma tabela;
    public class User
    {
        // criando a propriedade Id, para  o EFCore representa uma coluna da tabela User;
        // e colocando o Atributo/Annotation [Key],;
        // pois para o EFCORE ela representa uma chave, ela é única;
        [Key]
        public int Id { get; set; }

        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 60,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 3 e 60 caracteres).
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 3,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 3 e 60 caracteres).
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        
        // criando a propriedade Name, para o EFCore representa uma coluna da tabela User;
        public string Name { get; set; }

        // Required é um atributo que significa obrigatório
        // Se caso não for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        [Required(ErrorMessage = "Este campo é obrigatório")]

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 60,
        // Caso ao contrário será exibida a Mesagem de Erro (Este campo deve conter entre 3 e 60 caracteres).
        [MaxLength(2, ErrorMessage = "Este campo deve conter entre 1 e 2 caracteres")]

        // MinLength é um atributo que significa comprimento mínimo,
        // Deixamos especificado que o mínimo de caracteres que podem ser inseridos é a partir de 3,
        // Caso ao contrário será exibida a Mensagem de Erro (Este campo deve conter entre 3 e 60 caracteres).
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 2 caracteres")]

        // criando a propriedade Age, para o EFCore representa uma coluna da tabela User; 
        public int Age { get; set; }
    }

}

