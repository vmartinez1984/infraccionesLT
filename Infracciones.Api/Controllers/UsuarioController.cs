using Infracciones.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Infracciones.Api.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                Usuario item;

                item = null;

                return Ok(item);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }
    }
}
