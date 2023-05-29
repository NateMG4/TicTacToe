using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{

    public class BoardModel
    {
        public int turn { get; private set; } = 0;
        public int playerNumber => turn % 2;
        protected int[] data = new int[9];
        public int previousMove { get; private set; } = -1;
        public int gameState => EvalutateBoardState();
        public bool gameFinished = false;
        public int playerID => playerNumber == 0 ? 1 : -1;

        public BoardModel() { 

        }

        public override bool Equals(object? obj)
        {
            BoardModel other = obj as BoardModel;
            if (other == null) return false;
            return data.SequenceEqual(other.data) &&  turn == other.turn;
        }
        public BoardModel DeepCopy()
        {
            BoardModel copy = new BoardModel();
            Array.Copy(this.data, copy.data, this.data.Length);
            copy.turn = this.turn;
            return copy;
        }

        public int getCellState(int cellIndex)
        {
            return data[cellIndex];
        }
        public void move(int cellIndex)
        {
            if(cellIndex < 0 || cellIndex >= data.Length)
            {
                return;
            }
            if (data[cellIndex] == 0)
            {
                data[cellIndex] = playerID;
                previousMove = cellIndex;
                turn++;

                checkIfTerminalState();
            }
        }


        public int EvalutateBoardState()
        {
            for (int p = 0; p < 2; p++)
            {
                var playerID = p == 0 ? 1 : -1;
                int[] pointCounter = new int[8];
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
        public void checkIfTerminalState()
        {
            var state = gameState;
            if (state != 0)
            {
                gameFinished = true;

            }
            else if (state == 0 && turn >= 9)
            {
                gameFinished = true;
            }
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
            model.move(move);
            return model;

        }
    }

    public class TestBoardModel : BoardModel
    {
        public TestBoardModel(int[] data) {
            this.data = data;
        }
        public TestBoardModel(string movesString)
        {
            var movesChars = movesString.ToCharArray();
            foreach(var mChar in movesChars)
            {
                int move = (int)mChar - '0';
                this.move(move);
            }

        }
    }
}
