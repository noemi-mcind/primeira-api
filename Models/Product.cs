using System.ComponentModel.DataAnnotations;

namespace primeiraApi.Models
{
    // Criando uma classe chamada Product, para o EFCore representa uma tabela;
	public class Product
    {
        // KEY = CHAVE: POR QUE? 
        // Porque a chave é ÚNICA
        // Id significa Identificador, ou seja, é um IDENTIFICADOR ÚNICO, ex: CPF
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
        
        // criando a propriedade Title, para o EFCore representa uma coluna da tabela Product;
        public string Title { get; set; }

        // MaxLength é um atributo que significa comprimento máximo,
        // Deixamos especificado que o máximo de caracteres que podem ser colocados é de até 60 
        // criando a propriedade Description, para o EFCore represnta uma coluna da tabela Product;
         [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximo 1024 caracteres")]
         public string Description { get; set; }
        
        // Required é um Atributo/Annotation que significa obrigatório
        // Se caso nao for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        // Range de 1 a 5: 1, 2, 3, 4 ou 5 - ou seja digitar 6, está fora da range.
        // Criando a propriedade Price, para o EFCore representa uma coluna da tabela Product;
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Price { get; set; }

        // Required é um Atributo/Annotation que significa obrigatório
        // Se caso nao for preenchido irá dar uma Mensagem de Erro(Este campo é obrigatório);
        // Range de 1 a 5: 1, 2, 3, 4 ou 5 - ou seja digitar 6, está fora  da range.
        // Criando a propriedade CategoryId, para o EFCore representa uma coluna da tabela Product;   
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
        public int CategoryId  { get; set; }

        // Criando a propriedade        
        public Category Category { get; set; }
    }

}

