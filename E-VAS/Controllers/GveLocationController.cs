using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using E_VAS.Context;
using E_VAS.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace E_VAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GveLocationController : Controller
    {
        private DataContext dataContext;
        private PolygonIntersectHelper intersectHelper;
        public GveLocationController(DataContext dataContext, PolygonIntersectHelper intersectHelper)
        {
            this.dataContext = dataContext;
            this.intersectHelper = intersectHelper;
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
            if (model.Gve == null)
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);

            var existingGve = dataContext.GveModel.First(x => x.GveId == model.Gve.GveId);
            model.Gve = existingGve;

            //TODO at this point, calculate the current location of the GVE (L, S or W) and write it on the table
            //For the journal, we can just condense the data and export it.
            var places = dataContext.GvePlaceModel.Include(x => x.Points).ToList();
            List<PointF> polygon = new List<PointF>();
            foreach (var place in places)
            {
                if (place.Points!=null && place.Points.Count() > 0)
                {
                    foreach (var point in place.Points)
                    {
                        polygon.Add(new PointF(point.Latitude, point.Longitude));
                    }
                    if (intersectHelper.IsPointInPolygon(polygon.ToArray(), new PointF(model.Latitude, model.Longitude)))
                    {
                        model.LocationCategory = place.Type;
                    }
                }
            }

            dataContext.GveLocationModel.Add(model);

            try
            {
                dataContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
    }
}