namespace NetGameEngine
{
    partial class NetGameWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.MaskedTextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.shootButton = new System.Windows.Forms.Button();
            this.shootTextBox = new System.Windows.Forms.TextBox();
            this.shootListTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.ipTextBox);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(6, 86);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(132, 50);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(122, 20);
            this.ipTextBox.TabIndex = 2;
            this.ipTextBox.Text = "192.168.1.100";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 48);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // shootButton
            // 
            this.shootButton.Location = new System.Drawing.Point(144, 181);
            this.shootButton.Name = "shootButton";
            this.shootButton.Size = new System.Drawing.Size(122, 23);
            this.shootButton.TabIndex = 2;
            this.shootButton.Text = "Shoot";
            this.shootButton.UseVisualStyleBackColor = true;
            this.shootButton.Click += new System.EventHandler(this.ShootButton_Click);
            // 
            // shootTextBox
            // 
            this.shootTextBox.Location = new System.Drawing.Point(144, 155);
            this.shootTextBox.Name = "shootTextBox";
            this.shootTextBox.Size = new System.Drawing.Size(122, 20);
            this.shootTextBox.TabIndex = 3;
            // 
            // shootListTextBox
            // 
            this.shootListTextBox.Location = new System.Drawing.Point(12, 155);
            this.shootListTextBox.Multiline = true;
            this.shootListTextBox.Name = "shootListTextBox";
            this.shootListTextBox.Size = new System.Drawing.Size(126, 344);
            this.shootListTextBox.TabIndex = 4;
            // 
            // NetGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 511);
            this.Controls.Add(this.shootListTextBox);
            this.Controls.Add(this.shootTextBox);
            this.Controls.Add(this.shootButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "NetGameWindow";
            this.Text = "Net Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox ipTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button shootButton;
        private System.Windows.Forms.TextBox shootTextBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox shootListTextBox;
    }
}

