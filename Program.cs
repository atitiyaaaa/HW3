using System;

class LegendaryMatrix
{
    static void Main()
    {
        bool isValidOperation = false;
        string operation;

        do
        {
            operation = Console.ReadLine();

            if (operation == "+" || operation == "-")
            {
                isValidOperation = true;
            }
            else
            {
            }
        } while (!isValidOperation);

        int rows = int.Parse(Console.ReadLine());

        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = ReadMatrix(rows, columns);
        int[,] matrix2 = ReadMatrix(rows, columns);

        int[,] resultMatrix = PerformOperation(matrix1, matrix2, operation);

        PrintMatrix(resultMatrix);

        // Loop the program
        Main();
    }

    static int[,] ReadMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] elements = Console.ReadLine().Split(' ');

            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(elements[j]);
            }
        }

        return matrix;
    }

    static int[,] PerformOperation(int[,] matrix1, int[,] matrix2, string operation)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] resultMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (operation == "+")
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
                else if (operation == "-")
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
