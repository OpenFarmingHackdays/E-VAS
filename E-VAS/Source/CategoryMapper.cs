using E_VAS.Data.Models;
using System;
using System.Globalization;

namespace E_VAS.Source
{
    public class CategoryMapper
    {
        public string GetCategory(TvdModel tvd)
        {
            var alter = Convert.ToInt32(tvd.Alter);
            if (tvd.Geschlecht.Equals("Männlich", StringComparison.InvariantCultureIgnoreCase))
            {
                if (alter > 730)
                    return "A6";
                if (alter > 365 && alter < 730)
                    return "A7";
                if (alter > 120 && alter < 365)
                    return "A8";
                if (alter < 120)
                    return "A9";
            }
            else
            {
                if (!string.IsNullOrEmpty(tvd.Erstkalbung))
                {
                    var dt = DateTime.ParseExact(tvd.Erstkalbung, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    var diff = DateTime.Now - dt;
                    var ageAtFirstKalb = alter - diff.TotalDays;
                    if (ageAtFirstKalb > 365)
                        return "A3";

                    //Had child thus produces milk.
                    return "A1";
                }

                if (alter > 120 && alter < 365)
                    return "A4";
                if (alter < 120)
                    return "A5";

                //basically everything else.
                return "A2";
            }

            return "A1";
        }
    }
}