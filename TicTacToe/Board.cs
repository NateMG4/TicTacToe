using System.Data.SqlTypes;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace TicTacToe
{
    public partial class Board : Form
    {

        public int turn = 0;
        private int playerNumber => turn % 2;
        public Player[] players { get; private set; } = new Player[2];
        private int[] currentBoard = new int[9];
        private string playerName => playerNumber == 0 ? "X" : "O";
        private Label[] cells;

        private bool gameFinished = false;
        private bool testing = false;
        public Board(PlayerType playerX, PlayerType playerO)
        {
            InitializeComponent();
            //playerX == PlayerType.HUMAN_PLAYER ? new HumanPlayer(1, this) : new AiPlayer(1, this)
            var pX = new HumanPlayer(-1, this);
            var pO = new AiPlayer(-1, this);
            players[0] = pX;
            players[1] = pO;

            this.cells = FindAllCells();
            resetBoard();

        }

        public void play()
        {
            if (gameFinished)
            {
                return;
            }
            Player currentPlayer = GetCurrentPlayer();
            int move = currentPlayer.getMove(currentBoard);
            playerIndicator.Text = $"Player {playerName}";

            if (move != -1)
            {
                currentBoard[move] = currentPlayer.playerID;
                DisplayMove(move);

                checkForWinner();

                turn++;
                play();
            }

        }

        private void testingStart(int numGames, int moveDelay, int gameDelay)
        {

        }


        public Label[] FindAllCells()
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
        public int EvalutateBoardState(int[] boardState, int playerNumber)
        {
            int[] pointCounter = new int[8];
            var playerID = players[playerNumber].playerID;
            for (int i = 0; i < boardState.Length; i++)
            {
                if (boardState[i] != playerID)
                {
                    continue;
                }
                int x = i % 3;
                int y = i / 3;
                pointCounter[x]++;
                pointCounter[y + 3]++;
                if (x == y)
                {
                    //Top-Left -> Bottom-Right Diagonal
                    pointCounter[6]++;
                }

                if (x + y == 2)
                {
                    //  Top-Right -> Bottom-Left Diagonal
                    pointCounter[7]++;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (pointCounter[i] == 3)
                {
                    return playerID; // Return 1 for player 0 win, and -1 for player 1 win
                }
            }
            return 0;

        }
        /// <summary>
        /// Current player plays if legal
        /// </summary>
        /// <param name="cell"> Cell that was clicked</param>
        // private void play(Label cell)
        // {
        //
        //
        //     // is play valid
        //     if (cell.Text != "" || winner.Text != "")
        //     {
        //         return;
        //     }
        //
        //     
        //     currentBoard[getIndex(getCords(cell))] = currentPlayer;
        //
        //     int gameState = evalutateBoardState(currentBoard, currentPlayer);
        //     // If win end game and announce/draw winner or draw
        //     if (gameState == 10)
        //     {
        //         winner.Text = $"Player {playerName} Won!";
        //     }
        //     else if (currentTurn >= 8)
        //     {
        //         winner.Text = $"Draw";
        //     }
        //     else
        //     {
        //         currentTurn++;
        //         playerIndicator.Text = $"Player {playerName}";
        //
        //
        //         // next player is ai player
        //         if(currentPlayer == aiPlayer && currentTurn <= 8)
        //         {
        //             var value = minmax(currentBoard, currentTurn);
        //             play(value[1]);
        //         }
        //
        //
        //     }
        //
        // }
        // private void play(int move) {
        //     int x = move % 3;
        //     int y = move / 3;
        //     var name = $"Cell{x}{y}";
        //     play(this.Controls[name] as Label);
        //
        // }


        public Tuple<int, int[]>[] getAllPosibleMoves(int[] boardState, int playerID)
        {
            int[] moves = boardState.Select((b, i) => b == 0 ? i : -1).Where(x => x != -1).ToArray();
            var possibleStates = new Tuple<int, int[]>[moves.Length];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                int move = moves[i];
                int x = move % 3;
                int y = move / 3;
                var state = (int[])boardState.Clone();
                state[x + y * 3] = playerID;
                possibleStates[i] = Tuple.Create(move, state);
            }

            return possibleStates;
        }

        // private int[] minmax(int[] boardState, int turn)
        // {
        //     int player = turn % 2;
        //     var possibleStates = getAllPosibleMoves(boardState, player);
        //     var values = new int[possibleStates.Length][];
        //     for (int i = 0; i < possibleStates.Length; i++)
        //     {
        //         (int[] state, int move) = possibleStates[i];
        //         int gameState = evalutateBoardState(state, player);
        //         if(gameState != 0 || turn == 8)
        //         {
        //             int[] terminalState = {player == aiPlayer ? gameState : -gameState, move};
        //             return terminalState;
        //         }
        //         values[i] = minmax(state, turn + 1);
        //     }
        //
        //
        //     if(turn == 3)
        //     {
        //         Console.WriteLine("test");
        //     }
        //     int modifier = player == aiPlayer ? 1 : -1;
        //     var bestMove = values[0];
        //     for(int n = 0; n<values.Length;n++)
        //     {
        //         if (values[n][0] * modifier < bestMove[0] * modifier)
        //         {
        //             bestMove = values[n];
        //         }
        //     }
        //     if (bestMove[0] == 0)
        //     {
        //         Console.WriteLine(bestMove[1]);
        //     }
        //     return bestMove;
        // }


        //0 = None
        //1,-1 = Win


        public void DisplayMove(int move)
        {
            Label cell = cells[move];
            cell.Text = playerName;

        }

        public Player GetCurrentPlayer()
        {
            return players[playerNumber];
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
            var textboxes = this.Controls.OfType<Control>().Where(x => x is Label);
            foreach (var textbox in textboxes)
            {
                textbox.Text = "";
            }
            turn = 0;
            playerIndicator.Text = $"Player {playerName}";
            currentBoard = new int[9];
            gameFinished = false;
            foreach (var player in players)
            {
                player.nextMove = -1;
            }
        }

        private void onCellClick(object sender, EventArgs e)
        {
            Player p = GetCurrentPlayer();
            if (p.type == PlayerType.HUMAN_PLAYER && (sender as Label).Text == "")
            {
                p.nextMove = getIndex(sender as Label);
                play();
            }
        }

        private void checkForWinner()
        {
            if (EvalutateBoardState(currentBoard, playerNumber) != 0)
            {
                winner.Text = $"Player {playerName} Won!";
                gameFinished = true;

            }
            else if (turn >= 8)
            {
                winner.Text = $"Draw";
                gameFinished = true;
            }
        }


    }

}