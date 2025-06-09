using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Practical_08.Models
{
    public class Square:Polygon
    {
        //constructor 
        public Square()
        {

        }
        public Square(int length)
        {
            Sides = 4;
            Length = length;
        }

        //class method to calculate area
        public override string getSVG()
        {

            return $"<rect x=\"{XCoordinate}\" " +
                   $"y=\"{YCoordinate}\" " +
                   $"width=\"{Length}\" " +
                   $"height=\"{Length}\" " +
                   $"fill=\"{FillColour}\" " +
                   $"stroke=\"{StrokeColour}\" " +
                   $"stroke-width=\"{StrokeWidth}\" />";

        }

        public override double getArea()
        {
            return Length * Length;
        }
    }
}