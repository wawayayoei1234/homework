using System;

namespace interfacetrying
{
    class Program
    {
        static void Main(string[] args)
    {
        int x = 1;
        while (x < 10)
        {
            IHomework05 yayo = new homewark();
            String ledNo = Console.ReadLine();
            string waa = yayo.DisplayLEDOnScreen(ledNo);
            Console.WriteLine(waa);
        }
    }
    }
}
