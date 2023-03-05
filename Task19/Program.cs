Console.Clear();
int A = InputNumber("Введите пятизначное число: ");
PrintResult(A);

static int InputNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.Write(message);
            n = (int.Parse(Console.ReadLine() ?? ""));
            if ((n < 9999) || (n > 99999))
                Console.WriteLine($"Ошибка ввода данных! Число должно быть пятизначным");
            else break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
    return n;
}

static void PrintResult(int A)
{
    if ((A / 10000 == A % 10) && ((A / 1000) % 10 == (A % 100) / 10))
        Console.WriteLine($"Число {A} полиндром");
    else
        Console.WriteLine($"Число {A} не полиндром");
}