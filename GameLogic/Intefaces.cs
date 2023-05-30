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
        void TurnFinished(object sender, EventArgs arg);
        void GameFinished(object sender, EventArgs arg);
        void reset();
        void AddPlayerToMoveInputEvent(Player p);
    }


}
