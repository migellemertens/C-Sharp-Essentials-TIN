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
        #region Private Members
        // current results of cells in active game
        private MarkType[] mResults;

        // true if it's player 1's turn
        private bool mPlayer1Turn;

        // true if game is ended
        private bool mGameEnded;

        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        #endregion

        private void NewGame()
        {
            // new blank array of free cells
            mResults = new MarkType[9];

            for(var i = 0; i < mResults.Length; i++)
            {
                mResults[i] = MarkType.Free;
            }

            // player 1 starts game
            mPlayer1Turn = true;

            // iterate every button on grid
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            mGameEnded = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mGameEnded)
            {
                NewGame();
                return;
            }

            // cast sender to button
            var button = (Button)sender;

            // find buttons position in the array
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            // check if cell is free or not
            if(mResults[index] != MarkType.Free)
            {
                return;
            }

            // set cell value bases on playerturn
            mResults[index] = mPlayer1Turn ? MarkType.Cross : MarkType.Nought;

            // set button text to result
            button.Content = mPlayer1Turn ? "X" : "O";

            // change nought to green
            if (!mPlayer1Turn)
            {
                button.Foreground = Brushes.Red;
            }

            // inverts value
            mPlayer1Turn ^= true;

            // check for a winner
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            #region Horizontal Wins
            // check for horizontal wins
            // row 0
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton0_0.Background = Buton1_0.Background = Buton2_0.Background = Brushes.Green;
            }
            // row 1
            if (mResults[0] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton0_1.Background = Buton1_1.Background = Buton2_1.Background = Brushes.Green;
            }
            // row 2
            if (mResults[0] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton0_2.Background = Buton1_2.Background = Buton2_2.Background = Brushes.Green;
            }
            #endregion

            #region Verical Wins
            // check for vertical wins
            // column 0
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton0_0.Background = Buton0_1.Background = Buton0_2.Background = Brushes.Green;
            }
            // column 1
            if (mResults[0] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton1_0.Background = Buton1_1.Background = Buton1_2.Background = Brushes.Green;
            }
            // column 2
            if (mResults[0] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton2_0.Background = Buton2_1.Background = Buton2_2.Background = Brushes.Green;
            }
            #endregion

            #region Diagonal Wins
            // Top left - bottom right
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton0_0.Background = Buton1_1.Background = Buton2_2.Background = Brushes.Green;
            }
            // Top right - bottom left
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                mGameEnded = true;

                // highlight winning cells
                Buton2_0.Background = Buton1_1.Background = Buton0_2.Background = Brushes.Green;
            }
            #endregion

            #region No Winners

            if (!mResults.Any(result => result == MarkType.Free))
            {
                mGameEnded = true;

                // turn all cell sorange
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    
                    button.Background = Brushes.Orange;
                    
                });
            }
            #endregion
        }
    }
}
