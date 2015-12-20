namespace TicTacToe.GameLogic
{
    public class GameResultValidator : IGameResultValidator
    {
        // O-X
        // O-X
        // --X
        public GameResult GetResult(string board)
        {
            if ((board[0] == 'X' && board[1] == 'X' && board[2] == 'X') ||
                (board[3] == 'X' && board[4] == 'X' && board[5] == 'X') ||
                (board[6] == 'X' && board[7] == 'X' && board[8] == 'X') ||
                (board[0] == 'X' && board[3] == 'X' && board[6] == 'X') ||
                (board[1] == 'X' && board[4] == 'X' && board[7] == 'X') ||
                (board[2] == 'X' && board[5] == 'X' && board[8] == 'X') ||
                (board[0] == 'X' && board[4] == 'X' && board[8] == 'X') ||
                (board[2] == 'X' && board[4] == 'X' && board[6] == 'X'))
            {
                return GameResult.WonByX;
            }
            else if ((board[0] == 'O' && board[1] == 'O' && board[2] == 'O') ||
                    (board[3] == 'O' && board[4] == 'O' && board[5] == 'O') ||
                    (board[6] == 'O' && board[7] == 'O' && board[8] == 'O') ||
                    (board[0] == 'O' && board[3] == 'O' && board[6] == 'O') ||
                    (board[1] == 'O' && board[4] == 'O' && board[7] == 'O') ||
                    (board[2] == 'O' && board[5] == 'O' && board[8] == 'O') ||
                    (board[0] == 'O' && board[4] == 'O' && board[8] == 'O') ||
                    (board[2] == 'O' && board[4] == 'O' && board[6] == 'O'))
            {
                return GameResult.WonByO;
            }
            else if (!board.Contains("-"))
            {
                return GameResult.Draw;
            }
            else
            {
                return GameResult.NotFinished;
            }
        }
    }
}
