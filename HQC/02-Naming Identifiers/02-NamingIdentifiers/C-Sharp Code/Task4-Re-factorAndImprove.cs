namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        public const int FieldsWithoutMines = 35;

        public static void Main(string[] args)
        {
            int count = 0;
            int row = 0;
            int column = 0;
            string command = string.Empty;
            char[,] field = CreateGameField();
            char[,] bombs = PlaceBombs();
            bool explosion = false;
            bool startNewGame = true;
            bool wonTheGame = false;
            List<Points> champions = new List<Points>(6);

            do
            {
                if (startNewGame)
                {
                    Console.WriteLine("Let's play MineSweeper! Try to step only into the fields without mines on them." +
                    " Command 'top' shows the highscores, 'restart' starts a new game, 'exit' quits the game");
                    PrintPlayfield(field);
                    startNewGame = false;
                }

                Console.Write("Insert row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowHighscores(champions);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = PlaceBombs();
                        PrintPlayfield(field);
                        explosion = false;
                        startNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye Bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                PlayerTurn(field, bombs, row, column);
                                count++;
                            }

                            if (FieldsWithoutMines == count)
                            {
                                wonTheGame = true;
                            }
                            else
                            {
                                PrintPlayfield(field);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (explosion)
                {
                    PrintPlayfield(bombs);
                    Console.Write("\nYou died as a hero with {0} points. " + "Insert you nickname: ", count);
                    string nickname = Console.ReadLine();
                    Points t = new Points(nickname, count);
                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < t.Points)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Points r1, Points r2) => r2.Points.CompareTo(r1.Points));
                    ShowHighscores(champions);

                    field = CreateGameField();
                    bombs = PlaceBombs();
                    count = 0;
                    explosion = false;
                    startNewGame = true;
                }

                if (wonTheGame)
                {
                    Console.WriteLine("\nCongratulations! You opened 35 cels without stepping in a mine!.");
                    PrintPlayfield(bombs);
                    Console.WriteLine("Insert you nickname: ");
                    string nickname = Console.ReadLine();
                    Points totalPoints = new Points(nickname, count);
                    champions.Add(totalPoints);
                    ShowHighscores(champions);
                    field = CreateGameField();
                    bombs = PlaceBombs();
                    count = 0;
                    wonTheGame = false;
                    startNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("The bst console version of MineSweeper. EVER!");
            Console.Read();
        }

        private static void ShowHighscores(List<Points> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no scores to show!\n");
            }
        }

        private static void PlayerTurn(char[,] field, char[,] mines, int row, int col)
        {
            char numberOfMines = TotalNumberOfMines(mines, row, col);
            mines[row, col] = numberOfMines;
            field[row, col] = numberOfMines;
        }

        private static void PrintPlayfield(char[,] field)
        {
            int numberOfRows = field.GetLength(0);
            int numberOfCols = field.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < numberOfCols; j++)
                {
                    Console.Write(string.Format("{0} ", field[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }
            
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int fieldRows = 5;
            int fieldColumns = 10;
            char[,] field = new char[fieldRows, fieldColumns];
            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldColumns; j++)
                {
                    field[i, j] = '?';
                }
            }

            return field;
        }

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] field = new char[rows, cols];
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int minesId = random.Next(50);
                if (!mines.Contains(minesId))
                {
                    mines.Add(minesId);
                }
            }

            foreach (int mine in mines)
            {
                int row = mine / cols;
                int col = mine % cols;
                if (col == 0 && mine != 0)
                {
                    row--;
                    col = cols;
                }
                else
                {
                    col++;
                }

                field[row, col - 1] = '*';
            }
            
            return field;
        }

        private static void CalculateFieldValues(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char minesCount = TotalNumberOfMines(field, i, j);
                        field[i, j] = minesCount;
                    }
                }
            }
        }

        private static char TotalNumberOfMines(char[,] field, int row, int column)
        {
            int numberOfMines = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, column] == '*')
                { 
                    numberOfMines++; 
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, column] == '*')
                { 
                    numberOfMines++;
                }
            }
            
            if (column - 1 >= 0)
            {
                if (field[row, column - 1] == '*')
                { 
                    numberOfMines++;
                }
            }

            if (column + 1 < columns)
            {
                if (field[row, column + 1] == '*')
                { 
                    numberOfMines++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (field[row - 1, column - 1] == '*')
                { 
                    numberOfMines++;
                }
            }
  
            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (field[row - 1, column + 1] == '*')
                { 
                    numberOfMines++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (field[row + 1, column - 1] == '*')
                { 
                    numberOfMines++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (field[row + 1, column + 1] == '*')
                {
                    numberOfMines++;
                }
            }

            return char.Parse(numberOfMines.ToString());
        }

        public class Points
        {
            private string name;
            private int points;

            public Points()
            {
            }

            public Points(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }
        }
    }
}
