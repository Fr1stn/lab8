Math[] arr = new Math[3];
for (int i = 0; i <= 2; i++)
{
    Console.WriteLine("Введите первое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    double num3 = Convert.ToDouble(Console.ReadLine());
    arr[i] = new Math(num1, num2, num3);
    arr[i].one();
    arr[i].two();
    arr[i].three();
}
class Math
{
    double a;
    double b;
    double x;
    double S = 1;
    public Math(double num1, double num2, double num3)
    {
        a = num1;
        b = num2;
        x = num3;
    }
    public void one()
    {
        Console.WriteLine($"\nОтвет первого выражения: {3 * x + 5}");
        
    }
    public void two()
    {
        if ((a - b) == 0)
        {
            Console.WriteLine("Делить на 0 нельзя!");
        }
        else
        {
            Console.WriteLine($"\nОтвет второго выражения: {(a + b) / (a - b)}");
        }
    }
    public void three()
    {
        if (b == 0)
        {
            Console.WriteLine("Делить на 0 нельзя!");
        }
        else 
        {
            for (int i = 1; i <= (a * x / b); i++)
            {
                S *= i;
            }
            Console.WriteLine($"\nОтвет третьего выражения: {S}");
        }
    }
}
