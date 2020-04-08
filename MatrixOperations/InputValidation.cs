using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixOperations
{
    public static class InputValidation
    {

        public static bool EntryParameter(string[] arguments)
        {
            if (arguments.Length == 0)
            {
                Console.WriteLine("Nenhum parâmetro foi informado!");
                return true;
            }

            //int num;
            //bool firstArray = int.TryParse(arguments[1], out num);
            //bool secondtArray = int.TryParse(arguments[2], out num);
            //if (!firstArray)
            //{
            //    Console.WriteLine("Primeiro conjunto de array inválido!");
            //    return true;
            //}
            //if (!secondtArray)
            //{
            //    Console.WriteLine("Primeiro conjunto de array inválido!");
            //    return true;
            //}

            return false;
        }
    }
}
