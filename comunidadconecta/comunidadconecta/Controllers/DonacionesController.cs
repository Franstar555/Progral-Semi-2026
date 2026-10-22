using Microsoft.AspNetCore.Mvc;

namespace comunidadconecta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonacionesController : ControllerBase
    {
        // 1. PETICIÓN GET: Obtener todas las donaciones
        [HttpGet]
        public IActionResult GetDonaciones()
        {
            return Ok(new { mensaje = "Aquí se listarán tus donaciones desde la BD" });
        }

        // 2. PETICIÓN POST: Registrar una nueva donación
        [HttpPost]
        public IActionResult PostDonacion([FromBody] DonacionDto nuevaDonacion)
        {
            if (nuevaDonacion == null || string.IsNullOrWhiteSpace(nuevaDonacion.Titulo))
            {
                return BadRequest(new { mensaje = "El título de la donación es obligatorio." });
            }

            return Ok(new { mensaje = "¡Donación registrada con éxito por API RESTful!", titulo = nuevaDonacion.Titulo });
        }
    }

    // Modelo DTO con soporte para valores nulos (quita las advertencias CS8618)
    public class DonacionDto
    {
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public string? Ubicacion { get; set; }
    }
}