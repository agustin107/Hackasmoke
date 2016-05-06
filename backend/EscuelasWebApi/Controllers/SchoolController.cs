using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using EscuelasWebApi.Models;

namespace EscuelasWebApi.Controllers
{
   
    [RoutePrefix("School")]
    public class SchoolController: ApiController
    {

       


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetSchoolsLocation")]
        [System.Web.Http.ActionName("GetSchoolsLocation")]
        public async Task<IHttpActionResult> GetSchoolsLocation()
        {
            var model = new EscuelasEntities2();
            var escuelas = model.Establecimientos.Take(10).ToList();

            return Ok(escuelas);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetSchoolsPoints")]
        [System.Web.Http.ActionName("GetSchoolsPoints")]
        public async Task<IHttpActionResult> GetSchoolsPoints()
        {
            var model = new EscuelasEntities2();
            var escuelas = model.Puntajes.OrderBy(x=> x.points).Take(10).ToList();

            return Ok(escuelas);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetSchoolPoints")]
        [System.Web.Http.ActionName("GetSchoolPoints")]
        public async Task<IHttpActionResult> GetSchoolPoints(string schoolId)
        {
            var model = new EscuelasEntities2();
            var escuelas = model.Puntajes.FirstOrDefault(x => x.cue == schoolId);

            return Ok(escuelas);
        }
    }
}
