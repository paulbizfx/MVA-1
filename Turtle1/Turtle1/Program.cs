using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace Turtles
{
    class Program
    {
        static void Main(String[] args)
        {
            var len = 100;
            Turtle.Speed = 8;

            // Рисуем тело домика

            Turtle.Turn(90);
            Square(len);

            // Рисуем крышу

            Turtle.Turn(-60);
            Turtle.Move(len);
            Turtle.Turn(120);
            Turtle.Move(len);
            Turtle.Turn(30);

            // Рисуем окошко

            Turtle.PenUp();
            Turtle.Move(2 * len / 3);
            Turtle.Turn(90);
            Turtle.Move(len / 3);
            Turtle.PenDown();
            Square(len / 3);
        }
        static void Square(int len)
        {
            Side(len);
            Side(len);
            Side(len);
            Side(len);
        }
        static void Side(int len)
        {
            Turtle.Move(len);
            Turtle.Turn(90);
        }
    }
}

// Рисуем тело домика

/* Turtle.Turn(90);
 Turtle.Move(len);
 Turtle.Turn(90);
 Turtle.Move(len);
 Turtle.Turn(90);
 Turtle.Move(len);
 Turtle.Turn(90);
 Turtle.Move(len);
 Turtle.Turn(90);

 // Рисуем крышу

 Turtle.Turn(-60);
 Turtle.Move(len);
 Turtle.Turn(120);
 Turtle.Move(len);
 Turtle.Turn(30);

 // Рисуем окошко

 Turtle.PenUp();
 Turtle.Move(2 * len / 3);
 Turtle.Turn(90);
 Turtle.Move(len / 3);
 Turtle.PenDown();
 Turtle.Move(len / 3);
 Turtle.Turn(90);
 Turtle.Move(len / 3);
 Turtle.Turn(90);
 Turtle.Move(len / 3);
 Turtle.Turn(90);
 Turtle.Move(len / 3);
 Turtle.PenUp();
 Turtle.Move(500); */