using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numOperasionProjekt
{
    internal class Program
    {
        /*
    
        static string getThenumber(string args)
        {
            string liyt = " ";
            if (args.Length == 0)
            {
                liyt =  getNumberBycw();
                return liyt;
            }
            
            else
            {
                return args;
            }
        }

    



        //ממיר לרשימה של מספרים
        
        static List<int> chaingToNumList()
        {
            
            List<string> numbersList = new List<string>(getThenumber().Split(' '));
            List<int> isnumbers = new List<int>();
            foreach (string number in numbersList)
            {
                isnumbers.Add(int.Parse(number));
            }
            return isnumbers;
        }


        //a
        //אם לא מתקבל מהcmd אז מקבל מהמשתמש


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

        */
        //b

        static void printOrder(List<int> number)
        {
            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
        }




        //c
        static void printRevers(List<int> number)
        {
            int pointer = number.Count-1;
            while (pointer >= 0)
            {
                Console.WriteLine(number[pointer]);
                pointer--;
            }
        }




        
        //d 

        static void printSorted(List<int> number)
        {
            List<int> sorted = new List<int>();
            List<int> numberTosorted = number;
            for (int i = 0; i < numberTosorted.Count; i++)
            {
                for (int j = 0; j < numberTosorted.Count; j++)
                {
                    if (numberTosorted[i] < numberTosorted[j])
                    {
                        sorted.Add(numberTosorted[j]);
                    }
                }
            }
            for (int l = 0; l < sorted.Count; l++)
            {
                Console.WriteLine(sorted[l]);
            }
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

                int theMin = number2[0];
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
                
                double len = Convert.ToDouble(number3.Count);
                double average = sum / len;
                Console.WriteLine(average);
            }

        //h

            static void printLen(List<int> number5)
            {
                int counter = 0;
                for (int i = 0; i < number5.Count; i++)
                {
                    counter = i;
                }
                Console.WriteLine(counter);
            }


        //i


        static int printSum(List<int> number9)
            {
                int sum = 0;
                for (int i = 0; i < number9.Count; i++)
                {
                    sum += number9[i];
                }
                Console.WriteLine(sum);
                return sum;
            }
            

        /*


            static int deccide()
            {
                Console.WriteLine("enter your choise between 1-8 !!");
                int choise = Convert.ToInt32(Console.ReadLine());
                    return choise;
            }


        //main





        static void maneger()
        {

            List<int> number6 = chaingToNumList();

            int deccided = deccide();
            do
            {
                switch (deccided)
                {
                    case 1:
                        printOrder(number6);
                        break;
                    case 2:
                        printRevers(number6);
                        break;
                    case 3:
                        printSorted(number6);
                        break;
                    case 4:
                        printMax(number6);
                        break;
                    case 5:
                        printMin(number6);
                        break;
                    case 6:
                        printAverage(number6, printSum());
                        break;
                    case 7:
                        printLen(number6);
                        break;
                    case 8:
                        printSum(number6);
                        break;

}
                }
                while (deccided != 8) ;
            } 






        



        */
        //static List<int> lisr = new List<int> { 12, 23, 56, 99, 78 };


        static void Main(string[] args)
        {
            List<int> lisr = new List<int> {56,95, 12, 23, 56, 99, 78 };
            /*
            printMin( lisr);
            printMax( lisr);
            printLen( lisr);
            printAverage(lisr, printSum(lisr));
            printOrder(lisr);
            printSum(lisr);
            printRevers(lisr);
            */
            printSorted(lisr);
            //maneger();
        }
    }
}
