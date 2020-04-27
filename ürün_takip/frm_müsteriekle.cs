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
    public partial class frm_müsteriekle : Form
    {
        public frm_müsteriekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_ürüntakip;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_müsteriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frm_müsteriekle_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("insert into tbl_müsteriler (müsteri_adsoyad) values (@ad)", baglanti);
            cmd.Parameters.AddWithValue("@ad", txt_müsteriad.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Müşteri Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            baglanti.Close();
        }
    }
}
