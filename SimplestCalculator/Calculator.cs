using System;
using System.Collections.Generic;
using System.Text;

namespace SimplestCalculator
{
    public interface ILoggerManager
    {
        void LogMessage(string message);

    }
    public class Calculator
    {
        private ILoggerManager _loggerManager { get; set; }

        public Calculator(ILoggerManager loggerManager)
        {
            _loggerManager = loggerManager;
        }

        public int? Add(string a1, string a2)
        {
            int b = int.Parse(a2);

           if (!int.TryParse(a1, out int a))
            {
                _loggerManager.LogMessage("ERROR during add operation: Argument is not an integer number");
                return null;
            }

           var result = a + b;

            _loggerManager.LogMessage("Add Result is " + result);

            return result;
        }

        public int? Substruct(string a1, string a2)
        {
            int b = int.Parse(a2);

           if (!int.TryParse(a1, out int a))
            {
                _loggerManager.LogMessage("ERROR during Substruct operation: Argument is not an integer number");
                return null;
            }

           var result = a - b;

            _loggerManager.LogMessage("Substruct Result is " + result);

            return result;
        }

        public int? Multiply(string a1, string a2)
        {
            int b = int.Parse(a2);

           if (!int.TryParse(a1, out int a))
            {
                _loggerManager.LogMessage("ERROR during Multiply operation: Argument is not an integer number");
                return null;
            }

           var result = a * b;

            _loggerManager.LogMessage("Multiply Result is " + result);

            return result;
        }

        public int? Divide(string a1, string a2)
        {
            int b = int.Parse(a2);

           if (!int.TryParse(a1, out int a))
            {
                _loggerManager.LogMessage("ERROR during Divide operation: Argument is not an integer number");
                return null;
            }

            var result = a / b;

            _loggerManager.LogMessage("Divide Result is " + result);

            return result;
        }
    }
}
