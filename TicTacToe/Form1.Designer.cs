namespace TicTacToe
{
    partial class Form1
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
            SuspendLayout();
            // 
            // Cell01
            // 
            Cell01.BorderStyle = BorderStyle.FixedSingle;
            Cell01.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell01.Location = new Point(0, 200);
            Cell01.Margin = new Padding(0);
            Cell01.Name = "Cell01";
            Cell01.Size = new Size(200, 200);
            Cell01.TabIndex = 3;
            Cell01.Text = "X";
            Cell01.TextAlign = ContentAlignment.MiddleCenter;
            Cell01.Click += onCellClick;
            // 
            // Cell02
            // 
            Cell02.BorderStyle = BorderStyle.FixedSingle;
            Cell02.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell02.Location = new Point(0, 400);
            Cell02.Margin = new Padding(0);
            Cell02.Name = "Cell02";
            Cell02.Size = new Size(200, 200);
            Cell02.TabIndex = 6;
            Cell02.Text = "X";
            Cell02.TextAlign = ContentAlignment.MiddleCenter;
            Cell02.Click += onCellClick;
            // 
            // Cell12
            // 
            Cell12.BorderStyle = BorderStyle.FixedSingle;
            Cell12.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell12.Location = new Point(200, 400);
            Cell12.Margin = new Padding(0);
            Cell12.Name = "Cell12";
            Cell12.Size = new Size(200, 200);
            Cell12.TabIndex = 7;
            Cell12.Text = "X";
            Cell12.TextAlign = ContentAlignment.MiddleCenter;
            Cell12.Click += onCellClick;
            // 
            // Cell22
            // 
            Cell22.BorderStyle = BorderStyle.FixedSingle;
            Cell22.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell22.Location = new Point(400, 400);
            Cell22.Margin = new Padding(0);
            Cell22.Name = "Cell22";
            Cell22.Size = new Size(200, 200);
            Cell22.TabIndex = 8;
            Cell22.Text = "X";
            Cell22.TextAlign = ContentAlignment.MiddleCenter;
            Cell22.Click += onCellClick;
            // 
            // Cell10
            // 
            Cell10.BorderStyle = BorderStyle.FixedSingle;
            Cell10.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell10.Location = new Point(200, 0);
            Cell10.Margin = new Padding(0);
            Cell10.Name = "Cell10";
            Cell10.Size = new Size(200, 200);
            Cell10.TabIndex = 1;
            Cell10.Text = "X";
            Cell10.TextAlign = ContentAlignment.MiddleCenter;
            Cell10.Click += onCellClick;
            // 
            // Cell00
            // 
            Cell00.BorderStyle = BorderStyle.FixedSingle;
            Cell00.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell00.Location = new Point(0, 0);
            Cell00.Margin = new Padding(0);
            Cell00.Name = "Cell00";
            Cell00.Size = new Size(200, 200);
            Cell00.TabIndex = 0;
            Cell00.Text = "X";
            Cell00.TextAlign = ContentAlignment.MiddleCenter;
            Cell00.Click += onCellClick;
            // 
            // Cell21
            // 
            Cell21.BorderStyle = BorderStyle.FixedSingle;
            Cell21.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell21.Location = new Point(400, 200);
            Cell21.Margin = new Padding(0);
            Cell21.Name = "Cell21";
            Cell21.Size = new Size(200, 200);
            Cell21.TabIndex = 5;
            Cell21.Text = "X";
            Cell21.TextAlign = ContentAlignment.MiddleCenter;
            Cell21.Click += onCellClick;
            // 
            // Cell20
            // 
            Cell20.BorderStyle = BorderStyle.FixedSingle;
            Cell20.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell20.Location = new Point(400, 0);
            Cell20.Margin = new Padding(0);
            Cell20.Name = "Cell20";
            Cell20.Size = new Size(200, 200);
            Cell20.TabIndex = 2;
            Cell20.Text = "X";
            Cell20.TextAlign = ContentAlignment.MiddleCenter;
            Cell20.Click += onCellClick;
            // 
            // Cell11
            // 
            Cell11.BorderStyle = BorderStyle.FixedSingle;
            Cell11.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            Cell11.Location = new Point(200, 200);
            Cell11.Margin = new Padding(0);
            Cell11.Name = "Cell11";
            Cell11.Size = new Size(200, 200);
            Cell11.TabIndex = 4;
            Cell11.Text = "X";
            Cell11.TextAlign = ContentAlignment.MiddleCenter;
            Cell11.Click += onCellClick;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(963, 40);
            resetButton.Margin = new Padding(4, 5, 4, 5);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(107, 38);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // winner
            // 
            winner.AutoSize = true;
            winner.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            winner.Location = new Point(963, 110);
            winner.Margin = new Padding(4, 0, 4, 0);
            winner.Name = "winner";
            winner.Size = new Size(0, 48);
            winner.TabIndex = 10;
            // 
            // playerIndicator
            // 
            playerIndicator.AutoSize = true;
            playerIndicator.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            playerIndicator.Location = new Point(963, 215);
            playerIndicator.Margin = new Padding(4, 0, 4, 0);
            playerIndicator.Name = "playerIndicator";
            playerIndicator.Size = new Size(145, 48);
            playerIndicator.TabIndex = 11;
            playerIndicator.Text = "Player 1";
            playerIndicator.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 1018);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
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
    }
}