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
            try
            {
                return Ok(await _categoriaService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> Get(int id)
        {
            try
            {
                return Ok(await _categoriaService.Get(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // POST api/<CategoriaController>
        [HttpPost]
        public async Task<ActionResult<Categoria>> Post([FromBody] Categoria categoria)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Ausência de informações para categoria");
                }
                return Ok(await _categoriaService.Create(categoria));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Categoria>> Put(int id, [FromBody] Categoria categoria)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Ausência de informações para categoria");
                }
                return Ok(await _categoriaService.Edit(categoria, id));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                return Ok(await _categoriaService.Delete(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }
    }
}
