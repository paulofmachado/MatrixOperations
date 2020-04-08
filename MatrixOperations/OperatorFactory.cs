using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixOperations
{
    public static class OperatorFactory
    {
        static OperatorFactory()
        {
            _operations.Add("+", Sum);
            _operations.Add("-", (first,second) => first - second);
        }
        
        public static Func<int, int, decimal> GetFuncByType(string operationType)
            => _operations.GetValueOrDefault(operationType);

        private static Dictionary<string, Func<int, int, decimal>> _operations
            = new Dictionary<string, Func<int, int, decimal>>();
        
        private static decimal Sum(int first, int second)
            => first + second;

    }
}
