using System;

namespace Section06Adapter
{
    public class CodingExercise5
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 3;

            IRectangle adapter = new SquareToRectangleAdapter(square);

            Console.WriteLine("Area: " + adapter.Area());
            Console.ReadKey();
        }
    }
}
