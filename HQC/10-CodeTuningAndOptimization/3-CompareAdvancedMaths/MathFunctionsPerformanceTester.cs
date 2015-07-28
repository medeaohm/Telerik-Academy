namespace MathsFunctionsTest
{
    using System;
    using System.Diagnostics;

    public static class MathFunctionPerformanceTester
    {
        private const float OperatingValueFloat = 100.0F;
        private const double OperatingValueDouble = 100.0;
        private const decimal OperatingValueDecimal = 100.0M;
        private const int RepeatFunctionsCount = 1000000;
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        static MathFunctionPerformanceTester()
        {
            Console.WriteLine("The program tests every operation 1M times with all variables set at value 1.");
        }

        public static void TestPerformance(MathFunction function)
        {
            Console.WriteLine("\n" + function);

            float resultFloat = OperatingValueFloat;
            Stopwatch.Start();

            for (int i = 0; i < RepeatFunctionsCount; i++)
            {
                switch (function)
                {
                    case MathFunction.SquareRoot:
                        resultFloat = (float)Math.Sqrt(OperatingValueFloat);
                        break;
                    case MathFunction.Logarithm:
                        resultFloat = (float)Math.Log(OperatingValueFloat);
                        break;
                    case MathFunction.Sinus:
                        resultFloat = (float)Math.Sin(OperatingValueFloat);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Float", Stopwatch.Elapsed);
            Stopwatch.Reset();

            double resultDouble = OperatingValueDouble;
            Stopwatch.Start();

            for (int i = 0; i < RepeatFunctionsCount; i++)
            {
                switch (function)
                {
                    case MathFunction.SquareRoot:
                        resultDouble = Math.Sqrt(OperatingValueDouble);
                        break;
                    case MathFunction.Logarithm:
                        resultDouble = Math.Log(OperatingValueDouble);
                        break;
                    case MathFunction.Sinus:
                        resultDouble = Math.Sin(OperatingValueDouble);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Double", Stopwatch.Elapsed);
            Stopwatch.Reset();

            decimal resultDecimal = OperatingValueDecimal;
            Stopwatch.Start();

            for (int i = 0; i < RepeatFunctionsCount; i++)
            {
                switch (function)
                {
                    case MathFunction.SquareRoot:
                        resultDecimal = (decimal)Math.Sqrt((double)OperatingValueDecimal);
                        break;
                    case MathFunction.Logarithm:
                        resultDecimal = (decimal)Math.Log((double)OperatingValueDecimal);
                        break;
                    case MathFunction.Sinus:
                        resultDecimal = (decimal)Math.Sin((double)OperatingValueDecimal);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            Stopwatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Decimal", Stopwatch.Elapsed);
            Stopwatch.Reset();
        }
    }
}
