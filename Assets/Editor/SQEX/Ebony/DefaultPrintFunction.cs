using System;

namespace SQEX.Ebony.Std
{
    public static class DefaultPrintFunction
    {
        private static Action<string> defaultPrintFunction;

        public static void SetDefaultPrintFunction(Action<string> printFunction)
        {
            defaultPrintFunction = printFunction;
        }

        public static void Write(string message)
        {
            defaultPrintFunction(message);
        }
    }
}
