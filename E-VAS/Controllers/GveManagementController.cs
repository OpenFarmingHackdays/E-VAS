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
    public class GveManagementController : Controller
    {
        private DataContext dataContext;
        public GveManagementController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpPost("AddNewGve")]
        public HttpResponseMessage AddNewGve([FromBody] GveModel model)
        {
            if (model.GveId == null)
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            dataContext.GveModel.Add(model);

            dataContext.SaveChanges();

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        [HttpPost("ImportFromTvd")]
        public HttpResponseMessage ImportFromTvd([FromBody] GveModel model)
        {
            if (model.GveId == null)
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            dataContext.GveModel.Add(model);

            dataContext.SaveChanges();

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}