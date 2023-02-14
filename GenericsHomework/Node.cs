namespace GenericsHomework
{
    public class Node<TValues> where TValues : notnull
    {
        public TValues Value { get; set; }
        public Node<TValues> Next { get; private set; }
        public Node<TValues> Last;

        public Node(TValues value)
        {
            Value = value;
            Next = this;
            Last = this;
        }

        public Node(TValues value, Node<TValues> node)
        {
            Value = value;
            Next = node;
            Last = this;
        }

        public void Append(TValues value)
        {
            bool keyValueExists = Exists(value);
            if (keyValueExists == true)
            {
                throw new ArgumentException("Cannot add duplicate value");
            }
            Node<TValues> lastNode = GetLast();
            lastNode.Next = new Node<TValues>(value, Last);
        }

        public Node<TValues> GetLast()
        {
            Node<TValues> currentNode = Last;
            while (currentNode.Next != Last)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }
        public void Clear()
        {

            Last.Next = this;
        }
        public Boolean Exists(TValues key)
        {
            Node<TValues> currentNode = Last;
            do
            {
                if (key is null)
                {
                    if (currentNode.Value is null)
                        return true;
                }
                else if (key.Equals(currentNode.Value))
                    return true;
                currentNode = currentNode.Next;
            } while (currentNode != Last);

            return false;
        }

        public override string ToString()
        {
            string? stringReturn = null;
            if (Value is not null)
                stringReturn = Value.ToString();
            if (stringReturn is null)
                return "";
            return stringReturn;
        }
    }
}