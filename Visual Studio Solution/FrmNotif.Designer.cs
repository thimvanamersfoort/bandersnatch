namespace Bandersnatch
{
    partial class FrmNotif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotif));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblText1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bandersnatch.Properties.Resources.BannerWhite;
            this.pictureBox1.Location = new System.Drawing.Point(62, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(53, 20, 50, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnPlay.CausesValidation = false;
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPlay.FlatAppearance.BorderSize = 2;
            this.BtnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(74, 316);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(65, 15, 0, 50);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(165, 75);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExit.CausesValidation = false;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderSize = 2;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(411, 316);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0, 15, 65, 50);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(165, 75);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblText1
            // 
            this.LblText1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText1.Location = new System.Drawing.Point(74, 124);
            this.LblText1.Margin = new System.Windows.Forms.Padding(0);
            this.LblText1.Name = "LblText1";
            this.LblText1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblText1.Size = new System.Drawing.Size(502, 177);
            this.LblText1.TabIndex = 3;
            // 
            // FrmNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.LblText1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNotif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandersnatch";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmNotif_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmNotif_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmNotif_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblText1;
    }
}