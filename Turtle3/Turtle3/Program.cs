using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace Turtle2
{
    class Program
    {
        static void Main(string[] args)
        {
            var len = 100;

            Turtle.Speed = 8;
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.TurnRight();
            Turtle.Move(len);
            Turtle.TurnRight();
            Turtle.Move(len);
            Turtle.TurnRight();
            Turtle.Move(len);
            Turtle.Turn(46);
            Turtle.Move(71.98);
            Turtle.Turn(89.6);
            Turtle.Move(71);
            Turtle.PenUp();
            Turtle.Turn(89);
            Turtle.Move(40);
            Turtle.Turn(-45);
            Turtle.PenDown();
            Turtle.Move(40);
            Turtle.TurnRight();
            Turtle.Move(40);
            Turtle.TurnRight();
            Turtle.Move(40);
            Turtle.TurnRight();
            Turtle.Move(40);
            Turtle.PenUp();
            Turtle.Move(500);
        }
    }
}
