namespace EndlessTanks
{
    partial class EndlessTanks
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndlessTanks));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.en2 = new System.Windows.Forms.PictureBox();
            this.en1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.en2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.StartGame);
            // 
            // lbl_score
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(323, 0);
            this.scoreLabel.Name = "lbl_score";
            this.scoreLabel.Size = new System.Drawing.Size(86, 24);
            this.scoreLabel.TabIndex = 30;
            this.scoreLabel.Text = "Score: 0";
            // 
            // lbl_over
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("Imprint MT Shadow", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(252, 176);
            this.labelGameOver.Name = "lbl_over";
            this.labelGameOver.Size = new System.Drawing.Size(266, 56);
            this.labelGameOver.TabIndex = 31;
            this.labelGameOver.Text = "Game Over";
            // 
            // en_2
            // 
            this.en2.BackColor = System.Drawing.Color.Transparent;
            this.en2.Image = global::EndlessTanks.Properties.Resources.bull2_1_;
            this.en2.Location = new System.Drawing.Point(594, 307);
            this.en2.Name = "en_2";
            this.en2.Size = new System.Drawing.Size(22, 8);
            this.en2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en2.TabIndex = 29;
            this.en2.TabStop = false;
            // 
            // en_1
            // 
            this.en1.BackColor = System.Drawing.Color.Transparent;
            this.en1.Image = global::EndlessTanks.Properties.Resources.bull2_1_;
            this.en1.Location = new System.Drawing.Point(592, 132);
            this.en1.Name = "en_1";
            this.en1.Size = new System.Drawing.Size(22, 8);
            this.en1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.en1.TabIndex = 28;
            this.en1.TabStop = false;
            // 
            // enemy_2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::EndlessTanks.Properties.Resources.pixil_fram1;
            this.enemy2.Location = new System.Drawing.Point(622, 292);
            this.enemy2.Name = "enemy_2";
            this.enemy2.Size = new System.Drawing.Size(46, 31);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy2.TabIndex = 26;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // enemy_1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::EndlessTanks.Properties.Resources.pixil_fram1;
            this.enemy1.Location = new System.Drawing.Point(620, 116);
            this.enemy1.Name = "enemy_1";
            this.enemy1.Size = new System.Drawing.Size(46, 31);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy1.TabIndex = 25;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Black;
            this.pictureBox24.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox24.Location = new System.Drawing.Point(0, 420);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(786, 17);
            this.pictureBox24.TabIndex = 24;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Black;
            this.pictureBox23.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox23.Location = new System.Drawing.Point(0, 0);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(786, 17);
            this.pictureBox23.TabIndex = 23;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox22.BackgroundImage")));
            this.pictureBox22.Location = new System.Drawing.Point(415, 12);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(74, 39);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox22.TabIndex = 22;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "block";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox21.BackgroundImage")));
            this.pictureBox21.Location = new System.Drawing.Point(484, 12);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(74, 39);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox21.TabIndex = 21;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "block";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox20.BackgroundImage")));
            this.pictureBox20.Location = new System.Drawing.Point(558, 12);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(74, 39);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox20.TabIndex = 20;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "block";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox19.BackgroundImage")));
            this.pictureBox19.Location = new System.Drawing.Point(137, 12);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(74, 39);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox19.TabIndex = 19;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "block";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox18.BackgroundImage")));
            this.pictureBox18.Location = new System.Drawing.Point(207, 12);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(74, 39);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox18.TabIndex = 18;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "block";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox17.BackgroundImage")));
            this.pictureBox17.Location = new System.Drawing.Point(276, 12);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(74, 39);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox17.TabIndex = 17;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "block";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox16.BackgroundImage")));
            this.pictureBox16.Location = new System.Drawing.Point(344, 12);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(74, 39);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox16.TabIndex = 16;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "block";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox15.BackgroundImage")));
            this.pictureBox15.Location = new System.Drawing.Point(484, 386);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(74, 39);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox15.TabIndex = 15;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "block";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.Location = new System.Drawing.Point(556, 386);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(74, 39);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "block";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.Location = new System.Drawing.Point(-5, 12);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(74, 39);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "block";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.Location = new System.Drawing.Point(66, 12);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(74, 39);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "block";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.Location = new System.Drawing.Point(66, 386);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(74, 39);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "block";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.Location = new System.Drawing.Point(137, 386);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(74, 39);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "block";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.Location = new System.Drawing.Point(207, 386);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(74, 39);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "block";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(276, 386);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(74, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "block";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.Location = new System.Drawing.Point(344, 386);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(74, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "block";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.Location = new System.Drawing.Point(415, 386);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(74, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "block";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 386);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(74, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "block";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(207, 307);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "block";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(207, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "block";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "block";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "block";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::EndlessTanks.Properties.Resources.pixil_frame_01_;
            this.player.InitialImage = global::EndlessTanks.Properties.Resources.pixil_frame_01__1_;
            this.player.Location = new System.Drawing.Point(24, 211);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(101, 63);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // b_1
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::EndlessTanks.Properties.Resources.bull_1_;
            this.bullet.Location = new System.Drawing.Point(137, 239);
            this.bullet.Name = "b_1";
            this.bullet.Size = new System.Drawing.Size(22, 8);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bullet.TabIndex = 27;
            this.bullet.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox28.BackgroundImage")));
            this.pictureBox28.Location = new System.Drawing.Point(620, 386);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(74, 39);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox28.TabIndex = 35;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Tag = "block";
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox27.BackgroundImage")));
            this.pictureBox27.Location = new System.Drawing.Point(691, 386);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(74, 39);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox27.TabIndex = 34;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Tag = "block";
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox26.BackgroundImage")));
            this.pictureBox26.Location = new System.Drawing.Point(620, 12);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(74, 39);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox26.TabIndex = 33;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Tag = "block";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox25.BackgroundImage")));
            this.pictureBox25.Location = new System.Drawing.Point(691, 12);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(74, 39);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox25.TabIndex = 32;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "block";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 437);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.en2);
            this.Controls.Add(this.en1);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.en2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox en1;
        private System.Windows.Forms.PictureBox en2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
    }
}

