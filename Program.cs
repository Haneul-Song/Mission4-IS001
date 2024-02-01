using Mission4_IS001;

TicTacToeGame t = new TicTacToeGame();

// Create a game board array to store the players’ choices
char[] boardArray = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
// initialize player 1's turn
int playerTurn = 0;

//Welcome user to game
Console.WriteLine("Welcome to Tic-Tac-Toe!");
Console.WriteLine("Player 1 (X) - Player 2 (O)");

String gameResult = "";

// Game Loop
do
{
    // Turn Loop
    do
    {
        Console.WriteLine($"Player {playerTurn + 1}, what spot do you want");

        // Print the board by calling the method in the supporting class
        t.printBoard(boardArray);

    } while (playGame(playerTurn));

    // switch player functionality
        if (playerTurn == 0) {
            playerTurn = 1;
        }
        else if (playerTurn == 1) {
            playerTurn = 0;
        } 

    // Check for a winner by calling the method in the supporting class,
    gameResult = t.checkWinner(boardArray);
} while (gameResult == null);

// Print the board by calling the method in the supporting class
t.printBoard(boardArray);
// Display the Winner! notify the players when a win has occurred and which player won the game
Console.WriteLine(gameResult);
// Console.WriteLine("Game Over. Thank you for playing!");


// Player Turn Function
bool playGame(int pT)
{
    // set playerLetter, expanded functionality
       char playerLetter = ' ';
       if (pT == 0) {
           playerLetter = 'X';
       }
       else if (pT == 1) {
           playerLetter = 'O';
       } 

    Console.Write("Enter which square to play on! (enter a number 1-9): ");
    int playerChoice = (int.Parse(Console.ReadLine()) - 1);

    // update the game board array with player choice, if valid
    if (playerChoice >= 0 && playerChoice <= 8 && boardArray[playerChoice] == ' ')
    {
        boardArray[playerChoice] = playerLetter;
        return false;
    }
    else
    {
        Console.WriteLine("Invalid move. Please choose an empty position.");
        return true;
    }

}
