void NaturalValue(uint n)
{
    Console.Write(n + " ");
    if (n > 1) NaturalValue(n - 1);
}
NaturalValue(4);
Console.WriteLine();
NaturalValue(8);