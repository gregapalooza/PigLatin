namespace _6PigLatin
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
            this.tB_EnglishFrase = new System.Windows.Forms.TextBox();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rTBPigFrase = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_EnglishFrase
            // 
            this.tB_EnglishFrase.Location = new System.Drawing.Point(13, 59);
            this.tB_EnglishFrase.Name = "tB_EnglishFrase";
            this.tB_EnglishFrase.Size = new System.Drawing.Size(337, 20);
            this.tB_EnglishFrase.TabIndex = 0;
            // 
            // btn_Translate
            // 
            this.btn_Translate.Location = new System.Drawing.Point(356, 59);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(75, 23);
            this.btn_Translate.TabIndex = 1;
            this.btn_Translate.Text = "Translate";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_6PigLatin.Properties.Resources.piglatin__2_;
            this.pictureBox1.Location = new System.Drawing.Point(356, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rTBPigFrase
            // 
            this.rTBPigFrase.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rTBPigFrase.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBPigFrase.ForeColor = System.Drawing.SystemColors.Window;
            this.rTBPigFrase.Location = new System.Drawing.Point(13, 85);
            this.rTBPigFrase.Name = "rTBPigFrase";
            this.rTBPigFrase.ReadOnly = true;
            this.rTBPigFrase.Size = new System.Drawing.Size(337, 225);
            this.rTBPigFrase.TabIndex = 4;
            this.rTBPigFrase.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(563, 335);
            this.Controls.Add(this.rTBPigFrase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Translate);
            this.Controls.Add(this.tB_EnglishFrase);
            this.Name = "Form1";
            this.Text = "Pig Latin Translator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_EnglishFrase;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rTBPigFrase;
    }
}

