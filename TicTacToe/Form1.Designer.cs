namespace TicTacToe
{
    partial class Form1
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            moveDelay = new Label();
            gameDelay = new Label();
            gameCount = new Label();
            numericUpDown3 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(87, 193);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 0;
            button1.Text = "Run Tests";
            button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(113, 92);
            numericUpDown1.Margin = new Padding(5, 6, 5, 6);
            numericUpDown1.MinimumSize = new Size(50, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 29);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(113, 154);
            numericUpDown2.Margin = new Padding(5, 6, 5, 6);
            numericUpDown2.MinimumSize = new Size(50, 0);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(50, 29);
            numericUpDown2.TabIndex = 2;
            // 
            // moveDelay
            // 
            moveDelay.AutoSize = true;
            moveDelay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moveDelay.Location = new Point(41, 65);
            moveDelay.Margin = new Padding(4, 0, 4, 0);
            moveDelay.Name = "moveDelay";
            moveDelay.Size = new Size(196, 21);
            moveDelay.TabIndex = 3;
            moveDelay.Text = "Move Delay (milliseconds) ";
            // 
            // gameDelay
            // 
            gameDelay.AutoSize = true;
            gameDelay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameDelay.Location = new Point(41, 127);
            gameDelay.Margin = new Padding(4, 0, 4, 0);
            gameDelay.Name = "gameDelay";
            gameDelay.Size = new Size(198, 21);
            gameDelay.TabIndex = 4;
            gameDelay.Text = "Game Delay (milliseconds) ";
            // 
            // gameCount
            // 
            gameCount.AutoSize = true;
            gameCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameCount.Location = new Point(94, 9);
            gameCount.Margin = new Padding(4, 0, 4, 0);
            gameCount.Name = "gameCount";
            gameCount.Size = new Size(89, 21);
            gameCount.TabIndex = 6;
            gameCount.Text = "# of Games";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(113, 33);
            numericUpDown3.MinimumSize = new Size(50, 0);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(50, 29);
            numericUpDown3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 238);
            Controls.Add(gameCount);
            Controls.Add(numericUpDown3);
            Controls.Add(gameDelay);
            Controls.Add(moveDelay);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Test Options";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label moveDelay;
        private Label gameDelay;
        private Label gameCount;
        private NumericUpDown numericUpDown3;
    }
}