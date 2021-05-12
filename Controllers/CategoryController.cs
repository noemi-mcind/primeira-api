using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using primeiraApi.Data;
using primeiraApi.Models;

namespace primeiraApi.Controllers
{
    [ApiController]
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {
        // Verbo HTTP ou Método HTTP, são: GET, POST, PUT, DELETE 
        // Atributo ou Annotation
       [HttpPost]
        [Route("criar-varios")]
        public ActionResult<List<Category>> CriarVarios([FromServices] DataContext context)
        {
            // instanciando um objeto a partir da classe Category,
            // para o EFCore representa as linhas das colunas da tabela Category.
            var categories = new Category();

            categories.Id = 1;
            categories.SetTitle("");
            categories.Quantidade = 1;

            categories.Id = 2;
            categories.Quantidade = 2;

            categories.Id = 3;
            categories.Quantidade = 3;
            
            categories.Id = 4;
            categories.Quantidade = 4;

            context.SaveChanges();

             return Ok(new { });
        }
                    
        // Atributo ou Annotation
        [HttpGet]
        // Atributo ou Annotation
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
        {
            var categories = await context.Categories.ToListAsync();
            return categories;
        }
        
        // Atributo ou Annotation
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post(
            [FromServices] DataContext context,
            [FromBody] Category model)
        {    
            if (ModelState.IsValid)
            {
                
                context.Categories.Add(model);

                // passando as alterações feitas no contexto, ou seja, objetos novos adicionados
                // para o banco de dados, ou seja, vai ser refletido no banco de dados o que foi feito no contexto.
                await context.SaveChangesAsync();
                return model;
            }
            else 
            {
                return BadRequest(ModelState);
            }
            
            /*
            {
                "id": 1,
                "empresa": "VultComestics"
                "funcionarios": [
                    "noemi",
                    "gabriel"
                ]
            }

            [
                {
                    "nome": "Ponei",
                    "idade": 24
                }
            ]*/
        }
    }
}