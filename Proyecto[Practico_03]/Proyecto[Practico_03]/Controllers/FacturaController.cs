using Microsoft.AspNetCore.Mvc;
using Proyecto_Practico_03_.App;
using Proyecto_Practico_03_.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proyecto_Practico_03_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly Aplicacion app;
        public FacturaController()
        {
            app = new Aplicacion();
        }

        // GET: api/<FacturaController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(app.GetAllFactura());
            }
            catch (Exception)
            {
                return StatusCode(500,"Error Interno");
            }
        }

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if(id <= 0){ return BadRequest("Id no valido"); }
            try
            {
                var value = app.GetByIdFactura(id);
                if (value == null) { return NotFound("No se encontró la factura"); }
                return Ok(value);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno");
            }
        }

        // POST api/<FacturaController>
        [HttpPost]
        public IActionResult Post([FromBody] FacturaDTO value)
        {
            if (!value.Validar())
            {
                return BadRequest("Factura no valida, chequee los datos");
            }
            try
            {
                if (app.SaveFactura(value))
                {
                    return Ok("Factura guardada con exito");
                }
                else
                {
                    return StatusCode(500, "Error al insertar en la base de datos");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error Interno: {ex}");
            }
        }

        // PUT api/<FacturaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FacturaDTO value)
        {
            if(id <= 0 || app.GetByIdFactura(id) == null || !value.Validar())
            { return BadRequest("Id no valido, la factura no se encontró, chequee los datos"); }
            try
            {
                if(!app.UpdateFactura(id, value))
                {
                    return StatusCode(500,"Error al actualizar la factura");
                }
                 return Ok("Factura actualizada con exito");
            }
            catch (Exception)
            {
                return StatusCode(500, "Error Interno");
            }
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0 || app.GetByIdFactura(id) == null) 
            { return BadRequest("Id no valido, la factura no se encontró"); }
            try
            {
                if (!app.DeleteFactura(id))
                {
                    return StatusCode(500, "Error al borrar la factura");
                }
                return Ok("Factura borrada con exito");
            }
            catch (Exception)
            {
                return StatusCode(500,"Error Interno");
            }
        }
    }
}
