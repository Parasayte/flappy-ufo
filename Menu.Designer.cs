using System.ComponentModel;

namespace flapp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu_start_button = new System.Windows.Forms.Button();
            this.fish = new System.Windows.Forms.PictureBox();
            this.menu_option_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fish)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Azonix", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(188, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Flappy Ufo";
            // 
            // menu_start_button
            // 
            this.menu_start_button.BackColor = System.Drawing.Color.Gray;
            this.menu_start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_start_button.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_start_button.Location = new System.Drawing.Point(301, 247);
            this.menu_start_button.Name = "menu_start_button";
            this.menu_start_button.Size = new System.Drawing.Size(130, 47);
            this.menu_start_button.TabIndex = 1;
            this.menu_start_button.Text = "Start";
            this.menu_start_button.UseVisualStyleBackColor = false;
            this.menu_start_button.Click += new System.EventHandler(this.Menu_Start);
            // 
            // fish
            // 
            this.fish.BackColor = System.Drawing.Color.Transparent;
            this.fish.Image = ((System.Drawing.Image)(resources.GetObject("fish.Image")));
            this.fish.InitialImage = null;
            this.fish.Location = new System.Drawing.Point(12, 302);
            this.fish.Name = "fish";
            this.fish.Size = new System.Drawing.Size(147, 88);
            this.fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fish.TabIndex = 12;
            this.fish.TabStop = false;
            // 
            // menu_option_button
            // 
            this.menu_option_button.BackColor = System.Drawing.Color.Gray;
            this.menu_option_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_option_button.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_option_button.Location = new System.Drawing.Point(301, 316);
            this.menu_option_button.Name = "menu_option_button";
            this.menu_option_button.Size = new System.Drawing.Size(130, 48);
            this.menu_option_button.TabIndex = 16;
            this.menu_option_button.Text = "Option";
            this.menu_option_button.UseVisualStyleBackColor = false;
            this.menu_option_button.Click += new System.EventHandler(this.Menu_option_button);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Azonix", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(281, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Created By Selam";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Azonix", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(12, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 47);
            this.label4.TabIndex = 18;
            this.label4.Text = "Everything in this program was built by me only. (GRAVITY , JUMPING )";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(752, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menu_option_button);
            this.Controls.Add(this.fish);
            this.Controls.Add(this.menu_start_button);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fish)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button menu_option_button;


        private System.Windows.Forms.PictureBox fish;

        private System.Windows.Forms.Button menu_start_button;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}