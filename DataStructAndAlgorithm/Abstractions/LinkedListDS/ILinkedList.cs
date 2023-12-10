namespace DataStructAndAlgorithm;

public interface ILinkedList<T>
{
    int Length { get; }

    void InsertAt(T item, int index);
    T Remove(T item);
    T RemoveAt(int index);
    void Append(T item);
    void Prepend(T item);
    T Get(int index);

}
