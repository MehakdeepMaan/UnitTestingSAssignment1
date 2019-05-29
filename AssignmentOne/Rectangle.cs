using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
  public class Rectangle
    {   
        // declare the two private variable length and width with properties
        private int length;
        private int width;

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        // rectangle constuctor with two integer parameters
        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;

        }
        // default constructor of class rectangle
        public Rectangle()
        {
        }

        //1   Using Getlength method for getting the length of rectangle
        public double GetLength()
        {
            return Length;
        }
        //2 using Setlength method for setting the length of rectangle
        public void SetLength(int length)
        {
            this.Length = length;
           
        }
        //3 using Getwidth method for getting the width of ractangle
        public double GetWidth()
        {
            return Width;

        }
        //4  using Setwidth method for setting the width of rectangle
        public void  SetWidth(int width)
        {
            this.Width = width;
           // return this.width;
        }
        //5 using Getperimeter method for calculating the perimeter of rectangle
        public double GetPerimeter()
        {
            return ((Width * 2) + (Length * 2));
        }
        //6 using Getarea method for calculating the area of rectangle by multiply length with width
        public double GetArea()
        {
            return (Length * Width);
        }

      
    }
    
}
