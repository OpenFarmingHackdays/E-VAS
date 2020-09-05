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
        
        /// <summary>
        /// Adds a new record with the location of the GVE to the database.
        /// This is usally "called" by the GPS Tracker, but can also be called manually
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AddRecord")]
        public HttpResponseMessage AddRecord([FromBody] GveLocationModel model)
        {
            if(model.Gve == null)
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);

            //TODO at this point, calculate the current location of the GVE (L, S or W) and write it on the table
            //For the journal, we can just condense the data and export it.
            dataContext.GveLocationModel.Add(model);

            dataContext.SaveChanges();

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}