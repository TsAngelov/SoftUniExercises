using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier;

public class DateModifier
{
    private string firstDate;
    private string lastDate;

    public DateModifier(string firstDate, string lastDate)
    {
        this.firstDate = firstDate;
        this.lastDate = lastDate;
    }

    public int CalculateTime()
    {
        TimeSpan time = DateTime.Parse(firstDate).Subtract(DateTime.Parse(lastDate));
        int days = Math.Abs(time.Days);
        return days;
    }
}
