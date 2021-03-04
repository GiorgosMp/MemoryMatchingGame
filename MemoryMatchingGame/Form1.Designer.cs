namespace MemoryMatchingGame
{
    partial class GameWindow
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreKeeper = new System.Windows.Forms.Label();
            this.TimeCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playAgainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.DupCard1 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.DupCard2 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.DupCard3 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.DupCard4 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.DupCard5 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.DupCard6 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.DupCard7 = new System.Windows.Forms.PictureBox();
            this.Card10 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.DupCard10 = new System.Windows.Forms.PictureBox();
            this.Card11 = new System.Windows.Forms.PictureBox();
            this.DupCard8 = new System.Windows.Forms.PictureBox();
            this.DupCard11 = new System.Windows.Forms.PictureBox();
            this.Card9 = new System.Windows.Forms.PictureBox();
            this.Card12 = new System.Windows.Forms.PictureBox();
            this.DupCard9 = new System.Windows.Forms.PictureBox();
            this.DupCard12 = new System.Windows.Forms.PictureBox();
            this.CardsHolder = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard12)).BeginInit();
            this.CardsHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScoreLabel.Location = new System.Drawing.Point(56, 40);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(96, 24);
            this.ScoreLabel.TabIndex = 10;
            this.ScoreLabel.Text = "Attempts:";
            // 
            // ScoreKeeper
            // 
            this.ScoreKeeper.AutoSize = true;
            this.ScoreKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreKeeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScoreKeeper.Location = new System.Drawing.Point(155, 40);
            this.ScoreKeeper.Name = "ScoreKeeper";
            this.ScoreKeeper.Size = new System.Drawing.Size(21, 24);
            this.ScoreKeeper.TabIndex = 11;
            this.ScoreKeeper.Text = "0";
            // 
            // TimeCounter
            // 
            this.TimeCounter.AutoSize = true;
            this.TimeCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TimeCounter.Location = new System.Drawing.Point(279, 40);
            this.TimeCounter.Name = "TimeCounter";
            this.TimeCounter.Size = new System.Drawing.Size(63, 24);
            this.TimeCounter.TabIndex = 12;
            this.TimeCounter.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(340, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "0";
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playAgainToolStripMenuItem,
            this.uploadPhotosToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // playAgainToolStripMenuItem
            // 
            this.playAgainToolStripMenuItem.Name = "playAgainToolStripMenuItem";
            this.playAgainToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.playAgainToolStripMenuItem.Text = "New Game";
            this.playAgainToolStripMenuItem.Click += new System.EventHandler(this.playAgainToolStripMenuItem_Click);
            // 
            // uploadPhotosToolStripMenuItem
            // 
            this.uploadPhotosToolStripMenuItem.Name = "uploadPhotosToolStripMenuItem";
            this.uploadPhotosToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.uploadPhotosToolStripMenuItem.Text = "Upload photos";
            this.uploadPhotosToolStripMenuItem.Click += new System.EventHandler(this.uploadPhotosToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(630, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "5";
            // 
            // Card1
            // 
            this.Card1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Card1.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card1.Location = new System.Drawing.Point(13, 13);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(100, 150);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 3;
            this.Card1.TabStop = false;
            this.Card1.Tag = "1";
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // DupCard1
            // 
            this.DupCard1.ErrorImage = null;
            this.DupCard1.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard1.Location = new System.Drawing.Point(129, 13);
            this.DupCard1.Name = "DupCard1";
            this.DupCard1.Size = new System.Drawing.Size(100, 150);
            this.DupCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard1.TabIndex = 4;
            this.DupCard1.TabStop = false;
            this.DupCard1.Tag = "1";
            this.DupCard1.Click += new System.EventHandler(this.DupCard1_Click);
            // 
            // Card2
            // 
            this.Card2.ErrorImage = null;
            this.Card2.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card2.Location = new System.Drawing.Point(245, 13);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(100, 150);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 5;
            this.Card2.TabStop = false;
            this.Card2.Tag = "2";
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // DupCard2
            // 
            this.DupCard2.ErrorImage = null;
            this.DupCard2.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard2.Location = new System.Drawing.Point(360, 13);
            this.DupCard2.Name = "DupCard2";
            this.DupCard2.Size = new System.Drawing.Size(100, 150);
            this.DupCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard2.TabIndex = 6;
            this.DupCard2.TabStop = false;
            this.DupCard2.Tag = "2";
            this.DupCard2.Click += new System.EventHandler(this.DupCard2_Click);
            // 
            // Card3
            // 
            this.Card3.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card3.Location = new System.Drawing.Point(476, 13);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(100, 150);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 7;
            this.Card3.TabStop = false;
            this.Card3.Tag = "3";
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // DupCard3
            // 
            this.DupCard3.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard3.Location = new System.Drawing.Point(592, 13);
            this.DupCard3.Name = "DupCard3";
            this.DupCard3.Size = new System.Drawing.Size(100, 150);
            this.DupCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard3.TabIndex = 8;
            this.DupCard3.TabStop = false;
            this.DupCard3.Tag = "3";
            this.DupCard3.Click += new System.EventHandler(this.DupCard3_Click);
            // 
            // Card4
            // 
            this.Card4.ErrorImage = null;
            this.Card4.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card4.Location = new System.Drawing.Point(13, 179);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(100, 150);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 9;
            this.Card4.TabStop = false;
            this.Card4.Tag = "4";
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // DupCard4
            // 
            this.DupCard4.ErrorImage = null;
            this.DupCard4.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard4.Location = new System.Drawing.Point(129, 179);
            this.DupCard4.Name = "DupCard4";
            this.DupCard4.Size = new System.Drawing.Size(100, 150);
            this.DupCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard4.TabIndex = 10;
            this.DupCard4.TabStop = false;
            this.DupCard4.Tag = "4";
            this.DupCard4.Click += new System.EventHandler(this.DupCard4_Click);
            // 
            // Card5
            // 
            this.Card5.ErrorImage = null;
            this.Card5.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card5.Location = new System.Drawing.Point(245, 179);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(100, 150);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 11;
            this.Card5.TabStop = false;
            this.Card5.Tag = "5";
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // DupCard5
            // 
            this.DupCard5.ErrorImage = null;
            this.DupCard5.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard5.Location = new System.Drawing.Point(360, 179);
            this.DupCard5.Name = "DupCard5";
            this.DupCard5.Size = new System.Drawing.Size(100, 150);
            this.DupCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard5.TabIndex = 12;
            this.DupCard5.TabStop = false;
            this.DupCard5.Tag = "5";
            this.DupCard5.Click += new System.EventHandler(this.DupCard5_Click);
            // 
            // Card6
            // 
            this.Card6.ErrorImage = null;
            this.Card6.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card6.Location = new System.Drawing.Point(476, 179);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(100, 150);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 13;
            this.Card6.TabStop = false;
            this.Card6.Tag = "6";
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // DupCard6
            // 
            this.DupCard6.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard6.Location = new System.Drawing.Point(592, 179);
            this.DupCard6.Name = "DupCard6";
            this.DupCard6.Size = new System.Drawing.Size(100, 150);
            this.DupCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard6.TabIndex = 14;
            this.DupCard6.TabStop = false;
            this.DupCard6.Tag = "6";
            this.DupCard6.Click += new System.EventHandler(this.DupCard6_Click);
            // 
            // Card7
            // 
            this.Card7.ErrorImage = null;
            this.Card7.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card7.Location = new System.Drawing.Point(13, 347);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(100, 150);
            this.Card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card7.TabIndex = 15;
            this.Card7.TabStop = false;
            this.Card7.Tag = "7";
            this.Card7.Click += new System.EventHandler(this.Card7_Click);
            // 
            // DupCard7
            // 
            this.DupCard7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DupCard7.ErrorImage = null;
            this.DupCard7.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard7.Location = new System.Drawing.Point(129, 347);
            this.DupCard7.Name = "DupCard7";
            this.DupCard7.Size = new System.Drawing.Size(100, 150);
            this.DupCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard7.TabIndex = 16;
            this.DupCard7.TabStop = false;
            this.DupCard7.Tag = "7";
            this.DupCard7.Click += new System.EventHandler(this.DupCard7_Click);
            // 
            // Card10
            // 
            this.Card10.ErrorImage = null;
            this.Card10.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card10.Location = new System.Drawing.Point(13, 516);
            this.Card10.Name = "Card10";
            this.Card10.Size = new System.Drawing.Size(100, 150);
            this.Card10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card10.TabIndex = 9;
            this.Card10.TabStop = false;
            this.Card10.Tag = "10";
            this.Card10.Click += new System.EventHandler(this.Card10_Click);
            // 
            // Card8
            // 
            this.Card8.ErrorImage = null;
            this.Card8.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card8.Location = new System.Drawing.Point(245, 347);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(100, 150);
            this.Card8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card8.TabIndex = 17;
            this.Card8.TabStop = false;
            this.Card8.Tag = "8";
            this.Card8.Click += new System.EventHandler(this.Card8_Click);
            // 
            // DupCard10
            // 
            this.DupCard10.ErrorImage = null;
            this.DupCard10.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard10.Location = new System.Drawing.Point(129, 516);
            this.DupCard10.Name = "DupCard10";
            this.DupCard10.Size = new System.Drawing.Size(100, 150);
            this.DupCard10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard10.TabIndex = 10;
            this.DupCard10.TabStop = false;
            this.DupCard10.Tag = "10";
            this.DupCard10.Click += new System.EventHandler(this.DupCard10_Click);
            // 
            // Card11
            // 
            this.Card11.ErrorImage = null;
            this.Card11.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card11.Location = new System.Drawing.Point(245, 516);
            this.Card11.Name = "Card11";
            this.Card11.Size = new System.Drawing.Size(100, 150);
            this.Card11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card11.TabIndex = 11;
            this.Card11.TabStop = false;
            this.Card11.Tag = "11";
            this.Card11.Click += new System.EventHandler(this.Card11_Click);
            // 
            // DupCard8
            // 
            this.DupCard8.ErrorImage = null;
            this.DupCard8.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard8.Location = new System.Drawing.Point(360, 347);
            this.DupCard8.Name = "DupCard8";
            this.DupCard8.Size = new System.Drawing.Size(100, 150);
            this.DupCard8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard8.TabIndex = 18;
            this.DupCard8.TabStop = false;
            this.DupCard8.Tag = "8";
            this.DupCard8.Click += new System.EventHandler(this.DupCard8_Click);
            // 
            // DupCard11
            // 
            this.DupCard11.ErrorImage = null;
            this.DupCard11.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard11.Location = new System.Drawing.Point(360, 516);
            this.DupCard11.Name = "DupCard11";
            this.DupCard11.Size = new System.Drawing.Size(100, 150);
            this.DupCard11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard11.TabIndex = 12;
            this.DupCard11.TabStop = false;
            this.DupCard11.Tag = "11";
            this.DupCard11.Click += new System.EventHandler(this.DupCard11_Click);
            // 
            // Card9
            // 
            this.Card9.ErrorImage = null;
            this.Card9.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card9.Location = new System.Drawing.Point(476, 347);
            this.Card9.Name = "Card9";
            this.Card9.Size = new System.Drawing.Size(100, 150);
            this.Card9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card9.TabIndex = 19;
            this.Card9.TabStop = false;
            this.Card9.Tag = "9";
            this.Card9.Click += new System.EventHandler(this.Card9_Click);
            // 
            // Card12
            // 
            this.Card12.ErrorImage = null;
            this.Card12.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.Card12.Location = new System.Drawing.Point(476, 516);
            this.Card12.Name = "Card12";
            this.Card12.Size = new System.Drawing.Size(100, 150);
            this.Card12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card12.TabIndex = 13;
            this.Card12.TabStop = false;
            this.Card12.Tag = "12";
            this.Card12.Click += new System.EventHandler(this.Card12_Click);
            // 
            // DupCard9
            // 
            this.DupCard9.ErrorImage = null;
            this.DupCard9.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard9.Location = new System.Drawing.Point(592, 347);
            this.DupCard9.Name = "DupCard9";
            this.DupCard9.Size = new System.Drawing.Size(100, 150);
            this.DupCard9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard9.TabIndex = 20;
            this.DupCard9.TabStop = false;
            this.DupCard9.Tag = "9";
            this.DupCard9.Click += new System.EventHandler(this.DupCard9_Click);
            // 
            // DupCard12
            // 
            this.DupCard12.ErrorImage = null;
            this.DupCard12.Image = global::MemoryMatchingGame.Properties.Resources.cover;
            this.DupCard12.Location = new System.Drawing.Point(592, 516);
            this.DupCard12.Name = "DupCard12";
            this.DupCard12.Size = new System.Drawing.Size(100, 150);
            this.DupCard12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DupCard12.TabIndex = 14;
            this.DupCard12.TabStop = false;
            this.DupCard12.Tag = "12";
            this.DupCard12.Click += new System.EventHandler(this.DupCard12_Click);
            // 
            // CardsHolder
            // 
            this.CardsHolder.Controls.Add(this.DupCard12);
            this.CardsHolder.Controls.Add(this.DupCard9);
            this.CardsHolder.Controls.Add(this.Card12);
            this.CardsHolder.Controls.Add(this.Card9);
            this.CardsHolder.Controls.Add(this.DupCard11);
            this.CardsHolder.Controls.Add(this.DupCard8);
            this.CardsHolder.Controls.Add(this.Card11);
            this.CardsHolder.Controls.Add(this.DupCard10);
            this.CardsHolder.Controls.Add(this.Card8);
            this.CardsHolder.Controls.Add(this.Card10);
            this.CardsHolder.Controls.Add(this.DupCard7);
            this.CardsHolder.Controls.Add(this.Card7);
            this.CardsHolder.Controls.Add(this.DupCard6);
            this.CardsHolder.Controls.Add(this.Card6);
            this.CardsHolder.Controls.Add(this.DupCard5);
            this.CardsHolder.Controls.Add(this.Card5);
            this.CardsHolder.Controls.Add(this.DupCard4);
            this.CardsHolder.Controls.Add(this.Card4);
            this.CardsHolder.Controls.Add(this.DupCard3);
            this.CardsHolder.Controls.Add(this.Card3);
            this.CardsHolder.Controls.Add(this.DupCard2);
            this.CardsHolder.Controls.Add(this.Card2);
            this.CardsHolder.Controls.Add(this.DupCard1);
            this.CardsHolder.Controls.Add(this.Card1);
            this.CardsHolder.Location = new System.Drawing.Point(0, 66);
            this.CardsHolder.Name = "CardsHolder";
            this.CardsHolder.Size = new System.Drawing.Size(706, 683);
            this.CardsHolder.TabIndex = 0;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeCounter);
            this.Controls.Add(this.ScoreKeeper);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.CardsHolder);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Who";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard12)).EndInit();
            this.CardsHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreKeeper;
        private System.Windows.Forms.Label TimeCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAgainToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox DupCard1;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox DupCard2;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox DupCard3;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox DupCard4;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox DupCard5;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox DupCard6;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox DupCard7;
        private System.Windows.Forms.PictureBox Card10;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.PictureBox DupCard10;
        private System.Windows.Forms.PictureBox Card11;
        private System.Windows.Forms.PictureBox DupCard8;
        private System.Windows.Forms.PictureBox DupCard11;
        private System.Windows.Forms.PictureBox Card9;
        private System.Windows.Forms.PictureBox Card12;
        private System.Windows.Forms.PictureBox DupCard9;
        private System.Windows.Forms.PictureBox DupCard12;
        private System.Windows.Forms.Panel CardsHolder;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

