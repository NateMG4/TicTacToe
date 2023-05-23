﻿namespace TicTacToe
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
            label1 = new Label();
            PlayerSelectorX = new ComboBox();
            PlayerSelectorO = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            testingToolStripMenuItem = new ToolStripMenuItem();
            runTestToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Cell01
            // 
            Cell01.BorderStyle = BorderStyle.FixedSingle;
            Cell01.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell01.Location = new Point(191, 412);
            Cell01.Margin = new Padding(0);
            Cell01.Name = "Cell01";
            Cell01.Size = new Size(142, 165);
            Cell01.TabIndex = 3;
            Cell01.Text = "X";
            Cell01.TextAlign = ContentAlignment.MiddleCenter;
            Cell01.Click += onCellClick;
            // 
            // Cell02
            // 
            Cell02.BorderStyle = BorderStyle.FixedSingle;
            Cell02.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell02.Location = new Point(191, 578);
            Cell02.Margin = new Padding(0);
            Cell02.Name = "Cell02";
            Cell02.Size = new Size(142, 165);
            Cell02.TabIndex = 6;
            Cell02.Text = "X";
            Cell02.TextAlign = ContentAlignment.MiddleCenter;
            Cell02.Click += onCellClick;
            // 
            // Cell12
            // 
            Cell12.BorderStyle = BorderStyle.FixedSingle;
            Cell12.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell12.Location = new Point(334, 578);
            Cell12.Margin = new Padding(0);
            Cell12.Name = "Cell12";
            Cell12.Size = new Size(142, 165);
            Cell12.TabIndex = 7;
            Cell12.Text = "X";
            Cell12.TextAlign = ContentAlignment.MiddleCenter;
            Cell12.Click += onCellClick;
            // 
            // Cell22
            // 
            Cell22.BorderStyle = BorderStyle.FixedSingle;
            Cell22.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell22.Location = new Point(477, 578);
            Cell22.Margin = new Padding(0);
            Cell22.Name = "Cell22";
            Cell22.Size = new Size(142, 165);
            Cell22.TabIndex = 8;
            Cell22.Text = "X";
            Cell22.TextAlign = ContentAlignment.MiddleCenter;
            Cell22.Click += onCellClick;
            // 
            // Cell10
            // 
            Cell10.BorderStyle = BorderStyle.FixedSingle;
            Cell10.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell10.Location = new Point(334, 245);
            Cell10.Margin = new Padding(0);
            Cell10.Name = "Cell10";
            Cell10.Size = new Size(142, 165);
            Cell10.TabIndex = 1;
            Cell10.Text = "X";
            Cell10.TextAlign = ContentAlignment.MiddleCenter;
            Cell10.Click += onCellClick;
            // 
            // Cell00
            // 
            Cell00.BorderStyle = BorderStyle.FixedSingle;
            Cell00.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell00.Location = new Point(191, 245);
            Cell00.Margin = new Padding(0);
            Cell00.Name = "Cell00";
            Cell00.Size = new Size(142, 165);
            Cell00.TabIndex = 0;
            Cell00.Text = "X";
            Cell00.TextAlign = ContentAlignment.MiddleCenter;
            Cell00.Click += onCellClick;
            // 
            // Cell21
            // 
            Cell21.BorderStyle = BorderStyle.FixedSingle;
            Cell21.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell21.Location = new Point(477, 412);
            Cell21.Margin = new Padding(0);
            Cell21.Name = "Cell21";
            Cell21.Size = new Size(142, 165);
            Cell21.TabIndex = 5;
            Cell21.Text = "X";
            Cell21.TextAlign = ContentAlignment.MiddleCenter;
            Cell21.Click += onCellClick;
            // 
            // Cell20
            // 
            Cell20.BorderStyle = BorderStyle.FixedSingle;
            Cell20.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell20.Location = new Point(477, 245);
            Cell20.Margin = new Padding(0);
            Cell20.Name = "Cell20";
            Cell20.Size = new Size(142, 165);
            Cell20.TabIndex = 2;
            Cell20.Text = "X";
            Cell20.TextAlign = ContentAlignment.MiddleCenter;
            Cell20.Click += onCellClick;
            // 
            // Cell11
            // 
            Cell11.BorderStyle = BorderStyle.FixedSingle;
            Cell11.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell11.Location = new Point(334, 412);
            Cell11.Margin = new Padding(0);
            Cell11.Name = "Cell11";
            Cell11.Size = new Size(142, 165);
            Cell11.TabIndex = 4;
            Cell11.Text = "X";
            Cell11.TextAlign = ContentAlignment.MiddleCenter;
            Cell11.Click += onCellClick;
            // 
            // resetButton
            // 
            resetButton.AutoSize = true;
            resetButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(347, 143);
            resetButton.Margin = new Padding(4, 5, 4, 5);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(116, 70);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // winner
            // 
            winner.AutoSize = true;
            winner.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            winner.Location = new Point(261, 773);
            winner.Margin = new Padding(4, 0, 4, 0);
            winner.Name = "winner";
            winner.Size = new Size(300, 48);
            winner.TabIndex = 10;
            winner.Text = "Game in progress";
            winner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerIndicator
            // 
            playerIndicator.AutoSize = true;
            playerIndicator.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            playerIndicator.Location = new Point(334, 57);
            playerIndicator.Margin = new Padding(4, 0, 4, 0);
            playerIndicator.Name = "playerIndicator";
            playerIndicator.Size = new Size(145, 48);
            playerIndicator.TabIndex = 11;
            playerIndicator.Text = "Player 1";
            playerIndicator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 358);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 48);
            label1.TabIndex = 14;
            label1.Text = "AI Player";
            label1.Click += label1_Click;
            // 
            // PlayerSelectorX
            // 
            PlayerSelectorX.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerSelectorX.FormattingEnabled = true;
            PlayerSelectorX.Location = new Point(11, 460);
            PlayerSelectorX.Margin = new Padding(4, 5, 4, 5);
            PlayerSelectorX.Name = "PlayerSelectorX";
            PlayerSelectorX.Size = new Size(171, 36);
            PlayerSelectorX.TabIndex = 15;
            PlayerSelectorX.SelectedIndexChanged += createPlayers;
            // 
            // PlayerSelectorO
            // 
            PlayerSelectorO.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerSelectorO.FormattingEnabled = true;
            PlayerSelectorO.Location = new Point(11, 571);
            PlayerSelectorO.Margin = new Padding(4, 5, 4, 5);
            PlayerSelectorO.Name = "PlayerSelectorO";
            PlayerSelectorO.Size = new Size(171, 36);
            PlayerSelectorO.TabIndex = 16;
            PlayerSelectorO.SelectedIndexChanged += createPlayers;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 420);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 28);
            label2.TabIndex = 17;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(83, 531);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 28);
            label3.TabIndex = 18;
            label3.Text = "O";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { testingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(834, 33);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // testingToolStripMenuItem
            // 
            testingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runTestToolStripMenuItem });
            testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            testingToolStripMenuItem.Size = new Size(83, 29);
            testingToolStripMenuItem.Text = "Testing";
            // 
            // runTestToolStripMenuItem
            // 
            runTestToolStripMenuItem.Name = "runTestToolStripMenuItem";
            runTestToolStripMenuItem.Size = new Size(270, 34);
            runTestToolStripMenuItem.Text = "Run Test";
            runTestToolStripMenuItem.Click += ConfigureTestProperties;
            // 
            // BoardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 935);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PlayerSelectorO);
            Controls.Add(PlayerSelectorX);
            Controls.Add(label1);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "BoardView";
            Text = "TicTacToe";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label label1;
        private ComboBox PlayerSelectorX;
        private ComboBox PlayerSelectorO;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testingToolStripMenuItem;
        private ToolStripMenuItem runTestToolStripMenuItem;
    }
}