using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using E_VAS.Context;
using E_VAS.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_VAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GveLocationController : Controller
    {
        private DataContext dataContext;
        public GveLocationController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpPost("AddRecord")]
        public HttpResponseMessage AddRecord([FromBody] GveLocationModel model)
        {
            if(model.Gve == null)
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            dataContext.GveLocationModel.Add(new GveLocationModel()
            {
                Gve = model.Gve,
                Coordinates = model.Coordinates,
                TimeStamp = model.TimeStamp
            });

            dataContext.SaveChanges();

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}