﻿using Microsoft.AspNetCore.Mvc;
using Proyecto.Controllers.DTOS;

namespace Proyecto.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class NombreLocalController : ControllerBase
    {
        //  GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   


        [HttpGet(Name = "TraerNombreDelLocal")] // No se reciben parámetros desde la URL. El cuerpo de la petición siempre está vacío.
        public string TraerNombreDelLocal()
        {
            return "Tienda El Pollo";
        }
    }
}
