namespace ürün_takip
{
    partial class frm_kayitlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_müsteri = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_satici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ürün = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_saticiekle = new System.Windows.Forms.Button();
            this.btn_urunekle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_müsteriekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri :";
            // 
            // cmb_müsteri
            // 
            this.cmb_müsteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_müsteri.FormattingEnabled = true;
            this.cmb_müsteri.Location = new System.Drawing.Point(110, 56);
            this.cmb_müsteri.Name = "cmb_müsteri";
            this.cmb_müsteri.Size = new System.Drawing.Size(121, 21);
            this.cmb_müsteri.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.txt_fiyat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_satici);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_ürün);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_müsteri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(409, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 218);
            this.panel1.TabIndex = 2;
            // 
            // btn_ekle
            // 
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Location = new System.Drawing.Point(110, 181);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(121, 23);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "HAREKET EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(110, 137);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(121, 20);
            this.txt_fiyat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ALIŞVERİŞ KAYDI EKLE";
            // 
            // cmb_satici
            // 
            this.cmb_satici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_satici.FormattingEnabled = true;
            this.cmb_satici.Location = new System.Drawing.Point(110, 110);
            this.cmb_satici.Name = "cmb_satici";
            this.cmb_satici.Size = new System.Drawing.Size(121, 21);
            this.cmb_satici.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satıcı :";
            // 
            // cmb_ürün
            // 
            this.cmb_ürün.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ürün.FormattingEnabled = true;
            this.cmb_ürün.Location = new System.Drawing.Point(110, 83);
            this.cmb_ürün.Name = "cmb_ürün";
            this.cmb_ürün.Size = new System.Drawing.Size(121, 21);
            this.cmb_ürün.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "ALIŞVERİŞ KAYITLARI";
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kapat.Location = new System.Drawing.Point(626, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(75, 23);
            this.btn_kapat.TabIndex = 6;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_müsteriekle);
            this.panel2.Controls.Add(this.btn_urunekle);
            this.panel2.Controls.Add(this.btn_saticiekle);
            this.panel2.Location = new System.Drawing.Point(409, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 77);
            this.panel2.TabIndex = 7;
            // 
            // btn_saticiekle
            // 
            this.btn_saticiekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saticiekle.Location = new System.Drawing.Point(8, 13);
            this.btn_saticiekle.Name = "btn_saticiekle";
            this.btn_saticiekle.Size = new System.Drawing.Size(121, 23);
            this.btn_saticiekle.TabIndex = 9;
            this.btn_saticiekle.Text = "Satıcı Ekle";
            this.btn_saticiekle.UseVisualStyleBackColor = true;
            this.btn_saticiekle.Click += new System.EventHandler(this.btn_saticiekle_Click);
            // 
            // btn_urunekle
            // 
            this.btn_urunekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urunekle.Location = new System.Drawing.Point(135, 13);
            this.btn_urunekle.Name = "btn_urunekle";
            this.btn_urunekle.Size = new System.Drawing.Size(121, 23);
            this.btn_urunekle.TabIndex = 10;
            this.btn_urunekle.Text = "Ürün Ekle";
            this.btn_urunekle.UseVisualStyleBackColor = true;
            this.btn_urunekle.Click += new System.EventHandler(this.btn_urunekle_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(135, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "BOŞ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_müsteriekle
            // 
            this.btn_müsteriekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_müsteriekle.Location = new System.Drawing.Point(8, 42);
            this.btn_müsteriekle.Name = "btn_müsteriekle";
            this.btn_müsteriekle.Size = new System.Drawing.Size(121, 23);
            this.btn_müsteriekle.TabIndex = 11;
            this.btn_müsteriekle.Text = "Müşteri Ekle";
            this.btn_müsteriekle.UseVisualStyleBackColor = true;
            this.btn_müsteriekle.Click += new System.EventHandler(this.btn_müsteriekle_Click);
            // 
            // frm_kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(713, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_kayitlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_müsteri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_satici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ürün;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_müsteriekle;
        private System.Windows.Forms.Button btn_urunekle;
        private System.Windows.Forms.Button btn_saticiekle;
    }
}

