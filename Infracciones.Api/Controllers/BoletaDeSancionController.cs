using Infracciones.BusinessLayer;
using Infracciones.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Infracciones.Api.Controllers
{
    public class BoletaDeSancionController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(BoletaDeSancion item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    item.Id = BoletaDeSancionBl.Add(item);
                    return Created("", new { Id = item.Id });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }
    }
}
