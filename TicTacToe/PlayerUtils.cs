using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using static System.Windows.Forms.AxHost;

namespace TicTacToe
{
    public enum PlayerType
    {
        HUMAN_PLAYER,
        AI_PLAYER
    }

    public class Player
    {
        public int nextMove { protected get; set; } = -1;

        public PlayerType type { get; private set; }
        public int playerID { get; private set; }
        public Board board { get; private set; }
        public Player(PlayerType type, int playerId, Board board)
        {

            this.type = type;
            this.playerID = playerId;
            this.board = board;
        }

        public virtual int getMove(int[] boardState)
        {
            return 0;
        }
    }

    public class HumanPlayer : Player
    {
        public HumanPlayer(int playerId, Board board) : base(PlayerType.HUMAN_PLAYER, playerId, board)
        {
            
        }

        override public int getMove(int[] boardState)
        {
            int val = nextMove;
            nextMove = -1;
            return val;
        }
    }

    public class AiPlayer : Player
    {
        public AiPlayer(int playerId, Board board) : base(PlayerType.AI_PLAYER, playerId, board)
        {
        }

        public override int getMove(int[] boardState)
        {
            var possibleStates = board.getAllPosibleMoves(boardState, playerID);
            int bestMove = -1;
            int bestMoveValue = -10 * playerID;
            var values = new int[possibleStates.Length];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                (int move, int[] state) = possibleStates[i];

                values[i] = minmax(state, board.turn +1);
                if (values[i] * playerID > bestMoveValue * playerID)
                {
                    bestMove = move;
                    bestMoveValue = values[i];
                }

            }
            return bestMove;
        }


        private int minmax(int[] boardState, int turn)
        {
            int player = turn % 2;
            var playerId = board.players[player].playerID;
            int gameState = board.EvalutateBoardState(boardState, player);
            if (gameState != 0 || (turn == 8 && gameState == 0))
            {
                return gameState;
            }

            var possibleStates = board.getAllPosibleMoves(boardState, playerId);
            var values = new int[possibleStates.Length];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                (int move, int[] state) = possibleStates[i];


                values[i] = minmax(state, turn + 1);
            }


            // var bestMove = values[0];
            var best = 0;
            for (int n = 0; n < values.Length; n++)
            {
                // if (values[n][1] * modifier > bestMove[1] * modifier)
                if (values[n] * playerId > values[best] * playerId)
                {
                    // bestMove = values[n];
                    best = n;
                }

            }

            // if (bestMove[1] != 0)
            // {
            //     Console.WriteLine(bestMove[1]);
            // }
            // return bestMove;

            return values[best];
        }

    }
}
