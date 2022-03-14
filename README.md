# Lab01-a

# THE CODE :

```

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

```

---

## What is the purpose of the program ?

1. **It's a math game , like the user fill an array , then the program show the user , the array size and elements of the array and sum of elements .**
2. **There is GetProduct method , in this method , a random number will be generated between 1 and array length , then multiply it by the sum of elements in array .**
3. **There is GetQuotient method , in this method , we divide the product returned from GetProduct by a number from user .**

---

## How do I run the program?

1. **The program will ask the user to enter a number , this number will be the array size , then it will ask to enter the elements of the array , like if the number was 5 , then the program will ask the user 5 times to enter 5 values for array elements**

2. **apply GetProduct logic (Explained above)**

3. **apply GetQuotient logic (Explained above)**

---

## What does the program look like? (visual)

![IMG](/assets/Visual.PNG)

---





