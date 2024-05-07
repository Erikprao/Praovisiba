namespace SharedLib;

public class CalcMethods
{
    public static int IterAdd(int start, int bump, int iterations)
    {
        int result = start;

        for (int n = 0; n < iterations; n++)
        {
            result += bump;
        }

        return result;
    }

    public static int SmartAdd(int start, int bump, int iterations)
    {
        return bump * iterations + start;
    }
}