namespace School
{
    using System;
    using System.Collections.Generic;

    public class Disciplines : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercise;
        private string comment;

        public Disciplines(string name, int numberOfLectures, int numberOfExercise) 
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercise = numberOfExercise;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline's name cannot be blank!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures 
        {
            get { return this.numberOfLectures; }
            set
            {
                //if (numberOfLectures <= 0)
                //{
                //    throw new ArgumentException("Number of lectures must be greater than 0!");
                //}
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercise
        {
            get { return this.numberOfExercise; }
            set
            {
                //if (numberOfLectures < 0)
                //{
                //    throw new ArgumentException("Number of lectures must be greater than 0!");
                //}
                this.numberOfExercise = value;
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comment yet!";
                }

                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Discipline: {0}\nNumber of lectures: {1}\nNumber of exercise: {2}\nComments: {3}", this.Name, this.NumberOfLectures, this.NumberOfExercise, this.Comment);
        }
    }         
}
