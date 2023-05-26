using System.Diagnostics;
using System.Reflection;

namespace GameLogic;

public abstract class GameRunner
{
    public Game currentGame { get; protected set; }
    public GameRunner()
    {

    }

    public void CreateGame()
    {
        currentGame = new Game(this, getPlayerTypes());
    }

    public abstract List<PlayerType> getPlayerTypes();
    public abstract void TurnFinished();
    public abstract void GameFinished();
    public abstract void reset();
}

public class TestRunner : GameRunner
{
    private int numGames = 0;
    public bool finished = false;
    public int record = 0;
    public TestRunner(int numGames) : base()
    {
        this.numGames = numGames;
    }

    public void StartTest()
    {
        CreateGame();
    }
    public override void GameFinished()
    {
        Debug.WriteLine($"{numGames} Remaining");
        record += currentGame.model.gameState;
        numGames--;
        if (numGames >= 0)
        {
            reset();
        }
        else
        {
            finished = true;
        }
    }
    public void Run()
    {
        currentGame.WakeUp();
    }

    public override List<PlayerType> getPlayerTypes()
    {
        return new List<PlayerType>() { PlayerType.AI_PLAYER, PlayerType.AI_PLAYER };
    }

    public override void reset()
    {
        CreateGame();
    }

    public override void TurnFinished()
    {
        
    }
}

