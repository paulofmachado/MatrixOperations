using System;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = new int[2, 2];
            int[,] secondMatrix = new int[2, 2];

            firstMatrix[0, 0] = 1;
            firstMatrix[0, 1] = 2;
            firstMatrix[1, 0] = 3;
            firstMatrix[1, 1] = 4;

            secondMatrix[0, 0] = 1;
            secondMatrix[0, 1] = 2;
            secondMatrix[1, 0] = 3;
            secondMatrix[1, 1] = 4;

            var finalMatrix = Calculate(firstMatrix, secondMatrix, "addition");
            Presentation(finalMatrix);
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

