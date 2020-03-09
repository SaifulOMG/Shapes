using System;

namespace Mitsubishi_Electric___Software_Developer_Candidate_exercise
{
    class Rectangle : Widgets
    {
        public Rectangle()
        {
            this._name = "Rectangle";
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        override public string Draw()
        {
            return Name + ", Render Size = " + Size + ", Height = " + Height + 
                ", Width = " + Width + ", X Coordinate = " + X_Coordinate + 
                ", Y Coordinate = " + Y_Coordinate;
        }
    }
}

