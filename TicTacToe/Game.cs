using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace TicTacToe;

public class Game
{
    public Player[] players { get; private set; } = new Player[2];
    public BoardModel model { get; private set;}
    public GameRunner runner { get; private set; }
    BackgroundWorker turnWorker = new BackgroundWorker();

    public Game(GameRunner runner)
    {
        model = new BoardModel(this);
        this.runner = runner;
        turnWorker.RunWorkerAsync();
        this.runner = runner;
    }

    private async void GameLoop(object sender, DoWorkEventArgs e)
    {
        while (!model.gameFinished)
        {
            Player currentPlayer = players[model.playerNumber];
            currentPlayer.startTurn(model);

            int move = currentPlayer.getMove();
            if (move != -1)
            {
                model.move(move);
                model.checkIfTerminalState();
            }
        }
    }

    private async void GameFinished(object sender, RunWorkerCompletedEventArgs e)
    {

    }
    private void GameProgress(object sender, ProgressChangedEventArgs e)
    {

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
                GameProgress);

    }
}