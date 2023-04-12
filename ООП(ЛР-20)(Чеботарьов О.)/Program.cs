   try
    {
        Console.WriteLine("Вітаємо! Ця програма призначена для обчислення площі трикутника за його трьома сторонами.");
        Console.Write("Введіть сторону А: ");
        int sideA = Convert.ToInt32(Console.ReadLine());
    if (sideA == 0)
    {
        Console.WriteLine("Ви ввели нуль. Всі наступні операції не мають сенсу.");
    }
    else if (sideA < 0)
    {
        Console.WriteLine("Ви ввели число, менше за нуль. Всі наступні операції не мають сенсу.");
    }
    Console.Write("Введіть сторону Б: ");
        int sideB = Convert.ToInt32(Console.ReadLine());
    if (sideB == 0)
    {
        Console.WriteLine("Ви ввели нуль. Всі наступні операції не мають сенсу.");
        Environment.Exit(0);
    }
    else if (sideB < 0)
    {
        Console.WriteLine("Ви ввели число, менше за нуль. Всі наступні операції не мають сенсу.");
        Environment.Exit(0);
    }
    Console.Write("Введіть сторону В: ");
        int sideC = Convert.ToInt32(Console.ReadLine());
    if (sideC == 0)
    {
        Console.WriteLine("Ви ввели нуль. Всі наступні операції не мають сенсу.");
        Environment.Exit(0);
    }
    else if (sideC < 0)
    {
        Console.WriteLine("Ви ввели число, менше за нуль. Всі наступні операції не мають сенсу.");
        Environment.Exit(0);
    }
    if (sideA > sideB + sideC)
    {
        Console.WriteLine("Одна сторона більша за суму двох інших. Це не трикутник, наступні операції не мають сенсу.");
        Environment.Exit(0);
    }
    else if (sideA == sideB + sideC)
    {
        Console.WriteLine("Одна сторона рівна сумі двох інших. Це не трикутник, наступні операції не мають сенсу.");
        Environment.Exit(0);
    }

    int p = (sideA + sideB + sideC) / 2;
        int semiS = p * ((p - sideA) * (p - sideB) * (p - sideC));
        int S = Convert.ToInt32(Math.Sqrt(semiS));
        Console.WriteLine("Площа трикутника: " + S);
    }
    catch
    {
        Console.WriteLine("Ви ввели не число! Програма зупинена.");
    }
    Console.WriteLine("Кінець програми.");