using System.Data.SqlTypes;
using System.Drawing;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        int[] currentBoard = Enumerable.Repeat(-1, 9).ToArray();
        int currentTurn = 0;
        int currentPlayer => currentTurn % 2;
        int aiPlayer = 1;
        string playerName => currentPlayer == 0 ? "X" : "O";


        public Form1()
        {
            InitializeComponent();
            resetBoard();
        }

        /// <summary>
        /// Current player plays if legal
        /// </summary>
        /// <param name="cell"> Cell that was clicked</param>
        private void play(Label cell)
        {


            // is play valid
            if (cell.Text != "" || winner.Text != "")
            {
                return;
            }

            cell.Text = currentPlayer == 0 ? "X" : "O";
            currentBoard[getIndex(getCords(cell))] = currentPlayer;

            int gameState = evalutateBoardState(currentBoard, currentPlayer);
            // If win end game and announce/draw winner or draw
            if (gameState == 10)
            {
                winner.Text = $"Player {playerName} Won!";
            }
            else if (currentTurn >= 8)
            {
                winner.Text = $"Draw";
            }
            else
            {
                currentTurn++;
                playerIndicator.Text = $"Player {playerName}";


                // next player is ai player
                if(currentPlayer == aiPlayer && currentTurn <= 8)
                {
                    var value = minmax(currentBoard, currentTurn);
                    play(value[1]);
                }


            }

        }
        private void play(int move) {
            int x = move % 3;
            int y = move / 3;
            var name = $"Cell{x}{y}";
            play(this.Controls[name] as Label);

        }


        private Tuple<int[],int>[] getAllPosibleMoves(int[] boardState, int player)
        {
            int[] moves = boardState.Select((b, i) => b == -1 ? i : -1).Where(x => x != -1).ToArray();
            var possibleStates = new Tuple<int[], int>[moves.Length];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                int move = moves[i];
                int x = move % 3;
                int y = move / 3;
                var state =(int[]) boardState.Clone();
                state[x + y * 3] = player;
                possibleStates[i] = Tuple.Create(state, move);
            }

            return possibleStates;
        }

        private int[] minmax(int[] boardState, int turn)
        {
            int player = turn % 2;
            var possibleStates = getAllPosibleMoves(boardState, player);
            var values = new int[possibleStates.Length][];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                (int[] state, int move) = possibleStates[i];
                int gameState = evalutateBoardState(state, player);
                if(gameState != 0 || turn == 8)
                {
                    int[] terminalState = {player == aiPlayer ? gameState : -gameState, move};
                    return terminalState;
                }
                values[i] = minmax(state, turn + 1);
            }


            if(turn == 3)
            {
                Console.WriteLine("test");
            }
            int modifier = player == aiPlayer ? 1 : -1;
            var bestMove = values[0];
            for(int n = 0; n<values.Length;n++)
            {
                if (values[n][0] * modifier < bestMove[0] * modifier)
                {
                    bestMove = values[n];
                }
            }
            if (bestMove[0] == 0)
            {
                Console.WriteLine(bestMove[1]);
            }
            return bestMove;
        }


        //0 = None
        //1 = Win
        //2 = Draw
        private int evalutateBoardState(int[] boardState, int player)
        {
            int[,] gameState = new int[2, 8];
            for (int i = 0; i <  boardState.Length; i++)
            {
                if (boardState[i] == -1)
                {
                    continue;
                }
                int playerIndex = boardState[i];
                int x = i % 3;
                int y = i / 3;
                gameState[playerIndex, x]++;
                gameState[playerIndex, y + 3]++;
                if (x == y)
                {
                    gameState[playerIndex, 6]++;
                }
                if (x + y == 2)
                {
                    gameState[playerIndex, 7]++;

                }

            }
            for (int i = 0; i < 8; i++)
            {
                if (gameState[player, i] == 3)
                {
                    return 10;
                }
            }
            return 0;
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
        private int getIndex(Point p)
        {
            return p.X + p.Y * 3;
        }
        public void resetBoard()
        {
            var textboxes = this.Controls.OfType<Control>().Where(x => x is Label);
            foreach (var textbox in textboxes)
            {
                textbox.Text = "";
            }
            currentTurn = 0;
            playerIndicator.Text = $"Player {playerName}";
            currentBoard = Enumerable.Repeat(-1, 9).ToArray();
        }

        private void onCellClick(object sender, EventArgs e)
        {
            play(sender as Label);
        }
    }

}