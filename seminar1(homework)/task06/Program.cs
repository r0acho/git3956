Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
isdigit(x);

void isdigit(int num) 
{
    if(num%2 == 0)
    {
        Console.WriteLine("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}