using livrariaAPIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class livrariaController : ControllerBase
    {
        // Variável que vai armazenar no banco
        private readonly ToDoContext _context;

        // Construtor da controller
        public livrariaController(ToDoContext context)
        {
            _context = context;

            
        }

        // Retorna lista completa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            _context.TodoProducts.Add(new Produto { ID = "1", Nome = "Book1", Preco = 24.0, Quant = 1, Categoria = "Acao", Img = "img1" });
            _context.TodoProducts.Add(new Produto { ID = "2", Nome = "Book2", Preco = 30.0, Quant = 3, Categoria = "Acao", Img = "img2" });
            _context.TodoProducts.Add(new Produto { ID = "3", Nome = "Book3", Preco = 4.0, Quant = 10, Categoria = "Acao", Img = "img3" });
            _context.TodoProducts.Add(new Produto { ID = "4", Nome = "Book4", Preco = 94.0, Quant = 5, Categoria = "Acao", Img = "img4" });
            _context.TodoProducts.Add(new Produto { ID = "5", Nome = "Book5", Preco = 120.0, Quant = 2, Categoria = "Acao", Img = "img5" });


            _context.SaveChanges();

            return await _context.TodoProducts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetItem(int id)
        {
            var item = await _context.TodoProducts.FindAsync(id.ToString());

            if(item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto( Produto produto)
        {
            _context.TodoProducts.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProdutos), new { id = produto.ID }, produto);
        }

    }
}
