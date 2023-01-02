using Core;
using Core.DTOs;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProduto _produtoService;
        public ProdutoController(IProduto produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("GetDTO")]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> GetDTO()
        {
            try
            {
                return Ok(await _produtoService.GetAllDTO());
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // GET: api/<ProdutoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            try
            {
                return Ok(await _produtoService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            try
            {
                return Ok(await _produtoService.Get(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // POST api/<ProdutoController>
        [HttpPost]
        public async Task<ActionResult<Produto>> Post([FromBody] Produto produto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Ausência de informações para produto");
                }
                return Ok(await _produtoService.Create(produto));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Produto>> Put(int id, [FromBody] Produto produto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Ausência de informações para produto");
                }
                return Ok(await _produtoService.Edit(produto, id));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                return Ok(await _produtoService.Delete(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Erro interno: {e.Message}");
            }

        }
    }
}
