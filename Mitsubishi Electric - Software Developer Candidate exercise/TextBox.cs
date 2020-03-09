using System;
using System.Collections.Generic;
using System.Text;

namespace Mitsubishi_Electric___Software_Developer_Candidate_exercise
{
    class TextBox : Rectangle
    {
        private string backgroundColor = "Red";
        private string _text;
        public TextBox()
        {
            this._name = "TextBox";
        }

        public string Text
        {
            get => _text;
            set
            {
                backgroundColor = "Blue";
                _text = value;
            }
        }

        public override string Draw()
        {
            return Name + ", Render Size = " + Size + ", Height = " + Height +
                        ", Width = " + Width + " (X:" + X_Coordinate +
                        ", Y:" + Y_Coordinate +
                        "), Text:" + Text + ", Background Colour = " + backgroundColor;
        }
    }
}
