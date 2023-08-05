public static class IntExtensions
{
    public static int Factorial(this int number)
    {
        if (number < 0)
            throw new ArgumentException("Factorial menfi sayi ola bilmez");

        if (number == 0 || number == 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}

