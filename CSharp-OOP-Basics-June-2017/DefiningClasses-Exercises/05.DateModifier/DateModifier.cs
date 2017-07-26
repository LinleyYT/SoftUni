using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DateModifier
{
    public string DateOne { get; set; }
    public string DateTwo { get; set; }

    public int DateDifference(string dateOne, string dateTwo)
    {
        var parsedDateOne = DateTime.ParseExact(dateOne, "yyyy MM dd",
            System.Globalization.CultureInfo.InvariantCulture);
        var parsedDateTwo = DateTime.ParseExact(dateTwo, "yyyy MM dd",
            System.Globalization.CultureInfo.InvariantCulture);

        var difference = Math.Abs((parsedDateOne - parsedDateTwo).Days);
        return difference;
    }
}

