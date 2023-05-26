using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TestingUtils : Form
    {

        TestRunner runner { get; set; }
        public TestingUtils(BoardView board)
        {
            InitializeComponent();

        }

        private void runTests(object sender, EventArgs e)
        {
            this.runner = new TestRunner((int)numGames.Value, (int)moveDelay.Value, (int)gameDelay.Value);

        }
    }


}
