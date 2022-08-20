using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormPersonelTanımlama : Form
    {
        public FormPersonelTanımlama()
        {
            InitializeComponent();
        }
        string baglantiadresi;
        string baglantiadresi2;
        void metot()
        {
            StreamReader oku = new StreamReader(".\\DATABASE.INI");
            string satir = oku.ReadLine();
            while (satir != null)
            {
                baglantiadresi2 = satir;
                satir = oku.ReadLine();
            }
        }

        void metot2()
        {
            StreamReader oku = new StreamReader(".\\DATABASE2.INI");
            string satir = oku.ReadLine();
            while (satir != null)
            {
                baglantiadresi = satir;
                satir = oku.ReadLine();
            }
        }
        private void FormPersonelTanımlama_Load(object sender, EventArgs e)
        {
            metot2();
            SqlConnection baglanti2 = new SqlConnection(baglantiadresi);
            baglanti2.Open();

            SqlDataAdapter da = new SqlDataAdapter("select per_adi,per_soyadi,per_sicil_no,per_tel_cepno, per_tip, per_bolum_kodu from PERSONELLER", baglanti2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi2);
            baglanti.Open();
            SqlDataAdapter da6 = new SqlDataAdapter("select * from tblaltdepart", baglanti);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            lookUpEdit2.Properties.ValueMember = "per_departid";
            lookUpEdit2.Properties.DisplayMember = "per_departad";
            lookUpEdit2.Properties.DataSource = dt6;


            SqlDataAdapter da7 = new SqlDataAdapter("select per_ad as'Personel Adı',per_soyad as 'Personel Soyadı',per_departman as 'Personel Departman',per_mail as 'Personel Mail',per_tel as 'Personel Telefon', per_sicilno as 'Personel Sicil Numarası' from tblpersonel", baglanti);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            gridControl1.DataSource = dt7;

            txtmail.Text = "@novaplastik.com";
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtad.Text = gridView2.GetFocusedRowCellValue("per_adi").ToString();
                txtsoyad.Text = gridView2.GetFocusedRowCellValue("per_soyadi").ToString();
                txtsicilno.Text = gridView2.GetFocusedRowCellValue("per_sicil_no").ToString();
                txttelefon.Text = gridView2.GetFocusedRowCellValue("per_tel_cepno").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Dönebilir");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi2);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tblpersonel(per_ad,per_soyad,per_mail,per_tel,per_departman,per_sicilno) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", txtmail.Text);
            komut2.Parameters.AddWithValue("@p4", txttelefon.Text);
            komut2.Parameters.AddWithValue("@p5", lookUpEdit2.Text);
            komut2.Parameters.AddWithValue("@p6", txtsicilno.Text);
            komut2.ExecuteNonQuery();

            SqlDataAdapter da7 = new SqlDataAdapter("select per_ad as'Personel Adı',per_soyad as 'Personel Soyadı',per_departman as 'Personel Departman',per_mail as 'Personel Mail',per_tel as 'Personel Telefon', per_sicilno as 'Personel Sicil Numarası' from tblpersonel", baglanti);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            gridControl1.DataSource = dt7;
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
