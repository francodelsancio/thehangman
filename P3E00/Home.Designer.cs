namespace P3E00
{
    partial class Ahorcado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahorcado));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pannelGame = new System.Windows.Forms.Panel();
            this.picBoxStatus = new System.Windows.Forms.PictureBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnLetter10 = new System.Windows.Forms.Button();
            this.btnLetter9 = new System.Windows.Forms.Button();
            this.btnLetter8 = new System.Windows.Forms.Button();
            this.btnLetter7 = new System.Windows.Forms.Button();
            this.btnLetter6 = new System.Windows.Forms.Button();
            this.btnLetter5 = new System.Windows.Forms.Button();
            this.btnLetter4 = new System.Windows.Forms.Button();
            this.btnLetter3 = new System.Windows.Forms.Button();
            this.btnLetter2 = new System.Windows.Forms.Button();
            this.btnLetter1 = new System.Windows.Forms.Button();
            this.btnLetter0 = new System.Windows.Forms.Button();
            this.btnArrow = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.pannelAddWord = new System.Windows.Forms.Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBoxRemain = new System.Windows.Forms.PictureBox();
            this.lblRemain = new System.Windows.Forms.Label();
            this.pannelRemain = new System.Windows.Forms.Panel();
            this.picBoxGuy = new System.Windows.Forms.PictureBox();
            this.picBoxRope = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pannelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).BeginInit();
            this.pannelAddWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRemain)).BeginInit();
            this.pannelRemain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRope)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(748, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.pannelGame);
            this.panel1.Controls.Add(this.pannelAddWord);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 113);
            this.panel1.TabIndex = 1;
            // 
            // pannelGame
            // 
            this.pannelGame.Controls.Add(this.picBoxStatus);
            this.pannelGame.Controls.Add(this.lblWord);
            this.pannelGame.Controls.Add(this.btnLetter10);
            this.pannelGame.Controls.Add(this.btnLetter9);
            this.pannelGame.Controls.Add(this.btnLetter8);
            this.pannelGame.Controls.Add(this.btnLetter7);
            this.pannelGame.Controls.Add(this.btnLetter6);
            this.pannelGame.Controls.Add(this.btnLetter5);
            this.pannelGame.Controls.Add(this.btnLetter4);
            this.pannelGame.Controls.Add(this.btnLetter3);
            this.pannelGame.Controls.Add(this.btnLetter2);
            this.pannelGame.Controls.Add(this.btnLetter1);
            this.pannelGame.Controls.Add(this.btnLetter0);
            this.pannelGame.Controls.Add(this.btnArrow);
            this.pannelGame.Controls.Add(this.txtLetter);
            this.pannelGame.Location = new System.Drawing.Point(13, 6);
            this.pannelGame.Name = "pannelGame";
            this.pannelGame.Size = new System.Drawing.Size(776, 102);
            this.pannelGame.TabIndex = 7;
            this.pannelGame.Visible = false;
            // 
            // picBoxStatus
            // 
            this.picBoxStatus.BackColor = System.Drawing.Color.SaddleBrown;
            this.picBoxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxStatus.Location = new System.Drawing.Point(706, 23);
            this.picBoxStatus.Name = "picBoxStatus";
            this.picBoxStatus.Size = new System.Drawing.Size(60, 60);
            this.picBoxStatus.TabIndex = 9;
            this.picBoxStatus.TabStop = false;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Humnst777 Blk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWord.Location = new System.Drawing.Point(20, 6);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(429, 26);
            this.lblWord.TabIndex = 18;
            this.lblWord.Text = "Intente adivinar para vencer a su rival.";
            // 
            // btnLetter10
            // 
            this.btnLetter10.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter10.BackgroundImage")));
            this.btnLetter10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter10.FlatAppearance.BorderSize = 0;
            this.btnLetter10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter10.Location = new System.Drawing.Point(706, 40);
            this.btnLetter10.Name = "btnLetter10";
            this.btnLetter10.Size = new System.Drawing.Size(50, 50);
            this.btnLetter10.TabIndex = 17;
            this.btnLetter10.UseVisualStyleBackColor = false;
            // 
            // btnLetter9
            // 
            this.btnLetter9.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter9.BackgroundImage")));
            this.btnLetter9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter9.FlatAppearance.BorderSize = 0;
            this.btnLetter9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter9.Location = new System.Drawing.Point(650, 40);
            this.btnLetter9.Name = "btnLetter9";
            this.btnLetter9.Size = new System.Drawing.Size(50, 50);
            this.btnLetter9.TabIndex = 16;
            this.btnLetter9.UseVisualStyleBackColor = false;
            // 
            // btnLetter8
            // 
            this.btnLetter8.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter8.BackgroundImage")));
            this.btnLetter8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter8.FlatAppearance.BorderSize = 0;
            this.btnLetter8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter8.Location = new System.Drawing.Point(593, 41);
            this.btnLetter8.Name = "btnLetter8";
            this.btnLetter8.Size = new System.Drawing.Size(50, 50);
            this.btnLetter8.TabIndex = 15;
            this.btnLetter8.UseVisualStyleBackColor = false;
            // 
            // btnLetter7
            // 
            this.btnLetter7.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter7.BackgroundImage")));
            this.btnLetter7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter7.FlatAppearance.BorderSize = 0;
            this.btnLetter7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter7.Location = new System.Drawing.Point(537, 40);
            this.btnLetter7.Name = "btnLetter7";
            this.btnLetter7.Size = new System.Drawing.Size(50, 50);
            this.btnLetter7.TabIndex = 14;
            this.btnLetter7.UseVisualStyleBackColor = false;
            // 
            // btnLetter6
            // 
            this.btnLetter6.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter6.BackgroundImage")));
            this.btnLetter6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter6.FlatAppearance.BorderSize = 0;
            this.btnLetter6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter6.Location = new System.Drawing.Point(482, 41);
            this.btnLetter6.Name = "btnLetter6";
            this.btnLetter6.Size = new System.Drawing.Size(50, 50);
            this.btnLetter6.TabIndex = 13;
            this.btnLetter6.UseVisualStyleBackColor = false;
            // 
            // btnLetter5
            // 
            this.btnLetter5.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter5.BackgroundImage")));
            this.btnLetter5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter5.FlatAppearance.BorderSize = 0;
            this.btnLetter5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter5.Location = new System.Drawing.Point(426, 40);
            this.btnLetter5.Name = "btnLetter5";
            this.btnLetter5.Size = new System.Drawing.Size(50, 50);
            this.btnLetter5.TabIndex = 12;
            this.btnLetter5.UseVisualStyleBackColor = false;
            // 
            // btnLetter4
            // 
            this.btnLetter4.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter4.BackgroundImage")));
            this.btnLetter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter4.FlatAppearance.BorderSize = 0;
            this.btnLetter4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter4.Location = new System.Drawing.Point(370, 41);
            this.btnLetter4.Name = "btnLetter4";
            this.btnLetter4.Size = new System.Drawing.Size(50, 50);
            this.btnLetter4.TabIndex = 11;
            this.btnLetter4.UseVisualStyleBackColor = false;
            // 
            // btnLetter3
            // 
            this.btnLetter3.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter3.BackgroundImage")));
            this.btnLetter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter3.FlatAppearance.BorderSize = 0;
            this.btnLetter3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter3.Location = new System.Drawing.Point(314, 41);
            this.btnLetter3.Name = "btnLetter3";
            this.btnLetter3.Size = new System.Drawing.Size(50, 50);
            this.btnLetter3.TabIndex = 10;
            this.btnLetter3.UseVisualStyleBackColor = false;
            // 
            // btnLetter2
            // 
            this.btnLetter2.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter2.BackgroundImage")));
            this.btnLetter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter2.FlatAppearance.BorderSize = 0;
            this.btnLetter2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter2.Location = new System.Drawing.Point(258, 41);
            this.btnLetter2.Name = "btnLetter2";
            this.btnLetter2.Size = new System.Drawing.Size(50, 50);
            this.btnLetter2.TabIndex = 9;
            this.btnLetter2.UseVisualStyleBackColor = false;
            // 
            // btnLetter1
            // 
            this.btnLetter1.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter1.BackgroundImage")));
            this.btnLetter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter1.FlatAppearance.BorderSize = 0;
            this.btnLetter1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter1.Location = new System.Drawing.Point(202, 40);
            this.btnLetter1.Name = "btnLetter1";
            this.btnLetter1.Size = new System.Drawing.Size(50, 50);
            this.btnLetter1.TabIndex = 8;
            this.btnLetter1.UseVisualStyleBackColor = false;
            // 
            // btnLetter0
            // 
            this.btnLetter0.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter0.BackgroundImage")));
            this.btnLetter0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter0.FlatAppearance.BorderSize = 0;
            this.btnLetter0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLetter0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLetter0.Location = new System.Drawing.Point(146, 40);
            this.btnLetter0.Name = "btnLetter0";
            this.btnLetter0.Size = new System.Drawing.Size(50, 50);
            this.btnLetter0.TabIndex = 7;
            this.btnLetter0.UseVisualStyleBackColor = false;
            // 
            // btnArrow
            // 
            this.btnArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArrow.BackgroundImage")));
            this.btnArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrow.Enabled = false;
            this.btnArrow.FlatAppearance.BorderSize = 0;
            this.btnArrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnArrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrow.Location = new System.Drawing.Point(87, 46);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(45, 37);
            this.btnArrow.TabIndex = 1;
            this.btnArrow.UseVisualStyleBackColor = true;
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            this.btnArrow.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnArrow.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // txtLetter
            // 
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter.Location = new System.Drawing.Point(25, 45);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(39, 40);
            this.txtLetter.TabIndex = 0;
            this.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetter.TextChanged += new System.EventHandler(this.txtLetter_TextChanged);
            // 
            // pannelAddWord
            // 
            this.pannelAddWord.Controls.Add(this.lblAdd);
            this.pannelAddWord.Controls.Add(this.btnAdd);
            this.pannelAddWord.Controls.Add(this.txtWord);
            this.pannelAddWord.Location = new System.Drawing.Point(104, 12);
            this.pannelAddWord.Name = "pannelAddWord";
            this.pannelAddWord.Size = new System.Drawing.Size(601, 97);
            this.pannelAddWord.TabIndex = 9;
            this.pannelAddWord.Visible = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Humnst777 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAdd.Location = new System.Drawing.Point(10, 1);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(529, 23);
            this.lblAdd.TabIndex = 8;
            this.lblAdd.Text = "Ingrese la palabra y deje que su rival intente adivinar\r\n";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(426, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Comenzar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Swis721 LtEx BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(16, 36);
            this.txtWord.MaxLength = 11;
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(329, 43);
            this.txtWord.TabIndex = 6;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(312, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 66);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(352, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 272);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.Image")));
            this.lblTitle.Location = new System.Drawing.Point(425, 202);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 48);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "El Ahorcado";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxRemain
            // 
            this.picBoxRemain.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRemain.BackgroundImage = global::P3E00.Properties.Resources.letterBox;
            this.picBoxRemain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxRemain.Location = new System.Drawing.Point(18, 14);
            this.picBoxRemain.Name = "picBoxRemain";
            this.picBoxRemain.Size = new System.Drawing.Size(76, 75);
            this.picBoxRemain.TabIndex = 5;
            this.picBoxRemain.TabStop = false;
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(109)))), ((int)(((byte)(59)))));
            this.lblRemain.Font = new System.Drawing.Font("Clarendon Blk BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemain.Location = new System.Drawing.Point(36, 27);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(44, 45);
            this.lblRemain.TabIndex = 6;
            this.lblRemain.Text = "8";
            this.lblRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pannelRemain
            // 
            this.pannelRemain.BackColor = System.Drawing.Color.Transparent;
            this.pannelRemain.Controls.Add(this.lblRemain);
            this.pannelRemain.Controls.Add(this.picBoxRemain);
            this.pannelRemain.Location = new System.Drawing.Point(355, 395);
            this.pannelRemain.Name = "pannelRemain";
            this.pannelRemain.Size = new System.Drawing.Size(121, 92);
            this.pannelRemain.TabIndex = 7;
            this.pannelRemain.Visible = false;
            // 
            // picBoxGuy
            // 
            this.picBoxGuy.BackColor = System.Drawing.Color.Transparent;
            this.picBoxGuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxGuy.Location = new System.Drawing.Point(120, -1);
            this.picBoxGuy.Name = "picBoxGuy";
            this.picBoxGuy.Size = new System.Drawing.Size(105, 410);
            this.picBoxGuy.TabIndex = 8;
            this.picBoxGuy.TabStop = false;
            // 
            // picBoxRope
            // 
            this.picBoxRope.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxRope.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRope.Image")));
            this.picBoxRope.Location = new System.Drawing.Point(144, -1);
            this.picBoxRope.Name = "picBoxRope";
            this.picBoxRope.Size = new System.Drawing.Size(120, 459);
            this.picBoxRope.TabIndex = 9;
            this.picBoxRope.TabStop = false;
            // 
            // Ahorcado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.picBoxRope);
            this.Controls.Add(this.picBoxGuy);
            this.Controls.Add(this.pannelRemain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "Ahorcado";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ahorcado_Load);
            this.panel1.ResumeLayout(false);
            this.pannelGame.ResumeLayout(false);
            this.pannelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).EndInit();
            this.pannelAddWord.ResumeLayout(false);
            this.pannelAddWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRemain)).EndInit();
            this.pannelRemain.ResumeLayout(false);
            this.pannelRemain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRope)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBoxRemain;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Panel pannelRemain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pannelAddWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Panel pannelGame;
        private System.Windows.Forms.Button btnArrow;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnLetter0;
        private System.Windows.Forms.Button btnLetter10;
        private System.Windows.Forms.Button btnLetter9;
        private System.Windows.Forms.Button btnLetter8;
        private System.Windows.Forms.Button btnLetter7;
        private System.Windows.Forms.Button btnLetter6;
        private System.Windows.Forms.Button btnLetter5;
        private System.Windows.Forms.Button btnLetter4;
        private System.Windows.Forms.Button btnLetter3;
        private System.Windows.Forms.Button btnLetter2;
        private System.Windows.Forms.Button btnLetter1;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.PictureBox picBoxGuy;
        private System.Windows.Forms.PictureBox picBoxStatus;
        private System.Windows.Forms.PictureBox picBoxRope;
    }
}

