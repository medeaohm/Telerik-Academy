## Data Structures, Algorithms and Complexity Homework

1. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
 - The firts loop will execute n times. The second loop will execute n times. So, the program will execute in n*n steps -> O(n<sup>2</sup>)
 
2. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
 - The firts loop will execute n times. 
 - The second loop will execute only if the matrix element is even. We have 3 different possibilities:
	 - Best case: All the matrix elements are odds - the second loop will never execute ->  the program will execute in n steps -> O(n)
	 - Worst case: All the matrix elements are even - the second loop will execute m times ->  the program will execute in n*m steps -> O(n*m)
	 - Average case: Half of the matrix elements are even - the second loop will execute m/2 times ->  the program will execute in n*m/2 steps -> O(n*m)
	
3. (*) What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```

 - Firts of all , we have to change the conditions - we should have col < matrix.GetLength(1) and row < matrix.GetLength(0)
 - The first cycle will execute n times; the recursion will call the first loop m times. The algorithm will execute n*m times -> O(n*m)