using System;
using System.Collections.Generic;

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

            //int[,] finalMatrix = Addition(firstMatrix, secondMatrix);
            int[,] finalMatrix = Calculate(firstMatrix, secondMatrix, MathOperations.addition);

            Presentation(finalMatrix);
        }


        private static int[,] Calculate(int[,] a, int[,] b, string mathOperation)
        {
            int[,] result = new int[a.Rank, a.Rank];
            for (int i = 0; i < a.Rank; i++)
                for (int j = 0; j < a.Rank; j++)
                    result[i, j] = a[i, j] / b[i, j];

            return result;
        }





        //private static int[,] Addition(int[,] a, int[,] b)
        //{
        //    int[,] result = new int[a.Rank, a.Rank];
        //    for (int i = 0; i < a.Rank; i++)
        //        for (int j = 0; j < a.Rank; j++)
        //            result[i, j] = a[i, j] + b[i, j];
        //    return result;
        //}

        private static void Presentation(int[,] a)
        {
            for (int i = 0; i < a.Rank; i++)
            {
                for (int j = 0; j < a.Rank; j++)
                    Console.WriteLine($"Resultado da Operação: {a[i, j]}");
                Console.WriteLine("-------------------------");
                Console.WriteLine();
            }

        }

        public static class MathOperations
        {
            public const string addition = "+";
            public const string subtraction = "-";
            public const string multiplication = "*";
            public const string division = "/";


        }

        Dictionary<string, string> My_dict2 = new Dictionary<string, string>(){
                                  {"a.1", "Dog"},
                                  {"a.2", "Cat"},
                                {"a.3", "Pig"}
        };


        //Dictionary<string, string> My_dict2 = new Dictionary<string, string>(){
        //                          {"a.1", "Dog"},
        //                          {"a.2", "Cat"},
        //                        {"a.3", "Pig"}
        //};


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

