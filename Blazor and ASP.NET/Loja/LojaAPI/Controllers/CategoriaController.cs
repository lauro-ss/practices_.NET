using Core;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoria _categoriaService;
        public CategoriaController(ICategoria categoriaService)
        {
            _categoriaService = categoriaService;
        }

        // GET: api/<CategoriaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> Get()
        {
            return Ok(await _categoriaService.GetAll());
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            return Ok(await _categoriaService.Get(id));
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public async Task<ActionResult<Categoria>> Post([FromBody] Categoria categoria)
        {
            return Ok(await _categoriaService.Create(categoria));
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Categoria>> Put(int id, [FromBody] Categoria categoria)
        {
            return Ok(await _categoriaService.Edit(categoria, id));
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return Ok(await _categoriaService.Delete(id));
        }
    }
}
