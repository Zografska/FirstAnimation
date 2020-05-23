namespace ThisAnim
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.picBlueOcto = new System.Windows.Forms.PictureBox();
            this.tmrBlueOcto = new System.Windows.Forms.Timer(this.components);
            this.tmrWindow = new System.Windows.Forms.Timer(this.components);
            this.picRing1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.picRing2 = new System.Windows.Forms.PictureBox();
            this.picRing3 = new System.Windows.Forms.PictureBox();
            this.picRing4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueOcto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing4)).BeginInit();
            this.SuspendLayout();
            // 
            // picBlueOcto
            // 
            this.picBlueOcto.BackColor = System.Drawing.Color.Transparent;
            this.picBlueOcto.Image = ((System.Drawing.Image)(resources.GetObject("picBlueOcto.Image")));
            this.picBlueOcto.Location = new System.Drawing.Point(117, 152);
            this.picBlueOcto.Name = "picBlueOcto";
            this.picBlueOcto.Size = new System.Drawing.Size(100, 101);
            this.picBlueOcto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueOcto.TabIndex = 0;
            this.picBlueOcto.TabStop = false;
            this.picBlueOcto.Click += new System.EventHandler(this.picBlueOcto_Click);
            // 
            // tmrBlueOcto
            // 
            this.tmrBlueOcto.Enabled = true;
            this.tmrBlueOcto.Interval = 10;
            this.tmrBlueOcto.Tick += new System.EventHandler(this.tmrBlueOcto_Tick);
            // 
            // tmrWindow
            // 
            this.tmrWindow.Enabled = true;
            this.tmrWindow.Interval = 10;
            this.tmrWindow.Tick += new System.EventHandler(this.tmrWindow_Tick);
            // 
            // picRing1
            // 
            this.picRing1.BackColor = System.Drawing.Color.Transparent;
            this.picRing1.Image = ((System.Drawing.Image)(resources.GetObject("picRing1.Image")));
            this.picRing1.Location = new System.Drawing.Point(453, 96);
            this.picRing1.Name = "picRing1";
            this.picRing1.Size = new System.Drawing.Size(80, 60);
            this.picRing1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing1.TabIndex = 1;
            this.picRing1.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblScore.Font = new System.Drawing.Font("Yukon Font", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(29, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 25);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Coins: 0";
            // 
            // picRing2
            // 
            this.picRing2.BackColor = System.Drawing.Color.Transparent;
            this.picRing2.Image = ((System.Drawing.Image)(resources.GetObject("picRing2.Image")));
            this.picRing2.Location = new System.Drawing.Point(294, 292);
            this.picRing2.Name = "picRing2";
            this.picRing2.Size = new System.Drawing.Size(80, 60);
            this.picRing2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing2.TabIndex = 3;
            this.picRing2.TabStop = false;
            // 
            // picRing3
            // 
            this.picRing3.BackColor = System.Drawing.Color.Transparent;
            this.picRing3.Image = ((System.Drawing.Image)(resources.GetObject("picRing3.Image")));
            this.picRing3.Location = new System.Drawing.Point(713, 12);
            this.picRing3.Name = "picRing3";
            this.picRing3.Size = new System.Drawing.Size(80, 60);
            this.picRing3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing3.TabIndex = 4;
            this.picRing3.TabStop = false;
            // 
            // picRing4
            // 
            this.picRing4.BackColor = System.Drawing.Color.Transparent;
            this.picRing4.Image = ((System.Drawing.Image)(resources.GetObject("picRing4.Image")));
            this.picRing4.Location = new System.Drawing.Point(687, 124);
            this.picRing4.Name = "picRing4";
            this.picRing4.Size = new System.Drawing.Size(80, 60);
            this.picRing4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRing4.TabIndex = 5;
            this.picRing4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(958, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 500);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Location = new System.Drawing.Point(12, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 524);
            this.panel2.TabIndex = 8;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picRing4);
            this.Controls.Add(this.picRing3);
            this.Controls.Add(this.picRing2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picRing1);
            this.Controls.Add(this.picBlueOcto);
            this.Name = "frmGame";
            this.Text = "Game Demo";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBlueOcto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRing4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBlueOcto;
        private System.Windows.Forms.Timer tmrBlueOcto;
        private System.Windows.Forms.Timer tmrWindow;
        private System.Windows.Forms.PictureBox picRing1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picRing2;
        private System.Windows.Forms.PictureBox picRing3;
        private System.Windows.Forms.PictureBox picRing4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

