        Console.Write("Введіть час: ");
        int h = int.Parse(Console.ReadLine());

        if (h >= 5 && h < 12)
        {
            Console.WriteLine("Доброго ранку!");
        }
        else if (h >= 12 && h < 18)
        {
            Console.WriteLine("Добрий день!");
        }
        else if (h >= 18 && h < 22)
        {
            Console.WriteLine("Добрий вечір!");
        }
        else
        {
            Console.WriteLine("Доброї ночі!");
        }
    