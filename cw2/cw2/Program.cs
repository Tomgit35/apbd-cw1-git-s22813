// See https://aka.ms/new-console-template for more information

static double CalculateAverage(int[] values)
{
    double sum = 0;
    return values.Sum() / values.Length;
}

static int CalculateMax(int[] values)
{
    int max = values[0];
    return values.Max();
}