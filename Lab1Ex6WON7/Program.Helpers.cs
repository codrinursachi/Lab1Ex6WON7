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
    static string CheckParity(int numar)
    {
        if (numar % 2 == 0)
            return "par";
        else
            return "impar";
    }
    
    static void ShowParity(string parity)
    {
        Console.WriteLine(parity);
    }
}