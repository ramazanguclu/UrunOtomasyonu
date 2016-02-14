namespace UrunlerOtomasyonu
{
    partial class Profil
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnurunsil = new System.Windows.Forms.Button();
            this.btnyeniurun = new System.Windows.Forms.Button();
            this.btnresimdeg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnurunguncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(157, 20);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 0;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(157, 60);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(100, 20);
            this.txtaciklama.TabIndex = 1;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(157, 98);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 2;
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(157, 136);
            this.txttarih.Name = "txttarih";
            this.txttarih.ReadOnly = true;
            this.txttarih.Size = new System.Drawing.Size(100, 20);
            this.txttarih.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 248);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnurunsil
            // 
            this.btnurunsil.Location = new System.Drawing.Point(419, 7);
            this.btnurunsil.Name = "btnurunsil";
            this.btnurunsil.Size = new System.Drawing.Size(75, 61);
            this.btnurunsil.TabIndex = 6;
            this.btnurunsil.Text = "ÜRÜN SİL";
            this.btnurunsil.UseVisualStyleBackColor = true;
            this.btnurunsil.Click += new System.EventHandler(this.btnurunsil_Click);
            // 
            // btnyeniurun
            // 
            this.btnyeniurun.Location = new System.Drawing.Point(459, 92);
            this.btnyeniurun.Name = "btnyeniurun";
            this.btnyeniurun.Size = new System.Drawing.Size(75, 67);
            this.btnyeniurun.TabIndex = 7;
            this.btnyeniurun.Text = "YENİ ÜRÜN";
            this.btnyeniurun.UseVisualStyleBackColor = true;
            this.btnyeniurun.Click += new System.EventHandler(this.btnyeniurun_Click);
            // 
            // btnresimdeg
            // 
            this.btnresimdeg.Location = new System.Drawing.Point(275, 165);
            this.btnresimdeg.Name = "btnresimdeg";
            this.btnresimdeg.Size = new System.Drawing.Size(126, 23);
            this.btnresimdeg.TabIndex = 8;
            this.btnresimdeg.Text = "RESİM DEĞİŞTİR";
            this.btnresimdeg.UseVisualStyleBackColor = true;
            this.btnresimdeg.Click += new System.EventHandler(this.btnresimdeg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnurunguncelle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnyeniurun);
            this.groupBox1.Controls.Add(this.btnresimdeg);
            this.groupBox1.Controls.Add(this.btnurunsil);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtaciklama);
            this.groupBox1.Controls.Add(this.txtfiyat);
            this.groupBox1.Controls.Add(this.txttarih);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 200);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btnurunguncelle
            // 
            this.btnurunguncelle.Location = new System.Drawing.Point(500, 9);
            this.btnurunguncelle.Name = "btnurunguncelle";
            this.btnurunguncelle.Size = new System.Drawing.Size(75, 61);
            this.btnurunguncelle.TabIndex = 13;
            this.btnurunguncelle.Text = "GÜNCELLE";
            this.btnurunguncelle.UseVisualStyleBackColor = true;
            this.btnurunguncelle.Click += new System.EventHandler(this.btnurunguncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Eklenme Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Adı";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 496);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnurunsil;
        private System.Windows.Forms.Button btnyeniurun;
        private System.Windows.Forms.Button btnresimdeg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnurunguncelle;
    }
}