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
            
        }
    }
}