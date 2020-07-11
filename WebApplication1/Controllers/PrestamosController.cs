using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestamosBlazor.BLL;
using PrestamosBlazor.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {



        //GET: api/<Prestamos>
        [HttpGet]
        public ActionResult<IEnumerable<Prestamos>> Get()
        {
            return PrestamosBLL.Getprestamos();
        }

        // GET api/<Prestamos>/1
        [HttpGet("{id}")]
        public ActionResult<Prestamos> Get(int id)
        {
            return PrestamosBLL.Buscar(id);
        }

        // POST api/<Prestamos>
        [HttpPost]
        public void Post([FromBody] Prestamos prestamos )
        {
            bool paso = PrestamosBLL.Guardar(prestamos);
        }

        // PUT api/<Prestamos>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Prestamos>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return PrestamosBLL.Eliminar(id);
        }
    }
}
