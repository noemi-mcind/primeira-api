using System.ComponentModel.DataAnnotations;

namespace primeiraApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }

}

