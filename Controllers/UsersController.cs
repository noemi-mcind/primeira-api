using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using primeiraApi.Data;
using primeiraApi.Models;

namespace primeiraApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        // Verbo HTTP ou Método HTTP, são: GET, POST, PUT, DELETE 

        // GET localhost/[api/users]/[specifics/egg]
        // Atributo ou Annotation
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            var users = new List<User>();

            users.Add(
                new User
                {
                    Id = 1,
                    Name = "Gabriel",
                    Age = 24
                });

            // pegando a lista de usuários (que são objetos do C# e convertendo para JSON)
            return users;
            /*
                [
                    {
                        "id":1,
                        "name":"Gabriel",
                        "age":24
                    }
                ]
            */
        }
    }
}
