namespace DataStructAndAlgorithm;

public class LinkedList<T> : ILinkedList<T>
{
    private int length;
    private Node<T>? head;
    private Node<T>? tail;

    public LinkedList()
    {
        length = 0;
        head = null;
        tail = null;
    }
    public int Length => length;

    public void Append(T item)
    {
        var newNode = new Node<T>(item);
        if (head is null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Prev = tail;
            tail.Next = newNode;
            tail = newNode;
        }
        length++;
    }

    public void Prepend(T item)
    {
        var newNode = new Node<T>(item);
        if (head is null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        length++;
    }

    public T Get(int index)
    {
        if (head is null || index >= length || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        Node<T> current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }

        return current.Value;
    }

    public void InsertAt(T item, int index)
    {
        if (head is null || index >= length || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        if (index == 0)
        {
            Prepend(item);
            return;
        }
        else if (index == length - 1)
        {
            Append(item);
            return;
        }

        Node<T> newNode = new Node<T>(item);
        Node<T> current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }

        var prevNode = current.Prev;
        prevNode.Next = newNode;
        newNode.Next = current;
        newNode.Prev = current.Prev;
        current.Prev = newNode;

        length++;

    }

    public T Remove(T item)
    {
        throw new NotImplementedException();
    }

    public T RemoveAt(int index)
    {
        throw new NotImplementedException();
    }
}
