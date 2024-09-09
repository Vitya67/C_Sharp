Console.WriteLine("Введіть число для місяця");
int month = Convert.ToInt32(Console.ReadLine());

Conconsole.WriteLine("!!! Введіть число  дня !!!");
int day = Convert.ToInt32(Console.ReadLine());

if ((month > 0) && (month < 13))
{
    if (month == 2)
    {
        if ((day > 0) && (day <= 29)) 
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
    else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
    {
        if ((day > 0) && (day <= 31)) 
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
    else if ((month == 4 || month == 6 || month == 9 || month == 11))
    {
        if ((day > 0) && (day <= 30)) 
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
else
{
    Console.WriteLine("False");
}