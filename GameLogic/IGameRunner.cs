using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public interface IGameRunner
    {

        List<PlayerType> getPlayerTypes();
        void TurnFinished();
        void GameFinished();
        void reset();
    }
}
