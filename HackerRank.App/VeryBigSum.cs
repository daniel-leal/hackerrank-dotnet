namespace HackerRank.App
{
    public class VeryBigSum
    {
        public static long run(long[] ar)
        {
            long acc = 0;

            for (var i = 0; i < ar.Length; i++)
            {
                acc += ar[i];
            }
            return acc;
        }
    }
}
