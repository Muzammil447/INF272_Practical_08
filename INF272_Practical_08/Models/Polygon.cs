using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INF272_Practical_08.Models
{
    public abstract class Polygon
    {
        private int _sides;
        public int Sides
        {
            get { return _sides; }
            set { _sides = value; }
        }
        public string Description { get; set; }
        public string FillColour { get; set; }

        public string StrokeColour { get; set; }

        public int StrokeWidth { get; set; }
        
        public int XCoordinate { get; set; } = 0;
        public int YCoordinate { get; set; } = 0;
        public int Length { get; set; }
        public string getSides()
        {
            return "#Sides is " + Sides;
        }

        public abstract string getSVG();
        public abstract double getArea();
    }
}