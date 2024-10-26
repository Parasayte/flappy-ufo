using System.ComponentModel;

namespace flapp
{
    partial class Option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.label3 = new System.Windows.Forms.Label();
            this.gravity_plus = new System.Windows.Forms.Button();
            this.player_pictureBox = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.PictureBox();
            this.gravity_minus = new System.Windows.Forms.Button();
            this.fly_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.land_button = new System.Windows.Forms.Button();
            this.game_speed_minus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.game_speed_plus = new System.Windows.Forms.Button();
            this.jump_high_minus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.jump_high_plus = new System.Windows.Forms.Button();
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Azonix", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gravity : ";
            // 
            // gravity_plus
            // 
            this.gravity_plus.BackColor = System.Drawing.Color.DarkGray;
            this.gravity_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gravity_plus.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravity_plus.Location = new System.Drawing.Point(309, 108);
            this.gravity_plus.Name = "gravity_plus";
            this.gravity_plus.Size = new System.Drawing.Size(41, 38);
            this.gravity_plus.TabIndex = 15;
            this.gravity_plus.Text = "+";
            this.gravity_plus.UseVisualStyleBackColor = false;
            this.gravity_plus.Click += new System.EventHandler(this.Gravity_plus);
            // 
            // player_pictureBox
            // 
            this.player_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.player_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player_pictureBox.Image")));
            this.player_pictureBox.InitialImage = null;
            this.player_pictureBox.Location = new System.Drawing.Point(651, 55);
            this.player_pictureBox.Name = "player_pictureBox";
            this.player_pictureBox.Size = new System.Drawing.Size(60, 53);
            this.player_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_pictureBox.TabIndex = 16;
            this.player_pictureBox.TabStop = false;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.DarkGray;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_button.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(327, 340);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(107, 38);
            this.start_button.TabIndex = 17;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.Option_start_button);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Azonix", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "|Use Arrow UP to jump\r\nand Arrow Down to land??";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Image = ((System.Drawing.Image)(resources.GetObject("label.Image")));
            this.label.InitialImage = null;
            this.label.Location = new System.Drawing.Point(21, 329);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(88, 67);
            this.label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.label.TabIndex = 19;
            this.label.TabStop = false;
            // 
            // gravity_minus
            // 
            this.gravity_minus.BackColor = System.Drawing.Color.DarkGray;
            this.gravity_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gravity_minus.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravity_minus.Location = new System.Drawing.Point(356, 108);
            this.gravity_minus.Name = "gravity_minus";
            this.gravity_minus.Size = new System.Drawing.Size(41, 38);
            this.gravity_minus.TabIndex = 20;
            this.gravity_minus.Text = "-";
            this.gravity_minus.UseVisualStyleBackColor = false;
            this.gravity_minus.Click += new System.EventHandler(this.Gravity_minus);
            // 
            // fly_button
            // 
            this.fly_button.BackColor = System.Drawing.Color.DarkGray;
            this.fly_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fly_button.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fly_button.Location = new System.Drawing.Point(416, 108);
            this.fly_button.Name = "fly_button";
            this.fly_button.Size = new System.Drawing.Size(77, 38);
            this.fly_button.TabIndex = 21;
            this.fly_button.Text = "Jump";
            this.fly_button.UseVisualStyleBackColor = false;
            this.fly_button.Click += new System.EventHandler(this.Jump_button);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Azonix", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 52);
            this.label1.TabIndex = 22;
            this.label1.Text = "Flappy Ufo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Game_loop);
            // 
            // land_button
            // 
            this.land_button.BackColor = System.Drawing.Color.DarkGray;
            this.land_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.land_button.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.land_button.Location = new System.Drawing.Point(499, 108);
            this.land_button.Name = "land_button";
            this.land_button.Size = new System.Drawing.Size(83, 38);
            this.land_button.TabIndex = 23;
            this.land_button.Text = "Land";
            this.land_button.UseVisualStyleBackColor = false;
            this.land_button.Click += new System.EventHandler(this.Land_button);
            // 
            // game_speed_minus
            // 
            this.game_speed_minus.BackColor = System.Drawing.Color.DarkGray;
            this.game_speed_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game_speed_minus.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_speed_minus.Location = new System.Drawing.Point(356, 155);
            this.game_speed_minus.Name = "game_speed_minus";
            this.game_speed_minus.Size = new System.Drawing.Size(41, 38);
            this.game_speed_minus.TabIndex = 26;
            this.game_speed_minus.Text = "-";
            this.game_speed_minus.UseVisualStyleBackColor = false;
            this.game_speed_minus.Click += new System.EventHandler(this.Speed_minus);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Azonix", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(5, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "game SPEED :";
            // 
            // game_speed_plus
            // 
            this.game_speed_plus.BackColor = System.Drawing.Color.DarkGray;
            this.game_speed_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game_speed_plus.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_speed_plus.Location = new System.Drawing.Point(309, 155);
            this.game_speed_plus.Name = "game_speed_plus";
            this.game_speed_plus.Size = new System.Drawing.Size(41, 38);
            this.game_speed_plus.TabIndex = 25;
            this.game_speed_plus.Text = "+";
            this.game_speed_plus.UseVisualStyleBackColor = false;
            this.game_speed_plus.Click += new System.EventHandler(this.Speed_plus);
            // 
            // jump_high_minus
            // 
            this.jump_high_minus.BackColor = System.Drawing.Color.DarkGray;
            this.jump_high_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jump_high_minus.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jump_high_minus.Location = new System.Drawing.Point(356, 202);
            this.jump_high_minus.Name = "jump_high_minus";
            this.jump_high_minus.Size = new System.Drawing.Size(41, 38);
            this.jump_high_minus.TabIndex = 29;
            this.jump_high_minus.Text = "-";
            this.jump_high_minus.UseVisualStyleBackColor = false;
            this.jump_high_minus.Click += new System.EventHandler(this.JumpHigh_minus);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Azonix", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(5, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Jump high :";
            // 
            // jump_high_plus
            // 
            this.jump_high_plus.BackColor = System.Drawing.Color.DarkGray;
            this.jump_high_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jump_high_plus.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jump_high_plus.Location = new System.Drawing.Point(309, 202);
            this.jump_high_plus.Name = "jump_high_plus";
            this.jump_high_plus.Size = new System.Drawing.Size(41, 38);
            this.jump_high_plus.TabIndex = 28;
            this.jump_high_plus.Text = "+";
            this.jump_high_plus.UseVisualStyleBackColor = false;
            this.jump_high_plus.Click += new System.EventHandler(this.JumpHigh_plus);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 6D;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(752, 408);
            this.Controls.Add(this.jump_high_minus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jump_high_plus);
            this.Controls.Add(this.game_speed_minus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.game_speed_plus);
            this.Controls.Add(this.land_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fly_button);
            this.Controls.Add(this.gravity_minus);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.player_pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gravity_plus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.player_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer2;

        private System.Windows.Forms.Button jump_high_minus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button jump_high_plus;

        private System.Windows.Forms.Button game_speed_minus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button game_speed_plus;

        private System.Windows.Forms.Button land_button;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox label;
        private System.Windows.Forms.Button gravity_minus;
        private System.Windows.Forms.Button fly_button;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox player_pictureBox;
        private System.Windows.Forms.Button start_button;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gravity_plus;

        #endregion
    }
        
}