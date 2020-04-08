using System;
using System.Linq;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            if (InputValidation.EntryParameter(args))
                return;

            var array = SplitArray(args);

            int arrayRowsA = Convert.ToInt32(array[0]);
            int arrayColumnsA = Convert.ToInt32(array[1]);
            int arrayRowsB = Convert.ToInt32(array[2]);
            int arrayColumnsB = Convert.ToInt32(array[3]);

            int[,] matrixA = new int[arrayRowsA, arrayColumnsA];
            int[,] matrixB = new int[arrayRowsB, arrayColumnsB];

            var firstMatrix = FillMatrix(matrixA, arrayRowsA, arrayColumnsA);
            var secondMatrix = FillMatrix(matrixB, arrayRowsB, arrayColumnsB);

            var operatorMath = args[0];

            var finalMatrix = Calculate(firstMatrix, secondMatrix, operatorMath);
            Presentation(finalMatrix);
        }

        private static string[] SplitArray(string[] args)
        {
            char[] separator = { '(', ')', ',', '(', ')', ',' };
            int count = 6;

            return args[1].Split(separator, count, StringSplitOptions.RemoveEmptyEntries);
        }

        private static int[,] FillMatrix(int[,] matrix, int arrayRows, int arrayColumns)
        {
            int count = 1;

            for (int row = 0; row < arrayRows; row++)
            {
                for (int column = 0; column < arrayColumns; column++)
                {
                    matrix[row, column] = count++;
                }
            }

            return matrix;
        }

        private static decimal[,] Calculate(int[,] a, int[,] b, string mathOperation)
        {
            var operation = OperatorFactory.GetFuncByType(mathOperation);

            decimal[,] result = new decimal[a.Rank, a.Rank];
            for (int i = 0; i < a.Rank; i++)
                for (int j = 0; j < a.Rank; j++)
                    result[i, j] = operation(a[i, j], b[i, j]);

            return result;
        }

        private static void Presentation(decimal[,] a)
        {
            for (int i = 0; i < a.Rank; i++)
            {
                for (int j = 0; j < a.Rank; j++)
                    Console.WriteLine($"Resultado da Operação: {a[i, j]}");
                Console.WriteLine("-------------------------");
                Console.WriteLine();
            }

        }

        #region .: Notas :.

        //Criar um programa que receba um valor base e a quatidade de operações da seguinte forma
        //Cacula-Matriz --expressao multiplicacao --primeira((1,2),(2,1)) --segunda((1,2),(2,1))

        //Conteudo do Bate
        //dotnet C:\projects\mentoria\paulo\appsettings\ConsoleApp1\ConsoleApp1\bin\Debug\netcoreapp2.2\ConsoleApp1.dll %1 %2
        //Comando do Power Shell
        //Set-Alias -Name Print-Name -Value C:\projects\mentoria\paulo\appsettings\ConsoleApp1\ConsoleApp1\bin\Debug\netcoreapp2.2\run.bat

        //multiplicacao
        //divisao
        //subtracao
        //adicao
        //potencializacao
        //raiz

        #endregion
    }
}

