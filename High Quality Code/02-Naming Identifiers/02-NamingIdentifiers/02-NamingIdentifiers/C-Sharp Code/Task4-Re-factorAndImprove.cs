namespace Mines
{
    using System;
    using System.Collections.Generic;

    public class Mine
	{
        const int MAX = 35;

		public class Points
		{
			string name;
			int points;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}

			public int Points
			{
				get { return points; }
                set { points = value; }
			}

			public Points() 
            { 
            }

			public Points(string name, int points)
			{
				this.name = name;
                this.points = points;
			}
		}

		static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] field = CreateGameField();
			char[,] bombs = PlaceBombs();
			int count = 0;
			bool explosion = false;
			List<Points> champions = new List<Points>(6);
			int row = 0;
			int column = 0;
			bool flag = true;			
			bool flag2 = false;

/* DONE UNTIL HERE */

			do
			{
				if (flag)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					dumpp(field);
					flag = false;
				}
				Console.Write("Daj red i kolona : ");
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
						klasacia(champions);
						break;
					case "restart":
						field = CreateGameField();
						bombs = PlaceBombs();
						dumpp(field);
						explosion = false;
						flag = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								tisinahod(field, bombs, row, column);
								count++;
							}
							if (MAX == count)
							{
								flag2 = true;
							}
							else
							{
								dumpp(field);
							}
						}
						else
						{
							explosion = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (explosion)
				{
					dumpp(bombs);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", count);
					string niknejm = Console.ReadLine();
					Points t = new Points(niknejm, count);
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
					klasacia(champions);

					field = CreateGameField();
					bombs = PlaceBombs();
					count = 0;
					explosion = false;
					flag = true;
				}
				if (flag2)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					dumpp(bombs);
					Console.WriteLine("Daj si imeto, batka: ");
					string imeee = Console.ReadLine();
					Points to4kii = new Points(imeee, count);
					champions.Add(to4kii);
					klasacia(champions);
					field = CreateGameField();
					bombs = PlaceBombs();
					count = 0;
					flag2 = false;
					flag = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void klasacia(List<Points> to4kii)
		{
			Console.WriteLine("\nTo4KI:");
			if (to4kii.Count > 0)
			{
				for (int i = 0; i < to4kii.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, to4kii[i].Name, to4kii[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void tisinahod(char[,] POLE,
			char[,] BOMBI, int RED, int KOLONA)
		{
			char kolkoBombi = kolko(BOMBI, RED, KOLONA);
			BOMBI[RED, KOLONA] = kolkoBombi;
			POLE[RED, KOLONA] = kolkoBombi;
		}

		private static void dumpp(char[,] board)
		{
			int RRR = board.GetLength(0);
			int KKK = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < RRR; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < KKK; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceBombs()
		{
			int Редове = 5;
			int Колони = 10;
			char[,] игрално_поле = new char[Редове, Колони];

			for (int i = 0; i < Редове; i++)
			{
				for (int j = 0; j < Колони; j++)
				{
					игрално_поле[i, j] = '-';
				}
			}

			List<int> r3 = new List<int>();
			while (r3.Count < 15)
			{
				Random random = new Random();
				int asfd = random.Next(50);
				if (!r3.Contains(asfd))
				{
					r3.Add(asfd);
				}
			}

			foreach (int i2 in r3)
			{
				int kol = (i2 / Колони);
				int red = (i2 % Колони);
				if (red == 0 && i2 != 0)
				{
					kol--;
					red = Колони;
				}
				else
				{
					red++;
				}
				игрално_поле[kol, red - 1] = '*';
			}

			return игрално_поле;
		}

		private static void smetki(char[,] pole)
		{
			int kol = pole.GetLength(0);
			int red = pole.GetLength(1);

			for (int i = 0; i < kol; i++)
			{
				for (int j = 0; j < red; j++)
				{
					if (pole[i, j] != '*')
					{
						char kolkoo = kolko(pole, i, j);
						pole[i, j] = kolkoo;
					}
				}
			}
		}

		private static char kolko(char[,] r, int rr, int rrr)
		{
			int brojkata = 0;
			int reds = r.GetLength(0);
			int kols = r.GetLength(1);

			if (rr - 1 >= 0)
			{
				if (r[rr - 1, rrr] == '*')
				{ 
					brojkata++; 
				}
			}
			if (rr + 1 < reds)
			{
				if (r[rr + 1, rrr] == '*')
				{ 
					brojkata++; 
				}
			}
			if (rrr - 1 >= 0)
			{
				if (r[rr, rrr - 1] == '*')
				{ 
					brojkata++;
				}
			}
			if (rrr + 1 < kols)
			{
				if (r[rr, rrr + 1] == '*')
				{ 
					brojkata++;
				}
			}
			if ((rr - 1 >= 0) && (rrr - 1 >= 0))
			{
				if (r[rr - 1, rrr - 1] == '*')
				{ 
					brojkata++; 
				}
			}
			if ((rr - 1 >= 0) && (rrr + 1 < kols))
			{
				if (r[rr - 1, rrr + 1] == '*')
				{ 
					brojkata++; 
				}
			}
			if ((rr + 1 < reds) && (rrr - 1 >= 0))
			{
				if (r[rr + 1, rrr - 1] == '*')
				{ 
					brojkata++; 
				}
			}
			if ((rr + 1 < reds) && (rrr + 1 < kols))
			{
				if (r[rr + 1, rrr + 1] == '*')
				{ 
					brojkata++; 
				}
			}
			return char.Parse(brojkata.ToString());
		}
    }
}
