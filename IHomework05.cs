using System;


   public class Name : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            Console.WriteLine(ledNo);
            int x = 0;
            string b = null;
            string[] d = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            string e = (" 1  2  3  4  5  6  7  8  9  A");
        
          //  foreach (var item in d)
          //  {
          //      System.Console.WriteLine(item);
          //  }
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);
                while( x < 10 )
                {
                string input = Console.ReadLine();
                switch(input) 
                {
                case "1":
                     if(input == b ){
                        d[0]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                        d[0]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);       
                        Console.WriteLine(e);          
                        b = "1";
                    }
                    break;
                case "2":
                     if(input == b ){
                        d[1]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                        d[1]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "2";
                    }
                    break;
                case "3":
                     if(input == b ){
                       d[2]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                       d[2]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "3";
                    }
                    break;
                case "4":
                     if(input == b ){
                       d[3]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                       d[3]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "4";
                    }
                    break;
                case "5":
                     if(input == b ){
                       d[4]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                       d[4]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "5";
                    }
                    break;
                case "6":
                     if(input == b ){
                       d[5]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                       d[5]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "6";
                    }
                    break;
                case "7":
                     if(input == b ){
                       d[6]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                       d[6]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "7";
                    }
                    break;
                case "8":
                     if(input == b ){
                       d[7]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                       d[7]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "8";
                    }
                    break;
                case "9":
                     if(input == b ){
                       d[8]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                        d[8]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "9";
                    }
                    break;
                case "A":
                     if(input == b ){
                       d[9]="[ ]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = null;
                    }
                    else
                    { 
                       d[9]="[!]";
                        Console.WriteLine(d[0]+d[1]+d[2]+d[3]+d[4]+d[5]+d[6]+d[7]+d[8]+d[9]);
                        Console.WriteLine(e);                
                        b = "A";
                    }
                    break;
                default:

                    break;
                    }
                }
            return ledNo;
        }

        public void Main1()
        {

           
        }

    }

   

