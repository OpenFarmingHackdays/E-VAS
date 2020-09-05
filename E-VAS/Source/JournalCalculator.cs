using E_VAS.Context;
using E_VAS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_VAS.Source
{
    public class JournalCalculator
    {
        public List<DayModel> CalculateDays(DataContext context)
        {
            List<DayModel> result = new List<DayModel>();
            //1. Get all distinct gve categories
            //2. 
            var categories = context.GveLocationModel.GroupBy(x => new { x.Gve.CategoryId, x.TimeStamp });
            foreach (var item in categories.ToList())
            {
                result.Add(new DayModel()
                {
                    Day = item.Key.TimeStamp.Day,
                    Month = item.Key.TimeStamp.Month,
                    GveCategory = item.ToList().FirstOrDefault().Gve.CategoryId,
                    LocationCategory = item.ToList().FirstOrDefault().LocationCategory
                });
            }
            return result;
        }
    }
}
