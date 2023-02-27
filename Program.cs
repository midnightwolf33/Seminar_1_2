{
    int a, b, c;
    Console.WriteLine("Введите три числа : ");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    if (a > b)
    {
        Console.WriteLine("{0} наибольшее число", a);
    }
    else
    {
        Console.WriteLine("{0} наибольшее число ", b);
        if (b > c)
        {
            Console.WriteLine("{0} наибольшее число", b);
        }
        else
        {
            Console.WriteLine("{0} наибольшее число", c);
        }
    }
    Console.ReadLine();
}