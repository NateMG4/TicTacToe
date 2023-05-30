namespace TicTacToe
{
    partial class StartMenu
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
            OfflineButton = new Button();
            CreateServerButton = new Button();
            ConnectButton = new Button();
            SuspendLayout();
            // 
            // OfflineButton
            // 
            OfflineButton.AutoSize = true;
            OfflineButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OfflineButton.Location = new Point(12, 12);
            OfflineButton.Name = "OfflineButton";
            OfflineButton.Size = new Size(100, 31);
            OfflineButton.TabIndex = 0;
            OfflineButton.Text = "Offline Play";
            OfflineButton.UseVisualStyleBackColor = true;
            OfflineButton.Click += OfflineButton_Click;
            // 
            // CreateServerButton
            // 
            CreateServerButton.AutoSize = true;
            CreateServerButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateServerButton.Location = new Point(118, 12);
            CreateServerButton.Name = "CreateServerButton";
            CreateServerButton.Size = new Size(114, 31);
            CreateServerButton.TabIndex = 1;
            CreateServerButton.Text = "Create Server";
            CreateServerButton.UseVisualStyleBackColor = true;
            CreateServerButton.Click += CreateServerButton_Click;
            // 
            // ConnectButton
            // 
            ConnectButton.AutoSize = true;
            ConnectButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConnectButton.Location = new Point(238, 12);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(145, 31);
            ConnectButton.TabIndex = 2;
            ConnectButton.Text = "Connect To Server";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 52);
            Controls.Add(ConnectButton);
            Controls.Add(CreateServerButton);
            Controls.Add(OfflineButton);
            Name = "StartMenu";
            Text = "Start Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OfflineButton;
        private Button CreateServerButton;
        private Button ConnectButton;
    }
}