double DifferenceOfValue(double[] array)
{
    double MaxValue = array[0];
    double MinValue = array[0];
    foreach(double i in array)
    {
        if(i > MaxValue) MaxValue = i;
        if(i < MinValue) MinValue = i;
    }
    return(MaxValue - MinValue);
}


double[] filled_array = new double[8]{3, 7, 22, 2, 78, 98, 5, 9};
Console.WriteLine($"[{string.Join('|', filled_array)}] -> {DifferenceOfValue(filled_array)}");