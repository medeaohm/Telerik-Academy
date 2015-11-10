namespace LinkedListImplementation
{
    public class LinkedItem<T>
    {
        private T value;
        private LinkedItem<T> nextItem;

        public LinkedItem(T value, LinkedItem<T> nextItem = null)
        {
            this.Value = value;
            this.NextItem = nextItem;
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

        public LinkedItem<T> NextItem
        {
            get
            {
                return this.nextItem;
            }
            set
            {
                this.nextItem = value;
            }
        }
    }
}
