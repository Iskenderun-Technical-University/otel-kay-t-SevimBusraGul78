namespace otomasyon
{
    partial class frmmüsteriler
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmüsteriler));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnveri = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblücret = new System.Windows.Forms.Label();
            this.msktxttel = new System.Windows.Forms.MaskedTextBox();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpçıkış = new System.Windows.Forms.DateTimePicker();
            this.txtoda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpgiriş = new System.Windows.Forms.DateTimePicker();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkimlik = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SeaShell;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 347);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1044, 181);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İd";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adi";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadi";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cinsiyet";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tc";
            this.columnHeader7.Width = 57;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "OdaNo";
            this.columnHeader8.Width = 76;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ücret";
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "G.Tarihi";
            this.columnHeader10.Width = 85;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ç.Tarihi";
            this.columnHeader11.Width = 78;
            // 
            // btnveri
            // 
            this.btnveri.BackColor = System.Drawing.Color.Goldenrod;
            this.btnveri.Location = new System.Drawing.Point(945, 17);
            this.btnveri.Margin = new System.Windows.Forms.Padding(4);
            this.btnveri.Name = "btnveri";
            this.btnveri.Size = new System.Drawing.Size(169, 52);
            this.btnveri.TabIndex = 1;
            this.btnveri.Text = "Verileri Göster";
            this.btnveri.UseVisualStyleBackColor = false;
            this.btnveri.Click += new System.EventHandler(this.button1_Click);
            this.btnveri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Goldenrod;
            this.btnsil.Location = new System.Drawing.Point(945, 120);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(169, 52);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Goldenrod;
            this.btnara.Location = new System.Drawing.Point(868, 581);
            this.btnara.Margin = new System.Windows.Forms.Padding(4);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(169, 52);
            this.btnara.TabIndex = 4;
            this.btnara.Text = "Arama";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SeaShell;
            this.richTextBox1.Location = new System.Drawing.Point(676, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 29);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // lblücret
            // 
            this.lblücret.AutoSize = true;
            this.lblücret.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblücret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblücret.Location = new System.Drawing.Point(588, 90);
            this.lblücret.Name = "lblücret";
            this.lblücret.Size = new System.Drawing.Size(70, 25);
            this.lblücret.TabIndex = 42;
            this.lblücret.Text = "Ücret:";
            // 
            // msktxttel
            // 
            this.msktxttel.BackColor = System.Drawing.Color.SeaShell;
            this.msktxttel.Location = new System.Drawing.Point(191, 172);
            this.msktxttel.Mask = "(999) 000-0000";
            this.msktxttel.Name = "msktxttel";
            this.msktxttel.Size = new System.Drawing.Size(246, 30);
            this.msktxttel.TabIndex = 36;
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.BackColor = System.Drawing.Color.SeaShell;
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(191, 125);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(246, 31);
            this.cmbcinsiyet.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(501, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Oda Numarası:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(72, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cinsiyet:";
            // 
            // txtadi
            // 
            this.txtadi.BackColor = System.Drawing.Color.SeaShell;
            this.txtadi.Location = new System.Drawing.Point(191, 36);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(246, 30);
            this.txtadi.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Soyadı:";
            // 
            // dtpçıkış
            // 
            this.dtpçıkış.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpçıkış.Location = new System.Drawing.Point(676, 182);
            this.dtpçıkış.Name = "dtpçıkış";
            this.dtpçıkış.Size = new System.Drawing.Size(246, 30);
            this.dtpçıkış.TabIndex = 38;
            // 
            // txtoda
            // 
            this.txtoda.BackColor = System.Drawing.Color.SeaShell;
            this.txtoda.Location = new System.Drawing.Point(676, 40);
            this.txtoda.Name = "txtoda";
            this.txtoda.Size = new System.Drawing.Size(246, 30);
            this.txtoda.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "T.C Kimlik no:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(110, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(530, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // dtpgiriş
            // 
            this.dtpgiriş.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpgiriş.Location = new System.Drawing.Point(672, 134);
            this.dtpgiriş.Name = "dtpgiriş";
            this.dtpgiriş.Size = new System.Drawing.Size(250, 30);
            this.dtpgiriş.TabIndex = 37;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.BackColor = System.Drawing.Color.SeaShell;
            this.txtsoyadi.Location = new System.Drawing.Point(191, 85);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(246, 30);
            this.txtsoyadi.TabIndex = 32;
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.SeaShell;
            this.txtmail.Location = new System.Drawing.Point(191, 211);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(246, 30);
            this.txtmail.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Adı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(534, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Giriş Tarihi:";
            // 
            // txtkimlik
            // 
            this.txtkimlik.BackColor = System.Drawing.Color.SeaShell;
            this.txtkimlik.Location = new System.Drawing.Point(191, 263);
            this.txtkimlik.MaxLength = 11;
            this.txtkimlik.Name = "txtkimlik";
            this.txtkimlik.Size = new System.Drawing.Size(246, 30);
            this.txtkimlik.TabIndex = 34;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.SeaShell;
            this.richTextBox2.Location = new System.Drawing.Point(879, 535);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(246, 28);
            this.richTextBox2.TabIndex = 45;
            this.richTextBox2.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(803, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "İsim:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(945, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 52);
            this.button1.TabIndex = 46;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmmüsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblücret);
            this.Controls.Add(this.msktxttel);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpçıkış);
            this.Controls.Add(this.txtoda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpgiriş);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtkimlik);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnveri);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmüsteriler";
            this.Text = "Müsteri Bilgileri";
            this.Load += new System.EventHandler(this.frmmüsteriler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnveri;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblücret;
        private System.Windows.Forms.MaskedTextBox msktxttel;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpçıkış;
        private System.Windows.Forms.TextBox txtoda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpgiriş;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkimlik;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}