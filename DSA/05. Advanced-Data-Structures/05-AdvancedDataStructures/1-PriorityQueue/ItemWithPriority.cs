namespace AdvancedDataStructures
{
    using System;

    public class ItemWithPriority :IComparable <ItemWithPriority>
    {
        public string itemName;
        public double priority; // Smaller values are higher priority

        public ItemWithPriority(string itemName, double priority)
        {
            this.ItemName = itemName;
            this.Priority = priority;
        }

        public double Priority
        {
            get; set;
        }

        public string ItemName
        {
            get; set;
        }

        public int CompareTo(ItemWithPriority other)
        {
            if (this.priority < other.priority)
            {
                return -1;
            }
            else if (this.priority > other.priority)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "(" + this.ItemName.ToString() + ", " + this.Priority.ToString("F1") + ")";
        }
    }
}
