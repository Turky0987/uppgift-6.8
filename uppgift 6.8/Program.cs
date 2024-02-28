using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ange ett heltal: ");
        int användarensTal = Convert.ToInt32(Console.ReadLine());

        int antalPrimtal = BeräknaAntalPrimtal(användarensTal);
        Console.WriteLine("Antalet primtal mindre än " + användarensTal + " är: " + antalPrimtal);
    }

    static bool ÄrPrimtal(int tal)
    {
        if (tal <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(tal); i++)
        {
            if (tal % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static int BeräknaAntalPrimtal(int maxGräns)
    {
        int antalPrimtal = 0;

        for (int i = 2; i < maxGräns; i++)
        {
            if (ÄrPrimtal(i))
            {
                antalPrimtal++;
            }
        }

        return antalPrimtal;
    }
}
