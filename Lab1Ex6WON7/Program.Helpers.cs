partial class Program
{
    static int ReadNumber()
    {
        Console.WriteLine("Introduceti un numar pentru a i se verifica paritatea");
        if(!int.TryParse(Console.ReadLine(), out var number))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumber();
        }
        return number;
    }
    static void CheckParity(int numar)
    {
        if (numar % 2 == 0)
            Console.WriteLine("par");
        else
            Console.WriteLine("impar");
    }
}