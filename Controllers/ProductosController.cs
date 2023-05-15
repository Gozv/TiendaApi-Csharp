using Microsoft.AspNetCore.Mvc;
using Tienda_Api.Datos;
using Tienda_Api.Modelo;

namespace Tienda_Api.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController
    {
        [HttpGet]
        public async Task <ActionResult<List<Mproductos>>> Get()
        {
            var funcion = new Dproductos();
            var lista = await funcion.Mostrarproductos();
            return lista;
        }
    } 
}
