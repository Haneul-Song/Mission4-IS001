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
    char playerLetter = (pT == 0) ? 'X' : 'O';

    while (true)
    {
        Console.Write("Enter which square to play on! (enter a number 1-9): ");

        string input = Console.ReadLine();
        int playerChoice;

        // Check if input is a valid integer
        if (!int.TryParse(input, out playerChoice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }

        // Check if the choice is within the valid range
        if (playerChoice < 1 || playerChoice > 9)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
            continue;
        }

        // Adjust playerChoice for zero-based index
        playerChoice--;

        // Check if the chosen spot is already taken
        if (boardArray[playerChoice] != ' ')
        {
            Console.WriteLine("That spot is already taken. Please choose another.");
            continue;
        }

        // If all checks pass, update the board and break the loop
        boardArray[playerChoice] = playerLetter;
        break;
    }

    return false;
}

