using System;
using matrix.lib;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                // dimension input
                Console.WriteLine("Welcome to matrix interface, Please enter dimension of matrix:\n");
                int dimension;
                while(true){
                    try{
                        dimension = Convert.ToInt32(Console.ReadLine()); 
                        break;
                    }
                    catch(Exception){
                        Console.WriteLine("Can't convert your input string please input the right number again:");
                    }
                }
                
                Matrix matrixA = new Matrix(dimension);
                Matrix matrixB = new Matrix(dimension);

                // matrix input
                Console.WriteLine("Please input matrix:\n");
                int[] inputArray = new int[matrixA.Length];
                for (int i = 0; i < matrixA.Length; i ++)
                {
                    while(true){
                        try{
                            inputArray[i] = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch(Exception){
                            Console.WriteLine("Can't convert your input string please input the right number again:");
                        }
                    }
                }
                matrixA.Add(inputArray);
                matrixB.Add(inputArray);

                // show matrix and matrix transpose
                Console.WriteLine("Your matrix input is:\n" );
                Console.WriteLine(matrixA);
                Console.WriteLine("Your matrix transpose output is:\n" );
                matrixB.Transpose();
                Console.WriteLine(matrixB);

                // show matrix multiply output;
                Matrix matrixOutput = matrixA.Multiply(matrixB);
                Console.WriteLine("Your matrix multiply matrix transpose output is: \n");
                Console.WriteLine(matrixOutput);
            }
        }
    }

    
}
