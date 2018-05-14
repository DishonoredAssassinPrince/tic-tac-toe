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
            InitializeComponent();
            if(this.OpponentChoice == 'X')
            {
                AITurn();
            }
        }

        private void imgTopLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgTopLeft.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[0] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgTop.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[1] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgTopRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgTopRight.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[2] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgMiddleLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgMiddleLeft.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[3] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgMiddle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgMiddle.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[4] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgMiddleRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgMiddleRight.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[5] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgBottomLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgBottomLeft.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[6] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgBottom_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgBottom.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[7] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }

        private void imgBottomRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgBottomRight.Source = new BitmapImage(new Uri($@"Images/{PlayerChoice}.png", UriKind.Relative));
            Board[8] = $"{PlayerChoice}";
            CheckForWin();
            if (GameOver == false)
            { AITurn(); }
        }


        private void AITurn()
        {
            //Easy difficulty algorithm -> Choice is completely random
            if (Difficulty == "Easy")
            {
                Random rand = new Random();
                int play = rand.Next(0, 8);
                //Keeps generating new numbers until it finds an index of the Board which is free
                while (Board[play] != null)
                {
                    play = rand.Next(0, 8);
                }
                Board[play] = $"{OpponentChoice}";
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
                CheckForWin();
            }
        }

        private void CheckForWin()
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
                MessageBox.Show("Congratulations! You win!", "Win!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
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
                MessageBox.Show("You lose!", "Loss!", MessageBoxButton.OK);
                StartGameWindow startGameWindow = new StartGameWindow();
                startGameWindow.Show();
                this.Close();
                this.GameOver = true;
                return;
            }
        }
    }
}
