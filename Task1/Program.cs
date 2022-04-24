void IfPow (int arg)
{
    if (arg < 0)
    {
        Console.WriteLine("Не может являться степенью");
        return;
    }
    for (int i = 0; i <= arg; i++)
    {
        if (Math.Pow(2, i) == arg)
        {
            Console.Write("Является степенью двойки");
            return;
        }
        if (Math.Pow(2, i) > arg)
        {
            Console.Write("Не является степенью двойки");
            return;
        }
    }
}

IfPow(12);