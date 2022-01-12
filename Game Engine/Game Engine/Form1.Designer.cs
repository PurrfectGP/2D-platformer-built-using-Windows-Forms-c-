namespace Game_Engine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Keybindings Binds = new Keybindings();
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
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGround2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbGround.Location = new System.Drawing.Point(-8, 385);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(712, 50);
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            this.pbGround.Tag = "platform";
            // 
            // pbSprite
            // 
            this.pbSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbSprite.Location = new System.Drawing.Point(56, 277);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(71, 52);
            this.pbSprite.TabIndex = 1;
            this.pbSprite.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timerStart);
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Yellow;
            this.coin1.Location = new System.Drawing.Point(397, 243);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(19, 19);
            this.coin1.TabIndex = 2;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(494, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // pbGround2
            // 
            this.pbGround2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pbGround2.Location = new System.Drawing.Point(366, 268);
            this.pbGround2.Name = "pbGround2";
            this.pbGround2.Size = new System.Drawing.Size(190, 43);
            this.pbGround2.TabIndex = 0;
            this.pbGround2.TabStop = false;
            this.pbGround2.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.pbSprite);
            this.Controls.Add(this.pbGround2);
            this.Controls.Add(this.pbGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbGround2;
    }
}

