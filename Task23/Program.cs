Console.Clear();
int A = InputNumber("Введите число: ");
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
            if (n < 1)
                Console.WriteLine($"Ошибка ввода данных! Число должно быть больше нуля");
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
    int N = 1;
    double x;
    while (N <= A)
    {
        x = Math.Pow(N, 3);
        Console.Write($"{x}, ");
        N++;
    }
}