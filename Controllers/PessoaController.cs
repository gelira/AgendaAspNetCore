using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaAspNetCore.Dto;
using AgendaAspNetCore.Models;
using AgendaAspNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgendaAspNetCore.Controllers
{
    [ApiController]
    [Route("pessoas")]
    public class PessoaController : ControllerBase
    {
        public PessoaController() { }

        [HttpGet]
        public ActionResult<List<Pessoa>> GetAll() => PessoaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pessoa> Get(int id)
        {
            var p = PessoaService.Get(id);

            if (p is null)
            {
                return NotFound();
            }

            return p;
        }

        [HttpPost]
        public IActionResult Create(CreatePessoa cp)
        {            
            var p = PessoaService.Add(cp);
            return CreatedAtAction(nameof(Create), new { id = p.Id }, p);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdatePessoa up)
        {
            var retorno = PessoaService.Update(id, up);
            
            if (retorno is null)
            {
                return NotFound();
            }
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var retorno = PessoaService.Delete(id);

            if (retorno is null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
