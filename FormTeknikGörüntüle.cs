using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormTeknikGörüntüle : Form
    {
        public FormTeknikGörüntüle()
        {
            InitializeComponent();
        }
        string baglantiadresi;
        public string yazı;
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
        private void FormCihazTeknikPencresi_Load(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            label1.Text = yazı;
  

            SqlCommand komut = new SqlCommand("select chz_otip as 'Cihaz Özellik',chz_otipaciklama as 'Özellik Açıklama'from tblcihazozellik where chz_odemirbasno = @P1", baglanti);
            komut.Parameters.AddWithValue("@P1", label1.Text);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            komut.ExecuteNonQuery();









            //SqlCommand komut3 = new SqlCommand("select chz_id from tblcihaz where chz_demirbasno = @p1", baglanti);
            //komut3.Parameters.AddWithValue("@p1", label1.Text);
            //SqlDataReader dr3 = komut3.ExecuteReader();
            //while (dr3.Read())
            //{
            //    gridView1 = dr3[0].ToString();
            //}
            //baglanti.Close();


        }
    }
}
