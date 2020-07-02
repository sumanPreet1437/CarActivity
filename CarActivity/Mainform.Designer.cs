using System;

namespace CarActivity
{
    partial class Mainform
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
            this.BMWPicture = new System.Windows.Forms.PictureBox();
            this.ToyotaPicture = new System.Windows.Forms.PictureBox();
            this.LexusPicture = new System.Windows.Forms.PictureBox();
            this.MercedesPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BMWPicture
            // 
            this.BMWPicture.Image = global::CarActivity.Resource1.b;
            this.BMWPicture.Location = new System.Drawing.Point(26, 73);
            this.BMWPicture.Name = "BMWPicture";
            this.BMWPicture.Size = new System.Drawing.Size(100, 50);
            this.BMWPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMWPicture.TabIndex = 0;
            this.BMWPicture.TabStop = false;
            this.BMWPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ToyotaPicture
            // 
            this.ToyotaPicture.Image = global::CarActivity.Resource1.m;
            this.ToyotaPicture.Location = new System.Drawing.Point(180, 73);
            this.ToyotaPicture.Name = "ToyotaPicture";
            this.ToyotaPicture.Size = new System.Drawing.Size(100, 50);
            this.ToyotaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ToyotaPicture.TabIndex = 1;
            this.ToyotaPicture.TabStop = false;
            // 
            // LexusPicture
            // 
            this.LexusPicture.Image = global::CarActivity.Resource1.t;
            this.LexusPicture.Location = new System.Drawing.Point(634, 73);
            this.LexusPicture.Name = "LexusPicture";
            this.LexusPicture.Size = new System.Drawing.Size(100, 50);
            this.LexusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LexusPicture.TabIndex = 2;
            this.LexusPicture.TabStop = false;
            // 
            // MercedesPicture
            // 
            this.MercedesPicture.Image = global::CarActivity.Resource1.l;
            this.MercedesPicture.Location = new System.Drawing.Point(390, 73);
            this.MercedesPicture.Name = "MercedesPicture";
            this.MercedesPicture.Size = new System.Drawing.Size(100, 50);
            this.MercedesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MercedesPicture.TabIndex = 3;
            this.MercedesPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MercedesPicture);
            this.Controls.Add(this.LexusPicture);
            this.Controls.Add(this.ToyotaPicture);
            this.Controls.Add(this.BMWPicture);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPicture)).EndInit();
            this.ResumeLayout(false);

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox BMWPicture;
        private System.Windows.Forms.PictureBox ToyotaPicture;
        private System.Windows.Forms.PictureBox LexusPicture;
        private System.Windows.Forms.PictureBox MercedesPicture;
        private System.Windows.Forms.Button button1;
    }
}

