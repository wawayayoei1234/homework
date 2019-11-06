public class homewark : IHomework05
    {
        public static string[] d = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };string sum = null;
        public string DisplayLEDOnScreen(string ledNo)
        {   //  h8j90hj8k90hj89h8h890jkgjjjqweertyuiio[]]\\
            int numled = int.Parse(ledNo);
            numled--;
            if(d[numled]=="[ ]")
            {
             d[numled] = "[!]";
            }
            else
            {
                d[numled]="[ ]";
            }
            foreach (string item in d)
            sum+=item;
            return sum;   
        }
    }   