namespace TicTacToe
{
    partial class TestingUtils
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            moveDelay = new NumericUpDown();
            gameDelay = new NumericUpDown();
            moveDelayLabel = new Label();
            gameDelayLabel = new Label();
            gameCount = new Label();
            numGames = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)moveDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGames).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(101, 260);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(125, 42);
            button1.TabIndex = 0;
            button1.Text = "Run Tests";
            button1.UseVisualStyleBackColor = true;
            button1.Click += runTests;
            // 
            // moveDelay
            // 
            moveDelay.AutoSize = true;
            moveDelay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moveDelay.Location = new Point(125, 128);
            moveDelay.Margin = new Padding(5, 6, 5, 6);
            moveDelay.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            moveDelay.MinimumSize = new Size(50, 0);
            moveDelay.Name = "moveDelay";
            moveDelay.Size = new Size(103, 39);
            moveDelay.TabIndex = 1;
            moveDelay.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // gameDelay
            // 
            gameDelay.AutoSize = true;
            gameDelay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameDelay.Location = new Point(125, 211);
            gameDelay.Margin = new Padding(5, 6, 5, 6);
            gameDelay.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            gameDelay.MinimumSize = new Size(50, 0);
            gameDelay.Name = "gameDelay";
            gameDelay.Size = new Size(103, 39);
            gameDelay.TabIndex = 2;
            gameDelay.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // moveDelayLabel
            // 
            moveDelayLabel.AutoSize = true;
            moveDelayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moveDelayLabel.Location = new Point(13, 90);
            moveDelayLabel.Margin = new Padding(4, 0, 4, 0);
            moveDelayLabel.Name = "moveDelayLabel";
            moveDelayLabel.Size = new Size(301, 32);
            moveDelayLabel.TabIndex = 3;
            moveDelayLabel.Text = "Move Delay (milliseconds) ";
            // 
            // gameDelayLabel
            // 
            gameDelayLabel.AutoSize = true;
            gameDelayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameDelayLabel.Location = new Point(12, 173);
            gameDelayLabel.Margin = new Padding(4, 0, 4, 0);
            gameDelayLabel.Name = "gameDelayLabel";
            gameDelayLabel.Size = new Size(302, 32);
            gameDelayLabel.TabIndex = 4;
            gameDelayLabel.Text = "Game Delay (milliseconds) ";
            // 
            // gameCount
            // 
            gameCount.AutoSize = true;
            gameCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameCount.Location = new Point(95, 13);
            gameCount.Margin = new Padding(4, 0, 4, 0);
            gameCount.Name = "gameCount";
            gameCount.Size = new Size(136, 32);
            gameCount.TabIndex = 6;
            gameCount.Text = "# of Games";
            // 
            // numGames
            // 
            numGames.AutoSize = true;
            numGames.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numGames.Location = new Point(125, 48);
            numGames.MinimumSize = new Size(50, 0);
            numGames.Name = "numGames";
            numGames.Size = new Size(77, 39);
            numGames.TabIndex = 5;
            numGames.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // TestingUtils
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 306);
            Controls.Add(gameCount);
            Controls.Add(numGames);
            Controls.Add(gameDelayLabel);
            Controls.Add(moveDelayLabel);
            Controls.Add(gameDelay);
            Controls.Add(moveDelay);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TestingUtils";
            Text = "Test Options";
            ((System.ComponentModel.ISupportInitialize)moveDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown moveDelay;
        private NumericUpDown gameDelay;
        private Label moveDelayLabel;
        private Label gameDelayLabel;
        private Label gameCount;
        private NumericUpDown numGames;
    }
}