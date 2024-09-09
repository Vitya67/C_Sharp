        Console.Write("Введіть кількість чисел (n): ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i; 
        }

        Console.WriteLine("Сума перших " + n + " натуральних чисел дорівнює: " + sum);
