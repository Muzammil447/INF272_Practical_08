using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Practical_08.Models
{
    public class Rectangle:Polygon
    {
        //member specific to rectangle
        public int Breadth { get; set; }

        //constructor
        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
            Sides = 4;
        }

        public Rectangle()
        {

        }

        //class method to calculate area
        public override string getSVG()
        {

            return $"<rect " +
                $"x=\"{XCoordinate}\" " +
                $"y=\"{YCoordinate}\" " +
                $"width=\"{Length}\" " +
                $"height=\"{Breadth}\" " +
                $"fill=\"{FillColour}\" " +
                $"stroke=\"{StrokeColour}\" " +
                $"stroke-width=\"{StrokeWidth}\" />";
        }
        public override double getArea()
        {
            return Length * Breadth;
        }
    }
}