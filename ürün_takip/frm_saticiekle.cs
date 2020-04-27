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
    public partial class frm_saticiekle : Form
    {
        public frm_saticiekle()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select* from tbl_saticilar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_ürüntakip;Integrated Security=True");
        private void frm_saticiekle_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_saticilar (satici_ad) values (@ad)", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_saticiad.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Satıcı Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            baglanti.Close();
        }
    }
}
