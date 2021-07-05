using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaAspNetCore.Models;
using AgendaAspNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgendaAspNetCore.Controllers
{
    [ApiController]
    [Route("enderecos")]
    public class EnderecoController : ControllerBase
    {
        public EnderecoController() { }

        [HttpGet]
        public ActionResult<List<Endereco>> GetAll() => EnderecoService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Endereco> Get(int id)
        {
            var e = EnderecoService.Get(id);

            if (e is null)
            {
                return NotFound();
            }

            return e;
        }

        [HttpPost]
        public IActionResult Create(Endereco e)
        {            
            EnderecoService.Add(e);
            return CreatedAtAction(nameof(Create), new { id = e.Id }, e);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Endereco e)
        {
            var retorno = EnderecoService.Update(id, e);
            
            if (retorno is null)
            {
                return NotFound();
            }
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var retorno = EnderecoService.Delete(id);

            if (retorno is null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
