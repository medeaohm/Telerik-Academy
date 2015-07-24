using System;

public class CSharpExam : Exam
{
    public const int MIN_SCORE = 0;
    public const int MAX_SCORE = 100;

    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score 
    {
        get
        {
            return this.score;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Score cannot be < 0");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < MIN_SCORE || this.Score > MAX_SCORE)
        {
            throw new ArgumentOutOfRangeException("Score", "Score should be between " + MIN_SCORE + " and " + MAX_SCORE);
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
