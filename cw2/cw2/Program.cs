// See https://aka.ms/new-console-template for more information

static double CalculateAverage(int[] values)
{
    double test = 0;
    double sum = 0;
    return values.Sum() / values.Length;
}

static int CalculateMax(int[] values)
{
    int max = values[0];
    return values.Max();
}

static int CalculatePow(int values)
{
    int pow = values*values;
    return pow;
}