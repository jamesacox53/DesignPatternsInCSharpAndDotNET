namespace Section04Prototype
{
    internal class CodingExercise3
    {
        static void Main(string[] args)
        {
            Exercise.Line originalLine = new Exercise.Line();

            Exercise.Point originalStart = new Exercise.Point();
            originalStart.X = 50;
            originalStart.Y = 78;

            Exercise.Point originalEnd = new Exercise.Point();
            originalEnd.X = 140;
            originalEnd.Y = 221;


            originalLine.Start = originalStart;
            originalLine.End = originalEnd;
        }
    }
}
