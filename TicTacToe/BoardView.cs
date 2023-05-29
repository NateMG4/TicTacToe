using System.Data.SqlTypes;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Reflection;
using System.ComponentModel;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using GameLogic;

namespace TicTacToe
{
    public partial class BoardView : Form
    {

        
        private Label[] cells;
        private Color[] colors = new Color[9];
        private ContinuousGameRunner runner;


        
        public BoardView()
        {
            InitializeComponent();

            PlayerSelectorX.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
            PlayerSelectorO.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
            PlayerSelectorX.SelectedIndex = 0;
            PlayerSelectorO.SelectedIndex = 1;


            this.runner = new ContinuousGameRunner(this);
            this.cells = FindAllCells();
            runner.reset();


        }
        public void updateFromModel(BoardModel model)
        {
            for (int i = 0; i < 9; i++)
            {
                var cell = cells[i];
                var id = model.getCellState(getIndex(cell));
                cell.Text = getPlayerSymbol(id);
                cell.ForeColor = colors[i];
            }
            var symbol = getPlayerSymbol(model.playerID);
            playerIndicator.Text = $"Player {symbol}";
            displayWinner(model);


        }

        public void UpdateTestingResults(int[] testingResults)
        {
            OWinCounter.Text = testingResults[0].ToString();
            DrawCounter.Text = testingResults[1].ToString();
            XWinCounter.Text = testingResults[2].ToString();
        }
        private string getPlayerSymbol(int id)
        {

            if (id == 1)
            {
                return "X";
            }
            else if (id == -1)
            {
                return "O";
            }
            else
            {
                return "";
            }
        }

        public List<PlayerType> getSelectedPlayerTypes()
        {
            var types = new List<PlayerType>();
            types.Add((PlayerType)Enum.Parse(typeof(PlayerType), PlayerSelectorX.SelectedItem.ToString()));
            types.Add((PlayerType)Enum.Parse(typeof(PlayerType), PlayerSelectorO.SelectedItem.ToString()));
            return types;
        }



        public async void testingStart()
        {

            TestStats.Visible = true;
            PlayerSelectorX.SelectedIndex = (int)PlayerType.AI_PLAYER;
            PlayerSelectorO.SelectedIndex = (int)PlayerType.AI_PLAYER;
       
        
        }

        // public async void testingEnd()
        // {
        //     this.gameDelay = 0;
        //     this.moveDelay = MOVE_DELAY;
        //     this.testsRemaining = 0;
        // }


        private Label[] FindAllCells()
        {
            var cells = new Label[9];
            for (int i = 0; i < 9; i++)
            {
                int x = i % 3;
                int y = i / 3;
                var name = $"Cell{x}{y}";
                cells[i] = this.Controls[name] as Label;
            }

            return cells;
        }










        private void resetButton_Click(object sender, EventArgs e)
        {
            runner.reset();
        }

       
        private int getIndex(Label label)
        {
            var pointString = label.Name.Substring(label.Name.Length - 2);
            int[] values = pointString.ToCharArray().Select(i => i - '0').ToArray();

            return values[0] + values[1] * 3;
        }
        public void resetBoard(BoardModel model)
        {
            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                colors[i] = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }

            playerIndicator.Text = $"Player X";
            winner.Text = $"";

            updateFromModel(model);

        }

        private void onCellClick(object sender, EventArgs e)
            {
            runner.CellClicked(getIndex(sender as Label));
        }

        public void displayWinner(BoardModel model)
        {
            var playerName = getPlayerSymbol(model.gameState);
            var state = model.gameState;
            if (state != 0)
            {
                winner.Text = $"Player {playerName} Won!";

            }
            else if (state == 0 && model.turn >= 9)
            {

                winner.Text = $"Draw";
            }
        }


        private void ConfigureTestProperties(object sender, EventArgs e)
        {
            TestingUtils testingProperties = new TestingUtils(this);
            testingProperties.Show();
        }
    }

}