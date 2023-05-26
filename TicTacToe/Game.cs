using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace TicTacToe;

public class Game
{
    public Player[] players { get; private set; } = new Player[2];
    public BoardModel model { get; private set;}
    public GameRunner runner { get; private set; }

    public Player currentPlayer { get; private set; }
    BackgroundWorker turnWorker = new BackgroundWorker();

    public Game(GameRunner runner, List<PlayerType> types)
    {
        InitializeBackgroundWorker();

        model = new BoardModel();
        players[0] = Player.create(types[0],1);
        players[1] = Player.create(types[1], -1);
        currentPlayer = players[0];
        this.runner = runner;
        turnWorker.RunWorkerAsync();
    }

    private async void GameLoop(object sender, DoWorkEventArgs e)
    {
        BackgroundWorker worker = sender as BackgroundWorker;
        while (!model.gameFinished)
        {
            currentPlayer = players[model.playerNumber];
            if (currentPlayer.startTurn(model))
            {
                int move = currentPlayer.getMove();

                model.move(move);
                worker.ReportProgress(model.turn / 9);
            }

            // await Task.Delay(500);

        }
    }

    private async void GameFinished(object sender, RunWorkerCompletedEventArgs e)
    {
        runner.GameFinished();

    }
    private void TurnFinished(object sender, ProgressChangedEventArgs e)
    {
        runner.TurnFinished();

    }

    private void InitializeBackgroundWorker()
    {
        this.turnWorker.WorkerReportsProgress = true;
        // this.turnWorker.WorkerSupportsCancellation = true;

        turnWorker.DoWork +=
            new DoWorkEventHandler(GameLoop);

        turnWorker.RunWorkerCompleted +=
            new RunWorkerCompletedEventHandler(
                GameFinished);

        turnWorker.ProgressChanged +=
            new ProgressChangedEventHandler(
                TurnFinished);

    }
}