namespace ürün_takip
{
    partial class frm_saticiekle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_saticiad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txt_saticiad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 157);
            this.panel1.TabIndex = 1;
            // 
            // txt_saticiad
            // 
            this.txt_saticiad.Location = new System.Drawing.Point(103, 53);
            this.txt_saticiad.Name = "txt_saticiad";
            this.txt_saticiad.Size = new System.Drawing.Size(100, 20);
            this.txt_saticiad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satıcı Adı :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Location = new System.Drawing.Point(103, 93);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 29);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "SATICI EKLEME PANELİ";
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kapat.Location = new System.Drawing.Point(415, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(89, 21);
            this.btn_kapat.TabIndex = 6;
            this.btn_kapat.Text = "KAPAT";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // frm_saticiekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 265);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_saticiekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_saticiekle";
            this.Load += new System.EventHandler(this.frm_saticiekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_saticiad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_kapat;
    }
}