using System;

namespace interfacetrying
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while(x<10){
            IHomework05 yayo = new homewark();
            String ledNo =  Console.ReadLine();
            yayo.DisplayLEDOnScreen(ledNo);
            }

        }
    }
}
