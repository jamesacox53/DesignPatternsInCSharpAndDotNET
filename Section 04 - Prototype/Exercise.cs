namespace Section04Prototype
{
    public class Exercise
    {
        public class Point
        {
            public int X, Y;

            public Point DeepCopy()
            {
                Point newPoint = new Point();
                newPoint.X = X;
                newPoint.Y = Y;
                return newPoint;
            }
        }

        public class Line
        {
            public Point Start, End;

            public Line DeepCopy()
            {
                Line newLine = new Line();

                Point newStart = Start.DeepCopy();
                newLine.Start = newStart;

                Point newEnd = End.DeepCopy();
                newLine.End = newEnd;

                return newLine;
            }
        }
    }
}
