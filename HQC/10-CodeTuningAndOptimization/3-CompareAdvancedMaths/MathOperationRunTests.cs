/*
## Task 2. Compare simple Maths
*	Write a program to `compare the performance` of:
	*	**add**, **subtract**, **increment**, **multiply**, **divide**
*	for the values:
	*	`int`, `long`, `float`, `double` and `decimal`
*/
namespace MathsFunctionsTest
{
    internal class MathFunctionsTest
    {
        internal static void Main()
        {
            MathFunctionPerformanceTester.TestPerformance(MathFunction.SquareRoot);
            MathFunctionPerformanceTester.TestPerformance(MathFunction.Logarithm);
            MathFunctionPerformanceTester.TestPerformance(MathFunction.Sinus);
        }
    }
}
