namespace HackerRank.Arrays;

public class LeftRotation
{
    public static List<int> rotLeft(List<int> a, int d)
    {
        List<int> result = a;
        for (int rotation = 0; rotation < d; rotation++)
        {
            int item = result[0];
            result.RemoveAt(0);
            result.Add(item);
        }

        return result;
    }
}