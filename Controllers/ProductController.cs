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
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {

        [HttpPost]
        [Route("criar-varios")]
        public ActionResult<List<Product>> CriarVarios([FromServices] DataContext context)
        {
            // criar 3 produtos e adcionar no BD.
            var product1 = new Product();

            // instanciando
            product1.Id = 1;
            product1.Title = "Maçã";
            product1.Price = 1.20m;

            var product2 = new Product();

            product2.Id = 2;
            product2.Title = "Pera";
            product2.Price = 3.50m;

            var product3 = new Product();
            
            product3.Id = 3;
            product3.Title = "Uva";
            product3.Price = 2.25m;
            
            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);

            context.SaveChanges();
            
            return Ok(new { });
        }

        // Atributo ou Annotation
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext context)
        {
            var product = await context.Products.Include(x => x.Category).ToListAsync();
            return product;
        }

        // atributo ou annotation
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Product>> GetById([FromServices] DataContext context, int id)
        {
            var product = await context.Products.Include(x => x.Category)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }

        // atributo ou annotation
        [HttpGet]
        [Route("categories/{Id:int}")]
        public async Task<ActionResult<List<Product>>> GetByCategory([FromServices] DataContext context, int id)
        {
            var products = await context.Products
            .Include(x => x.Category)
            .AsNoTracking()
            .Where(x => x.CategoryId == id)
            .ToListAsync();
            return products;
        }

        // atributo ou annotations
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> Post([FromServices] DataContext context, [FromBody] Product model)
        {

            // instanciando um objeto do tipo Product, ou seja, a partir da classe Product; 
            var produtoAdicionadoManualmente = new Product();

            // definindo um valor 9 para a propriedade Id
            produtoAdicionadoManualmente.Id = 9;

            // definindo o valor "Produto manual" pra a propriedade Description
            // só consigo fazer isso pois a propriedade Description é public
            // se fosse private eu não poderia acessá-la daqui.
            produtoAdicionadoManualmente.Description = "Produto manual";

            // adicionando  o produto manual no Dbset Products, que está dentro do contexto
            context.Products.Add(produtoAdicionadoManualmente);

            if (ModelState.IsValid)
            {
                context.Products.Add(model);

                // aqui sim, eu passo as alterações feitas no contexto, ou seja, objetos novos adicionados
                // para o banco de dados, ou seja, aqui é refletido no banco de dados o que foi feito no contexto.
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
    }
}
