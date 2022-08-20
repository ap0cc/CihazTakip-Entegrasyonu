using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormCihazTeknik : Form
    {
        public FormCihazTeknik()
        {
            InitializeComponent();
        }
        public string yazı;

        string baglantiadresi;
        void metot()
        {
            StreamReader oku = new StreamReader(".\\DATABASE.INI");
            string satir = oku.ReadLine();
            while (satir != null)
            {
                baglantiadresi = satir;
                satir = oku.ReadLine();
            }
        }

        void metot2()
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
        }
        private void FormCihazTeknik_Load(object sender, EventArgs e)
        {
            metot();

            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            


            comboid.Text = yazı;


            SqlDataAdapter da = new SqlDataAdapter("select chz_otip as 'Özellik Tipi', chz_otipaciklama as 'Özellik Açıklama', chz_odemirbasno from tblcihazozellik", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            SqlCommand komut = new SqlCommand("Select chz_demirbasno, chz_anadepartman, chz_tip From tblcihaz where chz_id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtdemirbas.Text = dr[0].ToString();
                txtdepartman.Text = dr[1].ToString();
                txtcihaztip.Text = dr[2].ToString();

            }
            baglanti.Close();

            SqlDataAdapter da3 = new SqlDataAdapter("Select chz_boxid,chz_boxisim from tbl_boxozellik", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            lookUpEdit1.Properties.ValueMember = "chz_boxid";
            lookUpEdit1.Properties.DisplayMember = "chz_boxisim";
            lookUpEdit1.Properties.DataSource = dt3;

            SqlDataAdapter da4 = new SqlDataAdapter("Select chz_demirbasno from tblcihaz", baglanti);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            lookUpEdit2.Properties.ValueMember = "chz_demirbasno";
            lookUpEdit2.Properties.DisplayMember = "chz_demirbasno";
            lookUpEdit2.Properties.DataSource = dt4;

            SqlDataAdapter da44 = new SqlDataAdapter("select * from tbl_boxozellik", baglanti);
            DataTable dt44 = new DataTable();
            da44.Fill(dt44);
            gridControl3.DataSource = dt44;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tblcihazozellik(chz_otip,chz_otipaciklama,chz_odemirbasno,chz_oanadepart,chz_oid,chz_ozekayit) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut2.Parameters.AddWithValue("@p1", lookUpEdit1.Text);
            komut2.Parameters.AddWithValue("@p2", richTextBox1.Text);
            komut2.Parameters.AddWithValue("@p3", txtdemirbas.Text);
            komut2.Parameters.AddWithValue("@p4", txtdepartman.Text);
            komut2.Parameters.AddWithValue("@p5", comboid.Text);
            komut2.Parameters.AddWithValue("@p6", DateTime.Parse(dateTimePicker1.Text));
            komut2.ExecuteNonQuery();




            SqlDataAdapter da = new SqlDataAdapter("select chz_otip as 'Özellik Tipi', chz_otipaciklama as 'Özellik Açıklama', chz_odemirbasno from tblcihazozellik", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select chz_id,chz_tip,chz_anadepartman,chz_demirbasno from tblcihaz where chz_demirbasno=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", lookUpEdit2.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboid.Text = dr[0].ToString();
                txtcihaztip.Text = dr[1].ToString();
                txtdepartman.Text = dr[2].ToString();
                txtdemirbas.Text = dr[3].ToString();

            }
            baglanti.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_boxozellik (chz_boxisim) values (@p1)", baglanti);
            komut2.Parameters.AddWithValue("@p1", textBox4.Text);

            komut2.ExecuteNonQuery();

            SqlDataAdapter da44 = new SqlDataAdapter("select * from tbl_boxozellik", baglanti);
            DataTable dt44 = new DataTable();
            da44.Fill(dt44);
            gridControl3.DataSource = dt44;

            SqlDataAdapter da3 = new SqlDataAdapter("Select chz_boxid,chz_boxisim from tbl_boxozellik", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            lookUpEdit1.Properties.ValueMember = "chz_boxid";
            lookUpEdit1.Properties.DisplayMember = "chz_boxisim";
            lookUpEdit1.Properties.DataSource = dt3;

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
