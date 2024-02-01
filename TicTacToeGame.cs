using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4_IS001
{
    public class TicTacToeGame
    {
      public void printBoard(char[] board)
{
    // Print the Tic-Tac-Toe board with position numbers
    Console.WriteLine($" {board[0]} | {board[1]} | {board[2]}        1 | 2 | 3 ");
    Console.WriteLine("---|---|---      ---|---|---");
    Console.WriteLine($" {board[3]} | {board[4]} | {board[5]}        4 | 5 | 6 ");
    Console.WriteLine("---|---|---      ---|---|---");
    Console.WriteLine($" {board[6]} | {board[7]} | {board[8]}        7 | 8 | 9 ");
}


        public string checkWinner(char[] board)
        {
            // Check for a winner
            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2] && board[i * 3] != ' ')
                    return $"Player {(board[i * 3] == 'X' ? 1 : 2)} wins!";

                // Check columns
                if (board[i] == board[i + 3] && board[i + 3] == board[i + 6] && board[i] != ' ')
                    return $"Player {(board[i] == 'X' ? 1 : 2)} wins!";
            }

            // Check diagonals
            if ((board[0] == board[4] && board[4] == board[8] && board[0] != ' ') ||
                (board[2] == board[4] && board[4] == board[6] && board[2] != ' '))
                return $"Player {(board[4] == 'X' ? 1 : 2)} wins!";

            // Check for a tie
            if (!board.Any(c => c == ' '))
                return "It's a tie!";

            // No winner yet
            return null;
        }

    }
}
