using System;
using System.Collections.Generic;
using System.Text;

namespace Mitsubishi_Electric___Software_Developer_Candidate_exercise
{
    class Canvas
    {
        List<Widgets> widgets;
        public void AddToCanvas(List<Widgets> widgets)
        {
            this.widgets = widgets;
        }

        public void DisplayCanvas()
        {
            foreach(var widget in this.widgets)
            {
                Console.WriteLine(widget.Draw());
            }
        }
    }
}
