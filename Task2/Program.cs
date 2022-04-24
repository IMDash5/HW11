void Check(int arg)
{
    if (arg < 1)
    {
        Console.WriteLine("Это не натуральное число");
        return;
    }
    for (int i = 2; i < arg; i++)
    {
        if (arg % i == 0)
        {
            Console.WriteLine("Это не простое число");
            return;
        }
    }
    Console.WriteLine("Это простое число");
    return;
}

Check(0);