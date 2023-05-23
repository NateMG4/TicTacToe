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


        private int testsRemaining = 0;
        private int gameDelay = 0;
        private int moveDelay = 0;

        BackgroundWorker turnWorker = new BackgroundWorker();


        public BoardView()
        {
            turnWorker.WorkerSupportsCancellation = true;
            turnWorker.DoWork +=
                new DoWorkEventHandler(turnWorker_DoWork);

            turnWorker.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(turnWroker_RunWorkerCompleted);


            InitializeComponent();
            PlayerSelectorX.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
            PlayerSelectorO.Items.AddRange(Enum.GetNames(typeof(PlayerType)));
            PlayerSelectorX.SelectedIndex = 0;
            PlayerSelectorO.SelectedIndex = 1;

            this.cells = FindAllCells();
            resetBoard();


        }

        private async void turnWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Player currentPlayer = GetCurrentPlayer();
            currentPlayer.startTurn(model);
            int move = currentPlayer.getMove();

            if (move != -1 && !model.gameFinished)
            {
                Debug.WriteLine($"Player {playerName} played cell {move}");
                model.move(move);
                checkIfTerminalState();


                if (currentPlayer.type == PlayerType.AI_PLAYER)
                {
                    Debug.WriteLine($"Player {playerName} turn {model.turn} delay started");
                    System.Threading.Thread.Sleep(moveDelay);
                    Debug.WriteLine($"Player {playerName} turn {model.turn} delay ended");

                }
            }
        }

        private async void turnWroker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker turnWorker = sender as BackgroundWorker;
            updateFromModel();
            if (testsRemaining > 0 && model.gameFinished)
            {
                Debug.WriteLine($"Game {testsRemaining} Finished");
                await Task.Delay(gameDelay);
                testsRemaining--;
                resetBoard(false);
            }
            else if (testsRemaining <= 0 && !model.gameFinished)
            {
                testingEnd(); // this will be called regardless if testing was started in the first place, and everytime after all tests are completed
                //todo fix
            }

            if (!model.gameFinished && !turnWorker.CancellationPending)
            {
                turnWorker.RunWorkerAsync();
            }



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
            playerIndicator.Text = $"Player {playerName}";
            displayWinner();
        }

        public async void play()
        {
            Player currentPlayer = GetCurrentPlayer();
            currentPlayer.startTurn(model);
            int move = currentPlayer.getMove();

            if (move != -1 && !model.gameFinished)
            {

                model.move(move);
                checkIfTerminalState();


                if (currentPlayer.type == PlayerType.AI_PLAYER)
                {
                    Debug.WriteLine($"Player {playerName} turn {model.turn} delay started");
                    await Task.Delay(moveDelay);
                    Debug.WriteLine($"Player {playerName} turn {model.turn} delay ended");

                }
            }
        }

        public async void testingStart(int numGames, int moveDelay, int gameDelay)
        {
            this.gameDelay = gameDelay;
            this.moveDelay = moveDelay;
            this.testsRemaining = numGames;

            TestStats.Visible = true;
            PlayerSelectorX.SelectedIndex = (int)PlayerType.AI_PLAYER;
            PlayerSelectorO.SelectedIndex = (int)PlayerType.AI_PLAYER;



        }

        public async void testingEnd()
        {
            this.gameDelay = 0;
            this.moveDelay = 0;
            this.testsRemaining = 0;
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
        public void resetBoard(bool startTurnWorker = true)
        {

            model = new BoardModel(this);
            playerIndicator.Text = $"Player {playerName}";
            winner.Text = $"";
            foreach (var player in players)
            {
                player.nextMove = -1;
            }
            updateFromModel();
            if (!turnWorker.IsBusy && startTurnWorker)
            {
                turnWorker.RunWorkerAsync();
            }
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

        public void displayWinner()
        {
            var state = model.gameState;
            var add = testsRemaining > 0 ? 1 : 0;
            if (state != 0)
            {
                var playerName = state == 1 ? "X" : "O";
                winner.Text = $"Player {playerName} Won!";
                // (this.Controls[$"{playerName}WinsCounter"] as Label).Text = "0";

            }
            else if (state == 0 && model.turn >= 9)
            {

                winner.Text = $"Draw";
            }
        }
        public void checkIfTerminalState()
        {
            var state = model.gameState;
            if (state != 0)
            {
                model.gameFinished = true;

            }
            else if (state == 0 && model.turn >= 9)
            {
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