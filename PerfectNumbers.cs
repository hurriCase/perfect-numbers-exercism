using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number) 
    {
        int aliquotSum = 0;
        int i;

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);

        for (i = 1; i <= number / 2; i++)
        {
            if ((number % i) == 0) aliquotSum += i;
        }

        if (number == aliquotSum) return Classification.Perfect;
        if (number < aliquotSum) return Classification.Abundant;
        return Classification.Deficient;
    }
}
