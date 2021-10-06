using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samveg_Vyas_8737672
{
    class Program
    {
        static void Main(string[] args)
        {
            string len, wid;
            int length, width;

            Rectangle rectangle = new Rectangle();

            Console.Write("Length: ");
            len = Console.ReadLine();
            Console.Write("Width: ");
            wid = Console.ReadLine();

            if (int.TryParse(len, out length) && int.TryParse(wid, out width))
            {
                rectangle.SetLength(length);
                rectangle.SetWidth(width);

                Console.WriteLine("Perimeter of rectangle is: {0}", rectangle.GetPerimeter());
                Console.WriteLine("Area of rectangle is: {0}", rectangle.GetArea());
            }
            else
            {
                Console.WriteLine("Incorrect input \n");
                Console.WriteLine("Default Perimeter of rectangle is: {0}", rectangle.GetPerimeter());
                Console.WriteLine("Default Area of rectangle is: {0}", rectangle.GetArea());
            }
            
            Console.ReadLine();
        }
    }
}
