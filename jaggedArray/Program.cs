using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    using System;

    class Program
    {
        static void Main()
        {

            int[][] calendar = new int[5][];


            int day = 1;
            for (int i = 0; i < calendar.Length; i++)
            {

                if (day + 6 > 31)
                {
                    calendar[i] = new int[31 - day + 1];
                }
                else
                {
                    calendar[i] = new int[7];
                }

                for (int j = 0; j < calendar[i].Length; j++)
                {
                    calendar[i][j] = day;
                    day++;
                }
            }


            Console.WriteLine("Jagged Array Calendar:");
            for (int i = 0; i < calendar.Length; i++)
            {
                foreach (var d in calendar[i])
                {
                    Console.Write(d.ToString("D2") + " ");
                }
                Console.WriteLine();
            }
        }
    }

}