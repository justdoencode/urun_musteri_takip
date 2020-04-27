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
    public partial class frm_ürünekle : Form
    {
        public frm_ürünekle()
        {
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_ürüntakip;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ürünler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_ürünekle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_ürünler (ürün_ad,ürün_stok,ürün_alisfiyat,ürün_satisfiyat) values (@ad,@stok,@alis,@satis)", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_ürün.Text);
            cmd.Parameters.AddWithValue("@stok", txt_stok.Text);
            cmd.Parameters.AddWithValue("@alis", txt_alis.Text);
            cmd.Parameters.AddWithValue("@satis", txt_satis.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }
    }
}
