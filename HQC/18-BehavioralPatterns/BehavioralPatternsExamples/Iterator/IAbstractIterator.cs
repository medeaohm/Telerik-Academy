namespace Iterator
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    internal interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone
        {
            get;
        }
        Item CurrentItem
        {
            get;
        }
    }
}
