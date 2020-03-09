using System;
using System.Collections.Generic;

namespace Mitsubishi_Electric___Software_Developer_Candidate_exercise
{
    class Program
    {
        static void RenderWidget(Widgets widget, int widgetNum)
        {
            try
            {
                widget.Name = String.Format("{0}", widgetNum);
                Console.WriteLine(widget.Name);
                Console.WriteLine("Please type in widget size");
                widget.Size = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Please type in widget x coordinate");
                widget.X_Coordinate = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Please type in widget y coordinate");
                widget.Y_Coordinate = Int16.Parse(Console.ReadLine());

                if (widget is TextBox textBox)
                {
                    try
                    {
                        Console.WriteLine("Please type in Text Box height");
                        textBox.Height = Int16.Parse(Console.ReadLine());
                        Console.WriteLine("Please type in Text Box width");
                        textBox.Width = Int16.Parse(Console.ReadLine());
                        Console.WriteLine("Please type in Y to enter text in Text Box, otherwise; type N to continue");
                        char typeTextOption = Char.Parse(Console.ReadLine());
                        if (Char.ToUpper(typeTextOption) == 'Y')
                        {
                            textBox.Text = Console.ReadLine();
                        }
                        else if (Char.ToUpper(typeTextOption) != 'N')
                        {
                            throw new Exception("Only characters accepted are Y and N");
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

                if (widget is Rectangle rectangle)
                {
                    Console.WriteLine("Please type in Rectangle height");
                    rectangle.Height = Int16.Parse(Console.ReadLine());
                    Console.WriteLine("Please type in Rectangle width");
                    rectangle.Width = Int16.Parse(Console.ReadLine());
                }

                if (widget is Ellipse ellipse)
                {
                    Console.WriteLine("Please type in Ellipse Vertical Diameter");
                    ellipse.Vertical_Diameter = Int16.Parse(Console.ReadLine());
                    Console.WriteLine("Please type in Ellipse Horizontal Diameter");
                    ellipse.Horizontal_Diameter = Int16.Parse(Console.ReadLine());
                }
            } catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        static void WidgetOptionList()
        {
            Console.WriteLine("Enter 0 to draw a Square Widget");
            Console.WriteLine("Enter 1 to draw a Rectangle Widget");
            Console.WriteLine("Enter 2 to draw a Circle Widget");
            Console.WriteLine("Enter 3 to draw a Ellipse Widget");
            Console.WriteLine("Enter 4 to draw a Text Box Widget");
            Console.WriteLine("Enter 5 to Exit");
        }

        static Widgets WidgetToAdd(Widgets NewWidget, int widgetNum)
        {
            Widgets widget = NewWidget;
            RenderWidget(widget, widgetNum);
            return widget;
        } 

        static void Main(string[] args)
        {
            int textBoxNum = 0;
            int rectangleNum = 0;
            int circleNum = 0;
            int ellipseNum = 0;
            int squareNum = 0;
            Boolean exitLoop = false;
            int optionNum;

            Canvas canvas = new Canvas();
            List<Widgets> widgets = new List<Widgets>();
            WidgetOptionList();

            for (int i = 0; exitLoop != true; i++) 
            {
                try
                {
                    optionNum = Int16.Parse(Console.ReadLine());
                    switch (optionNum)
                    {
                        case 0:
                            widgets.Add(WidgetToAdd(new Square(), squareNum));
                            squareNum++;
                            break;
                        case 1:
                            widgets.Add(WidgetToAdd(new Rectangle(), rectangleNum));
                            rectangleNum++;
                            break;
                        case 2:
                            widgets.Add(WidgetToAdd(new Circle(), circleNum));
                            circleNum++;
                            break;
                        case 3:
                            widgets.Add(WidgetToAdd(new Ellipse(), ellipseNum));
                            ellipseNum++;
                            break;
                        case 4:
                            widgets.Add(WidgetToAdd(new TextBox(), textBoxNum));
                            textBoxNum++;
                            break;
                        case 5:
                            Console.WriteLine("Are you sure you would like to exit enter Y to exit and N to continue");
                            char exitOption = Char.Parse(Console.ReadLine());
                            if (Char.ToUpper(exitOption) == 'Y')
                            {
                                exitLoop = true;
                            }
                            else if (Char.ToUpper(exitOption) != 'N')
                            {
                                throw new Exception("Only characters accepted are Y and N");
                            }
                            break;
                        default:
                            Console.WriteLine("Please enter a valid option from the list");
                            WidgetOptionList();
                            break;
                    }
                    canvas.AddToCanvas(widgets);
                    canvas.DisplayCanvas();
                    WidgetOptionList();
                } catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            } 
        }
    }
}
