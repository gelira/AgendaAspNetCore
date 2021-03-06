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
    [Route("telefones")]
    public class TelefoneController : ControllerBase
    {
        public TelefoneController() { }

        [HttpGet]
        public ActionResult<List<Telefone>> GetAll() => TelefoneService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Telefone> Get(int id)
        {
            var t = TelefoneService.Get(id);

            if (t is null)
            {
                return NotFound();
            }

            return t;
        }

        [HttpPost]
        public IActionResult Create(CreateTelefone ct)
        {            
            var t = TelefoneService.Add(ct);
            return CreatedAtAction(nameof(Create), new { id = t.Id }, t);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateTelefone ut)
        {
            var retorno = TelefoneService.Update(id, ut);
            
            if (retorno is null)
            {
                return NotFound();
            }
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var retorno = TelefoneService.Delete(id);

            if (retorno is null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
