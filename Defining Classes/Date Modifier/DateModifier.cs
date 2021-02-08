using System;
using System.Collections.Generic;
using System.Globalization;

namespace Date_Modifier
{
    class DateModifier
    {
        public double GetTheDiference(string date1,string date2)
        {
            //DateTime date1 = Convert.ToDateTime(firstDate);
            //DateTime date2 = Convert.ToDateTime(secondDate);
            var firstDate = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);

            var secondDate = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (firstDate>secondDate)
            {
                return GetTheDiference(date1, date2);
            }

            return (secondDate- firstDate).Days;
        }
    }
}
