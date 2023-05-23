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

        private int gameDelay = 0;
        private int moveDelay = 0;

        public BoardView()
        {
            InitializeComponent();
            PlayerSelectorX.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
            PlayerSelectorO.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
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
            foreach (var cell in cells)
            {
                var id = model.getState(getIndex(cell));
                cell.Text = getPlayerSymbol(id);
            }
            if (GetCurrentPlayer().startTurn(model))
            {
                play();// todo call  play after 1 second timer 

            }
            playerIndicator.Text = $"Player {playerName}";
        }

        public async void play()
        {
            Player currentPlayer = GetCurrentPlayer();
            int move = currentPlayer.getMove();


            if (move != -1 && !model.gameFinished)
            {
                if (currentPlayer.type == PlayerType.AI_PLAYER)
                {
                    await Task.Delay(moveDelay);
                }
                model.move(move);
                checkForWinner();
                updateFromModel();

            }



        }

        public async void testingStart(int numGames, int moveDelay, int gameDelay)
        {
            PlayerSelectorX.SelectedIndex = (int)PlayerType.AI_PLAYER;
            PlayerSelectorO.SelectedIndex = (int)PlayerType.AI_PLAYER;
            this.gameDelay = gameDelay;
            this.moveDelay = moveDelay;

            for (int i = 0; i < numGames; i++)
            {
                model = new BoardModel(this);
                updateFromModel(); // using awiat task.run breaks here
                if (model.gameState != 0)
                {
                    return;
                }
                await Task.Delay(gameDelay);
            }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void ConfigureTestProperties(object sender, EventArgs e)
        {
            TestingUtils testingProperties = new TestingUtils(this);
            testingProperties.Show();
        }
    }

}