public static class GradeHelper
{
    public static double CalculateAverage(int[] values)
    {
        int sum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        return (double)sum / values.Length;
    }
}