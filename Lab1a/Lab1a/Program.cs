using System;

namespace Lab1a
{
    class Program
    {

        static int[] Populate(int [] array) {
            for (int i = 0 ; i <  array.Length; i++) {
                Console.WriteLine("Please enter a number : " + i + " / " + array.Length);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array ;
           
        }

        static int GetSum(int[] array){
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
               sum += array[i];
            }
            return sum;

        }

        static int GetProduct(int[]array , int sum) {
            try
            {
                int num = 0;
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++) {

                   num  = Convert.ToInt32(rnd.Next(1,array.Length));
                   
                 
                }
                Console.WriteLine("RAN NUM     " + num);

                // Console.WriteLine("HELLO" + Console.ReadLine());
                int product = num * sum;
               // Console.WriteLine(num + " * " + sum + " = " + product);
                return product;
               
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine(e.Message);
                throw new ArgumentException("Index out of range");
            }
        }

        static double GetQuotient(int product) {
            try
            {
                Console.WriteLine("Enter a number to divide your product " + product + " by");
                double num = Convert.ToInt32(Console.ReadLine());
                double qoutient = product / num;
                return qoutient;
                //Console.WriteLine(product + " / " + num + " = " + qoutient);
                
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;

            }
           


        }



        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a number greater than zero");
                int num = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[num];
                Populate(array);
                GetSum(array);
                Console.WriteLine("Your array size is : " + array.Length);
                Console.Write("The numbers in the array are : ");
                for (int i = 0; i < array.Length; i++) {
                    Console.Write(array[i] + " , ");
                }
                Console.WriteLine();
                Console.WriteLine("The sum of the array is : " + GetSum(array));
                Console.WriteLine("Product = " + GetProduct(array, GetSum(array)));
                Console.WriteLine("Quotient = " + GetQuotient(num * GetSum(array)));







            }

            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e) {
                Console.WriteLine(e.Message);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game ! Let's do some math");
            try { StartSequence();}
            catch { Console.WriteLine("Please check what you do , there is an error"); }
            finally { Console.WriteLine("Program Completed .."); }
        }
    }
}
