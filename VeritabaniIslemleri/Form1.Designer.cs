namespace VeritabaniIslemleri
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
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.groupBoxDersler = new System.Windows.Forms.GroupBox();
            this.dataGridViewDersler = new System.Windows.Forms.DataGridView();
            this.groupBoxOgretmenler = new System.Windows.Forms.GroupBox();
            this.dataGridViewOgretmenler = new System.Windows.Forms.DataGridView();
            this.DersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODersAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageOgretmen = new System.Windows.Forms.TabPage();
            this.tabPageDers = new System.Windows.Forms.TabPage();
            this.groupBoxEkleme = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDEAd = new System.Windows.Forms.TextBox();
            this.buttonDersKaydet = new System.Windows.Forms.Button();
            this.groupBoxDersGuncelleme = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            this.buttonDersSecG = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDersYeniAd = new System.Windows.Forms.TextBox();
            this.buttonDersGuncelle = new System.Windows.Forms.Button();
            this.groupBoxDersSilme = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDerslerSilme = new System.Windows.Forms.ComboBox();
            this.buttonDersSil = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBoxOgretmenEkleme = new System.Windows.Forms.GroupBox();
            this.groupBoxOgretmenGuncelleme = new System.Windows.Forms.GroupBox();
            this.groupBoxOgretmenSilme = new System.Windows.Forms.GroupBox();
            this.panelIslemler.SuspendLayout();
            this.groupBoxDersler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).BeginInit();
            this.groupBoxOgretmenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgretmenler)).BeginInit();
            this.tabPageOgretmen.SuspendLayout();
            this.tabPageDers.SuspendLayout();
            this.groupBoxEkleme.SuspendLayout();
            this.groupBoxDersGuncelleme.SuspendLayout();
            this.groupBoxDersSilme.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIslemler
            // 
            this.panelIslemler.Controls.Add(this.tabControl1);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIslemler.Location = new System.Drawing.Point(0, 0);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(938, 379);
            this.panelIslemler.TabIndex = 0;
            // 
            // groupBoxDersler
            // 
            this.groupBoxDersler.Controls.Add(this.dataGridViewDersler);
            this.groupBoxDersler.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxDersler.Location = new System.Drawing.Point(0, 379);
            this.groupBoxDersler.Name = "groupBoxDersler";
            this.groupBoxDersler.Size = new System.Drawing.Size(333, 324);
            this.groupBoxDersler.TabIndex = 1;
            this.groupBoxDersler.TabStop = false;
            this.groupBoxDersler.Text = "Dersler";
            // 
            // dataGridViewDersler
            // 
            this.dataGridViewDersler.AllowUserToAddRows = false;
            this.dataGridViewDersler.AllowUserToDeleteRows = false;
            this.dataGridViewDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DersId,
            this.DersAd});
            this.dataGridViewDersler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDersler.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDersler.Name = "dataGridViewDersler";
            this.dataGridViewDersler.ReadOnly = true;
            this.dataGridViewDersler.Size = new System.Drawing.Size(327, 305);
            this.dataGridViewDersler.TabIndex = 0;
            // 
            // groupBoxOgretmenler
            // 
            this.groupBoxOgretmenler.Controls.Add(this.dataGridViewOgretmenler);
            this.groupBoxOgretmenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOgretmenler.Location = new System.Drawing.Point(333, 379);
            this.groupBoxOgretmenler.Name = "groupBoxOgretmenler";
            this.groupBoxOgretmenler.Size = new System.Drawing.Size(605, 324);
            this.groupBoxOgretmenler.TabIndex = 2;
            this.groupBoxOgretmenler.TabStop = false;
            this.groupBoxOgretmenler.Text = "Öğretmenler";
            // 
            // dataGridViewOgretmenler
            // 
            this.dataGridViewOgretmenler.AllowUserToAddRows = false;
            this.dataGridViewOgretmenler.AllowUserToDeleteRows = false;
            this.dataGridViewOgretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgretmenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OId,
            this.OAd,
            this.Osoyad,
            this.ODersId,
            this.ODersAd,
            this.DTarih});
            this.dataGridViewOgretmenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOgretmenler.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOgretmenler.Name = "dataGridViewOgretmenler";
            this.dataGridViewOgretmenler.ReadOnly = true;
            this.dataGridViewOgretmenler.Size = new System.Drawing.Size(599, 305);
            this.dataGridViewOgretmenler.TabIndex = 0;
            // 
            // DersId
            // 
            this.DersId.HeaderText = "Ders Nu";
            this.DersId.Name = "DersId";
            this.DersId.ReadOnly = true;
            // 
            // DersAd
            // 
            this.DersAd.HeaderText = "Ders Adı";
            this.DersAd.Name = "DersAd";
            this.DersAd.ReadOnly = true;
            // 
            // OId
            // 
            this.OId.HeaderText = "Nu";
            this.OId.Name = "OId";
            this.OId.ReadOnly = true;
            // 
            // OAd
            // 
            this.OAd.HeaderText = "Adı";
            this.OAd.Name = "OAd";
            this.OAd.ReadOnly = true;
            // 
            // Osoyad
            // 
            this.Osoyad.HeaderText = "Soyadı";
            this.Osoyad.Name = "Osoyad";
            this.Osoyad.ReadOnly = true;
            // 
            // ODersId
            // 
            this.ODersId.HeaderText = "Ders Nu";
            this.ODersId.Name = "ODersId";
            this.ODersId.ReadOnly = true;
            // 
            // ODersAd
            // 
            this.ODersAd.HeaderText = "Ders Adı";
            this.ODersAd.Name = "ODersAd";
            this.ODersAd.ReadOnly = true;
            // 
            // DTarih
            // 
            this.DTarih.HeaderText = "Doğum Tarihi";
            this.DTarih.Name = "DTarih";
            this.DTarih.ReadOnly = true;
            // 
            // tabPageOgretmen
            // 
            this.tabPageOgretmen.Controls.Add(this.groupBoxOgretmenSilme);
            this.tabPageOgretmen.Controls.Add(this.groupBoxOgretmenGuncelleme);
            this.tabPageOgretmen.Controls.Add(this.groupBoxOgretmenEkleme);
            this.tabPageOgretmen.Location = new System.Drawing.Point(4, 22);
            this.tabPageOgretmen.Name = "tabPageOgretmen";
            this.tabPageOgretmen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgretmen.Size = new System.Drawing.Size(930, 353);
            this.tabPageOgretmen.TabIndex = 1;
            this.tabPageOgretmen.Text = "Öğretmenler";
            this.tabPageOgretmen.UseVisualStyleBackColor = true;
            // 
            // tabPageDers
            // 
            this.tabPageDers.Controls.Add(this.groupBoxDersSilme);
            this.tabPageDers.Controls.Add(this.groupBoxDersGuncelleme);
            this.tabPageDers.Controls.Add(this.groupBoxEkleme);
            this.tabPageDers.Location = new System.Drawing.Point(4, 22);
            this.tabPageDers.Name = "tabPageDers";
            this.tabPageDers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDers.Size = new System.Drawing.Size(930, 353);
            this.tabPageDers.TabIndex = 0;
            this.tabPageDers.Text = "Ders İşlemleri";
            this.tabPageDers.UseVisualStyleBackColor = true;
            // 
            // groupBoxEkleme
            // 
            this.groupBoxEkleme.Controls.Add(this.buttonDersKaydet);
            this.groupBoxEkleme.Controls.Add(this.textBoxDEAd);
            this.groupBoxEkleme.Controls.Add(this.label1);
            this.groupBoxEkleme.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxEkleme.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEkleme.Name = "groupBoxEkleme";
            this.groupBoxEkleme.Size = new System.Drawing.Size(253, 347);
            this.groupBoxEkleme.TabIndex = 0;
            this.groupBoxEkleme.TabStop = false;
            this.groupBoxEkleme.Text = "Ekleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Adı";
            // 
            // textBoxDEAd
            // 
            this.textBoxDEAd.Location = new System.Drawing.Point(59, 22);
            this.textBoxDEAd.Name = "textBoxDEAd";
            this.textBoxDEAd.Size = new System.Drawing.Size(188, 20);
            this.textBoxDEAd.TabIndex = 1;
            // 
            // buttonDersKaydet
            // 
            this.buttonDersKaydet.Location = new System.Drawing.Point(172, 48);
            this.buttonDersKaydet.Name = "buttonDersKaydet";
            this.buttonDersKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonDersKaydet.TabIndex = 2;
            this.buttonDersKaydet.Text = "Ekle";
            this.buttonDersKaydet.UseVisualStyleBackColor = true;
            this.buttonDersKaydet.Click += new System.EventHandler(this.buttonDersKaydet_Click);
            // 
            // groupBoxDersGuncelleme
            // 
            this.groupBoxDersGuncelleme.Controls.Add(this.buttonDersGuncelle);
            this.groupBoxDersGuncelleme.Controls.Add(this.textBoxDersYeniAd);
            this.groupBoxDersGuncelleme.Controls.Add(this.label3);
            this.groupBoxDersGuncelleme.Controls.Add(this.buttonDersSecG);
            this.groupBoxDersGuncelleme.Controls.Add(this.comboBoxDersler);
            this.groupBoxDersGuncelleme.Controls.Add(this.label2);
            this.groupBoxDersGuncelleme.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxDersGuncelleme.Location = new System.Drawing.Point(256, 3);
            this.groupBoxDersGuncelleme.Name = "groupBoxDersGuncelleme";
            this.groupBoxDersGuncelleme.Size = new System.Drawing.Size(317, 347);
            this.groupBoxDersGuncelleme.TabIndex = 1;
            this.groupBoxDersGuncelleme.TabStop = false;
            this.groupBoxDersGuncelleme.Text = "Güncelleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ders Seçin";
            // 
            // comboBoxDersler
            // 
            this.comboBoxDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDersler.FormattingEnabled = true;
            this.comboBoxDersler.Location = new System.Drawing.Point(71, 22);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(226, 21);
            this.comboBoxDersler.TabIndex = 1;
            // 
            // buttonDersSecG
            // 
            this.buttonDersSecG.Location = new System.Drawing.Point(222, 49);
            this.buttonDersSecG.Name = "buttonDersSecG";
            this.buttonDersSecG.Size = new System.Drawing.Size(75, 23);
            this.buttonDersSecG.TabIndex = 2;
            this.buttonDersSecG.Text = "Seç";
            this.buttonDersSecG.UseVisualStyleBackColor = true;
            this.buttonDersSecG.Click += new System.EventHandler(this.buttonDersSecG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders Adı";
            // 
            // textBoxDersYeniAd
            // 
            this.textBoxDersYeniAd.Location = new System.Drawing.Point(59, 101);
            this.textBoxDersYeniAd.Name = "textBoxDersYeniAd";
            this.textBoxDersYeniAd.Size = new System.Drawing.Size(238, 20);
            this.textBoxDersYeniAd.TabIndex = 4;
            // 
            // buttonDersGuncelle
            // 
            this.buttonDersGuncelle.Location = new System.Drawing.Point(222, 127);
            this.buttonDersGuncelle.Name = "buttonDersGuncelle";
            this.buttonDersGuncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonDersGuncelle.TabIndex = 5;
            this.buttonDersGuncelle.Text = "Güncelle";
            this.buttonDersGuncelle.UseVisualStyleBackColor = true;
            this.buttonDersGuncelle.Click += new System.EventHandler(this.buttonDersGuncelle_Click);
            // 
            // groupBoxDersSilme
            // 
            this.groupBoxDersSilme.Controls.Add(this.buttonDersSil);
            this.groupBoxDersSilme.Controls.Add(this.comboBoxDerslerSilme);
            this.groupBoxDersSilme.Controls.Add(this.label4);
            this.groupBoxDersSilme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDersSilme.Location = new System.Drawing.Point(573, 3);
            this.groupBoxDersSilme.Name = "groupBoxDersSilme";
            this.groupBoxDersSilme.Size = new System.Drawing.Size(354, 347);
            this.groupBoxDersSilme.TabIndex = 2;
            this.groupBoxDersSilme.TabStop = false;
            this.groupBoxDersSilme.Text = "Silme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders Seçin";
            // 
            // comboBoxDerslerSilme
            // 
            this.comboBoxDerslerSilme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDerslerSilme.FormattingEnabled = true;
            this.comboBoxDerslerSilme.Location = new System.Drawing.Point(71, 22);
            this.comboBoxDerslerSilme.Name = "comboBoxDerslerSilme";
            this.comboBoxDerslerSilme.Size = new System.Drawing.Size(226, 21);
            this.comboBoxDerslerSilme.TabIndex = 4;
            // 
            // buttonDersSil
            // 
            this.buttonDersSil.Location = new System.Drawing.Point(222, 49);
            this.buttonDersSil.Name = "buttonDersSil";
            this.buttonDersSil.Size = new System.Drawing.Size(75, 23);
            this.buttonDersSil.TabIndex = 5;
            this.buttonDersSil.Text = "Sil";
            this.buttonDersSil.UseVisualStyleBackColor = true;
            this.buttonDersSil.Click += new System.EventHandler(this.buttonDersSil_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDers);
            this.tabControl1.Controls.Add(this.tabPageOgretmen);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // groupBoxOgretmenEkleme
            // 
            this.groupBoxOgretmenEkleme.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOgretmenEkleme.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOgretmenEkleme.Name = "groupBoxOgretmenEkleme";
            this.groupBoxOgretmenEkleme.Size = new System.Drawing.Size(326, 347);
            this.groupBoxOgretmenEkleme.TabIndex = 0;
            this.groupBoxOgretmenEkleme.TabStop = false;
            this.groupBoxOgretmenEkleme.Text = "Ekleme";
            // 
            // groupBoxOgretmenGuncelleme
            // 
            this.groupBoxOgretmenGuncelleme.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOgretmenGuncelleme.Location = new System.Drawing.Point(329, 3);
            this.groupBoxOgretmenGuncelleme.Name = "groupBoxOgretmenGuncelleme";
            this.groupBoxOgretmenGuncelleme.Size = new System.Drawing.Size(333, 347);
            this.groupBoxOgretmenGuncelleme.TabIndex = 1;
            this.groupBoxOgretmenGuncelleme.TabStop = false;
            this.groupBoxOgretmenGuncelleme.Text = "Güncelleme";
            // 
            // groupBoxOgretmenSilme
            // 
            this.groupBoxOgretmenSilme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOgretmenSilme.Location = new System.Drawing.Point(662, 3);
            this.groupBoxOgretmenSilme.Name = "groupBoxOgretmenSilme";
            this.groupBoxOgretmenSilme.Size = new System.Drawing.Size(265, 347);
            this.groupBoxOgretmenSilme.TabIndex = 2;
            this.groupBoxOgretmenSilme.TabStop = false;
            this.groupBoxOgretmenSilme.Text = "Silme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 703);
            this.Controls.Add(this.groupBoxOgretmenler);
            this.Controls.Add(this.groupBoxDersler);
            this.Controls.Add(this.panelIslemler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Veritabanı Çalışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelIslemler.ResumeLayout(false);
            this.groupBoxDersler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).EndInit();
            this.groupBoxOgretmenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgretmenler)).EndInit();
            this.tabPageOgretmen.ResumeLayout(false);
            this.tabPageDers.ResumeLayout(false);
            this.groupBoxEkleme.ResumeLayout(false);
            this.groupBoxEkleme.PerformLayout();
            this.groupBoxDersGuncelleme.ResumeLayout(false);
            this.groupBoxDersGuncelleme.PerformLayout();
            this.groupBoxDersSilme.ResumeLayout(false);
            this.groupBoxDersSilme.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.GroupBox groupBoxDersler;
        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.GroupBox groupBoxOgretmenler;
        private System.Windows.Forms.DataGridView dataGridViewOgretmenler;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn OId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODersAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTarih;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDers;
        private System.Windows.Forms.GroupBox groupBoxDersSilme;
        private System.Windows.Forms.Button buttonDersSil;
        private System.Windows.Forms.ComboBox comboBoxDerslerSilme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxDersGuncelleme;
        private System.Windows.Forms.Button buttonDersGuncelle;
        private System.Windows.Forms.TextBox textBoxDersYeniAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDersSecG;
        private System.Windows.Forms.ComboBox comboBoxDersler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxEkleme;
        private System.Windows.Forms.Button buttonDersKaydet;
        private System.Windows.Forms.TextBox textBoxDEAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageOgretmen;
        private System.Windows.Forms.GroupBox groupBoxOgretmenSilme;
        private System.Windows.Forms.GroupBox groupBoxOgretmenGuncelleme;
        private System.Windows.Forms.GroupBox groupBoxOgretmenEkleme;
    }
}

