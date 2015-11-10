namespace WorkingWithTree
{
    using System;
    using System.Collections.Generic;

    public class Node<T>
    {
        private T value;
        private bool hasParent;

        public Node(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value");
            }

            this.Value = value;
            this.Children = new List<Node<T>>();
            this.HasParent = false;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public int ChildrenCount()
        {
            return this.Children.Count;
        }

        public void AddChild(Node<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value");
            }

            if (child.hasParent)
            {
                throw new ArgumentException(
                    "The node already has a parent!");
            }

            child.hasParent = true;
            this.Children.Add(child);
        }

        public bool HasChildren
        {
            get
            {
                return this.Children.Count > 0;
            }
        }

        public List<Node<T>> Children
        {
            get; set;
        }

        public bool HasParent
        {
            get; set;
        }

        public Node<T> GetChild(int index)
        {
            return this.Children[index];
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
