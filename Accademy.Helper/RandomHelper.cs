using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class Helper
    {
        /// <summary>
        /// Get a random value in a range
        /// </summary>
        /// <param name="min">min range value</param>
        /// <param name="max">max range value</param>
        /// <exception cref="Accademy.Helper.RandomArgumentsException">Thrown when min value is greater then max value</exception>
        /// <returns>random int in a range</returns>
        public static int GetRandomInt(int min, int max)
        {
            if (min > max)
            {
                throw new RandomArgumentsException();
            }
            else
            {
                int seed = Guid.NewGuid().GetHashCode();
                Random r = new Random(seed);
                //Random r = new Random();
                return r.Next(min, max);
            }
           
        }
        public static int GetSameInt(int sameint)
        {
            return sameint;
        }

        public static String CheckElementsArray(int[] array, int length)
        {
            String s1 = "All elements are equal";
            String s2 = "Not all elements are equal"; 
            int i= 0;
            while(  i<length && array[0] == array[i])
            {
              
                i++;
              //  System.Console.WriteLine(array[i]);

            }
            System.Console.WriteLine(i);
           
            if (i == 10) return s1;
            else return s2;
        }

        public static int ConvertBinarytoInt(string s)
        { int val=0;
            char[] chararry = s.ToCharArray();
            for (int i = 0; i < chararry.Length; i++) System.Console.WriteLine(chararry[i]);
            int[] convarray = new int[10];
            for (int i = 0; i < chararry.Length; i++) {
                convarray[i] = Convert.ToInt32(chararry[i]);
                System.Console.WriteLine(chararry[i]);

            }
            for (int i = 0; i <chararry.Length ; i++)
            {
                convarray[i] = Convert.ToInt32(chararry[i]-48); System.Console.WriteLine(chararry[i]);
                val +=  convarray[i] * (int)System.Math.Pow(2 , 7-i) ;

            }

            return val;
        }
        public static bool CheckElementsArrayDifferent(int[] array)
        {
            int length;
            length =array.Length ;
            for (int i = 0; i < length; i++) {
                System.Console.WriteLine(array[i]);
            }

                for (int i=0; i < length; i++)
            {   
                for(int j = i+1; j < length; j++) {
                    if (array[j] == array[i])
                    {   
                        return false;
                      
                    }
                }
            }
            return true ;
           
        }

    }
}
