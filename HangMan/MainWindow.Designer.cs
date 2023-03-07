namespace HangMan
{
    partial class HangManMainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangManMainView));
            this.secretWord_textBox = new System.Windows.Forms.TextBox();
            this.tryLetter_textBox = new System.Windows.Forms.TextBox();
            this.usedLetters_textBox = new System.Windows.Forms.TextBox();
            this.trials_progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picB_HangmanPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_HangmanPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // secretWord_textBox
            // 
            this.secretWord_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.secretWord_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretWord_textBox.Location = new System.Drawing.Point(30, 52);
            this.secretWord_textBox.Name = "secretWord_textBox";
            this.secretWord_textBox.ReadOnly = true;
            this.secretWord_textBox.Size = new System.Drawing.Size(238, 31);
            this.secretWord_textBox.TabIndex = 0;
            this.secretWord_textBox.TabStop = false;
            this.secretWord_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tryLetter_textBox
            // 
            this.tryLetter_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tryLetter_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryLetter_textBox.Location = new System.Drawing.Point(109, 213);
            this.tryLetter_textBox.MaxLength = 1;
            this.tryLetter_textBox.Name = "tryLetter_textBox";
            this.tryLetter_textBox.Size = new System.Drawing.Size(80, 31);
            this.tryLetter_textBox.TabIndex = 0;
            this.tryLetter_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tryLetter_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tryLetter_textBox_KeyUp);
            // 
            // usedLetters_textBox
            // 
            this.usedLetters_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedLetters_textBox.Location = new System.Drawing.Point(30, 112);
            this.usedLetters_textBox.Multiline = true;
            this.usedLetters_textBox.Name = "usedLetters_textBox";
            this.usedLetters_textBox.ReadOnly = true;
            this.usedLetters_textBox.Size = new System.Drawing.Size(238, 72);
            this.usedLetters_textBox.TabIndex = 2;
            this.usedLetters_textBox.TabStop = false;
            // 
            // trials_progressBar
            // 
            this.trials_progressBar.Location = new System.Drawing.Point(30, 273);
            this.trials_progressBar.Maximum = 7;
            this.trials_progressBar.Name = "trials_progressBar";
            this.trials_progressBar.Size = new System.Drawing.Size(238, 23);
            this.trials_progressBar.Step = 1;
            this.trials_progressBar.TabIndex = 3;
            this.trials_progressBar.Value = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Secret Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Used Letters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Try Letter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trials Left!!";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picB_HangmanPicture
            // 
            this.picB_HangmanPicture.Location = new System.Drawing.Point(32, 302);
            this.picB_HangmanPicture.Name = "picB_HangmanPicture";
            this.picB_HangmanPicture.Size = new System.Drawing.Size(236, 148);
            this.picB_HangmanPicture.TabIndex = 9;
            this.picB_HangmanPicture.TabStop = false;
            // 
            // HangManMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 461);
            this.Controls.Add(this.picB_HangmanPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trials_progressBar);
            this.Controls.Add(this.usedLetters_textBox);
            this.Controls.Add(this.tryLetter_textBox);
            this.Controls.Add(this.secretWord_textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HangManMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangMan";
            this.Load += new System.EventHandler(this.HangMan_MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_HangmanPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secretWord_textBox;
        private System.Windows.Forms.TextBox usedLetters_textBox;
        private System.Windows.Forms.ProgressBar trials_progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox tryLetter_textBox;
        private System.Windows.Forms.PictureBox picB_HangmanPicture;
    }
}

