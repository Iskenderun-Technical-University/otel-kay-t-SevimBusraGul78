namespace otomasyon
{
    partial class frmanaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmanaform));
            this.frmyenimüsteri = new System.Windows.Forms.Button();
            this.frmodalar = new System.Windows.Forms.Button();
            this.btnadmingiriş = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmyenimüsteri
            // 
            this.frmyenimüsteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.frmyenimüsteri.Location = new System.Drawing.Point(287, 45);
            this.frmyenimüsteri.Name = "frmyenimüsteri";
            this.frmyenimüsteri.Size = new System.Drawing.Size(172, 89);
            this.frmyenimüsteri.TabIndex = 1;
            this.frmyenimüsteri.Text = "Yeni Müşteri ";
            this.frmyenimüsteri.UseVisualStyleBackColor = false;
            this.frmyenimüsteri.Click += new System.EventHandler(this.frmyenimüsteri_Click);
            // 
            // frmodalar
            // 
            this.frmodalar.BackColor = System.Drawing.Color.Yellow;
            this.frmodalar.Location = new System.Drawing.Point(534, 45);
            this.frmodalar.Name = "frmodalar";
            this.frmodalar.Size = new System.Drawing.Size(172, 89);
            this.frmodalar.TabIndex = 3;
            this.frmodalar.Text = "Odalar";
            this.frmodalar.UseVisualStyleBackColor = false;
            this.frmodalar.Click += new System.EventHandler(this.frmodalar_Click);
            // 
            // btnadmingiriş
            // 
            this.btnadmingiriş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadmingiriş.Location = new System.Drawing.Point(52, 45);
            this.btnadmingiriş.Name = "btnadmingiriş";
            this.btnadmingiriş.Size = new System.Drawing.Size(172, 89);
            this.btnadmingiriş.TabIndex = 4;
            this.btnadmingiriş.Text = "Admin Giriş";
            this.btnadmingiriş.UseVisualStyleBackColor = false;
            this.btnadmingiriş.Click += new System.EventHandler(this.btnadmingiriş_Click);
            // 
            // frmanaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 474);
            this.Controls.Add(this.btnadmingiriş);
            this.Controls.Add(this.frmodalar);
            this.Controls.Add(this.frmyenimüsteri);
            this.DoubleBuffered = true;
            this.Name = "frmanaform";
            this.Text = "frmanaform";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button frmyenimüsteri;
        private System.Windows.Forms.Button frmodalar;
        private System.Windows.Forms.Button btnadmingiriş;
    }
}