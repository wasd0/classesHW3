using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classesHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            double daysPerWeek = 7;
            Console.WriteLine($"Количество дней в неделе: {daysPerWeek}");
            double weeksPerYear = 52.1429;
            Console.WriteLine($"Количество недель в году: {weeksPerYear}");
            double daysPerYear = daysPerWeek * weeksPerYear;
            int now = Convert.ToInt32(daysPerYear);
            Console.WriteLine($"Количество дней в году: {now}");
            DateTime thisDay = DateTime.Today;
            Console.WriteLine("Сегодня: " + thisDay.ToString("D"));
            Console.ReadKey();
        }
    }
}
