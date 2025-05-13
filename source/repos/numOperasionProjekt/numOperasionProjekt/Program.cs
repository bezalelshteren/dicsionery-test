using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numOperasionProjekt
{
    internal class Program
    {

    
        static List<int> getThenumber(int[] args)
        {
            if (args.Length == 0)
            {
                getNumberBycw();
            }
            return args;
        }
    



        //ממיר לרשימה של מספרים
        
        static List<int> chaingToNumList()
        {
            
            List<string> numbersList = new List<string>(getNumberBycw().Split(' '));
            List<int> isnumbers = new List<int>();
            foreach (string number in numbersList)
            {
                isnumbers.Add(int.Parse(number));
            }
            return isnumbers;
        }


        //a
        static string getNumberBycw()
        {
            string numbersList;
            do
            {
                Console.WriteLine("enter numbers");
                numbersList = Console.ReadLine();
            }
            while (numbersList.Length > 3);
            
            return numbersList;
        }


        //b

        static void printOrder(int[] number)
        {
            foreach (int num in number) {
                Console.WriteLine(num);
            }
        }



        //c
        static void printRevers(int[] number)
        {
            int pointer = number.Length;
            while (pointer > 0) {
                Console.WriteLine(number[pointer]);
                pointer--;
            }
        }





        //d 

        static void printSorted(List<int> number)
        {
            List<int> numberTosorted = number;
                        for (int i = 0; i < numberTosorted.Count; i++)
            {
                for (j = 0; j < numberTosorted.Count - 1; j++)
                {
                    if (numberTosorted[j] > numberTosorted[j + 1])
                    {
                        numberTosorted[numberTosorted.Count - 1] = numberTosorted[j];
                                    j++;
                            }
                }
                Console.WriteLine(numberTosorted);
              }



            //e
            static void printMax(List<int> number2)
            {
                int theMex = 0;
                foreach (int num in number2)
                {
                    if (num > theMex)
                    {
                        theMex = num;
                    }
                }
                Console.WriteLine(theMex);
            }            

            //f

            static void printMin(List<int> number2) {

                int theMin = 0;
                foreach (int num in number2)
                {
                    if (num < theMin)
                    {
                        theMin = num;
                    }
                }
                Console.WriteLine(theMin);
            }

            //g

            static void printAverage(List<int> number3, int sum)
            {
                int len = number3.Count;
                int average = sum / len;
                Console.WriteLine(average);
            }

        //h

            static void printLen(int[] number)
            {

            }


        //i


        static int printSum(int[] number)
            {
                int sum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    sum += number[i];
                }
                Console.WriteLine(sum);
                return sum;
            }
            




            static int deccide()
            {
                console.WriteLine("enter your choise between 1-8 !!")
                    int choise = Convert.ToInt32(Console.ReadLine())
                    return choise;
            }
                    //main

                    static void maneger()
                    {
                chaingToNumList();
                
                deccide();
                do
                {
                    switch (decisen)
                    {
                        case 1:
                            printOrder();
                            break;
                        case 2:
                            printRevers();
                            break;
                        case 3:
                            printSorted();
                            break;
                        case 4:
                            printMax();
                            break;
                        case 5:
                            printMin();
                            break;
                        case 6:
                            printAverage();
                            break;
                        case 7:
                            printLen();
                            break;
                        case 8:
                            printSum();
                            break;


                    }
                    while (deccide != 8)}


                    static void Main(string[] args)
        {
                   maneger();
        }
    }
}
