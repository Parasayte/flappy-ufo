﻿namespace flapp
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer1 = new System.Timers.Timer();
            this.menu_button = new System.Windows.Forms.Button();
            this.colo_up = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.option_button = new System.Windows.Forms.Button();
            this.restart_button = new System.Windows.Forms.Button();
            this.game_over = new System.Windows.Forms.Label();
            this.frames_counter = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.colo_downn = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Timers.Timer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo_downn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Game_loop);
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.DarkGray;
            this.menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_button.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_button.Location = new System.Drawing.Point(339, 334);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(115, 48);
            this.menu_button.TabIndex = 21;
            this.menu_button.Text = "Menu";
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Visible = false;
            this.menu_button.Click += new System.EventHandler(this.Menu_button);
            // 
            // colo_up
            // 
            this.colo_up.BackColor = System.Drawing.Color.Transparent;
            this.colo_up.Image = ((System.Drawing.Image)(resources.GetObject("colo_up.Image")));
            this.colo_up.InitialImage = null;
            this.colo_up.Location = new System.Drawing.Point(742, 380);
            this.colo_up.Name = "colo_up";
            this.colo_up.Size = new System.Drawing.Size(65, 272);
            this.colo_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colo_up.TabIndex = 24;
            this.colo_up.TabStop = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Azonix", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.scorelabel.Location = new System.Drawing.Point(12, 9);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(168, 27);
            this.scorelabel.TabIndex = 25;
            this.scorelabel.Text = "Score : 0";
            // 
            // option_button
            // 
            this.option_button.BackColor = System.Drawing.Color.DarkGray;
            this.option_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option_button.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option_button.Location = new System.Drawing.Point(339, 271);
            this.option_button.Name = "option_button";
            this.option_button.Size = new System.Drawing.Size(115, 48);
            this.option_button.TabIndex = 28;
            this.option_button.Text = "Option";
            this.option_button.UseVisualStyleBackColor = false;
            this.option_button.Visible = false;
            this.option_button.Click += new System.EventHandler(this.Option_button);
            // 
            // restart_button
            // 
            this.restart_button.BackColor = System.Drawing.Color.DarkGray;
            this.restart_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart_button.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_button.Location = new System.Drawing.Point(339, 206);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(115, 48);
            this.restart_button.TabIndex = 27;
            this.restart_button.Text = "Restart";
            this.restart_button.UseVisualStyleBackColor = false;
            this.restart_button.Visible = false;
            this.restart_button.Click += new System.EventHandler(this.Restart_button);
            // 
            // game_over
            // 
            this.game_over.AutoSize = true;
            this.game_over.BackColor = System.Drawing.Color.Transparent;
            this.game_over.Font = new System.Drawing.Font("Azonix", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over.ForeColor = System.Drawing.Color.Maroon;
            this.game_over.Location = new System.Drawing.Point(287, 131);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(227, 32);
            this.game_over.TabIndex = 26;
            this.game_over.Text = "Game Over";
            this.game_over.Visible = false;
            // 
            // frames_counter
            // 
            this.frames_counter.Font = new System.Drawing.Font("Arabic Pixel 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frames_counter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.frames_counter.Location = new System.Drawing.Point(12, 36);
            this.frames_counter.Name = "frames_counter";
            this.frames_counter.Size = new System.Drawing.Size(122, 26);
            this.frames_counter.TabIndex = 29;
            this.frames_counter.Text = "Good : 0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.InitialImage = null;
            this.player.Location = new System.Drawing.Point(33, 195);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(59, 59);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 30;
            this.player.TabStop = false;
            // 
            // colo_downn
            // 
            this.colo_downn.BackColor = System.Drawing.Color.Transparent;
            this.colo_downn.Image = ((System.Drawing.Image)(resources.GetObject("colo_downn.Image")));
            this.colo_downn.InitialImage = null;
            this.colo_downn.Location = new System.Drawing.Point(395, -199);
            this.colo_downn.Name = "colo_downn";
            this.colo_downn.Size = new System.Drawing.Size(59, 271);
            this.colo_downn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colo_downn.TabIndex = 31;
            this.colo_downn.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 6D;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arabic Pixel 2", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Arch : 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colo_downn);
            this.Controls.Add(this.player);
            this.Controls.Add(this.frames_counter);
            this.Controls.Add(this.option_button);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.colo_up);
            this.Controls.Add(this.menu_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo_downn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Timers.Timer timer2;

        private System.Windows.Forms.Label frames_counter;

        private System.Windows.Forms.Button menu_button;

        private System.Windows.Forms.Button option_button;

        private System.Windows.Forms.Button restart_button;

        private System.Windows.Forms.Label game_over;

        public System.Windows.Forms.PictureBox colo_downn;

        private System.Timers.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label scorelabel;
        public System.Windows.Forms.PictureBox colo_up;
    }
}

