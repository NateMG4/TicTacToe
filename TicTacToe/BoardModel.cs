using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class BoardModel
    {
        private BoardView boardView;
        public int turn { get; private set; } = 0;
        public int playerNumber => turn % 2;
        private int[] data = new int[9];
        public int previousMove { get; private set; } = -1;
        public int gameState => EvalutateBoardState();
        public bool gameFinished = false;
        public int playerID => boardView.players[playerNumber].playerID;

        public BoardModel(BoardView view) { 

            boardView = view;
        }
        public BoardModel DeepCopy()
        {
            BoardModel copy = new BoardModel(boardView);
            Array.Copy(this.data, copy.data, this.data.Length);
            copy.turn = this.turn;
            return copy;
        }

        public int getState(int cellIndex)
        {
            return data[cellIndex];
        }
        public void move(int cellIndex)
        {
            hiddenMove(cellIndex);
            boardView.updateFromModel();

        }
        public void hiddenMove(int cellIndex)
        {
            if (data[cellIndex] == 0)
            {
                data[cellIndex] = playerID;
                previousMove = cellIndex;
                turn++;


            }

        }


        public int EvalutateBoardState()
        {
            for (int p = 0; p < 2; p++)
            {
                int[] pointCounter = new int[8];
                var playerID = boardView.players[p].playerID;
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != playerID)
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
            }
            return 0;

        }


        public BoardModel[] getNextMoves()
        {
            int[] moves = data.Select((b, i) => b == 0 ? i : -1).Where(x => x != -1).ToArray();
            var possibleStates = new BoardModel[moves.Length];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                int move = moves[i];
/*                int x = move % 3;
                int y = move / 3;*/

                var model = modelFuture(move);
                possibleStates[i] = model;
            }

            return possibleStates;
        }

        private BoardModel modelFuture(int move)
        {
            BoardModel model = this.DeepCopy();
            model.hiddenMove(move);
            return model;

        }
    }
}
