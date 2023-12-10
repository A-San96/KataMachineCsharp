namespace DataStructAndAlgorithm.UnitTests;

public class LinkedListTests
{
    [Fact]
    public void Length_IsZero_WhenListCreated()
    {
        // Arrange
        var list = new LinkedList<int>();

        // Act
        int length = list.Length;

        // Assert
        Assert.Equal(0, length);
    }

    [Fact]
    public void Append_AddsElement_AtTheEnd()
    {
        // Arrange
        var list = new LinkedList<int>();

        // Act
        list.Append(10);
        list.Append(20);
        list.Append(30);

        // Assert
        Assert.Equal(10, list.Get(0));
        Assert.Equal(20, list.Get(1));
        Assert.Equal(30, list.Get(2));
        Assert.Equal(3, list.Length);
    }

    [Fact]
    public void Prepend_AddsElement_AtTheBeginning()
    {
        // Arrange
        var list = new LinkedList<int>();

        // Act
        list.Prepend(30);
        list.Prepend(20);
        list.Prepend(10);

        // Assert
        Assert.Equal(10, list.Get(0));
        Assert.Equal(20, list.Get(1));
        Assert.Equal(30, list.Get(2));
        Assert.Equal(3, list.Length);
    }

    [Fact]
    public void Remove_RemovesElement_ReturnsRemovedItem()
    {
        // Arrange
        var list = new LinkedList<int>();
        list.Append(10);
        list.Append(20);
        list.Append(30);

        // Act
        int removed = list.Remove(20);

        // Assert
        Assert.Equal(20, removed);
        Assert.Equal(2, list.Length);
        Assert.Equal(10, list.Get(0));
        Assert.Equal(30, list.Get(1));
    }

    [Fact]
    public void InsertAt_InsertsElement_AtGivenIndex()
    {
        // Arrange
        var list = new LinkedList<int>();
        list.Append(10);
        list.Append(30);

        // Act
        list.InsertAt(20, 1);

        // Assert
        Assert.Equal(3, list.Length);
        Assert.Equal(10, list.Get(0));
        Assert.Equal(20, list.Get(1));
        Assert.Equal(30, list.Get(2));
    }

    [Fact]
    public void Get_ReturnsElement_AtGivenIndex()
    {
        // Arrange
        var list = new LinkedList<int>();
        list.Append(10);
        list.Append(20);
        list.Append(30);

        // Act
        int element = list.Get(1);

        // Assert
        Assert.Equal(20, element);
    }

    [Fact]
    public void RemoveAt_RemovesElement_AtGivenIndex()
    {
        // Arrange
        var list = new LinkedList<int>();
        list.Append(10);
        list.Append(20);
        list.Append(30);

        // Act
        int removed = list.RemoveAt(1);

        // Assert
        Assert.Equal(20, removed);
        Assert.Equal(2, list.Length);
        Assert.Equal(10, list.Get(0));
        Assert.Equal(30, list.Get(1));
    }
}

