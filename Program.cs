using System;


/**
 * Author: Sean Cui
 * Prediction of Missing Values Algorithms:
 * 1.FillingGlobalConstant();
 * 
 * 4.FillingbyDeletingMissingValue_Algo4()
 * 
 * 
 * This programn will ask users to enter a  number 
 * to be a global number in oder to fill up the empty 
 * spots in data table.
 * The input will be checked if it is a number or not.
 * (perfered double type.)
 * 
 * deleteBlank class is to delete empty elements in the array.
 */

namespace fillingMissingData
{
    class Program
    {
        public static double globalCon = 1.0;

        // below declarations are only for testing purpose
        public static String[] OpenP = { "1","", "2", "","3","4" };

        public static string[] newArr;
        static void Main(string[] args)
        {
            
           // GetConstant(ref globalCon);
            Console.WriteLine(globalCon);

            string para = Convert.ToString(globalCon);
            
            fillingGlobalConstant fill = new fillingGlobalConstant();

            //fill.fillBlank(para, OpenP);

            deleteBlank del = new deleteBlank();
            del.deletingMissing(OpenP);

            newArr = (string[])del.deletingMissing(OpenP).Clone();
            Console.WriteLine("new array's length is : "+ newArr.Length);
           

            foreach (string index in newArr)
            {
                Console.WriteLine(index);
            }
            Console.ReadLine();
        }

        static double GetConstant(ref double input)
        {
            Console.WriteLine("Please enter any number you would like to replace the blank spots: ");
            while(!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input, please type a number agian.");
            }

            return input;

        }


    }
}
