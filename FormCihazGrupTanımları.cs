using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormCihazGrupTanımları : Form
    {
        public FormCihazGrupTanımları()
        {
            InitializeComponent();
        }
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
        private void FormCihazGrupTanımları_Load(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select chz_altgrupad,chz_baglıanagrup from chz_altgrup", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            SqlDataAdapter da2 = new SqlDataAdapter("select * from chz_anagrup", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            SqlDataAdapter da3 = new SqlDataAdapter("select * from tbldepartman", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            gridControl3.DataSource = dt3;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
