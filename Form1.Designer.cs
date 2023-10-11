namespace pictureBoxDinoK
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
            this.pcrSlika = new System.Windows.Forms.PictureBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcrSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pcrSlika
            // 
            this.pcrSlika.Image = global::pictureBoxDinoK.Properties.Resources.Ucinoca2;
            this.pcrSlika.Location = new System.Drawing.Point(12, 75);
            this.pcrSlika.Name = "pcrSlika";
            this.pcrSlika.Size = new System.Drawing.Size(330, 177);
            this.pcrSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrSlika.TabIndex = 0;
            this.pcrSlika.TabStop = false;
            this.pcrSlika.Visible = false;
            this.pcrSlika.Click += new System.EventHandler(this.pcrSlika_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(15, 270);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži sliku";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(12, 46);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(125, 13);
            this.lblFoto.TabIndex = 2;
            this.lblFoto.Text = "Fotografija naše učionice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.pcrSlika);
            this.Name = "Form1";
            this.Text = "PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pcrSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcrSlika;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label lblFoto;
    }
}

