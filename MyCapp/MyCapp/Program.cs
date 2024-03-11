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
    
    static int FindMax(int[] tab)
    {
        int x=0;
        
        for (int i = 0; i < tab.Length; i++)
        {
            if (i == 0)
                x = tab[i];
            else
            {
                if (x < tab[i])
                    x = tab[i];
            }

        }
        return x;
    } 
    
    public static void Main(string[] args)
    {
        int[] tbl = { 1, 7, 2, 8, 12, 20, 60, 23, -19, -57, 12 };
        Console.WriteLine("Average = " +FindAvg(tbl));
        Console.WriteLine("Maximum = " +FindMax(tbl));

    }

}