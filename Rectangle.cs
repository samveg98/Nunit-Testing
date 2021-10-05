using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samveg_Vyas_8737672
{
    public class Rectangle
    {
        private int length;
        private int width;

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public int GetLength()
        {
            return Length;
        }
        public int SetLength(int length)
        {
            Length = length;
            return Length;
        }
        public int GetWidth()
        {
            return Width;
        }
        public int SetWidth(int width)
        {
            Width = width;
            return Width;
        }


        public int GetPerimeter()
        {
            return (2*(Length+Width));
        }
        public int GetArea()
        {
            return Length * Width;
        }

        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

    }
}
