namespace DataStructAndAlgorithm.UnitTests;

public class SortListTests
{
    private SortList _sortList;
    public SortListTests()
    {
        _sortList = new();
    }

    [Fact]
    public void BubbleSortTest()
    {
        // Arrange
        int[] arr = [9, 3, 7, 4, 69, 420, 42];
        int[] expected = [3, 4, 7, 9, 42, 69, 420];

        // Act
        _sortList.BubbleSort(ref arr);

        // Assert
        Assert.Equal(expected, arr);
    }

}
