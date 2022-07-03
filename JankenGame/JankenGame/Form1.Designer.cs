namespace JankenGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picEnemyImage = new System.Windows.Forms.PictureBox();
            this.picEnemyHand = new System.Windows.Forms.PictureBox();
            this.picPlayerHand = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHand)).BeginInit();
            this.SuspendLayout();
            // 
            // picEnemyImage
            // 
            this.picEnemyImage.Image = global::JankenGame.Properties.Resources.fantasyDrogon;
            this.picEnemyImage.Location = new System.Drawing.Point(98, 25);
            this.picEnemyImage.Name = "picEnemyImage";
            this.picEnemyImage.Size = new System.Drawing.Size(226, 161);
            this.picEnemyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemyImage.TabIndex = 0;
            this.picEnemyImage.TabStop = false;
            // 
            // picEnemyHand
            // 
            this.picEnemyHand.Location = new System.Drawing.Point(151, 208);
            this.picEnemyHand.Name = "picEnemyHand";
            this.picEnemyHand.Size = new System.Drawing.Size(119, 102);
            this.picEnemyHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnemyHand.TabIndex = 1;
            this.picEnemyHand.TabStop = false;
            // 
            // picPlayerHand
            // 
            this.picPlayerHand.Location = new System.Drawing.Point(151, 316);
            this.picPlayerHand.Name = "picPlayerHand";
            this.picPlayerHand.Size = new System.Drawing.Size(119, 102);
            this.picPlayerHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerHand.TabIndex = 2;
            this.picPlayerHand.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(358, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 54);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "じゃんけんゲーム";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(362, 155);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(241, 48);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "スタート";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(45, 434);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(85, 30);
            this.btnRock.TabIndex = 5;
            this.btnRock.Text = "グー";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(163, 434);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(87, 30);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Text = "チョキ";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(278, 432);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(85, 32);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.Text = "パー";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 472);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picPlayerHand);
            this.Controls.Add(this.picEnemyHand);
            this.Controls.Add(this.picEnemyImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerHand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picEnemyImage;
        private PictureBox picEnemyHand;
        private PictureBox picPlayerHand;
        private Label lblTitle;
        private Button btnStart;
        private Button btnRock;
        private Button btnScissors;
        private Button btnPaper;
    }
}