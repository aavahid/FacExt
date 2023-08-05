int number;
while (true)
{
    Console.Write("Faktorial hesablamaq ucun ededi daxil edin: ");
    if (int.TryParse(Console.ReadLine(), out number))
    {
        try
        {
            var result = number.Factorial();
            Console.WriteLine("Netice: " + result);
            break;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        Console.WriteLine("Duzgun eded daxil edin.");
    }
}