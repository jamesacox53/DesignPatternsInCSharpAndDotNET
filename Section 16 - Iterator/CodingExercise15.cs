using System;
using System.Linq;

namespace Section16Iterator
{
    internal class CodingExercise15
    {
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test1()
        {
            var node = new Node<char>('a',
          new Node<char>('b',
            new Node<char>('c'),
            new Node<char>('d')),
          new Node<char>('e'));

            string preOrderTraversal = new string(node.PreOrder.ToArray());

            Console.WriteLine($"PreOrder Traversal is: {preOrderTraversal} and should be \"abcde\"");
            Console.ReadKey();
        }
    }
}
