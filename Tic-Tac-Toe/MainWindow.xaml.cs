using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Checks if it's first turn for Normal difficulty if the opponent is first so that they can play somewhere randomly
        private bool FirstTurn { get; set; }

        private string Difficulty { get; set; }

        private char PlayerChoice { get; set; }

        private char OpponentChoice { get; set; }

        private string[] Board { get; set; }

        private bool GameOver { get; set; }

        public MainWindow(string difficulty, char playerChoice)
        {
            //Sets current difficulty level, taken from StartGameWindow
            this.Difficulty = difficulty;
            this.PlayerChoice = playerChoice;
            if (this.PlayerChoice == 'X')
            {
                this.OpponentChoice = 'O';
            }
            else { this.OpponentChoice = 'X'; }
            // 0 | 1 | 2
            // 3 | 4 | 5
            // 6 | 7 | 8
            Board = new string[9];
            GameOver = false;
            this.FirstTurn = true;
            InitializeComponent();
            if (this.OpponentChoice == 'X')
            {
                AITurn();
            }
        }

        private void imgTopLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgTopLeft.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[0] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgTop.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[1] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgTopRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgTopRight.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[2] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgMiddleLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgMiddleLeft.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[3] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgMiddle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgMiddle.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[4] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgMiddleRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgMiddleRight.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[5] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgBottomLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgBottomLeft.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[6] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgBottom_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgBottom.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[7] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgBottomRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FirstTurn = false;
            imgBottomRight.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[8] = $"{PlayerChoice}";
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            if (GameOver == false)
            { AITurn(); }
        }


        private void AITurn()
        {
            //Position the opponent is going to choose
            int play = -1;

            //Easy difficulty algorithm -> Choice is completely random
            if (Difficulty == "Easy" || (Difficulty == "Normal" && FirstTurn == true))
            {
                play = RandomPlay();
            }
            //Normal difficulty algorithm -> Looks one turn ahead using a nested loop. If it finds a possibility for win for itself,
            //it chooses that move. If not but it finds that the player has such a chance it will block them. Otherwise, plays
            //randomly.
            else if (Difficulty == "Normal")
            {
                //Copy of Board we can freely manipulate
                string[] tempBoard = new string[9];
                for (int i = 0; i < Board.Length; i++)
                {
                    tempBoard[i] = Board[i];
                }

                play = AICheckNormal(tempBoard);

                Board[play] = $"{OpponentChoice}";
            }
            //else if (Difficulty == "Impossible")
            //{
            //    //Copy of Board we can freely manipulate
            //    string[] tempBoard = new string[9];
            //    for (int i = 0; i < Board.Length; i++)
            //    {
            //        tempBoard[i] = Board[i];
            //    }
            //    play = AICheckImpossible(tempBoard, OpponentChoice, play, 0);

            //    Board[play] = $"{OpponentChoice}";
            //}
            switch (play)
            {
                case 0:
                    imgTopLeft.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 1:
                    imgTop.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 2:
                    imgTopRight.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 3:
                    imgMiddleLeft.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 4:
                    imgMiddle.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 5:
                    imgMiddleRight.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 6:
                    imgBottomLeft.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 7:
                    imgBottom.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
                case 8:
                    imgBottomRight.Source = new BitmapImage(new Uri($@"Images/{OpponentChoice}.png", UriKind.Relative));
                    break;
            }
            if (CheckForWin(Board) == "Player")
            {
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Opponent")
            {
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
            else if (CheckForWin(Board) == "Draw")
            {
                MessageBox.Show("It's a draw!", "Draw!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
        }

        //private int AICheckImpossible(string[] tempBoard, char currentPlayer, int play, int depth) 
        //{
        //    if (CheckForWin(tempBoard) == "Player")
        //    {
        //        return 10 - depth;
        //    }
        //    else if (CheckForWin(tempBoard) == "Opponent")
        //    {
        //        return depth - 10;
        //    }
        //    if (CheckForWin(tempBoard) == "Draw")
        //    {
        //        return 0;
        //    }
        //    int[] moves = GetMoves(tempBoard);
        //    Dictionary<int, int> moveScores = new Dictionary<int, int>();
        //    foreach (int move in moves)
        //    {
        //        if (currentPlayer == OpponentChoice)
        //        {
        //            tempBoard[move] = OpponentChoice.ToString();
        //            int score = AICheckImpossible(tempBoard, PlayerChoice, play, depth + 1);
        //            moveScores.Add(move, score);
        //            if (depth != 0)
        //            {
        //                return score;
        //            }
        //            if (depth == 0)
        //            {
        //            }
        //        }
        //        else if (currentPlayer == PlayerChoice)
        //        {
        //            tempBoard[move] = PlayerChoice.ToString();
        //            int score = AICheckImpossible(tempBoard, OpponentChoice, play, depth + 1);
        //            moveScores.Add(move, score);
        //        }
        //    }

        //    if (currentPlayer == OpponentChoice)
        //    {
        //        int bestMaxValue = int.MinValue;
        //        int 
        //        foreach (var turn in moveScores)
        //        {
        //            if (turn.Value > bestMaxValue)
        //            {
                        
        //            }
        //        }
        //        return moveScores.Keys.Max();
        //    }
        //    else if (currentPlayer == PlayerChoice)
        //    {
        //        return moveScores.Keys.Min();
        //    }
        //}

        //private int[] GetMoves(string[] Board)
        //{
        //    List<int> moves = new List<int>();
        //    for (int i = 0; i < Board.Length; i++)
        //    {
        //        if (Board[i] == null)
        //        {
        //            moves.Add(i);
        //        }
        //    }
        //    return moves.ToArray();
        //}

        private int RandomPlay()
        {
            int play;
            Random rand = new Random();
            play = rand.Next(0, 8);
            //Keeps generating new numbers until it finds an index of the Board which is free
            while (Board[play] != null)
            {
                play = rand.Next(0, 8);
            }

            Board[play] = $"{OpponentChoice}";
            return play;
        }

        private int AICheckNormal(string[] tempBoard)
        {
            for (int opponentTurn = 0; opponentTurn < tempBoard.Length; opponentTurn++)
            {
                //Checks if cell is free
                if (tempBoard[opponentTurn] == null)
                {
                    //Checks top-left corner and if there are winning combinations possible
                    if (opponentTurn == 0)
                    {
                        if ((tempBoard[1] == $"{OpponentChoice}" && tempBoard[2] == $"{OpponentChoice}") ||
                            (tempBoard[3] == $"{OpponentChoice}" && tempBoard[6] == $"{OpponentChoice}") ||
                            (tempBoard[4] == $"{OpponentChoice}" && tempBoard[8] == $"{OpponentChoice}"))
                        { return opponentTurn; }
                    }
                    else if (opponentTurn % 3 == 0)
                    {
                        //Checks for horizontal rows starting from leftmost cells and sees if there are winning combinations possible
                        if (tempBoard[opponentTurn + 1] == $"{OpponentChoice}" && tempBoard[opponentTurn + 2] == $"{OpponentChoice}")
                        {
                            return opponentTurn;
                        }
                        else if (tempBoard[opponentTurn - 3] == $"{OpponentChoice}") //Checks vertical rows
                        {
                            if (opponentTurn == 3 && tempBoard[6] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                            else if (opponentTurn == 6 && tempBoard[0] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                        }
                        else if (tempBoard[4] == $"{OpponentChoice}") //Checks for diagonal rows -> 4 is the index of the center cell.
                        {
                            if (tempBoard[8] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                            else if (tempBoard[2] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                        }
                    }
                    if (opponentTurn % 3 == 1)
                    {
                        //Checks horizontal rows for middle cells and sees if there are winning combinations possible
                        if (tempBoard[opponentTurn - 1] == $"{OpponentChoice}" && tempBoard[opponentTurn + 1] == $"{OpponentChoice}")
                        {
                            return opponentTurn;
                        }
                        //Checks row 1/4/7
                        else if (opponentTurn == 1 && tempBoard[4] == $"{OpponentChoice}" && tempBoard[7] == $"{OpponentChoice}")
                        {
                            return opponentTurn;
                        }
                        else if (opponentTurn == 4) //Checks for center cell possibilities
                        {
                            //Checks diagonals
                            if (tempBoard[0] == $"{OpponentChoice}" && tempBoard[8] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                            else if (tempBoard[2] == $"{OpponentChoice}" && tempBoard[6] == $"{OpponentChoice}")
                            { return opponentTurn; }

                            //Checks row 1/4/7
                            else if (tempBoard[1] == $"{OpponentChoice}" && tempBoard[7] == $"{OpponentChoice}")
                            { return opponentTurn; }
                        }
                        //Checks row 1/4/7
                        else if (opponentTurn == 7 && tempBoard[4] == $"{OpponentChoice}" && tempBoard[1] == $"{OpponentChoice}")
                        {
                            return opponentTurn;
                        }
                    }
                    if (opponentTurn % 3 == 2)
                    {
                        //Checks horizontal rows for rightmost cells and sees if there are winning combinations possible
                        if (tempBoard[opponentTurn - 1] == $"{OpponentChoice}" && tempBoard[opponentTurn - 2] == $"{OpponentChoice}")
                        {
                            return opponentTurn;
                        }
                        else if (opponentTurn == 2)
                        {
                            //Checks row 2/4/6
                            if (tempBoard[4] == $"{OpponentChoice}" && tempBoard[6] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                            //Checks row 2/5/8
                            else if (tempBoard[5] == $"{OpponentChoice}" && tempBoard[8] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                        }
                        //Checks middle horizontal row (row 2/5/8)
                        else if (opponentTurn == 5 && (tempBoard[2] == $"{OpponentChoice}" && tempBoard[8] == $"{OpponentChoice}"))
                        {
                            return opponentTurn;
                        }
                        else if (opponentTurn == 8)
                        {
                            //Checks row 0/4/8
                            if (tempBoard[0] == $"{OpponentChoice}" && tempBoard[4] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                            //Checks row 2/5/8
                            else if (tempBoard[5] == $"{OpponentChoice}" && tempBoard[2] == $"{OpponentChoice}")
                            {
                                return opponentTurn;
                            }
                        }
                    }

                    //Assumes the opponent plays this move
                    tempBoard[opponentTurn] = $"{OpponentChoice}";

                    //Loops for possible player turns (one turn ahead)
                    for (int playerTurn = opponentTurn; playerTurn < tempBoard.Length; playerTurn++)
                    {
                        if (tempBoard[playerTurn] == null && playerTurn != opponentTurn)
                        {
                            //Checks top-left corner
                            if (playerTurn == 0)
                            {
                                if ((tempBoard[1] == $"{PlayerChoice}" && tempBoard[2] == $"{PlayerChoice}") ||
                                    (tempBoard[3] == $"{PlayerChoice}" && tempBoard[6] == $"{PlayerChoice}") ||
                                    (tempBoard[4] == $"{PlayerChoice}" && tempBoard[8] == $"{PlayerChoice}"))
                                { return playerTurn; }
                            }
                            else if (playerTurn % 3 == 0)
                            {
                                //Checks for horizontal rows starting from leftmost cells and sees if there are winning combinations possible
                                if (tempBoard[playerTurn + 1] == $"{PlayerChoice}" && tempBoard[playerTurn + 2] == $"{PlayerChoice}")
                                {
                                    return playerTurn;
                                }
                                //Checks vertical rows
                                else if (tempBoard[playerTurn - 3] == $"{PlayerChoice}")
                                {
                                    if (playerTurn == 3 && tempBoard[6] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                    else if (playerTurn == 6 && tempBoard[0] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                }
                                //Checks for diagonal rows -> 4 is the index of the center cell.
                                else if (tempBoard[4] == $"{PlayerChoice}")
                                {
                                    if (tempBoard[8] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                    else if (tempBoard[2] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                }
                            }
                            if (playerTurn % 3 == 1)
                            {
                                //Checks horizontal rows for middle cells and sees if there are winning combinations possible
                                if (tempBoard[playerTurn - 1] == $"{PlayerChoice}" && tempBoard[playerTurn + 1] == $"{PlayerChoice}")
                                {
                                    return playerTurn;
                                }
                                //Checks row 1/4/7
                                else if (playerTurn == 1 && tempBoard[4] == $"{PlayerChoice}" && tempBoard[7] == $"{PlayerChoice}")
                                {
                                    return playerTurn;
                                }
                                //Checks for center cell possibilities
                                else if (playerTurn == 4)
                                {
                                    //Checks diagonals
                                    if (tempBoard[0] == $"{PlayerChoice}" && tempBoard[8] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                    else if (tempBoard[2] == $"{PlayerChoice}" && tempBoard[6] == $"{PlayerChoice}")
                                    { return playerTurn; }

                                    //Checks middle horizontal row (row 1/4/7)
                                    else if (tempBoard[1] == $"{PlayerChoice}" && tempBoard[7] == $"{PlayerChoice}")
                                    { return playerTurn; }
                                }
                                //Checks row 1/4/7
                                else if (playerTurn == 7 && tempBoard[4] == $"{PlayerChoice}" && tempBoard[1] == $"{PlayerChoice}")
                                {
                                    return playerTurn;
                                }
                            }
                            if (playerTurn % 3 == 2)
                            {
                                //Checks horizontal rows for rightmost cells and sees if there are winning combinations possible
                                if (tempBoard[playerTurn - 1] == $"{PlayerChoice}" && tempBoard[playerTurn - 2] == $"{PlayerChoice}")
                                {
                                    return playerTurn;
                                }
                                else if (playerTurn == 2)
                                {
                                    //Checks row 2/4/6
                                    if (tempBoard[4] == $"{PlayerChoice}" && tempBoard[6] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                    //Checks row 2/5/8
                                    else if (tempBoard[5] == $"{PlayerChoice}" && tempBoard[8] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                }
                                //Checks row 2/5/8 (middle horizontal row)
                                else if (playerTurn == 5 && (tempBoard[2] == $"{PlayerChoice}" && tempBoard[8] == $"{PlayerChoice}"))
                                {
                                    return playerTurn;
                                }
                                else if (playerTurn == 8)
                                {
                                    //Checks row 0/4/8
                                    if (tempBoard[0] == $"{PlayerChoice}" && tempBoard[4] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                    //Checks row 2/5/8
                                    else if (tempBoard[5] == $"{PlayerChoice}" && tempBoard[2] == $"{PlayerChoice}")
                                    {
                                        return playerTurn;
                                    }
                                }

                            }
                        }
                    }
                    //Resets board to original state to test for other possibilities
                    tempBoard[opponentTurn] = null;
                }
            }

            //Returns random number if not in a close winning or losing state (2 for opponent or player)
            return RandomPlay();
        }

        private string CheckForWin(string[] Board)
        {
            //Checks for player win
            if ((Board[0] == $"{PlayerChoice}" && Board[1] == $"{PlayerChoice}" && Board[2] == $"{PlayerChoice}") ||
                (Board[3] == $"{PlayerChoice}" && Board[4] == $"{PlayerChoice}" && Board[5] == $"{PlayerChoice}") ||
                (Board[6] == $"{PlayerChoice}" && Board[7] == $"{PlayerChoice}" && Board[8] == $"{PlayerChoice}") ||
                (Board[0] == $"{PlayerChoice}" && Board[3] == $"{PlayerChoice}" && Board[6] == $"{PlayerChoice}") ||
                (Board[1] == $"{PlayerChoice}" && Board[4] == $"{PlayerChoice}" && Board[7] == $"{PlayerChoice}") ||
                (Board[2] == $"{PlayerChoice}" && Board[5] == $"{PlayerChoice}" && Board[8] == $"{PlayerChoice}") ||
                (Board[0] == $"{PlayerChoice}" && Board[4] == $"{PlayerChoice}" && Board[8] == $"{PlayerChoice}") ||
                (Board[2] == $"{PlayerChoice}" && Board[4] == $"{PlayerChoice}" && Board[6] == $"{PlayerChoice}"))
            {
                return "Player";

            }
            //Checks for opponent win
            if ((Board[0] == $"{OpponentChoice}" && Board[1] == $"{OpponentChoice}" && Board[2] == $"{OpponentChoice}") ||
                (Board[3] == $"{OpponentChoice}" && Board[4] == $"{OpponentChoice}" && Board[5] == $"{OpponentChoice}") ||
                (Board[6] == $"{OpponentChoice}" && Board[7] == $"{OpponentChoice}" && Board[8] == $"{OpponentChoice}") ||
                (Board[0] == $"{OpponentChoice}" && Board[3] == $"{OpponentChoice}" && Board[6] == $"{OpponentChoice}") ||
                (Board[1] == $"{OpponentChoice}" && Board[4] == $"{OpponentChoice}" && Board[7] == $"{OpponentChoice}") ||
                (Board[2] == $"{OpponentChoice}" && Board[5] == $"{OpponentChoice}" && Board[8] == $"{OpponentChoice}") ||
                (Board[0] == $"{OpponentChoice}" && Board[4] == $"{OpponentChoice}" && Board[8] == $"{OpponentChoice}") ||
                (Board[2] == $"{OpponentChoice}" && Board[4] == $"{OpponentChoice}" && Board[6] == $"{OpponentChoice}"))
            {
                return "Opponent";
            }

            if (Board.All(place => place == "O" || place == "X"))
            {
                return "Draw";
            }
            return "None";
        }
    }
}
