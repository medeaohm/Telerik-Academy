namespace Task2
{
    using System;

    public class Start
    {
        public static void Main()
        {
            const int MAX_X = 10;
            const int MIN_X = -10;
            const int MAX_Y = 20;
            const int MIN_Y = -20;

            // Task 2
            int x = 1;
            int y = 2;

            bool inRangeX = MIN_X <= x && x <= MAX_X;
            bool inRangeY = MIN_Y <= y && y <= MAX_Y;
            bool inRange = inRangeX && inRangeY;

            bool notVisitedCell = true;

            if (inRange && notVisitedCell)
            {
                VisitCell();
            }

            // Task 1
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
        }   

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }        

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}
