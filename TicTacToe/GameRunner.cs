using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using GameLogic;
namespace TicTacToe;

public abstract class GameRunner : IGameRunner
{
    public Game currentGame { get; protected set; }
    public GameRunner()
    {

    }

    protected virtual void CreateGame()
    {
        currentGame = new Game(this, getPlayerTypes());
        currentGame.ModelChanged_Effect(null, null); // start the game with no sender or args
    }

    public abstract List<PlayerType> getPlayerTypes();
    public abstract void TurnFinished(object sender, EventArgs arg);
    public abstract void GameFinished(object sender, EventArgs arg);
    public abstract void reset();
    public abstract void AddPlayerToMoveInputEvent(Player p);
}



public class OfflineGameRunner : GameRunner
{
    private BoardView viewer;

    public OfflineGameRunner(BoardView viewer) : base()
    {
        this.viewer = viewer;
        CreateGame();
    }

    public override List<PlayerType> getPlayerTypes()
    {
        return viewer.getSelectedPlayerTypes();
    }

    public override void TurnFinished(object sender, EventArgs arg)
    {
        viewer.updateFromModel(currentGame.model);
    }

    public override void GameFinished(object sender, EventArgs arg)
    {
        viewer.updateFromModel(currentGame.model);
    }

    public override void reset()
    {
        CreateGame();
        viewer.resetBoard(currentGame.model);
    }
    public void reset(object sender, EventArgs arg)
    {
        reset();
    }

    public override void AddPlayerToMoveInputEvent(Player p)
    {
        if (p.type == PlayerType.HUMAN_PLAYER) {
            viewer.MoveInput += (p as HumanPlayer).recieveMoveInput;
        }
    }

}

//public class TestRunner : GameRunner
//{
//    private int numGames = 0;
//    public bool finished = false;
//    private BoardView viewer;
//    private int[] TestingResults = new int[3];
//    private int gameDelay = 0;
//    private int moveDelay = 0;
//    public TestRunner(int numGames, int moveDelay, int gameDelay) : base()
//    {
//        this.moveDelay = moveDelay;
//        this.gameDelay = gameDelay;
//        this.numGames = numGames;
//        viewer = new BoardView();
//        viewer.testingStart();
//        viewer.Show();
//        CreateGame();
//    }

//    public void CreateGame()
//    {
//        currentGame = new Game(this, getPlayerTypes(), moveDelay);

//    }
//    public override async void GameFinished()
//    {
//        TestingResults[currentGame.model.gameState + 1]++;
//        numGames--;
//        viewer.UpdateTestingResults(TestingResults);
//        await Task.Delay(gameDelay);
//        if (numGames > 0)
//        {
//            reset();
//        }
//        else
//        {
//            finished = true;
//        }
//    }

//    public override List<PlayerType> getPlayerTypes()
//    {
//        return new List<PlayerType>() { PlayerType.AI_PLAYER, PlayerType.AI_PLAYER };
//    }

//    public override void reset()
//    {
//        CreateGame();
//        viewer.resetBoard(currentGame.model);

//    }

//    public override void TurnFinished()
//    {
//        viewer.updateFromModel(currentGame.model);

//    }
//}


//public class ServerGameRunner : GameRunner
//{
//    BackgroundWorker ServerWorker = new BackgroundWorker();

//    private void InitializeBackgroundWorker()
//    {

//        ServerWorker.DoWork +=
//            new DoWorkEventHandler(ListenLoop);
//    }

//    private void Create_TCP_Server(string ip, Int32 port)
//    {
//        TcpListener server = null;
//        try
//        {
//            IPAddress localAddr = IPAddress.Parse(ip);

//            server = new TcpListener(localAddr, port);
//            server.Start();
//            ServerWorker.RunWorkerAsync(server);

//        }
//        catch (SocketException exception)
//        {
//            Debug.WriteLine("SocketException: {0}", exception);
//        }
//    }

//    private async void ListenLoop(object sender, DoWorkEventArgs e)
//    {
//        TcpListener server = (TcpListener)e.Argument;
//        // Buffer for reading data
//        Byte[] bytes = new Byte[256];
//        String data = null;

//        // Enter the listening loop.
//        while (true)
//        {
//            Debug.Write("Waiting for a connection... ");

//            // Perform a blocking call to accept requests.
//            // You could also use server.AcceptSocket() here.
//            using TcpClient client = await server.AcceptTcpClientAsync();
//            Debug.WriteLine("Connected!");

//            data = null;

//            // Get a stream object for reading and writing
//            await using NetworkStream stream = client.GetStream();

//            int i;

//            // Loop to receive all the data sent by the client.
//            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
//            {
//                // Translate data bytes to a ASCII string.
//                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
//                Debug.WriteLine("Received: {0}", data);

//                // Process the data sent by the client.
//                //ServerLog.Invoke(() => ServerLog.Text = data);


//                data = "Message Received";
//                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

//                // Send back a response.
//                stream.Write(msg, 0, msg.Length);
//                Debug.WriteLine("Sent: {0}", data);
//            }
//        }

//    }

//    public override void GameFinished()
//    {
//        throw new NotImplementedException();
//    }

//    public override List<PlayerType> getPlayerTypes()
//    {
//        throw new NotImplementedException();
//    }

//    public override void reset()
//    {
//        throw new NotImplementedException();
//    }

//    public override void TurnFinished()
//    {
//        throw new NotImplementedException();
//    }
//}

