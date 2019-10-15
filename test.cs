using System;
using System.Collections.Generic;
using System.Text;


class Name
{
    public void test()
    {
        for (int i = 1; i <= 10; i++)
        {
            var b = string.Format("{0:000000}", i);
            Console.WriteLine(b);

        }
        Console.ReadLine();
    }
    public void loop()
    {

        int[] g = { 0, 0, 0, 0, 0, 0 };

        for (int i = 1; i <= 10; i++)
        {
            var b = string.Format("{0:000000}", i);
            if (i <= 9)
            {
                g[5] = i;
            }
        }
        Console.ReadLine();
        foreach (var item in g)
        {
            int h = 0;
            h = item;
            Console.Write(h);
        }
    }
    public void testtest()
    {
        Console.ReadLine();
        int[] num = {0, 0, 0};
        num[0] = 1;
        num[1] = 2;
        num[2] = 3;
        int a = num[0];
        int b = num[1];
        int c = num[2];

        var d = (a == 1);
        if (d)
        {
            b = 0;
            c = 0;
        }
        var e = (a == 2);
        if (e)
        {
            
        }
        var f = (a == 3);
        var g = (a == 4);
        var h = (a == 5);


        //Console.WriteLine("kuy : "+num[0]+""+num[1]+""+num[2]);
        
    }
}
