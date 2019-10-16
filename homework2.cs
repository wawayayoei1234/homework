using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int raw = 0;
            string sum = null;

            int[] number = {0,0,0,0,0,0};
             
           for(int i = 1;i <=999999 ;i++ ){
               
               //string sum = null;
               if(i<=999999){
                    number[5]++;
                                       
                    
                    if(number[5]==10){
                        number[5]=0;
                        number[4]++;
                        if(number[4]==10)
                        {
                            number[4]=0;
                            number[3]++;
                            if(number[3]==10)
                            {
                                number[3]=0;
                                number[2]++;
                                if(number[2]==10)
                                {
                                    number[2]=0;
                                    number[1]++;
                                    if(number[1]==10)
                                    {
                                        number[1]=0;
                                        number[0]++;
                                        
                                    }
                                }

                            }
                        }
                    }
                        if(number[5]+number[4] ==18)
                        {
                            if(number[3] !=9)
                            {
                                if(number[0]+number[1]+number[2] != 27)
                                {
                                foreach(var item in number)
                                sum+=item;
                                Console.WriteLine(sum);
                                sum = null;
                                }
                              
                            }
                        }
                        else if(number[4]+number[3]==18)
                        {

                            if(number[5] != 9 && number[3] != 9)
                            {
                             foreach(var item in number)
                              sum+=item;
                            
                               Console.WriteLine(sum);
                               sum = null;
                            }
                        }
                        else if(number[3]+number[2]==18)
                        {
                            if(number[4] != 9 && number[1] != 9)
                            {
                            foreach(var item in number)
                              sum+=item;
                            
                               Console.WriteLine(sum);
                               sum = null;
                            }
                        }
                        else if(number[2]+number[1]==18)
                        {
                            if(number[3] != 9 && number[0] != 9)
                            {
                            foreach(var item in number)
                              sum+=item;
                            
                               Console.WriteLine(sum);
                               sum = null;
                            }
                        }
                        else if(number[1]+number[0]==18)
                        {
                            if(number[2] != 9 )
                            { 
                                if(number[5]+number[4]+number[3] != 27)
                                {
                                foreach(var item in number)
                                sum+=item;
                                Console.WriteLine(sum);
                                sum = null;
                                }
                        }
                    }
        
                }
                //foreach (int item in number)
                //sum += item;
                //System.Console.WriteLine(sum);
      
            }
            Console.WriteLine(raw);           
        }
    }
}

