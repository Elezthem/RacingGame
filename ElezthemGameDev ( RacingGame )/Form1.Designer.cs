namespace ElezthemGameDev___RacingGame__
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.bg22 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.Labelcoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(840, 650);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(422, 522);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(128, 128);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bg2
            // 
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(0, -650);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(840, 650);
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // bg22
            // 
            this.bg22.Image = ((System.Drawing.Image)(resources.GetObject("bg22.Image")));
            this.bg22.Location = new System.Drawing.Point(0, 0);
            this.bg22.Name = "bg22";
            this.bg22.Size = new System.Drawing.Size(840, 650);
            this.bg22.TabIndex = 3;
            this.bg22.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(179, -130);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(128, 128);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 4;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(535, -400);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(128, 128);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 5;
            this.enemy2.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.LightCoral;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.White;
            this.labelLose.Location = new System.Drawing.Point(246, 202);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(339, 54);
            this.labelLose.TabIndex = 6;
            this.labelLose.Text = "Вы проиграли";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRestart.Location = new System.Drawing.Point(243, 274);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(342, 59);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Играть сначала";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(333, 72);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(32, 32);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 8;
            this.coin.TabStop = false;
            // 
            // Labelcoins
            // 
            this.Labelcoins.AutoSize = true;
            this.Labelcoins.BackColor = System.Drawing.Color.LightCoral;
            this.Labelcoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Labelcoins.ForeColor = System.Drawing.Color.White;
            this.Labelcoins.Location = new System.Drawing.Point(0, 0);
            this.Labelcoins.Name = "Labelcoins";
            this.Labelcoins.Size = new System.Drawing.Size(169, 36);
            this.Labelcoins.TabIndex = 9;
            this.Labelcoins.Text = "Монеты: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.Labelcoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox bg22;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label Labelcoins;
    }
}

