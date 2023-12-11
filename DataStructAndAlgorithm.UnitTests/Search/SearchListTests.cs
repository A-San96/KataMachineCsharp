using DataStructAndAlgorithm.Implementations.Search;

namespace DataStructAndAlgorithm.UnitTests;

public class SearchListTests
{
    private SearchList _searchList;
    public SearchListTests()
    {
        _searchList = new SearchList();
    }

    [Fact]
    public void LinearSearchTest()
    {
        // Arrange
        int[] foo = [1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420];

        // Act & Assert
        Assert.True(_searchList.LinearSearch(foo, 69));
        Assert.False(_searchList.LinearSearch(foo, 1336));
        Assert.True(_searchList.LinearSearch(foo, 69420));
        Assert.False(_searchList.LinearSearch(foo, 69421));
        Assert.True(_searchList.LinearSearch(foo, 1));
        Assert.False(_searchList.LinearSearch(foo, 0));
    }

    [Fact]
    public void BinarySearchTest()
    {
        // Arrange
        int[] foo = [1, 3, 4, 69, 71, 81, 90, 99, 420, 1337, 69420];

        // Act & Assert
        Assert.True(_searchList.BinarySearch(foo, 69));
        Assert.False(_searchList.BinarySearch(foo, 1336));
        Assert.True(_searchList.BinarySearch(foo, 69420));
        Assert.False(_searchList.BinarySearch(foo, 69421));
        Assert.True(_searchList.BinarySearch(foo, 1));
        Assert.False(_searchList.BinarySearch(foo, 0));
    }
}
