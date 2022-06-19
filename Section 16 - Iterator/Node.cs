using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section16Iterator
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left, Right;
        public Node<T> Parent;

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;

            left.Parent = right.Parent = this;
        }

        public IEnumerable<T> PreOrder
        {
            get
            {
                foreach (var node in TraverseInPreOrder(this))
                    yield return node.Value;
            }
        }
    
        private IEnumerable<Node<T>> TraverseInPreOrder(Node<T> current)
        {
            yield return current;

            if (current.Left != null)
            {
                foreach (var left in TraverseInPreOrder(current.Left))
                    yield return left;
            }
            
            if (current.Right != null)
            {
                foreach (var right in TraverseInPreOrder(current.Right))
                    yield return right;
            }
        }
    }
}
