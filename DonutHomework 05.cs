using System;

namespace DonutHomework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            String[] f = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", };
            String n = (" 1  2  3  4  5  6  7  8  9  A");
            var k = "[ ]";
            var e = "[!]";




            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
            Console.WriteLine(n);
            Console.WriteLine("Please choose LED to turn On/Off:");



            while (a < 10)
            {
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":

                        if (f[0] == k)
                        {
                            f[0] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[0] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "2":

                        if (f[1] == k)
                        {
                            f[1] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[1] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "3":

                        if (f[2] == k)
                        {
                            f[2] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[2] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "4":

                        if (f[3] == k)
                        {
                            f[3] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[3] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "5":

                        if (f[4] == k)
                        {
                            f[4] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[4] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "6":

                        if (f[5] == k)
                        {
                            f[1] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[5] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "7":

                        if (f[6] == k)
                        {
                            f[6] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[6] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "8":

                        if (f[7] == k)
                        {
                            f[7] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[7] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);


                            break;
                        }
                    case "9":

                        if (f[8] == k)
                        {
                            f[8] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[8] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "A":

                        if (f[9] == k)
                        {
                            f[9] = e;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[9] = k;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }

                }
            }
        }
    }
}

