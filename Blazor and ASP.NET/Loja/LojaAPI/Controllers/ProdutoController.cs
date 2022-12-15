using Core;
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
        // GET: api/<ProdutoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            return Ok(await _produtoService.GetAll());
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            return Ok(await _produtoService.Get(id));
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public async Task<ActionResult<Produto>> Post([FromBody] Produto produto)
        {
            return Ok(await _produtoService.Create(produto));
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Produto>> Put(int id, [FromBody] Produto produto)
        {
            return Ok(await _produtoService.Edit(produto, id));
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return Ok(await _produtoService.Delete(id));
        }
    }
}
