﻿using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Markup;

namespace GameLogic
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
        public Player(PlayerType type, int playerId)
        {

            this.type = type;
            this.playerID = playerId;
        }

        /// <summary>
        /// Player Factory
        /// </summary>
        /// <param name="type"></param>
        /// <param name="playerId"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Player create(PlayerType type, int playerId)
        {
            switch(type)
            {
                case PlayerType.HUMAN_PLAYER:
                    return new HumanPlayer(playerId);
                case PlayerType.AI_PLAYER:
                    return new AiPlayer(playerId);

            }
            throw new NotImplementedException($"Unknown player type {type}");
        }
        public int getMove()
        {
            int val = nextMove;
            nextMove = -1;
            return val;
        }


        public virtual bool startTurn(BoardModel boardState)
        {
            return nextMove != -1;
        }
        public virtual void endTurn()
        {

        }

        public virtual void setMove(int move)
        {
        }
    }

    public class HumanPlayer : Player
    {
        public HumanPlayer(int playerId) : base(PlayerType.HUMAN_PLAYER, playerId)
        {
            
        }

        public override void setMove(int move)
        {
            Debug.WriteLine($"Move for cell {move} set");
            nextMove = move;
        }

    }

    public class AiPlayer : Player
    {
        public AiPlayer(int playerId) : base(PlayerType.AI_PLAYER, playerId)
        {
        }

         public override bool startTurn(BoardModel boardState)
        {
            Random rand = new Random();
            var possibleStates = boardState.getNextMoves();
            if (boardState.turn <= 0)
            {
                nextMove = possibleStates[rand.Next(0, possibleStates.Length)].previousMove;
                return true;
            }

            int bestMove = -1;
            int bestMoveValue = -10 * playerID;
            // remove values array
            var values = new int[possibleStates.Length];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                var model = possibleStates[i];

                values[i] = minmax(model);
                if (values[i] * playerID > bestMoveValue * playerID)
                {
                    bestMove = model.previousMove;
                    bestMoveValue = values[i];
                }

            }
            nextMove = bestMove;
            return true;
        }


        private int minmax(BoardModel boardState)
        {
/*            int player = turn % 2;
            var playerId = board.players[player].playerID;*/

            int gameState = boardState.EvalutateBoardState();
            if (gameState != 0 || (boardState.turn >= 9 && gameState == 0))
            {
                return gameState;
            }

            var possibleStates = boardState.getNextMoves();
            var values = new int[possibleStates.Length];
            for (int i = 0; i < possibleStates.Length; i++)
            {
                var model = possibleStates[i];


                values[i] = minmax(model);
            }


            var bestIndex = 0;
            for (int n = 0; n < values.Length; n++)
            {
                if (values[n] * boardState.playerID> values[bestIndex] * boardState.playerID)
                {
                    bestIndex = n;
                }

            }


            return values[bestIndex];
        }

    }
}