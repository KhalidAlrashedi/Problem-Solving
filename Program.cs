using System;
/** Notes
* 1- 
* 2-
* 3-
**/
namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring & Initializing with defalut value of integer object. 
            int[] elms = new int[10];

            // Assign 1 and 2 to 1's & 2's indexes
            elms[0] = 1;
            elms[1] = 2;
            
            // call method to evaluate Even Fibonacci Theroy
            EvenFibonacci(elms);

            // Display the results
            for(int i = 0; i < 10; i++){
                Console.WriteLine(elms[i]);
            }

        }

        // Even Fibonacci method to find addition of two prevouis cells of array.
        public static void EvenFibonacci(int[] arr){
            for(int i = 2; i < 10; i++){
                arr[i] = arr[i-1] + arr[i-2];
            } // end loop
        }// End EvenFibonacci method
    } // End class
} // End namespace
