using System;

    class homewark : IHomework05
        {
        public string DisplayLEDOnScreen(string ledNo)
        {
            int U = 0;

            String[] f = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", };
            String n = (" 1  2  3  4  5  6  7  8  9  A");
            var M = "[ ]";
            var R = "[!]";




            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
            Console.WriteLine(n);
            Console.WriteLine("Please choose LED to turn On/Off:");



            while (U < 10)
            {
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":

                        if (f[0] == M)
                        {
                            f[0] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[0] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "2":

                        if (f[1] == M)
                        {
                            f[1] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[1] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "3":

                        if (f[2] == M)
                        {
                            f[2] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[2] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "4":

                        if (f[3] == M)
                        {
                            f[3] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[3] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "5":

                        if (f[4] == M)
                        {
                            f[4] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[4] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "6":

                        if (f[5] == M)
                        {
                            f[1] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[5] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "7":

                        if (f[6] == M)
                        {
                            f[6] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[6] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                    case "8":

                        if (f[7] == M)
                        {
                            f[7] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[7] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);


                            break;
                        }
                    case "9":

                        if (f[8] == M)
                        {
                            f[8] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[8] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;

                        }
                    case "A":

                        if (f[9] == M)
                        {
                            f[9] = R;
                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]);
                            Console.WriteLine(n);

                            break;
                        }
                        else
                        {
                            f[9] = M;

                            Console.WriteLine(f[0] + f[1] + f[2] + f[3] + f[4] + f[5] + f[6] + f[7] + f[8] + f[9]); ;
                            Console.WriteLine(n);

                            break;
                        }
                }
            }
        return ledNo;
    }

    public string DisplayLEDonScreen(string ledNo) => throw new NotImplementedException();
}
public interface IHomework05

{
    string DisplayLEDonScreen(string ledNo);
}