namespace Bandersnatch
{
    partial class FrmHowTo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHowTo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnCredits = new System.Windows.Forms.Button();
            this.BtnChoices = new System.Windows.Forms.Button();
            this.BtnStory = new System.Windows.Forms.Button();
            this.BtnControls = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PbTitle = new System.Windows.Forms.PictureBox();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.TbUserInput1 = new System.Windows.Forms.TextBox();
            this.LblText1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.BtnCredits);
            this.splitContainer1.Panel1.Controls.Add(this.BtnChoices);
            this.splitContainer1.Panel1.Controls.Add(this.BtnStory);
            this.splitContainer1.Panel1.Controls.Add(this.BtnControls);
            this.splitContainer1.Panel1.Controls.Add(this.BtnHome);
            this.splitContainer1.Panel1.Controls.Add(this.PbTitle);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmHowTo_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmHowTo_MouseMove);
            this.splitContainer1.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmHowTo_MouseUp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnDownload);
            this.splitContainer1.Panel2.Controls.Add(this.TbUserInput1);
            this.splitContainer1.Panel2.Controls.Add(this.LblText1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmHowTo_MouseDown);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmHowTo_MouseMove);
            this.splitContainer1.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmHowTo_MouseUp);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 800);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnCredits
            // 
            this.BtnCredits.BackColor = System.Drawing.Color.Transparent;
            this.BtnCredits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCredits.BackgroundImage")));
            this.BtnCredits.CausesValidation = false;
            this.BtnCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCredits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCredits.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCredits.ForeColor = System.Drawing.Color.White;
            this.BtnCredits.Location = new System.Drawing.Point(0, 340);
            this.BtnCredits.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCredits.Name = "BtnCredits";
            this.BtnCredits.Size = new System.Drawing.Size(350, 85);
            this.BtnCredits.TabIndex = 7;
            this.BtnCredits.Text = "Credits / Download";
            this.BtnCredits.UseVisualStyleBackColor = false;
            this.BtnCredits.Click += new System.EventHandler(this.BtnCredits_Click);
            // 
            // BtnChoices
            // 
            this.BtnChoices.BackColor = System.Drawing.Color.Transparent;
            this.BtnChoices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnChoices.BackgroundImage")));
            this.BtnChoices.CausesValidation = false;
            this.BtnChoices.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnChoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnChoices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnChoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChoices.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChoices.ForeColor = System.Drawing.Color.White;
            this.BtnChoices.Location = new System.Drawing.Point(0, 255);
            this.BtnChoices.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChoices.Name = "BtnChoices";
            this.BtnChoices.Size = new System.Drawing.Size(350, 85);
            this.BtnChoices.TabIndex = 6;
            this.BtnChoices.Text = "Choices";
            this.BtnChoices.UseVisualStyleBackColor = false;
            this.BtnChoices.Click += new System.EventHandler(this.BtnChoices_Click);
            // 
            // BtnStory
            // 
            this.BtnStory.BackColor = System.Drawing.Color.Transparent;
            this.BtnStory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStory.BackgroundImage")));
            this.BtnStory.CausesValidation = false;
            this.BtnStory.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnStory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnStory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStory.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStory.ForeColor = System.Drawing.Color.White;
            this.BtnStory.Location = new System.Drawing.Point(0, 170);
            this.BtnStory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStory.Name = "BtnStory";
            this.BtnStory.Size = new System.Drawing.Size(350, 85);
            this.BtnStory.TabIndex = 5;
            this.BtnStory.Text = "Story";
            this.BtnStory.UseVisualStyleBackColor = false;
            this.BtnStory.Click += new System.EventHandler(this.BtnStory_Click);
            // 
            // BtnControls
            // 
            this.BtnControls.BackColor = System.Drawing.Color.Transparent;
            this.BtnControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnControls.BackgroundImage")));
            this.BtnControls.CausesValidation = false;
            this.BtnControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnControls.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnControls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnControls.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnControls.ForeColor = System.Drawing.Color.White;
            this.BtnControls.Location = new System.Drawing.Point(0, 85);
            this.BtnControls.Margin = new System.Windows.Forms.Padding(0);
            this.BtnControls.Name = "BtnControls";
            this.BtnControls.Size = new System.Drawing.Size(350, 85);
            this.BtnControls.TabIndex = 4;
            this.BtnControls.Text = "Controls";
            this.BtnControls.UseVisualStyleBackColor = false;
            this.BtnControls.Click += new System.EventHandler(this.BtnControls_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.BackgroundImage = global::Bandersnatch.Properties.Resources.BackgroundClearBlack;
            this.BtnHome.CausesValidation = false;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 715);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(350, 85);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PbTitle
            // 
            this.PbTitle.BackgroundImage = global::Bandersnatch.Properties.Resources.BackgroundClearBlack;
            this.PbTitle.Image = global::Bandersnatch.Properties.Resources.BannerWhite;
            this.PbTitle.Location = new System.Drawing.Point(0, 0);
            this.PbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PbTitle.Name = "PbTitle";
            this.PbTitle.Size = new System.Drawing.Size(350, 85);
            this.PbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbTitle.TabIndex = 0;
            this.PbTitle.TabStop = false;
            this.PbTitle.Click += new System.EventHandler(this.PbTitle_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackgroundImage = global::Bandersnatch.Properties.Resources.BackgroundClearBlack;
            this.BtnDownload.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownload.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownload.ForeColor = System.Drawing.Color.White;
            this.BtnDownload.Image = global::Bandersnatch.Properties.Resources.BackgroundClearBlack;
            this.BtnDownload.Location = new System.Drawing.Point(298, 661);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(197, 54);
            this.BtnDownload.TabIndex = 2;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Visible = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // TbUserInput1
            // 
            this.TbUserInput1.BackColor = System.Drawing.Color.Black;
            this.TbUserInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUserInput1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUserInput1.ForeColor = System.Drawing.Color.DimGray;
            this.TbUserInput1.Location = new System.Drawing.Point(298, 608);
            this.TbUserInput1.MaxLength = 3;
            this.TbUserInput1.Name = "TbUserInput1";
            this.TbUserInput1.Size = new System.Drawing.Size(197, 27);
            this.TbUserInput1.TabIndex = 1;
            this.TbUserInput1.Text = "Fill in password";
            this.TbUserInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbUserInput1.Visible = false;
            this.TbUserInput1.Click += new System.EventHandler(this.TbUserInput1_Click);
            this.TbUserInput1.TextChanged += new System.EventHandler(this.TbUserInput1_TextChanged);
            // 
            // LblText1
            // 
            this.LblText1.Font = new System.Drawing.Font("Consolas", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText1.Image = global::Bandersnatch.Properties.Resources.BackgroundClearBlack;
            this.LblText1.Location = new System.Drawing.Point(21, 25);
            this.LblText1.Margin = new System.Windows.Forms.Padding(25);
            this.LblText1.Name = "LblText1";
            this.LblText1.Padding = new System.Windows.Forms.Padding(10);
            this.LblText1.Size = new System.Drawing.Size(750, 750);
            this.LblText1.TabIndex = 0;
            this.LblText1.Text = "Click on a button to see it\'s contents!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmHowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Bandersnatch.Properties.Resources.BackgroundMainMenuBlur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHowTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandersnatch";
            this.Load += new System.EventHandler(this.FrmHowTo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox PbTitle;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnStory;
        private System.Windows.Forms.Button BtnControls;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnCredits;
        private System.Windows.Forms.Button BtnChoices;
        private System.Windows.Forms.Label LblText1;
        private System.Windows.Forms.TextBox TbUserInput1;
        private System.Windows.Forms.Button BtnDownload;
    }
}