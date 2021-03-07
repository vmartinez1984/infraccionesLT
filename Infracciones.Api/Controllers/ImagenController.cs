using Infracciones.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Infracciones.Api.Controllers
{
    public class ImagenController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(Imagen item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    return Created("", new { Id = item.Id });
                }
            }
            catch (Exception ex)
            {

               return InternalServerError(ex);
            }
        }
    }
}
