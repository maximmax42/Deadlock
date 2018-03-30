namespace Deadlock
{
    partial class FormDeadlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeadlock));
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.roundButton0 = new Deadlock.RoundButton();
            this.roundButton9 = new Deadlock.RoundButton();
            this.roundButton8 = new Deadlock.RoundButton();
            this.roundButton7 = new Deadlock.RoundButton();
            this.roundButton6 = new Deadlock.RoundButton();
            this.roundButton5 = new Deadlock.RoundButton();
            this.roundButton4 = new Deadlock.RoundButton();
            this.roundButton3 = new Deadlock.RoundButton();
            this.roundButton2 = new Deadlock.RoundButton();
            this.roundButton1 = new Deadlock.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.BackgroundImage = global::Deadlock.Properties.Resources.screen_enterpassword;
            this.pictureBoxScreen.InitialImage = global::Deadlock.Properties.Resources.screen_enterpassword;
            this.pictureBoxScreen.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(500, 160);
            this.pictureBoxScreen.TabIndex = 16;
            this.pictureBoxScreen.TabStop = false;
            this.pictureBoxScreen.BackgroundImageChanged += new System.EventHandler(this.pictureBoxScreen_BackgroundImageChanged);
            // 
            // roundButton0
            // 
            this.roundButton0.BackColor = System.Drawing.Color.Transparent;
            this.roundButton0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton0.BackgroundImage")));
            this.roundButton0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton0.Location = new System.Drawing.Point(188, 446);
            this.roundButton0.Name = "roundButton0";
            this.roundButton0.Size = new System.Drawing.Size(125, 65);
            this.roundButton0.TabIndex = 15;
            this.roundButton0.Click += new System.EventHandler(this.roundButton0_Click);
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.Transparent;
            this.roundButton9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton9.BackgroundImage")));
            this.roundButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton9.Enabled = false;
            this.roundButton9.Location = new System.Drawing.Point(348, 353);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(125, 65);
            this.roundButton9.TabIndex = 14;
            this.roundButton9.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton9.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.Transparent;
            this.roundButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton8.BackgroundImage")));
            this.roundButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton8.Enabled = false;
            this.roundButton8.Location = new System.Drawing.Point(188, 353);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(125, 65);
            this.roundButton8.TabIndex = 13;
            this.roundButton8.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton8.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.Transparent;
            this.roundButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton7.BackgroundImage")));
            this.roundButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton7.Enabled = false;
            this.roundButton7.Location = new System.Drawing.Point(27, 353);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(125, 65);
            this.roundButton7.TabIndex = 12;
            this.roundButton7.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton7.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.Transparent;
            this.roundButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton6.BackgroundImage")));
            this.roundButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton6.Enabled = false;
            this.roundButton6.Location = new System.Drawing.Point(348, 257);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(125, 65);
            this.roundButton6.TabIndex = 11;
            this.roundButton6.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton6.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.Transparent;
            this.roundButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton5.BackgroundImage")));
            this.roundButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton5.Enabled = false;
            this.roundButton5.Location = new System.Drawing.Point(188, 257);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(125, 65);
            this.roundButton5.TabIndex = 10;
            this.roundButton5.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton5.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.Transparent;
            this.roundButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton4.BackgroundImage")));
            this.roundButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton4.Enabled = false;
            this.roundButton4.Location = new System.Drawing.Point(27, 257);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(125, 65);
            this.roundButton4.TabIndex = 9;
            this.roundButton4.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton4.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Transparent;
            this.roundButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton3.BackgroundImage")));
            this.roundButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton3.Enabled = false;
            this.roundButton3.Location = new System.Drawing.Point(348, 163);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(125, 65);
            this.roundButton3.TabIndex = 8;
            this.roundButton3.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton3.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton2.BackgroundImage")));
            this.roundButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton2.Enabled = false;
            this.roundButton2.Location = new System.Drawing.Point(188, 163);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(125, 65);
            this.roundButton2.TabIndex = 7;
            this.roundButton2.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton2.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButton1.BackgroundImage")));
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundButton1.Enabled = false;
            this.roundButton1.Location = new System.Drawing.Point(27, 163);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(125, 65);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.Click += new System.EventHandler(this.roundButton_Click);
            this.roundButton1.DoubleClick += new System.EventHandler(this.roundButton_Click);
            // 
            // FormDeadlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 530);
            this.Controls.Add(this.pictureBoxScreen);
            this.Controls.Add(this.roundButton0);
            this.Controls.Add(this.roundButton9);
            this.Controls.Add(this.roundButton8);
            this.Controls.Add(this.roundButton7);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeadlock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deadlock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
        private RoundButton roundButton5;
        private RoundButton roundButton6;
        private RoundButton roundButton7;
        private RoundButton roundButton8;
        private RoundButton roundButton9;
        private RoundButton roundButton0;
        private System.Windows.Forms.PictureBox pictureBoxScreen;
    }
}

