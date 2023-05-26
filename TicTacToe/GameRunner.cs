 using System.Reflection;

namespace TicTacToe;

public abstract class GameRunner
{
    public Game currentGame { get; protected set; }
    public GameRunner()
    {

    }

    public virtual void CreateGame()
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
    private BoardView viewer;
    private int[] TestingResults = new int[3];
    private int gameDelay = 0;
    private int moveDelay = 0;
    public TestRunner(int numGames, int moveDelay, int gameDelay) : base()
    {
        this.moveDelay = moveDelay;
        this.gameDelay = gameDelay;
        this.numGames = numGames;
        viewer = new BoardView();
        viewer.testingStart();
        viewer.Show();
        CreateGame();
    }

    public void CreateGame()
    {
        currentGame = new Game(this, getPlayerTypes(), moveDelay);

    }
    public override async void GameFinished()
    {
        TestingResults[currentGame.model.gameState + 1]++;
        numGames--;
        viewer.UpdateTestingResults(TestingResults);
        await Task.Delay(gameDelay);
        if (numGames > 0)
        {
            reset();
        }
        else
        {
            finished = true;
        }
    }

    public override List<PlayerType> getPlayerTypes()
    {
        return new List<PlayerType>() { PlayerType.AI_PLAYER, PlayerType.AI_PLAYER };
    }

    public override void reset()
    {
        CreateGame();
        viewer.resetBoard(currentGame.model);

    }

    public override void TurnFinished()
    {
        viewer.updateFromModel(currentGame.model);

    }
}

public class ContinuousGameRunner : GameRunner
{
    private BoardView viewer;

    public ContinuousGameRunner(BoardView viewer) : base()
    {
        this.viewer = viewer;
        CreateGame();
    }

    public override List<PlayerType> getPlayerTypes()
    {
        return viewer.getSelectedPlayerTypes();
    }

    public override void TurnFinished()
    {
        viewer.updateFromModel(currentGame.model);
    }

    public override void GameFinished()
    {
        viewer.updateFromModel(currentGame.model);
    }

    public override void reset()
    {
        CreateGame();
        viewer.resetBoard(currentGame.model);
    }

    public void CellClicked(int move)
    {
        currentGame.currentPlayer.setMove(move);
    }
}
