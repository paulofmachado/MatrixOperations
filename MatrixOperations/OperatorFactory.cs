using System;
using System.Collections.Generic;

namespace MatrixOperations
{
    public static class OperatorFactory
    {
        static OperatorFactory()
        {
            _operations.Add("addition", (first, second) => first + second);
            _operations.Add("subtraction", (first, second) => first - second);
            _operations.Add("multiplication", (first, second) => first * second);
            _operations.Add("division", (first, second) => first / second);
            _operations.Add("-", (first, second) => first - second);
        }

        public static Func<int, int, decimal> GetFuncByType(string operationType)
            => _operations.GetValueOrDefault(operationType);

        private static Dictionary<string, Func<int, int, decimal>> _operations
            = new Dictionary<string, Func<int, int, decimal>>();
    }
}
