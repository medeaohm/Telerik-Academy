using System;

public class SimpleMathExam : Exam
{
    private const int MIN_PROBLEMS_SOLVED = 0;
    private const int MAX_PROBLEMS_SOLVED = 10;
    private const int NUM_PROBLEMS_FOR_BAD_GRADE = 2;
    private const int NUM_PROBLEMS_FOR_AVERAGE_GRADE = 5;
    private const int NUM_PROBLEMS_FOR_GOOD_GRADE = 8;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            if (this.problemsSolved < MIN_PROBLEMS_SOLVED)
            {
                return MIN_PROBLEMS_SOLVED;
            }
            else if (this.problemsSolved > MAX_PROBLEMS_SOLVED)
            {
                return MAX_PROBLEMS_SOLVED;
            }
            else
            {
                return this.problemsSolved;
            }
        }

        set
        {
            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        string comment;

        if (this.ProblemsSolved < NUM_PROBLEMS_FOR_BAD_GRADE)
        {
            comment = "Bad result: nothing done.";
        }
        else if (this.ProblemsSolved < NUM_PROBLEMS_FOR_AVERAGE_GRADE)
        {
            comment = "Average result: nothing done.";
        }
        else if (this.ProblemsSolved < NUM_PROBLEMS_FOR_GOOD_GRADE)
        {
             comment = "Good result: almost everything done.";
        }
        else
        {
            comment = "Excellent result: everything done.";
        }

        return new ExamResult(this.ProblemsSolved, MIN_PROBLEMS_SOLVED, MAX_PROBLEMS_SOLVED, comment);
    }
}
