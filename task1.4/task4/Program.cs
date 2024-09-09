        Console.Write("Введіть перше число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Введіть третє число: ");
        int num3 = int.Parse(Console.ReadLine());
 
        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }
     
        int min = num1;

        if (num2 < min)
        {
            min = num2;
        }

        if (num3 < min)
        {
            min = num3;
        }
        
        Console.WriteLine("Максимальне число: " + max);
        Console.WriteLine("Мінімальне число: " + min);
    }
