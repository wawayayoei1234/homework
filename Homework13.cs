using System;
using System.Collections.Generic;
using System.Linq;
    
    
 class homework2 : IHomework13    
    {
    public int Homework13 (IEnumerable<int> numbers)
    {
    string sum = null;
    int[] array = numbers.ToArray();
    if(array[5]+array[4] ==18)
        {
            if(array[3] !=9)
            {
                if(array[0]+array[1]+array[2] != 27)
                {
                    foreach(var item in array)
                    sum+=item;
                    Console.WriteLine(sum);
                }                              
            }
        }
    else if(array[4]+array[3]==18)
        {
            if(array[5] != 9 && array[3] != 9)
            {
                foreach(var item in array)
                sum+=item;
                Console.WriteLine(sum);    
            }
        }
    else if(array[3]+array[2]==18)
        {
        if(array[4] != 9 && array[1] != 9)
            {
                foreach(var item in array)
                sum+=item;
                Console.WriteLine(sum);
            }
        }
    else if(array[2]+array[1]==18)
        {
            if(array[3] != 9 && array[0] != 9)
            {
                foreach(var item in array)
                sum+=item;                            
                Console.WriteLine(sum);                           
            }
        }
    else if(array[1]+array[0]==18)
        {
            if(array[2] != 9 )
            { 
                if(array[5]+array[4]+array[3] != 27)
                {
                    foreach(var item in array)
                    sum+=item;
                    Console.WriteLine(sum);
                }
            }
        }
        return 10;
        }
    }
    public interface IHomework13
    {
    int Homework13(IEnumerable<int> numbers);
    
}
