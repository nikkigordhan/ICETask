using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the width");
            string width = Console.ReadLine();
            int iwidth = int.Parse(width);

            Console.WriteLine("Please enter the height");
            string height  = Console.ReadLine();
            int iheight = int.Parse(height);

            double darea = iwidth * iheight;
            Console.WriteLine("The area of the rectangle is: ");
            Console.WriteLine(darea);

           
        }
    }
}
