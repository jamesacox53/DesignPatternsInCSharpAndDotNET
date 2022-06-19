using System;

namespace Section12Proxy
{
    internal class CodingExercise11
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            ResponsiblePerson responsiblePerson = new ResponsiblePerson(person);
            responsiblePerson.Age = 15;

            Console.WriteLine(responsiblePerson.Drink());
            Console.WriteLine(responsiblePerson.Drive());
            Console.WriteLine(responsiblePerson.DrinkAndDrive());

            responsiblePerson.Age = 22;

            Console.WriteLine(responsiblePerson.Drink());
            Console.WriteLine(responsiblePerson.Drive());
            Console.WriteLine(responsiblePerson.DrinkAndDrive());

            Console.ReadKey();
        }
    }
}
