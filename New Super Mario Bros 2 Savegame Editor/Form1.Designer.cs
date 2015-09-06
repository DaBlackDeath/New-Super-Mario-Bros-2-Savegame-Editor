namespace New_Super_Mario_Bros_2_Savegame_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.box_file1_lives = new System.Windows.Forms.TextBox();
            this.box_file1_coins = new System.Windows.Forms.TextBox();
            this.box_file2_coins = new System.Windows.Forms.TextBox();
            this.box_file2_lives = new System.Windows.Forms.TextBox();
            this.box_file3_coins = new System.Windows.Forms.TextBox();
            this.box_file3_lives = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.box_money = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "load savegame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.box_file1_coins);
            this.groupBox1.Controls.Add(this.box_file1_lives);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save File 1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::New_Super_Mario_Bros_2_Savegame_Editor.Properties.Resources.nsmb2_lives;
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::New_Super_Mario_Bros_2_Savegame_Editor.Properties.Resources.nsmb2_starcoin;
            this.pictureBox1.Location = new System.Drawing.Point(6, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.box_file2_coins);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.box_file2_lives);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Location = new System.Drawing.Point(123, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save File 2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::New_Super_Mario_Bros_2_Savegame_Editor.Properties.Resources.nsmb2_lives;
            this.pictureBox3.Location = new System.Drawing.Point(6, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::New_Super_Mario_Bros_2_Savegame_Editor.Properties.Resources.nsmb2_starcoin;
            this.pictureBox4.Location = new System.Drawing.Point(6, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.box_file3_coins);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.box_file3_lives);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Location = new System.Drawing.Point(12, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 84);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save File 3";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::New_Super_Mario_Bros_2_Savegame_Editor.Properties.Resources.nsmb2_lives;
            this.pictureBox5.Location = new System.Drawing.Point(6, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::New_Super_Mario_Bros_2_Savegame_Editor.Properties.Resources.nsmb2_starcoin;
            this.pictureBox6.Location = new System.Drawing.Point(6, 50);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // box_file1_lives
            // 
            this.box_file1_lives.Location = new System.Drawing.Point(37, 24);
            this.box_file1_lives.MaxLength = 4;
            this.box_file1_lives.Name = "box_file1_lives";
            this.box_file1_lives.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_file1_lives.Size = new System.Drawing.Size(55, 20);
            this.box_file1_lives.TabIndex = 2;
            // 
            // box_file1_coins
            // 
            this.box_file1_coins.Location = new System.Drawing.Point(37, 55);
            this.box_file1_coins.MaxLength = 3;
            this.box_file1_coins.Name = "box_file1_coins";
            this.box_file1_coins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_file1_coins.Size = new System.Drawing.Size(55, 20);
            this.box_file1_coins.TabIndex = 3;
            // 
            // box_file2_coins
            // 
            this.box_file2_coins.Location = new System.Drawing.Point(37, 55);
            this.box_file2_coins.MaxLength = 3;
            this.box_file2_coins.Name = "box_file2_coins";
            this.box_file2_coins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_file2_coins.Size = new System.Drawing.Size(55, 20);
            this.box_file2_coins.TabIndex = 5;
            // 
            // box_file2_lives
            // 
            this.box_file2_lives.Location = new System.Drawing.Point(37, 24);
            this.box_file2_lives.MaxLength = 4;
            this.box_file2_lives.Name = "box_file2_lives";
            this.box_file2_lives.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_file2_lives.Size = new System.Drawing.Size(55, 20);
            this.box_file2_lives.TabIndex = 4;
            // 
            // box_file3_coins
            // 
            this.box_file3_coins.Location = new System.Drawing.Point(37, 55);
            this.box_file3_coins.MaxLength = 3;
            this.box_file3_coins.Name = "box_file3_coins";
            this.box_file3_coins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_file3_coins.Size = new System.Drawing.Size(55, 20);
            this.box_file3_coins.TabIndex = 7;
            // 
            // box_file3_lives
            // 
            this.box_file3_lives.Location = new System.Drawing.Point(37, 24);
            this.box_file3_lives.MaxLength = 4;
            this.box_file3_lives.Name = "box_file3_lives";
            this.box_file3_lives.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.box_file3_lives.Size = new System.Drawing.Size(55, 20);
            this.box_file3_lives.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.box_money);
            this.groupBox4.Location = new System.Drawing.Point(123, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 84);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Money";
            // 
            // box_money
            // 
            this.box_money.Location = new System.Drawing.Point(6, 36);
            this.box_money.MaxLength = 7;
            this.box_money.Name = "box_money";
            this.box_money.Size = new System.Drawing.Size(86, 20);
            this.box_money.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "save savegame";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSMB2 3DS Editor v1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox box_file1_coins;
        private System.Windows.Forms.TextBox box_file1_lives;
        private System.Windows.Forms.TextBox box_file2_coins;
        private System.Windows.Forms.TextBox box_file2_lives;
        private System.Windows.Forms.TextBox box_file3_coins;
        private System.Windows.Forms.TextBox box_file3_lives;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox box_money;
        private System.Windows.Forms.Button button2;
    }
}

