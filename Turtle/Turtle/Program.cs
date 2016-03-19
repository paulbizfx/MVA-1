using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle1
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 5;
            Turtle.PenUp();
            Turtle.MoveTo(100, 80);
            Turtle.PenDown();
            Turtle.MoveTo(200, 80);
            Turtle.MoveTo(200, 180);
            Turtle.MoveTo(100, 180);
            Turtle.MoveTo(100, 80);
            Turtle.MoveTo(150, 10);
            Turtle.MoveTo(200, 80);
            Turtle.PenUp();
            Turtle.MoveTo(130, 100);
            Turtle.PenDown();
            Turtle.MoveTo(170, 100);
            Turtle.MoveTo(170, 150);
            Turtle.MoveTo(130, 150);
            Turtle.MoveTo(130, 100);
            Turtle.PenUp();
            Turtle.MoveTo(0, 0);
        }
    }
}
