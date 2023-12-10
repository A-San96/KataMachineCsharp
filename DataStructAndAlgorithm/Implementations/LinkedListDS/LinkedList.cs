﻿namespace DataStructAndAlgorithm;

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
        }
        else
        {
            newNode.Prev = tail;
            tail.Next = newNode;
            tail = newNode;
        }
        length++;
    }

    public T Get(int index)
    {
        throw new NotImplementedException();
    }

    public void InsertAt(T item, int index)
    {
        throw new NotImplementedException();
    }

    public void Prepend(T item)
    {
        throw new NotImplementedException();
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