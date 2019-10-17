using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcom"+ ledNo);
            int x = 0;
            string[] d = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            int[] g = { 0,0,0,0,0,0,0,0,0,0};
            string e = (" 1  2  3  4  5  6  7  8  9  A");
            string sum = null;
                while( x < 10 )
                {
                     int b = 1;
                     string input = Console.ReadLine();
                     
                     switch(input) 
                {
                case "1":
                     if(g[0] == b ){
                        d[0]="[ ]";
                        foreach (string item in d)
                        sum += item;                       
                        System.Console.WriteLine(sum);
                        Console.WriteLine(e);                
                        g[0] = 0;
                          
                    }
                    else
                    { 
                        d[0]="[!]"; 
                        foreach (string item in d)
                        sum += item;
                        System.Console.WriteLine(sum);       
                        Console.WriteLine(e);          
                        g[0] = 1;
                        
                    }
                    break;
                    // case "2":
                    //  if(g[1] == b ){
                    //     d[1]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[1] = 0;
                       
                    // }
                    // else
                    // { 
                    //     d[1]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[1] = 1;
                        
                    // }
                    // break;
                    // case "3":
                    //  if(g[2] == b ){
                    //     d[2]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                       
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[2] = 0;
                      
                    // }
                    // else
                    // { 
                    //     d[2]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[2] = 1;
                       
                    // }
                    // break;
                    // case "4":
                    //  if(g[3] == b ){
                    //     d[3]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                      
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[3] = 0;
                        
                    // }
                    // else
                    // { 
                    //     d[3]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[3] = 1;
                        
                    // }
                    // break;
                    // case "5":
                    //  if(g[4] == b ){
                    //     d[4]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                        
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[4] = 0;
                        
                    // }
                    // else
                    // { 
                    //     d[4]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[4] = 1;
                        
                    // }
                    // break;
                    // case "6":
                    //  if(g[5] == b ){
                    //     d[5]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                 
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[5] = 0;
                      
                    // }
                    // else
                    // { 
                    //     d[5]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[5] = 1;
                      
                    // }
                    // break;
                    // case "7":
                    //  if(g[6] == b ){
                    //     d[6]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                       
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[6] = 0;
                     
                    // }
                    // else
                    // { 
                    //     d[6]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[6] = 1;
                        
                    // }
                    // break;
                    // case "8":
                    //  if(g[7] == b ){
                    //     d[7]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                      
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[7] = 0;
                      
                    // }
                    // else
                    // { 
                    //     d[7]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[7] = 1;
                     
                    // }
                    // break;
                    // case "9":
                    //  if(g[8] == b ){
                    //     d[8]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                       
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[8] = 0;
                        
                    // }
                    // else
                    // { 
                    //     d[8]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[8] = 1;
                        
                    // }
                    // break;
                    //  case "A":
                    //  if(g[9] == b ){
                    //     d[9]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                       
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[8] = 0;
                        
                    // }
                    // else
                    // { 
                    //     d[9]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[9] = 1;     
                    // }
                    // break;
                    // case "10":
                    //  if(g[9] == b ){
                    //     d[9]="[ ]";
                    //     foreach (string item in d)
                    //     sum += item;                       
                    //     System.Console.WriteLine(sum);
                    //     Console.WriteLine(e);                
                    //     g[8] = 0;
                        
                    // }
                    // else
                    // { 
                    //     d[9]="[!]"; 
                    //     foreach (string item in d)
                    //     sum += item;
                    //     System.Console.WriteLine(sum);       
                    //     Console.WriteLine(e);          
                    //     g[9] = 1;     
                    // }
                    // break;
                }
                    
                
            }
        }
    }
}
