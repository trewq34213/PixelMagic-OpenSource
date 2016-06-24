﻿namespace PixelMagic.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdStartBot = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblHotkeyInfo = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTargetHealth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTargetCasting = new System.Windows.Forms.TextBox();
            this.cmdDonate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptCombatRoutineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debuggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMouseXY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPlayErrorSounds = new System.Windows.Forms.CheckBox();
            this.chkDisableOverlay = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMouseXYClick = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudPulse = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPulse)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdStartBot
            // 
            this.cmdStartBot.ForeColor = System.Drawing.Color.Black;
            this.cmdStartBot.Location = new System.Drawing.Point(13, 21);
            this.cmdStartBot.Name = "cmdStartBot";
            this.cmdStartBot.Size = new System.Drawing.Size(128, 31);
            this.cmdStartBot.TabIndex = 1;
            this.cmdStartBot.Text = "Start bot";
            this.cmdStartBot.UseVisualStyleBackColor = false;
            this.cmdStartBot.Click += new System.EventHandler(this.cmdStartBot_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbLog.Location = new System.Drawing.Point(3, 29);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbLog.Size = new System.Drawing.Size(645, 498);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            // 
            // lblHotkeyInfo
            // 
            this.lblHotkeyInfo.AutoSize = true;
            this.lblHotkeyInfo.Location = new System.Drawing.Point(476, 312);
            this.lblHotkeyInfo.Name = "lblHotkeyInfo";
            this.lblHotkeyInfo.Size = new System.Drawing.Size(68, 13);
            this.lblHotkeyInfo.TabIndex = 3;
            this.lblHotkeyInfo.Text = "[Hotkey Info]";
            // 
            // txtHealth
            // 
            this.txtHealth.ForeColor = System.Drawing.Color.Black;
            this.txtHealth.Location = new System.Drawing.Point(59, 20);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.ReadOnly = true;
            this.txtHealth.Size = new System.Drawing.Size(78, 20);
            this.txtHealth.TabIndex = 4;
            // 
            // txtPower
            // 
            this.txtPower.ForeColor = System.Drawing.Color.Black;
            this.txtPower.Location = new System.Drawing.Point(59, 42);
            this.txtPower.Name = "txtPower";
            this.txtPower.ReadOnly = true;
            this.txtPower.Size = new System.Drawing.Size(78, 20);
            this.txtPower.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Power";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Health";
            // 
            // txtTargetHealth
            // 
            this.txtTargetHealth.ForeColor = System.Drawing.Color.Black;
            this.txtTargetHealth.Location = new System.Drawing.Point(59, 19);
            this.txtTargetHealth.Name = "txtTargetHealth";
            this.txtTargetHealth.ReadOnly = true;
            this.txtTargetHealth.Size = new System.Drawing.Size(78, 20);
            this.txtTargetHealth.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Casting";
            // 
            // txtTargetCasting
            // 
            this.txtTargetCasting.ForeColor = System.Drawing.Color.Black;
            this.txtTargetCasting.Location = new System.Drawing.Point(59, 41);
            this.txtTargetCasting.Name = "txtTargetCasting";
            this.txtTargetCasting.ReadOnly = true;
            this.txtTargetCasting.Size = new System.Drawing.Size(78, 20);
            this.txtTargetCasting.TabIndex = 11;
            // 
            // cmdDonate
            // 
            this.cmdDonate.BackColor = System.Drawing.Color.White;
            this.cmdDonate.ForeColor = System.Drawing.Color.DimGray;
            this.cmdDonate.Location = new System.Drawing.Point(668, 482);
            this.cmdDonate.Name = "cmdDonate";
            this.cmdDonate.Size = new System.Drawing.Size(128, 31);
            this.cmdDonate.TabIndex = 12;
            this.cmdDonate.Text = "Donate";
            this.cmdDonate.UseVisualStyleBackColor = false;
            this.cmdDonate.Click += new System.EventHandler(this.cmdDonate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debuggingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRotationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadRotationToolStripMenuItem
            // 
            this.loadRotationToolStripMenuItem.Name = "loadRotationToolStripMenuItem";
            this.loadRotationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadRotationToolStripMenuItem.Text = "Load Rotation...";
            this.loadRotationToolStripMenuItem.Click += new System.EventHandler(this.loadRotationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeysToolStripMenuItem,
            this.spellbookToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.hotkeysToolStripMenuItem_Click);
            // 
            // spellbookToolStripMenuItem
            // 
            this.spellbookToolStripMenuItem.Name = "spellbookToolStripMenuItem";
            this.spellbookToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.spellbookToolStripMenuItem.Text = "Spellbook";
            this.spellbookToolStripMenuItem.Click += new System.EventHandler(this.spellbookToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptCombatRoutineToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // encryptCombatRoutineToolStripMenuItem
            // 
            this.encryptCombatRoutineToolStripMenuItem.Name = "encryptCombatRoutineToolStripMenuItem";
            this.encryptCombatRoutineToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.encryptCombatRoutineToolStripMenuItem.Text = "Encrypt Combat Routine";
            this.encryptCombatRoutineToolStripMenuItem.Click += new System.EventHandler(this.encryptCombatRoutineToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // debuggingToolStripMenuItem
            // 
            this.debuggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.debuggingToolStripMenuItem.Name = "debuggingToolStripMenuItem";
            this.debuggingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.debuggingToolStripMenuItem.Text = "Debugging";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPower);
            this.groupBox1.Controls.Add(this.txtHealth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(654, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 74);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTargetHealth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTargetCasting);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(654, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 74);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdStartBot);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(654, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 66);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pixel Magic";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMouseXY);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(654, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 51);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mouse Position";
            // 
            // txtMouseXY
            // 
            this.txtMouseXY.ForeColor = System.Drawing.Color.Black;
            this.txtMouseXY.Location = new System.Drawing.Point(59, 19);
            this.txtMouseXY.Name = "txtMouseXY";
            this.txtMouseXY.ReadOnly = true;
            this.txtMouseXY.Size = new System.Drawing.Size(78, 20);
            this.txtMouseXY.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X, Y = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // chkPlayErrorSounds
            // 
            this.chkPlayErrorSounds.AutoSize = true;
            this.chkPlayErrorSounds.Checked = true;
            this.chkPlayErrorSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayErrorSounds.ForeColor = System.Drawing.Color.Black;
            this.chkPlayErrorSounds.Location = new System.Drawing.Point(669, 391);
            this.chkPlayErrorSounds.Name = "chkPlayErrorSounds";
            this.chkPlayErrorSounds.Size = new System.Drawing.Size(110, 17);
            this.chkPlayErrorSounds.TabIndex = 18;
            this.chkPlayErrorSounds.Text = "Play Error Sounds";
            this.chkPlayErrorSounds.UseVisualStyleBackColor = true;
            this.chkPlayErrorSounds.CheckedChanged += new System.EventHandler(this.chkPlayErrorSounds_CheckedChanged);
            // 
            // chkDisableOverlay
            // 
            this.chkDisableOverlay.AutoSize = true;
            this.chkDisableOverlay.Checked = true;
            this.chkDisableOverlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisableOverlay.ForeColor = System.Drawing.Color.Black;
            this.chkDisableOverlay.Location = new System.Drawing.Point(669, 414);
            this.chkDisableOverlay.Name = "chkDisableOverlay";
            this.chkDisableOverlay.Size = new System.Drawing.Size(100, 17);
            this.chkDisableOverlay.TabIndex = 19;
            this.chkDisableOverlay.Text = "Disable Overlay";
            this.chkDisableOverlay.UseVisualStyleBackColor = true;
            this.chkDisableOverlay.CheckedChanged += new System.EventHandler(this.chkDisableOverlay_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtMouseXYClick);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(654, 309);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 67);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Last Mouse Click Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(36, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "In WoW";
            // 
            // txtMouseXYClick
            // 
            this.txtMouseXYClick.ForeColor = System.Drawing.Color.Black;
            this.txtMouseXYClick.Location = new System.Drawing.Point(59, 37);
            this.txtMouseXYClick.Name = "txtMouseXYClick";
            this.txtMouseXYClick.ReadOnly = true;
            this.txtMouseXYClick.Size = new System.Drawing.Size(78, 20);
            this.txtMouseXYClick.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "X, Y = ";
            // 
            // nudPulse
            // 
            this.nudPulse.ForeColor = System.Drawing.Color.Black;
            this.nudPulse.Location = new System.Drawing.Point(725, 437);
            this.nudPulse.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPulse.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPulse.Name = "nudPulse";
            this.nudPulse.Size = new System.Drawing.Size(66, 20);
            this.nudPulse.TabIndex = 21;
            this.nudPulse.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPulse.ValueChanged += new System.EventHandler(this.nudPulse_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(664, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pulse (ms)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 528);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPulse);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.chkDisableOverlay);
            this.Controls.Add(this.chkPlayErrorSounds);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdDonate);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblHotkeyInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPulse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdStartBot;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblHotkeyInfo;
        public System.Windows.Forms.TextBox txtHealth;
        public System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTargetHealth;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTargetCasting;
        private System.Windows.Forms.Button cmdDonate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptCombatRoutineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debuggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellbookToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMouseXY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox chkPlayErrorSounds;
        public System.Windows.Forms.CheckBox chkDisableOverlay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMouseXYClick;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPulse;
        private System.Windows.Forms.Label label9;
    }
}
