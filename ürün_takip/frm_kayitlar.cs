using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ürün_takip
{
    public partial class frm_kayitlar : Form
    {
        public frm_kayitlar()
        {
            InitializeComponent();
        }
        void hareketler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute hareketler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_ürüntakip;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            hareketler();
            SqlDataAdapter da2 = new SqlDataAdapter("select* from tbl_müsteriler", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmb_müsteri.DataSource = dt2;
            cmb_müsteri.DisplayMember = "müsteri_adsoyad";
            cmb_müsteri.ValueMember = "müsteri_id";

            SqlDataAdapter da3 = new SqlDataAdapter("select * from tbl_ürünler", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmb_ürün.DataSource = dt3;
            cmb_ürün.DisplayMember = "ürün_ad";
            cmb_ürün.ValueMember = "ürün_id";

            SqlDataAdapter da4 = new SqlDataAdapter("select* from tbl_saticilar",baglanti);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            cmb_satici.DataSource = dt4;
            cmb_satici.DisplayMember = "satici_ad";
            cmb_satici.ValueMember = "satici_id";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_hareketler (ürün,müsteri,satici,fiyat) values (@ürün,@müsteri,@satici,@fiyat)", baglanti);
            cmd.Parameters.AddWithValue("@ürün", cmb_ürün.SelectedValue);
            cmd.Parameters.AddWithValue("@müsteri", cmb_müsteri.SelectedValue);
            cmd.Parameters.AddWithValue("@satici", cmb_satici.SelectedValue);
            cmd.Parameters.AddWithValue("@fiyat", txt_fiyat.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("İşlem Kaydı Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            hareketler();
            baglanti.Close();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_saticiekle_Click(object sender, EventArgs e)
        {
            frm_saticiekle frmsaticiekle = new frm_saticiekle();
            frmsaticiekle.Show();
        }

        private void btn_urunekle_Click(object sender, EventArgs e)
        {
            frm_ürünekle frmürünekle = new frm_ürünekle();
            frmürünekle.Show();
        }

        private void btn_müsteriekle_Click(object sender, EventArgs e)
        {
            frm_müsteriekle frmmüsteriekle = new frm_müsteriekle();
            frmmüsteriekle.Show();
        }
    }
}
