using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormEntegTanımla : Form
    {
        public FormEntegTanımla()
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
        private void FormEntegTanımla_Load(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();


            SqlDataAdapter da4 = new SqlDataAdapter("Select chz_id,chz_demirbasno from tblcihaz", baglanti);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            lookUpEdit3.Properties.ValueMember = "chz_demirbasno";
            lookUpEdit3.Properties.DisplayMember = "chz_id";
            lookUpEdit3.Properties.DataSource = dt4;

            SqlDataAdapter da3 = new SqlDataAdapter("Select per_id,per_ad,per_soyad from tblpersonel", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            lookUpEdit1.Properties.ValueMember = ("per_soyad");
            lookUpEdit1.Properties.DisplayMember = "per_id";
            lookUpEdit1.Properties.DataSource = dt3;

            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblenttip", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            lookUpEdit2.Properties.ValueMember = "chz_enttipad";
            lookUpEdit2.Properties.DisplayMember = "chz_entipid";
            lookUpEdit2.Properties.DataSource = dt2;


            SqlDataAdapter da44 = new SqlDataAdapter("select chz_enttipad from tblenttip", baglanti);
            DataTable dt44 = new DataTable();
            da44.Fill(dt44);
            gridControl3.DataSource = dt44;



            //SqlDataAdapter da6 = new SqlDataAdapter("Select  ent_islemid as 'Entegrasyon ID', chz_enttipad as 'İşlem Tipi', tblcihaztip.chz_tipad as 'Cihaz Tip', per_adsoyad as 'İşlem Yapılan Personel',per_departad as 'İşlem Departman', ent_islemtarihi as 'İşlem Tarihi',  tblcihaz.chz_id as 'Cihaz ID', tblcihaz.chz_demirbasno as 'Cihaz Demirbas', tbldepartman.dep_ad as 'Cihaz AnaDepartman' from tblcihaz inner join tblcihaztip on tblcihaz.chz_tip = tblcihaztip.chz_tipid inner join tblentegrasyon ON tblcihaz.chz_id=tblentegrasyon.ent_cihazid inner join tbldepartman ON tblcihaz.chz_anadepartman = tbldepartman.dep_id inner join tblpersonel ON tblentegrasyon.ent_personelid=tblpersonel.per_id inner join tblaltdepart ON tblpersonel.per_departman=tblaltdepart.per_departid inner join tblenttip ON tblentegrasyon.ent_islemtipi=tblenttip.chz_entipid  ", baglanti);
            //DataTable dt6 = new DataTable();
            //da6.Fill(dt6);
            //gridControl1.DataSource = dt6;

            SqlDataAdapter da = new SqlDataAdapter("select * from tblentegrasyon", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tblentegrasyon(ent_cihazid,ent_personelid,ent_islemtipi,ent_islemtarihi,ent_aciklama) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut2.Parameters.AddWithValue("@p1", lookUpEdit3.Text);
            komut2.Parameters.AddWithValue("@p2", lookUpEdit1.Text);
            komut2.Parameters.AddWithValue("@p3", lookUpEdit2.Text);
            komut2.Parameters.AddWithValue("@p4", DateTime.Parse(dateTimePicker1.Text));
            komut2.Parameters.AddWithValue("@p5", richTextBox1.Text);

            komut2.ExecuteNonQuery();

            metot();


            SqlDataAdapter da = new SqlDataAdapter("select * from tblentegrasyon", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btntipekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tblenttip (chz_enttipad) values (@p1)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txttip.Text);

            komut2.ExecuteNonQuery();

            SqlDataAdapter da44 = new SqlDataAdapter("select * from tblenttip", baglanti);
            DataTable dt44 = new DataTable();
            da44.Fill(dt44);
            gridControl3.DataSource = dt44;


            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblenttip", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            lookUpEdit2.Properties.ValueMember = "chz_enttipad";
            lookUpEdit2.Properties.DisplayMember = "chz_entipid";
            lookUpEdit2.Properties.DataSource = dt2;
        }
    }
}
