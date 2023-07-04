using Microsoft.AspNetCore.Mvc;
using Proyecto.Controllers.DTOS;

namespace Proyecto.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LoginController : ControllerBase
    {
        //  GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   


        [HttpGet(Name = "InicioDeSesion")] // Se reciben los parámetros nombreUsuario y contraseña desde la URL. El cuerpo de la petición siempre está vacío.
        public Usuario InicioDeSesion(string nombreUsuario, string contraseña)
        {
            return UsuarioHandler.InicioDeSesion(nombreUsuario, contraseña);
        }
    }
}
