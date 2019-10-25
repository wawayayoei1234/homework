using System;
using System.Collections.Generic;
using System.Linq;

public interface IHomework13
{
    IEnumerable<int> Homework13(IEnumerable<int> numbers);
}
public class IHomework : IHomework13
{
    public IEnumerable<int> Homework13(IEnumerable<int> numbers)
    {
        var result = new List<int>();
        foreach(var item in numbers)
        {
            var ss = item.ToString();
            if(ss.Length == 5)
            {
                ss = "0" + ss;
            }
            else if(ss.Length == 4)
            {
                ss = "00" + ss;
            }
            else if(ss.Length == 3)
            {
                ss = "000" + ss;
            }
            else if(ss.Length == 2)
            {
                ss = "0000" + ss;
            }
            else if(ss.Length == 1)
            {
                ss = "00000" + ss;
            }
            var d_1 = (ss[0] == '9');
            var d_2 = (ss[0] != '9');
            var e_1 = (ss[1] == '9');
            var e_2 = (ss[1] != '9');
            var f_1 = (ss[2] == '9');
            var f_2 = (ss[2] != '9');
            var g_1 = (ss[3] == '9');
            var g_2 = (ss[3] != '9');
            var h_1 = (ss[4] == '9');
            var h_2 = (ss[4] != '9');
            var i_1 = (ss[5] == '9');
            var i_2 = (ss[5] != '9');
            /* */
            var hub1 = (d_1 && e_1 && f_2);
            var hub2 = (d_2 && e_1 && f_1 && g_2);
            var hub3 = (e_2 && f_1 && g_1 && h_2);
            var hub4 = (f_2 && g_1 && h_1 && i_2);
            var hub5 = (g_2 && h_1 && i_1);
            /*  */
            if(hub1)
            {
                var hub1_1 = (g_1 && h_1 && i_2);
                var hub1_2 = (g_2 && h_1 && i_1);
                if (hub1_1 || hub1_2)
                {

                }
                else
                {
                    result.Add(item);
                }
            }
            else if(hub2)
            {
                var hub2_1 = (h_1 && i_1);
                if (hub2_1)
                {

                }
                else
                {
                    result.Add(item);
                }
            }
            else if(hub3)
            {
                result.Add(item);

            }
            else if(hub4)
            {
                var hub4_1 = (d_1 && e_1);
                if (hub4_1)
                {

                }
                else
                {
                    result.Add(item);
                }
            }
            else if(hub5)
            {
                var hub5_1 = (d_1 && e_1 && f_2);
                var hub5_2 = (d_2 && e_1 && f_1);
                if (hub5_1 || hub5_2)
                {

                }
                else
                {
                    result.Add(item);
                }
            }
        }
        return result;
    }
}