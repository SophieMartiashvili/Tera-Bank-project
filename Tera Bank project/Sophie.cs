


class Program
{
    static void Main(string[] args)
    {

        MyFunction my = Sum;
        int result = my(5, 4);
        Console.WriteLine(result);

    }
    delegate int MyFunction(int a, int b);
    public static int Sum(int a, int b)
    {
        return a + b;
    }







}
