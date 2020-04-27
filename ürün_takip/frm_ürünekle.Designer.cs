namespace ürün_takip
{
    partial class frm_ürünekle
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
            this.btn_kapat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_satis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ürün = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_alis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kapat.Location = new System.Drawing.Point(376, 23);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(89, 21);
            this.btn_kapat.TabIndex = 10;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "ÜRÜN EKLEME PANELİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txt_satis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_ürün);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_alis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.txt_stok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 129);
            this.panel1.TabIndex = 8;
            // 
            // txt_satis
            // 
            this.txt_satis.Location = new System.Drawing.Point(329, 41);
            this.txt_satis.Name = "txt_satis";
            this.txt_satis.Size = new System.Drawing.Size(100, 20);
            this.txt_satis.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(220, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Satış Fiyatı : ";
            // 
            // txt_ürün
            // 
            this.txt_ürün.Location = new System.Drawing.Point(101, 12);
            this.txt_ürün.Name = "txt_ürün";
            this.txt_ürün.Size = new System.Drawing.Size(100, 20);
            this.txt_ürün.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı :";
            // 
            // txt_alis
            // 
            this.txt_alis.Location = new System.Drawing.Point(329, 12);
            this.txt_alis.Name = "txt_alis";
            this.txt_alis.Size = new System.Drawing.Size(100, 20);
            this.txt_alis.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(235, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alış Fiyatı :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Location = new System.Drawing.Point(125, 78);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(185, 39);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(101, 38);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(100, 20);
            this.txt_stok.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stok :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 157);
            this.dataGridView1.TabIndex = 7;
            // 
            // frm_ürünekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(503, 384);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ürünekle";
            this.Text = "frm_ürünekle";
            this.Load += new System.EventHandler(this.frm_ürünekle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ürün;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_satis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_alis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Label label2;
    }
}