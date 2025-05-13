using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numOperasionProjekt
{
    internal class Program
    {

    
        static int[] getThenumber(int[] args)
        {
            if Not(args)
            {
                getNumberBycw()
            }
        }



        //a
        static int getNumberBycw()
        {
            do {
            Console.WriteLine("enter numbers");
            int[] numbersList = Convert.Int32 (Console.ReadLine().Split(' '));
            while(numbersList.Length > 3 )
            return numbersList;
        }


        //b

        static void printOrder(int[] number)
        {
            foreach(int number in getThenumber(0))
                    Console.WriteLine(number);
        }



            //c
            static void printRevers(int[] number = [5,6,9,73,14,74])
            {
                int pointer = number.Length;
                while(pointer > 0) {
                    Console.WriteLine(number[pointer]);
                    pointer--;
            }





                //d 

                static int[] printSorted(int[] number)
                {
                    int [] numberTosorted =  number
                        for (int i = 0;i<numberTosorted.Length;i++) 
                             {
                        for ( j = 0; j < numberTosorted.Length-1; j++)
                        {
                            if (numberTosorted[j] > numberTosorted[j + 1])
                            {
                                numberTosorted[numberTosorted.Length -1] = numberTosorted[j]
                                    j++
                            }
                        }
                        Console.WriteLine(numberTosorted);
                        int[] MaxMin = numberTosorted[0]
                        MaxMin.add(numberTosorted[numberTosorted.Length-1]);
                        return numberTosorted;
                    }



                    //e
                    static void printMax(int[] numberToSorted) {
                        Console.WriteLine(numberTosorted[numberTosorted.Length - 1])
                            }

                    //f

                    static void printMin(int[] numberToSorted) {
                        Console.WriteLine(numberTosorted[0])
                            }

                    //g

                    static int printSum(int[] number)
                    {
                        int sum = 0;
                        for (int i = 0; i < point; i++)
                        {
                            sum += number[i];
                        }
                        
                        return sum;
                    }

                    //h



                    //i

                    
                    //j

                    static void printSum(int sum)
                    {
                        int salution = sum / point;
                        Console.WriteLine(salution);
                    }
                    //main

                    static void 


                    static void Main(string[] args)
        {
                   
        }
    }
}
