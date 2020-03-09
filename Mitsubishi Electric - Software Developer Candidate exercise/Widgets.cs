
namespace Mitsubishi_Electric___Software_Developer_Candidate_exercise
{
    public abstract class Widgets
    {
        protected string _name;

        public string Name
        {
            get => _name;
            set => _name = _name + " " + value;
        }

        public int X_Coordinate
        {
            get;
            set;
        }

        public int Y_Coordinate
        {
            get;
            set;
        }

        public int Size
        {
            get;
            set;
        }

        virtual public string Draw()
        {
            return Name + ", Render Size = " + Size + ", X Coordinate = " + X_Coordinate + 
                ", Y Coordinate = " + Y_Coordinate;
        }
    }
}
