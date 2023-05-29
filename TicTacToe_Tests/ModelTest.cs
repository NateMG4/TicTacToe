using GameLogic;

namespace TestProject1
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void TestBlank()
        {
            BoardModel board = new BoardModel();
            Assert.AreEqual(0, board.turn);
            Assert.AreEqual(0, board.playerNumber);
            Assert.AreEqual(1, board.playerID);
            Assert.AreEqual(0, board.gameState);
            Assert.IsFalse(board.gameFinished);
            


            for (int i = 0; i < 9; i++)
            {
                Assert.AreEqual(0,board.getCellState(i));
            }
           

        }
        [TestMethod]
        public void TestFirstMove()
        {
            for (int i = 0; i < 9; i++)
            {
                BoardModel board = new BoardModel();

                board.move(i);
                Assert.AreEqual(1, board.getCellState(i));
            }


        }

        [TestMethod]
        public void TestSecondMove()
        {
            for (int i = 1; i < 9; i++)
            {
                BoardModel board = new BoardModel();
                board.move(0);
                board.move(i);
                Assert.AreEqual(-1, board.getCellState(i));
            }
        }

        [TestMethod]
        public void InvalidMove()
        {
            BoardModel board = new BoardModel();
            board.move(-1);
            Assert.AreEqual(0, board.turn);
            board.move(10);
            Assert.AreEqual(0, board.turn);
        }

        [TestMethod]
        public void OccupiedMove()
        {
            BoardModel board = new BoardModel();
            board.move(0);
            Assert.AreEqual(1, board.turn);
            Assert.AreEqual(1, board.getCellState(0));

            board.move(0);
            Assert.AreEqual(1, board.turn);
            Assert.AreEqual(1, board.getCellState(0));

        }

        [TestMethod]
        public void TestDeepCopy()
        {
            BoardModel board = new BoardModel();
            BoardModel copy = board.DeepCopy();
            Assert.AreEqual(board, copy);
            Assert.IsFalse(board == copy);
            copy.move(1);
            Assert.AreNotEqual(board, copy);


        }
        [TestMethod]
        public void TestEvaluateWins()
        {
            // X Wins on bottom row
            var board = new TestBoardModel("617482");
            Assert.AreEqual(board.gameState, 1);
            Assert.IsTrue(board.gameFinished);

            // O Wins on top row
            board = new TestBoardModel("506182");
            Assert.AreEqual(board.gameState,-1);
            Assert.IsTrue(board.gameFinished);

            // X Wins on left column
            board = new TestBoardModel("013268");
            Assert.AreEqual(board.gameState, 1);
            Assert.IsTrue(board.gameFinished);

            // O Wins on left column
            board = new TestBoardModel("102386");
            Assert.AreEqual(board.gameState, -1);
            Assert.IsTrue(board.gameFinished);

            //X wins on TopRight -> BottomLeft Diagonal
            board = new TestBoardModel("014287");
            Assert.AreEqual(board.gameState, 1);
            Assert.IsTrue(board.gameFinished);

            //P wins on BottomRight -> TopLeft Diagonal
            board = new TestBoardModel("021456");
            Assert.AreEqual(board.gameState, -1);
            Assert.IsTrue(board.gameFinished);


        }

        [TestMethod]
        public void TestDraw()
        {
            var board = new TestBoardModel("012345");
            Assert.AreEqual(board.gameState, 0);
            Assert.IsFalse(board.gameFinished);
        }
    }
}