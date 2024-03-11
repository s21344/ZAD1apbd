// See https://aka.ms/new-console-template for more information

class Program
{
    static double FindAvg(int[] tab)
    {
        double x = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            x += tab[i];
        }
        return x / tab.Length;
    }
    public static void Main(string[] args)
    {
        int[] tbl = { 1, 7, 2, 8, 12, 20, 60, 23, -19, -57, 12 };
        Console.WriteLine("Average = " +FindAvg(tbl));
        
    }

}