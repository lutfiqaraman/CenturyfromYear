using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturyfromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int YearofNow = DateTime.Now.Year;
            int Century = YearofNow / 100;
            int YearsAfterCentury = YearofNow % 100;

            if (YearsAfterCentury > 0)
                Century += 1;

            Console.WriteLine("Year: {0}", YearofNow);
            Console.WriteLine("Century: {0}", Century);
            Console.ReadKey();
        }
    }
}
