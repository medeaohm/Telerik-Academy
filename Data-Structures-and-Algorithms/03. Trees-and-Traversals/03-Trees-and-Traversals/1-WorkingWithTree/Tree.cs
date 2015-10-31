namespace WorkingWithTree
{
    using System;
    using System.Collections.Generic;

    public class Tree<T>
    {
        private Node<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            this.Root = new Node<T>(value);
        }

        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public Node<T> Root
        {
            get
            {
                return this.root;
            }
            private set
            {
                this.root = value;
            }
        }

        private void TraverseDFS(Node<T> root, string spaces)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            Node<T> child = null;
            for (int i = 0; i < root.ChildrenCount(); i++)
            {
                child = root.GetChild(i);
                this.TraverseDFS(child, spaces + "   ");
            }
        }

        public void TraverseDFS()
        {
            this.TraverseDFS(this.root, string.Empty);
        }

        public void TraverseBFS()
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(this.root);
            while (queue.Count > 0)
            {
                Node<T> currentNode = queue.Dequeue();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount(); i++)
                {
                    Node<T> childNode = currentNode.GetChild(i);
                    queue.Enqueue(childNode);
                }
            }
        }

        public void TraverseDFSWithStack()
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                Node<T> currentNode = stack.Pop();
                Console.Write("{0} ", currentNode.Value);
                for (int i = 0; i < currentNode.ChildrenCount(); i++)
                {
                    Node<T> childNode = currentNode.GetChild(i);
                    stack.Push(childNode);
                }
            }
        }

        // the root node
        public Node<T> GetRoot()
        {
            return this.root;
        }

        // all leaf nodes
        public void GetLeaves()
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                Node<T> currentNode = stack.Pop();
                for (int i = 0; i < currentNode.ChildrenCount(); i++)
                {
                    Node<T> childNode = currentNode.GetChild(i);
                    if (!childNode.HasChildren)
                    {
                        Console.Write("{0} ", childNode.Value);
                    }
                    stack.Push(childNode);
                }
            }
        }

        // all middle nodes
        public void GetMiddle()
        {
            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(this.root);
            while (stack.Count > 0)
            {
                Node<T> currentNode = stack.Pop();
                for (int i = 0; i < currentNode.ChildrenCount(); i++)
                {
                    Node<T> childNode = currentNode.GetChild(i);
                    if (childNode.HasChildren)
                    {
                        Console.Write("{0} ", childNode.Value);
                    }
                    stack.Push(childNode);
                }
            }
        }
    }
}
