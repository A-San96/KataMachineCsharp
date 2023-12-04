namespace DataStructAndAlgorithm;

public class TwoCrystalBalls : ITwoCrystalBalls
{
    public int GetBreakPoint(bool[] breaks)
    {
        var jumpAmount = (int)Math.Floor(Math.Sqrt(breaks.Length));
        var i = jumpAmount;

        for (; i < breaks.Length; i += jumpAmount)
        {
            if (breaks[i])
            {
                break;
            }
        }

        i -= jumpAmount;

        for (int j = 0; j <= jumpAmount && i < breaks.Length; j++, i++)
        {
            if (breaks[i])
            {
                return i;
            }
        }

        return -1;
    }
}
