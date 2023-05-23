using System.Data.SqlTypes;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Reflection;

namespace TicTacToe
{
    public partial class BoardView : Form
    {

        public Player[] players { get; private set; } = new Player[2];
        private BoardModel model;
        public int playerNumber => model.playerNumber;
        private string playerName => playerNumber == 0 ? "X" : "O";
        private Label[] cells;
        private int gameFinished => model.gameState;
        private bool testing = false;
        public BoardView()
        {
            InitializeComponent();
            PlayerSelectorX.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
            PlayerSelectorO.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
            var test = Enum.GetNames(typeof(PlayerType));
            PlayerSelectorX.SelectedIndex = 0;
            PlayerSelectorO.SelectedIndex = 1;

            this.cells = FindAllCells();
            resetBoard();



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
/*        private void createPlayers()
        {
            var typeX = (PlayerType)Enum.Parse(typeof(PlayerType), PlayerSelectorX.SelectedItem.ToString());
            var typeO = (PlayerType)Enum.Parse(typeof(PlayerType), PlayerSelectorO.SelectedItem.ToString());

            var pX = Player.create(typeX, 1, this);

            var pO = Player.create(typeO, -1, this);
            players[0] = pX;
            players[1] = pO;
        }*/
        private void createPlayers(object sender, EventArgs e)
        {
            var selector = sender as ComboBox;
            var symbol = selector.Name.Substring(selector.Name.Length - 1);
            var index = symbol == "X" ? 0 : 1;
            var type = (PlayerType)Enum.Parse(typeof(PlayerType), selector.SelectedItem.ToString());
            players[index] = Player.create(type, index == 0 ? 1 : -1, this);
        }
        public void updateFromModel()
        {
            // todo: read board state and apply to cells
            foreach (var cell in cells)
            {
                var id = model.getState(getIndex(cell));
                cell.Text = getPlayerSymbol(id);
            }
            if (!model.gameFinished)// -1 if game over
            {
                if (GetCurrentPlayer().startTurn(model))
                {
                    play();// todo call ascencrounsesly  play after 1 second timer 

                }


            }
            playerIndicator.Text = $"Player {playerName}";

        }

        public void play()
        {
            Player currentPlayer = GetCurrentPlayer();
            int move = currentPlayer.getMove();


            if (move != -1 && !model.gameFinished)
            {
                model.move(move);
                checkForWinner();

                updateFromModel();

            }

        }

        private void testingStart(int numGames, int moveDelay, int gameDelay)
        {

        }


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





        public Player GetCurrentPlayer()
        {
            return players[playerNumber];
        }

        public void DisplayMove(int move)
        {
            Label cell = cells[move];
            cell.Text = playerName;

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            resetBoard();
        }

        private Point getCords(Label label)
        {
            Point p = label.Location;
            p.X /= 200;
            p.Y /= 200;

            return p;
        }
        private int getIndex(Label label)
        {
            var pointString = label.Name.Substring(label.Name.Length - 2);
            int[] values = pointString.ToCharArray().Select(i => i - '0').ToArray();

            return values[0] + values[1] * 3;
        }
        public void resetBoard()
        {

            model = new BoardModel(this);
            playerIndicator.Text = $"Player {playerName}";
            winner.Text = $"";
            foreach (var player in players)
            {
                player.nextMove = -1;
            }
            updateFromModel();

        }

        private void onCellClick(object sender, EventArgs e)
        {
            Player p = GetCurrentPlayer();
            if (p.type == PlayerType.HUMAN_PLAYER && (sender as Label).Text == "")
            { // check model for valid move            
                p.nextMove = getIndex(sender as Label);
                play();
            }
        }

        public void checkForWinner()
        {
            var state = model.gameState;
            if (state != 0)
            {
                var playerName = state == 1 ? "X" : "O";
                winner.Text = $"Player {playerName} Won!";
                model.gameFinished = true;

            }
            else if (state == 0 && model.turn >= 9)
            {

                winner.Text = $"Draw";
                model.gameFinished = true;
            }
        }


    }

}