using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть, будь ласка, натуральне число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ви ввели число: " + n);

        if (n > 0)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++) 
            {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Сума s = {sum}");
        }
        else
        {
            Console.WriteLine("Введене число значення n не є допустимим натуральним числом");
        }
    }
}