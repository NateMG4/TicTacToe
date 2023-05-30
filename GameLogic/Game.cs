using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace GameLogic;

public class Game
{
    public Player[] players { get; private set; } = new Player[2];
    public BoardModel model { get; private set; }
    public IGameRunner runner { get; private set; }
    public int moveDelay = 0;
    public Player currentPlayer { get; private set; }
    BackgroundWorker turnWorker = new BackgroundWorker();
    public bool IsPaused => !turnWorker.IsBusy;

    public Game(IGameRunner runner, List<PlayerType> types)
    {
        Initialize(runner, types);
    }
    public Game(IGameRunner runner, List<PlayerType> types, int moveDelay)
    {
        this.moveDelay = moveDelay;
        Initialize(runner, types);
    }
    private void Initialize(IGameRunner runner, List<PlayerType> types)
    {
        //InitializeBackgroundWorker();

        model = new BoardModel();
        model.ModelChanged += ModelChanged_Effect;
        players[0] = Player.create(types[0], 1);
        players[1] = Player.create(types[1], -1);
        players[0].HasMove += ModelChanged_Effect;
        players[1].HasMove += ModelChanged_Effect;
        currentPlayer = null;

        this.runner = runner;
        GameStateChanged += runner.TurnFinished;
        GameFinished += runner.GameFinished;


        foreach(Player p in players)
        {
            if(p.type == PlayerType.HUMAN_PLAYER)
            {
                runner.AddPlayerToMoveInputEvent(p);
            }
        }

        //turnWorker.RunWorkerAsync();
    }
    public void ModelChanged_Effect(object sender, EventArgs args)
    {

        // TODO: change active player?
        if(sender as Player == currentPlayer && currentPlayer != null)
        {
            int move = currentPlayer.getMove();
            model.move(move);
        }
        if (model.gameFinished)
        {
            GameFinished_Trigger();
            return;
        }
        var next = players[model.playerNumber];
        if(next != currentPlayer)
        {
            //todo end current player turn
            currentPlayer = next;
            currentPlayer.startTurn(model.DeepCopy());
        }

        GameStateChanged_Trigger();
    }

    public event EventHandler<EventArgs> GameStateChanged;
    protected void GameStateChanged_Trigger()
    {
        var evt = GameStateChanged;

        // Event will be null if there are no subscribers
        if (evt != null)
        {
            EventArgs args = new EventArgs();
            evt(this, args);
        }
    }

    public event EventHandler<EventArgs> GameFinished;
    protected void GameFinished_Trigger()
    {
        var mcEvent = GameFinished;

        // Event will be null if there are no subscribers
        if (mcEvent != null)
        {
            EventArgs args = new EventArgs();
            mcEvent(this, args);
        }
    }
    

    //public void Wake()
    //{
    //    turnWorker.RunWorkerAsync();
    //}
    //private async void GameLoop(object sender, DoWorkEventArgs e)
    //{
    //    BackgroundWorker worker = sender as BackgroundWorker;
    //    while (!model.gameFinished && !currentPlayer.WaitForMove)
    //    {
    //        currentPlayer = players[model.playerNumber];
    //        if (currentPlayer.startTurn(model))
    //        {
    //            int move = currentPlayer.getMove();

    //            model.move(move);
    //            worker.ReportProgress(model.turn / 9);
    //        }

    //        Thread.Sleep(moveDelay);

    //    }
    //}

    //private async void GameFinished(object sender, RunWorkerCompletedEventArgs e)
    //{

    //    runner.GameFinished();

    //}
    //private void TurnFinished(object sender, ProgressChangedEventArgs e)
    //{
    //    runner.TurnFinished();

    //}

    //private void InitializeBackgroundWorker()
    //{
    //    this.turnWorker.WorkerReportsProgress = true;
    //    // this.turnWorker.WorkerSupportsCancellation = true;

    //    turnWorker.DoWork +=
    //        new DoWorkEventHandler(GameLoop);

    //    turnWorker.RunWorkerCompleted +=
    //        new RunWorkerCompletedEventHandler(
    //            GameFinished);

    //    turnWorker.ProgressChanged +=
    //        new ProgressChangedEventHandler(
    //            TurnFinished);

    //}
}