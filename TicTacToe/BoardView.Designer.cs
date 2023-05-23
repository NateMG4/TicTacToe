namespace TicTacToe
{
    partial class BoardView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cell01 = new Label();
            Cell02 = new Label();
            Cell12 = new Label();
            Cell22 = new Label();
            Cell10 = new Label();
            Cell00 = new Label();
            Cell21 = new Label();
            Cell20 = new Label();
            Cell11 = new Label();
            resetButton = new Button();
            winner = new Label();
            playerIndicator = new Label();
            toolStrip1 = new ToolStrip();
            label1 = new Label();
            PlayerSelectorX = new ComboBox();
            PlayerSelectorO = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Cell01
            // 
            Cell01.BorderStyle = BorderStyle.FixedSingle;
            Cell01.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell01.Location = new Point(134, 247);
            Cell01.Margin = new Padding(0);
            Cell01.Name = "Cell01";
            Cell01.Size = new Size(100, 100);
            Cell01.TabIndex = 3;
            Cell01.Text = "X";
            Cell01.TextAlign = ContentAlignment.MiddleCenter;
            Cell01.Click += onCellClick;
            // 
            // Cell02
            // 
            Cell02.BorderStyle = BorderStyle.FixedSingle;
            Cell02.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell02.Location = new Point(134, 347);
            Cell02.Margin = new Padding(0);
            Cell02.Name = "Cell02";
            Cell02.Size = new Size(100, 100);
            Cell02.TabIndex = 6;
            Cell02.Text = "X";
            Cell02.TextAlign = ContentAlignment.MiddleCenter;
            Cell02.Click += onCellClick;
            // 
            // Cell12
            // 
            Cell12.BorderStyle = BorderStyle.FixedSingle;
            Cell12.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell12.Location = new Point(234, 347);
            Cell12.Margin = new Padding(0);
            Cell12.Name = "Cell12";
            Cell12.Size = new Size(100, 100);
            Cell12.TabIndex = 7;
            Cell12.Text = "X";
            Cell12.TextAlign = ContentAlignment.MiddleCenter;
            Cell12.Click += onCellClick;
            // 
            // Cell22
            // 
            Cell22.BorderStyle = BorderStyle.FixedSingle;
            Cell22.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell22.Location = new Point(334, 347);
            Cell22.Margin = new Padding(0);
            Cell22.Name = "Cell22";
            Cell22.Size = new Size(100, 100);
            Cell22.TabIndex = 8;
            Cell22.Text = "X";
            Cell22.TextAlign = ContentAlignment.MiddleCenter;
            Cell22.Click += onCellClick;
            // 
            // Cell10
            // 
            Cell10.BorderStyle = BorderStyle.FixedSingle;
            Cell10.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell10.Location = new Point(234, 147);
            Cell10.Margin = new Padding(0);
            Cell10.Name = "Cell10";
            Cell10.Size = new Size(100, 100);
            Cell10.TabIndex = 1;
            Cell10.Text = "X";
            Cell10.TextAlign = ContentAlignment.MiddleCenter;
            Cell10.Click += onCellClick;
            // 
            // Cell00
            // 
            Cell00.BorderStyle = BorderStyle.FixedSingle;
            Cell00.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell00.Location = new Point(134, 147);
            Cell00.Margin = new Padding(0);
            Cell00.Name = "Cell00";
            Cell00.Size = new Size(100, 100);
            Cell00.TabIndex = 0;
            Cell00.Text = "X";
            Cell00.TextAlign = ContentAlignment.MiddleCenter;
            Cell00.Click += onCellClick;
            // 
            // Cell21
            // 
            Cell21.BorderStyle = BorderStyle.FixedSingle;
            Cell21.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell21.Location = new Point(334, 247);
            Cell21.Margin = new Padding(0);
            Cell21.Name = "Cell21";
            Cell21.Size = new Size(100, 100);
            Cell21.TabIndex = 5;
            Cell21.Text = "X";
            Cell21.TextAlign = ContentAlignment.MiddleCenter;
            Cell21.Click += onCellClick;
            // 
            // Cell20
            // 
            Cell20.BorderStyle = BorderStyle.FixedSingle;
            Cell20.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell20.Location = new Point(334, 147);
            Cell20.Margin = new Padding(0);
            Cell20.Name = "Cell20";
            Cell20.Size = new Size(100, 100);
            Cell20.TabIndex = 2;
            Cell20.Text = "X";
            Cell20.TextAlign = ContentAlignment.MiddleCenter;
            Cell20.Click += onCellClick;
            // 
            // Cell11
            // 
            Cell11.BorderStyle = BorderStyle.FixedSingle;
            Cell11.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell11.Location = new Point(234, 247);
            Cell11.Margin = new Padding(0);
            Cell11.Name = "Cell11";
            Cell11.Size = new Size(100, 100);
            Cell11.TabIndex = 4;
            Cell11.Text = "X";
            Cell11.TextAlign = ContentAlignment.MiddleCenter;
            Cell11.Click += onCellClick;
            // 
            // resetButton
            // 
            resetButton.AutoSize = true;
            resetButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(243, 86);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(81, 42);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // winner
            // 
            winner.AutoSize = true;
            winner.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            winner.Location = new Point(183, 464);
            winner.Name = "winner";
            winner.Size = new Size(201, 32);
            winner.TabIndex = 10;
            winner.Text = "Game in progress";
            winner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerIndicator
            // 
            playerIndicator.AutoSize = true;
            playerIndicator.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            playerIndicator.Location = new Point(234, 34);
            playerIndicator.Name = "playerIndicator";
            playerIndicator.Size = new Size(98, 32);
            playerIndicator.TabIndex = 11;
            playerIndicator.Text = "Player 1";
            playerIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(584, 25);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 215);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 14;
            label1.Text = "AI Player";
            // 
            // PlayerSelectorX
            // 
            PlayerSelectorX.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerSelectorX.FormattingEnabled = true;
            PlayerSelectorX.Location = new Point(0, 280);
            PlayerSelectorX.Name = "PlayerSelectorX";
            PlayerSelectorX.Size = new Size(121, 29);
            PlayerSelectorX.TabIndex = 15;
            PlayerSelectorX.SelectedIndexChanged += createPlayers;
            // 
            // PlayerSelectorO
            // 
            PlayerSelectorO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerSelectorO.FormattingEnabled = true;
            PlayerSelectorO.Location = new Point(0, 347);
            PlayerSelectorO.Name = "PlayerSelectorO";
            PlayerSelectorO.Size = new Size(121, 29);
            PlayerSelectorO.TabIndex = 16;
            PlayerSelectorO.SelectedIndexChanged += createPlayers;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 256);
            label2.Name = "label2";
            label2.Size = new Size(19, 21);
            label2.TabIndex = 17;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 323);
            label3.Name = "label3";
            label3.Size = new Size(22, 21);
            label3.TabIndex = 18;
            label3.Text = "O";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BoardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PlayerSelectorO);
            Controls.Add(PlayerSelectorX);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(playerIndicator);
            Controls.Add(winner);
            Controls.Add(resetButton);
            Controls.Add(Cell22);
            Controls.Add(Cell12);
            Controls.Add(Cell02);
            Controls.Add(Cell21);
            Controls.Add(Cell11);
            Controls.Add(Cell01);
            Controls.Add(Cell20);
            Controls.Add(Cell10);
            Controls.Add(Cell00);
            Name = "BoardView";
            Text = "TicTacToe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Cell01;
        private Label Cell02;
        private Label Cell12;
        private Label Cell22;
        private Label Cell10;
        private Label Cell00;
        private Label Cell21;
        private Label Cell20;
        private Label Cell11;
        private Button resetButton;
        private Label winner;
        private Label playerIndicator;
        private ToolStrip toolStrip1;
        private Label label1;
        private ComboBox PlayerSelectorX;
        private ComboBox PlayerSelectorO;
        private Label label2;
        private Label label3;
    }
}