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
using System.Windows.Shapes;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for StartGameWindow.xaml
    /// </summary>
    public partial class StartGameWindow : Window
    {
        public StartGameWindow()
        {
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            string difficulty = DifficultyCBox.Text;
            char playerChoice = ' ';
            if(PlayerXChoice.IsChecked == true)
            {
                playerChoice = 'X';
            }
            else
            {
                playerChoice = 'O';
            }
            //Declares mainWindow with selected difficulty and player
            MainWindow mainWindow = new MainWindow(difficulty, playerChoice);
            mainWindow.Show();
            this.Close();
        }
    }
}
