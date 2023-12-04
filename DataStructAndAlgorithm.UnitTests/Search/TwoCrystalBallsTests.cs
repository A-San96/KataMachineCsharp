namespace DataStructAndAlgorithm.UnitTests;

public class TwoCrystalBallsTests
{
    private TwoCrystalBalls _twoCrystalBalls;
    public TwoCrystalBallsTests()
    {
        _twoCrystalBalls = new();
    }

    [Fact]
    public void GetBreakPointTest()
    {
        // Arrange
        const int NO_BREAK_POINT_FOUND = -1;
        var idx = (int)Math.Floor(new Random().NextDouble() * 10000);
        bool[] dataWithBreakPoint = new bool[10000];
        Array.Fill<bool>(dataWithBreakPoint, false);

        var dataWithoutBreakPoint = new bool[827];
        Array.Fill<bool>(dataWithoutBreakPoint, false);

        for (int i = idx; i < 10000; ++i)
        {
            dataWithBreakPoint[i] = true;
        }

        // Act and Assert
        Assert.Equal(idx, _twoCrystalBalls.GetBreakPoint(dataWithBreakPoint));
        Assert.Equal(NO_BREAK_POINT_FOUND, _twoCrystalBalls.GetBreakPoint(dataWithoutBreakPoint));
    }
}
