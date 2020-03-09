using System;

namespace Mitsubishi_Electric___Software_Developer_Candidate_exercise
{
    class Ellipse : Widgets
    {
        public Ellipse()
        {
            this._name = "Ellipse";
        }

        public int Vertical_Diameter
        {
            get;
            set;
        }

        public int Horizontal_Diameter
        {
            get;
            set;
        }

        override public string Draw()
        {
            return Name + ", Render Size = " + Size + ", Horizontal Diameter = " + Horizontal_Diameter + 
                ", Vertical Diameter = " + Vertical_Diameter + ", X Coordinate = " + X_Coordinate + 
                ", Y Coordinate = " + Y_Coordinate;
        }
    }
}