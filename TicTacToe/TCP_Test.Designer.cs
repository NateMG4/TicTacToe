namespace TicTacToe
{
    partial class TCP_Test
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
            Port_Self = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            IP_Self = new TextBox();
            ServerLog = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            ClientInput = new RichTextBox();
            ClientLog = new RichTextBox();
            button2 = new Button();
            label4 = new Label();
            IP_Server = new TextBox();
            Port_Server = new NumericUpDown();
            label3 = new Label();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)Port_Self).BeginInit();
            ServerLog.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Port_Server).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 160);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 19;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Create_TCP_Server;
            // 
            // Port_Self
            // 
            Port_Self.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Port_Self.Location = new Point(130, 93);
            Port_Self.Maximum = new decimal(new int[] { 5320, 0, 0, 0 });
            Port_Self.Minimum = new decimal(new int[] { 5310, 0, 0, 0 });
            Port_Self.Name = "Port_Self";
            Port_Self.Size = new Size(180, 35);
            Port_Self.TabIndex = 17;
            Port_Self.Value = new decimal(new int[] { 5310, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 99);
            label2.Margin = new Padding(3, 20, 20, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 29);
            label2.TabIndex = 16;
            label2.Text = "Port";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 50);
            label1.Margin = new Padding(3, 20, 20, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 29);
            label1.TabIndex = 15;
            label1.Text = "IP";
            // 
            // IP_Self
            // 
            IP_Self.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IP_Self.Location = new Point(130, 47);
            IP_Self.Name = "IP_Self";
            IP_Self.Size = new Size(150, 35);
            IP_Self.TabIndex = 14;
            IP_Self.Text = "127.0.0.1";
            // 
            // ServerLog
            // 
            ServerLog.Controls.Add(tabPage1);
            ServerLog.Controls.Add(tabPage2);
            ServerLog.Location = new Point(3, 1);
            ServerLog.Name = "ServerLog";
            ServerLog.SelectedIndex = 0;
            ServerLog.Size = new Size(785, 373);
            ServerLog.TabIndex = 28;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(ClientInput);
            tabPage1.Controls.Add(ClientLog);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(IP_Server);
            tabPage1.Controls.Add(Port_Server);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(777, 335);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Connect To Server";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(100, 214);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 38;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            button3.Click += SendMessage;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(332, 179);
            label6.Name = "label6";
            label6.Size = new Size(90, 32);
            label6.TabIndex = 37;
            label6.Text = "Output";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(332, 15);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 36;
            label5.Text = "Input";
            // 
            // ClientInput
            // 
            ClientInput.Location = new Point(332, 50);
            ClientInput.Name = "ClientInput";
            ClientInput.Size = new Size(425, 115);
            ClientInput.TabIndex = 35;
            ClientInput.Text = "";
            // 
            // ClientLog
            // 
            ClientLog.Location = new Point(332, 214);
            ClientLog.Name = "ClientLog";
            ClientLog.Size = new Size(425, 115);
            ClientLog.TabIndex = 34;
            ClientLog.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(100, 160);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 33;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ConnectTo_TCP_Server;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 99);
            label4.Margin = new Padding(3, 20, 20, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 29);
            label4.TabIndex = 31;
            label4.Text = "Port";
            // 
            // IP_Server
            // 
            IP_Server.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IP_Server.Location = new Point(130, 47);
            IP_Server.Name = "IP_Server";
            IP_Server.Size = new Size(150, 35);
            IP_Server.TabIndex = 29;
            IP_Server.Text = "127.0.0.1";
            // 
            // Port_Server
            // 
            Port_Server.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Port_Server.Location = new Point(130, 93);
            Port_Server.Maximum = new decimal(new int[] { 5320, 0, 0, 0 });
            Port_Server.Minimum = new decimal(new int[] { 5310, 0, 0, 0 });
            Port_Server.Name = "Port_Server";
            Port_Server.Size = new Size(180, 35);
            Port_Server.TabIndex = 32;
            Port_Server.Value = new decimal(new int[] { 5310, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 50);
            label3.Margin = new Padding(3, 20, 20, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 29);
            label3.TabIndex = 30;
            label3.Text = "IP";
            label3.Click += label3_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(IP_Self);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(Port_Self);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 335);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Create Server";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(350, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(410, 258);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            // 
            // TCP_Test
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 388);
            Controls.Add(ServerLog);
            Name = "TCP_Test";
            Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)Port_Self).EndInit();
            ServerLog.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Port_Server).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private NumericUpDown Port_Self;
        private Label label2;
        private Label label1;
        private TextBox IP_Self;
        private TabControl ServerLog;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private RichTextBox ClientLog;
        private Button button2;
        private Label label4;
        private TextBox IP_Server;
        private NumericUpDown Port_Server;
        private Label label3;
        private Label label6;
        private Label label5;
        private RichTextBox ClientInput;
        private Button button3;
    }
}