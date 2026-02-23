using System;
using System.Collections.Generic;
using System.Text;

namespace EX_C__46_60
{
    internal class ex59
    {
        public static void EX59()
        {
            DateTime hoje = DateTime.Now;
            
            if (hoje.DayOfWeek == DayOfWeek.Sunday || hoje.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Hoje é Final de Semana");
            }
            else
            {
                Console.WriteLine("Hoje é Meio de Semana");
            }
        }
    }
}
