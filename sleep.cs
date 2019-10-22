using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
 
public class Name : IHomework13
{
    public int Homework13(IEnumerable<int> numbers)
    {
        
        int[] a = numbers.ToArray();
        string b = String.Join(" ", a.Select(p=>p.ToString()).ToArray());
        string c = $"{b[0]}{b[1]}{b[2]}{b[3]}{b[4]}{b[5]}";
        Console.WriteLine("Hello");
        var f = ($"{c[0]}" =="9" && $"{c[1]}" == "9");
        var g = ($"{c[0]}" !="9" && $"{c[1]}" == "9" && $"{c[2]}" == "9");
        var h = ($"{c[0]}" !="9" && $"{c[1]}" == "9" && $"{c[2]}" == "9");
        var i = ($"{c[3]}" =="9" && $"{c[4]}" == "9");
        var j = ($"{c[4]}" =="9" && $"{c[5]}" == "9");
        if (f)
        {
            foreach (var item in c)
            {
                Console.Write(item);
            }
            var f1 = ($"{c[2]}" != "9");
            if (f1)
            {
               var f2_1 = ($"{c[3]}" != "9" && $"{c[4]}" == "9" && $"{c[5]}" == "9");
               var f2_2 = ($"{c[3]}" == "9" && $"{c[4]}" != "9" && $"{c[5]}" == "9");
               var f2_3 = ($"{c[3]}" == "9" && $"{c[4]}" == "9" && $"{c[5]}" != "9");
               var f2_4 = ($"{c[3]}" == "9" && $"{c[4]}" == "9" && $"{c[5]}" == "9");
               var f2_5 = ($"{c[3]}" == "9" && $"{c[4]}" != "9" && $"{c[5]}" != "9");
               var f2_6 = ($"{c[3]}" != "9" && $"{c[4]}" == "9" && $"{c[5]}" != "9");
               var f2_7 = ($"{c[3]}" != "9" && $"{c[4]}" != "9" && $"{c[5]}" == "9");
               var f2_8 = ($"{c[3]}" == "9" && $"{c[4]}" != "9" && $"{c[5]}" == "9");
                if (f2_4 || f2_5 || f2_6 || f2_7 || f2_8)
                {
                    foreach (var item in c)
                    {
                        Console.Write(item);
                    }
                }else if(f2_1 || f2_2 || f2_3)
                {
                    Console.WriteLine("NO!!!");
                }
            }

        }else if (g)
        {
            var g1 = ($"{c[0]}" != "9" && $"{c[3]}" != "9");
            if (g1)
            {
                var g1_1 = ($"{c[4]}" != "9" && $"{c[5]}" == "9");
                var g1_2 = ($"{c[4]}" == "9" && $"{c[5]}" != "9");
                var g1_3 = ($"{c[4]}" == "9" && $"{c[5]}" == "9");
                if (g1_1 || g1_2)
                {
                    foreach (var item in c)
                    {
                        Console.Write(item);
                    }
                } else if(g1_3)
                {
                    Console.WriteLine("ม่ายยยยย!!!");
                }
            }
        }else if(h)
        {
            var h1 = ($"{c[1]}" != "9" && $"{c[4]}" != "9");
            if (h1)
            {
                // var h1_1 = ();
            }
        }

        
        /* */
    return 0;
    }
}
