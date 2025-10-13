Console.WriteLine("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());
Mat Y = new Mat(num1, num2, num3);
Console.WriteLine(Y.one());
Console.WriteLine(Y.two());
Console.WriteLine(Y.three());
Mat Z = new Mat(Y.one(), Y.two(), Y.three());
class Mat
{
    double a;
    double b;
    double x;
    double S = 1;
    public Mat(double a, double b, double x)
    {
        this.a = a;
        this.b = b;
        this.x = x;
    }
    public double one()
    {
        return 3 * this.x + 5;
    }
    public double two()
    {
        return (this.a + this.b) / (this.a - this.b);
    }
    public double three()
    {
        for (int i = 1; i <= (this.a * this.x / this.b); i++)
        {
            S *= i;
        }
        return S;
    }
}