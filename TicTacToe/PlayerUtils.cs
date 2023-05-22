using System;

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
            return minmax(boardState, board.turn)[0];
        }


        private int[] minmax(int[] boardState, int turn)
        {
            int player = turn % 2;
            var possibleStates = board.getAllPosibleMoves(boardState, player);
            var values = new int[possibleStates.Length][];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                (int[] state, int move) = possibleStates[i];
                int gameState = board.EvalutateBoardState(state, player);
                if (gameState != 0 || (turn == 8 && gameState == 0))
                {
                    int[] terminalState = { move, gameState };
                    return terminalState;
                }

                values[i] = minmax(state, turn + 1);
            }


            int modifier = board.players[player].playerID == this.playerID ? this.playerID : -this.playerID;
            // var bestMove = values[0];
            var bestMove = 0;
            for (int n = 0; n < values.Length; n++)
            {
                // if (values[n][1] * modifier > bestMove[1] * modifier)
                if (values[n][1] * modifier > values[bestMove][1] * modifier)
                {
                    // bestMove = values[n];
                    bestMove = n;
                }

            }

            // if (bestMove[1] != 0)
            // {
            //     Console.WriteLine(bestMove[1]);
            // }
            // return bestMove;
            (int[] state2, int move2) = possibleStates[bestMove];
            int[] bestMoveTuple = {move2, values[bestMove][0]};
            return bestMoveTuple;
        }

    }
}
