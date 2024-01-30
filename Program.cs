using System;

class Program
{
    static void Main()
    {
        //Welcome the User to the Game
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        //Create a game *Board Array* to store players choices
        TicTacToeGame game = new TicTacToeGame();

        //Run through the game 
        for (int turnCount = 0; turnCount < 9 && !game.IsGameOver(); turnCount++)
        {
            game.PrintBoard();  //print the board by calling method in supporting class
            game.TakeTurn();
            if (game.CheckForWinner())  //check for winner by using suporting class method
                break;
        }

        //Game Over Message
        Console.WriteLine("Game Over. Thank you for playing!");
    }
}


// How do we want to tell each player its their turn?
// should we use a for loop or while loop?