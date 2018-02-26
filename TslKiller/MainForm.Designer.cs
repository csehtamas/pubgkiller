namespace TslKiller
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.shortcutGroupBox = new System.Windows.Forms.GroupBox();
            this.shiftBox = new System.Windows.Forms.CheckBox();
            this.altBox = new System.Windows.Forms.CheckBox();
            this.ctrlBox = new System.Windows.Forms.CheckBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bitcoinButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.relaunchBox = new System.Windows.Forms.CheckBox();
            this.steamTextBox = new System.Windows.Forms.TextBox();
            this.relaunchGroupBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.shortcutGroupBox.SuspendLayout();
            this.relaunchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortcutGroupBox
            // 
            this.shortcutGroupBox.Controls.Add(this.shiftBox);
            this.shortcutGroupBox.Controls.Add(this.altBox);
            this.shortcutGroupBox.Controls.Add(this.ctrlBox);
            this.shortcutGroupBox.Controls.Add(this.keyTextBox);
            this.shortcutGroupBox.Controls.Add(this.label1);
            this.shortcutGroupBox.Location = new System.Drawing.Point(13, 13);
            this.shortcutGroupBox.Name = "shortcutGroupBox";
            this.shortcutGroupBox.Size = new System.Drawing.Size(227, 94);
            this.shortcutGroupBox.TabIndex = 0;
            this.shortcutGroupBox.TabStop = false;
            this.shortcutGroupBox.Text = "Shortcut";
            // 
            // shiftBox
            // 
            this.shiftBox.AutoSize = true;
            this.shiftBox.Checked = true;
            this.shiftBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shiftBox.Location = new System.Drawing.Point(7, 68);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(57, 17);
            this.shiftBox.TabIndex = 2;
            this.shiftBox.Text = "SHIFT";
            this.shiftBox.UseVisualStyleBackColor = true;
            // 
            // altBox
            // 
            this.altBox.AutoSize = true;
            this.altBox.Checked = true;
            this.altBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.altBox.Location = new System.Drawing.Point(7, 44);
            this.altBox.Name = "altBox";
            this.altBox.Size = new System.Drawing.Size(46, 17);
            this.altBox.TabIndex = 1;
            this.altBox.Text = "ALT";
            this.altBox.UseVisualStyleBackColor = true;
            // 
            // ctrlBox
            // 
            this.ctrlBox.AutoSize = true;
            this.ctrlBox.Checked = true;
            this.ctrlBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctrlBox.Location = new System.Drawing.Point(7, 20);
            this.ctrlBox.Name = "ctrlBox";
            this.ctrlBox.Size = new System.Drawing.Size(54, 17);
            this.ctrlBox.TabIndex = 0;
            this.ctrlBox.Text = "CTRL";
            this.ctrlBox.UseVisualStyleBackColor = true;
            // 
            // keyTextBox
            // 
            this.keyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.keyTextBox.Location = new System.Drawing.Point(106, 17);
            this.keyTextBox.MaxLength = 1;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(30, 20);
            this.keyTextBox.TabIndex = 1;
            this.keyTextBox.Text = "P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key";
            // 
            // bitcoinButton
            // 
            this.bitcoinButton.Location = new System.Drawing.Point(124, 241);
            this.bitcoinButton.Name = "bitcoinButton";
            this.bitcoinButton.Size = new System.Drawing.Size(92, 23);
            this.bitcoinButton.TabIndex = 3;
            this.bitcoinButton.Text = "Donate Bitcoin";
            this.bitcoinButton.UseVisualStyleBackColor = true;
            this.bitcoinButton.Click += new System.EventHandler(this.bitcoinButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PUBG Killer";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(35, 241);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // relaunchBox
            // 
            this.relaunchBox.AutoSize = true;
            this.relaunchBox.Location = new System.Drawing.Point(8, 19);
            this.relaunchBox.Name = "relaunchBox";
            this.relaunchBox.Size = new System.Drawing.Size(179, 17);
            this.relaunchBox.TabIndex = 5;
            this.relaunchBox.Text = "Relaunch PUBG after task killed";
            this.relaunchBox.UseVisualStyleBackColor = true;
            this.relaunchBox.CheckedChanged += new System.EventHandler(this.relaunchBox_CheckedChanged);
            // 
            // steamTextBox
            // 
            this.steamTextBox.Location = new System.Drawing.Point(6, 87);
            this.steamTextBox.Name = "steamTextBox";
            this.steamTextBox.ReadOnly = true;
            this.steamTextBox.Size = new System.Drawing.Size(216, 20);
            this.steamTextBox.TabIndex = 7;
            // 
            // relaunchGroupBox
            // 
            this.relaunchGroupBox.Controls.Add(this.browseButton);
            this.relaunchGroupBox.Controls.Add(this.relaunchBox);
            this.relaunchGroupBox.Controls.Add(this.steamTextBox);
            this.relaunchGroupBox.Location = new System.Drawing.Point(12, 113);
            this.relaunchGroupBox.Name = "relaunchGroupBox";
            this.relaunchGroupBox.Size = new System.Drawing.Size(228, 115);
            this.relaunchGroupBox.TabIndex = 8;
            this.relaunchGroupBox.TabStop = false;
            this.relaunchGroupBox.Text = "Relaunch";
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(57, 51);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(114, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse steam.exe";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 277);
            this.Controls.Add(this.relaunchGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bitcoinButton);
            this.Controls.Add(this.shortcutGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUBG Killer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.shortcutGroupBox.ResumeLayout(false);
            this.shortcutGroupBox.PerformLayout();
            this.relaunchGroupBox.ResumeLayout(false);
            this.relaunchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shortcutGroupBox;
        private System.Windows.Forms.CheckBox shiftBox;
        private System.Windows.Forms.CheckBox altBox;
        private System.Windows.Forms.CheckBox ctrlBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bitcoinButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox relaunchBox;
        private System.Windows.Forms.TextBox steamTextBox;
        private System.Windows.Forms.GroupBox relaunchGroupBox;
        private System.Windows.Forms.Button browseButton;
    }
}

