namespace HackerRank.Arrays;

public class NewYearChaos
{
    // https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&isFullScreen=false&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays&h_r=next-challenge&h_v=zen
    
    public static void minimumBribes(List<int> q)
    {
        int bribes = 0;
        bool tooChaotic = false;

        // 0, 1, 2, 3, 4, 5, 6, 7
        // 1, 2, 5, 3, 7, 8, 6, 4
        for (int i = 0; i < q.Count; i++)
        {
            if ((i-1) < q[i])
            {
                bribes += (i - q[i]);
                if (q[i] - i > 3)
                {
                    tooChaotic = true;
                    break;
                }
            }
        }

        Console.WriteLine(tooChaotic ? "Too chaotic" : $"{bribes}");
    }
}