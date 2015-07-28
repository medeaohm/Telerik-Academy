/*
## Task 2. Compare simple Maths
*	Write a program to `compare the performance` of:
	*	**add**, **subtract**, **increment**, **multiply**, **divide**
*	for the values:
	*	`int`, `long`, `float`, `double` and `decimal`
*/
namespace MathsOperationsTest
{
    internal class MathOperationsTest
    {
        internal static void Main()
        {
            OperationPerformanceTester.TestPerformance(Operation.Addition);
            OperationPerformanceTester.TestPerformance(Operation.Substraction);
            OperationPerformanceTester.TestPerformance(Operation.Multiplication);
            OperationPerformanceTester.TestPerformance(Operation.Division);
        }
    }
}
