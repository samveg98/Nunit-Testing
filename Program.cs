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

            Console.WriteLine("Default Perimeter of rectangle is: {0}", rectangle.GetPerimeter());
            Console.WriteLine("Default Area of rectangle is: {0}", rectangle.GetArea());

            Console.WriteLine("Length: ");
            len = Console.ReadLine();
            Console.WriteLine("Width: ");
            wid = Console.ReadLine();

            length = int.Parse(len);
            width = int.Parse(wid);

            rectangle.SetLength(length);
            rectangle.SetWidth(width);
          

            Console.WriteLine("Perimeter of rectangle is: {0}",rectangle.GetPerimeter());
            Console.WriteLine("Area of rectangle is: {0}", rectangle.GetArea());

            Console.ReadLine();
        }
    }
}
