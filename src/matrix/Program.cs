using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // dimension input
            Console.WriteLine("Welcome to matrix interface, Please enter dimension of matrix:\n");
            int dimension = Convert.ToInt32(Console.ReadLine());
            Matrix matrixA = new Matrix(dimension);
            Matrix matrixB = new Matrix(dimension);

            // matrix input
            Console.WriteLine("Please input matrix:\n");
            int[] inputArray = new int[matrixA.Length];
            for (int i = 0; i < matrixA.Length; i ++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
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

    class Matrix
    {
        int Row;
        int[,] matrix;

        public Matrix(int dimension)
        {
            Row = dimension;
            matrix =new int[Row,Row];
        }
        
        public int Length
        {
            get
            {
                return Row * Row;
            }
        }

        public int[,] Array
        {
            get
            {
                return matrix;
            }
        }

        public int Dimension
        {
            get 
            {
                return Row;
            }
        }

        public void Add(int[] args)
        {
            // check args length;
            if (args.Length > Length)
            {
                throw new ArgumentException("Input length is bigger than Matrix length.");
            }
            else
            {
                // add args to matrix array
                for(int i = 0;i < args.Length; i++)
                {
                    int row = i / Row;
                    int col = i % Row;
                    matrix[row,col] = args[i];
                }
            }
        }

        public void Transpose()
        {
            // transpose self matrix
            for (int row = 0; row < Row; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    int tmp = matrix[row,col];
                    matrix[row,col] = matrix[col,row];
                    matrix[col,row] = tmp;
                }
            }
        }

        public Matrix Multiply(Matrix matrixB)
        {
            // calculate multiply another Matrix
            if (matrixB.Dimension != Dimension)
            {
                throw new ArgumentException("Two matrix Row is different, please check again!");

            }
            else
            {
                Matrix matrixResult = new Matrix(Dimension);
                int[] matrixArray = new int[Length];

                for (int i = 0; i < Length; i++)
                {
                    int sum = 0;
                    for(int col = 0; col < Row; col++)
                    {
                        sum = sum + matrix[i/Row,col] * matrixB.Array[col,i%Row];
                    }
                    matrixArray[i] = sum;
                }
                matrixResult.Add(matrixArray);
                return matrixResult;
            }
        }

        public override string ToString()
        {
            string stringArray = "";
            for (int row = 0; row < Row; row++)
            {
                for (int col = 0; col < Row; col++)
                {
                    stringArray = stringArray + matrix[row,col].ToString() + " ";
                    // enter a line when row = Row
                    if (col + 1 == Row)
                    {
                        stringArray = stringArray + "\n";
                    }
                }
            }
            return stringArray;
        }
    }
}
