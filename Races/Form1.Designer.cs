namespace Races
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.SukhmanLabel = new System.Windows.Forms.Label();
            this.SahilLabel = new System.Windows.Forms.Label();
            this.PariLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Button();
            this.horseNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.NameOfBettorLabel = new System.Windows.Forms.Label();
            this.SukhmanRadio = new System.Windows.Forms.RadioButton();
            this.SahilRadio = new System.Windows.Forms.RadioButton();
            this.PariRadio = new System.Windows.Forms.RadioButton();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.horse1 = new System.Windows.Forms.PictureBox();
            this.horse2 = new System.Windows.Forms.PictureBox();
            this.horse3 = new System.Windows.Forms.PictureBox();
            this.horse4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseNumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.reset.Location = new System.Drawing.Point(525, 158);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(116, 54);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // BobLabel
            // 
            this.SukhmanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SukhmanLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SukhmanLabel.Location = new System.Drawing.Point(696, 172);
            this.SukhmanLabel.Name = "BobLabel";
            this.SukhmanLabel.Size = new System.Drawing.Size(244, 20);
            this.SukhmanLabel.TabIndex = 13;
            this.SukhmanLabel.Text = "Bob\'s Bet";
            this.SukhmanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlLabel
            // 
            this.SahilLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SahilLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SahilLabel.Location = new System.Drawing.Point(696, 147);
            this.SahilLabel.Name = "AlLabel";
            this.SahilLabel.Size = new System.Drawing.Size(244, 20);
            this.SahilLabel.TabIndex = 12;
            this.SahilLabel.Text = "Al\'s Bet";
            this.SahilLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JoeLabel
            // 
            this.PariLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PariLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PariLabel.Location = new System.Drawing.Point(696, 122);
            this.PariLabel.Name = "JoeLabel";
            this.PariLabel.Size = new System.Drawing.Size(244, 20);
            this.PariLabel.TabIndex = 11;
            this.PariLabel.Text = "Joe\'s Bet";
            this.PariLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(692, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bets Informatiuon";
            // 
            // Race
            // 
            this.Race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Race.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Race.Location = new System.Drawing.Point(525, 102);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(116, 54);
            this.Race.TabIndex = 9;
            this.Race.Text = "Race!";
            this.Race.UseVisualStyleBackColor = false;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // horseNumberNumeric
            // 
            this.horseNumberNumeric.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.horseNumberNumeric.Location = new System.Drawing.Point(394, 183);
            this.horseNumberNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.horseNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horseNumberNumeric.Name = "horseNumberNumeric";
            this.horseNumberNumeric.Size = new System.Drawing.Size(75, 20);
            this.horseNumberNumeric.TabIndex = 8;
            this.horseNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(327, 185);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "horse No";
            // 
            // betNumeric
            // 
            this.betNumeric.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.betNumeric.Location = new System.Drawing.Point(246, 183);
            this.betNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(75, 20);
            this.betNumeric.TabIndex = 6;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.betsButton.Location = new System.Drawing.Point(117, 183);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // NameOfBettorLabel
            // 
            this.NameOfBettorLabel.AutoSize = true;
            this.NameOfBettorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfBettorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameOfBettorLabel.Location = new System.Drawing.Point(18, 188);
            this.NameOfBettorLabel.Name = "NameOfBettorLabel";
            this.NameOfBettorLabel.Size = new System.Drawing.Size(93, 13);
            this.NameOfBettorLabel.TabIndex = 4;
            this.NameOfBettorLabel.Text = "Who\'s Betting?";
            // 
            // BobyRadio
            // 
            this.SukhmanRadio.AutoSize = true;
            this.SukhmanRadio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SukhmanRadio.Location = new System.Drawing.Point(16, 158);
            this.SukhmanRadio.Name = "BobyRadio";
            this.SukhmanRadio.Size = new System.Drawing.Size(44, 17);
            this.SukhmanRadio.TabIndex = 3;
            this.SukhmanRadio.TabStop = true;
            this.SukhmanRadio.Text = "Bob";
            this.SukhmanRadio.UseVisualStyleBackColor = true;
            this.SukhmanRadio.Click += new System.EventHandler(this.RadioClicked);
            // 
            // AliRadio
            // 
            this.SahilRadio.AutoSize = true;
            this.SahilRadio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SahilRadio.Location = new System.Drawing.Point(16, 135);
            this.SahilRadio.Name = "AliRadio";
            this.SahilRadio.Size = new System.Drawing.Size(34, 17);
            this.SahilRadio.TabIndex = 2;
            this.SahilRadio.TabStop = true;
            this.SahilRadio.Text = "Al";
            this.SahilRadio.UseVisualStyleBackColor = true;
            this.SahilRadio.Click += new System.EventHandler(this.RadioClicked);
            // 
            // JohnRadio
            // 
            this.PariRadio.AutoSize = true;
            this.PariRadio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PariRadio.Location = new System.Drawing.Point(16, 112);
            this.PariRadio.Name = "JohnRadio";
            this.PariRadio.Size = new System.Drawing.Size(42, 17);
            this.PariRadio.TabIndex = 1;
            this.PariRadio.TabStop = true;
            this.PariRadio.Text = "Joe";
            this.PariRadio.UseVisualStyleBackColor = true;
            this.PariRadio.Click += new System.EventHandler(this.RadioClicked);
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimumBetLabel.Location = new System.Drawing.Point(12, 85);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(130, 23);
            this.MinimumBetLabel.TabIndex = 0;
            this.MinimumBetLabel.Text = "Bet Setting";
            // 
            // horse1
            // 
            this.horse1.BackColor = System.Drawing.Color.Transparent;
            this.horse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horse1.Image = ((System.Drawing.Image)(resources.GetObject("horse1.Image")));
            this.horse1.Location = new System.Drawing.Point(29, 219);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(103, 80);
            this.horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse1.TabIndex = 2;
            this.horse1.TabStop = false;
            // 
            // horse2
            // 
            this.horse2.BackColor = System.Drawing.Color.Transparent;
            this.horse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horse2.Image = ((System.Drawing.Image)(resources.GetObject("horse2.Image")));
            this.horse2.Location = new System.Drawing.Point(29, 314);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(103, 80);
            this.horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse2.TabIndex = 3;
            this.horse2.TabStop = false;
            // 
            // horse3
            // 
            this.horse3.BackColor = System.Drawing.Color.Transparent;
            this.horse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horse3.Image = ((System.Drawing.Image)(resources.GetObject("horse3.Image")));
            this.horse3.Location = new System.Drawing.Point(29, 410);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(103, 71);
            this.horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse3.TabIndex = 4;
            this.horse3.TabStop = false;
            // 
            // horse4
            // 
            this.horse4.BackColor = System.Drawing.Color.Transparent;
            this.horse4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horse4.Image = ((System.Drawing.Image)(resources.GetObject("horse4.Image")));
            this.horse4.Location = new System.Drawing.Point(29, 499);
            this.horse4.Name = "horse4";
            this.horse4.Size = new System.Drawing.Size(103, 80);
            this.horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horse4.TabIndex = 5;
            this.horse4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.Timer1_tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(289, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(391, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(198, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bucks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SukhmanRadio);
            this.Controls.Add(this.horseNumberNumeric);
            this.Controls.Add(this.SahilRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PariRadio);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.MinimumBetLabel);
            this.Controls.Add(this.betNumeric);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.betsButton);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.NameOfBettorLabel);
            this.Controls.Add(this.SukhmanLabel);
            this.Controls.Add(this.horse4);
            this.Controls.Add(this.SahilLabel);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.PariLabel);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Betting On Race";
            this.Load += new System.EventHandler(this.Form1_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseNumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.RadioButton SukhmanRadio;
        private System.Windows.Forms.RadioButton SahilRadio;
        private System.Windows.Forms.RadioButton PariRadio;
        private System.Windows.Forms.Label NameOfBettorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.NumericUpDown horseNumberNumeric;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.Label SukhmanLabel;
        private System.Windows.Forms.Label SahilLabel;
        private System.Windows.Forms.Label PariLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox horse1;
        private System.Windows.Forms.PictureBox horse2;
        private System.Windows.Forms.PictureBox horse3;
        private System.Windows.Forms.PictureBox horse4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

