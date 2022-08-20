using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormAnaEntegrasyon : Form
    {
        public FormAnaEntegrasyon()
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
        private void FormAnaEntegrasyon_Load(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select  ent_islemid as 'Entegrasyon ID', chz_enttipad as ' İşlem Tipi ', chz_tip as ' İşlem Cihaz Tipi', per_ad as 'Personel Ad',per_soyad as 'Personel Soyad',per_departman as 'İşlem Departmanı',ent_islemtarihi as ' İşlem Tarihi',chz_demirbasno,chz_anadepartman as 'Cihaz Ana Departman' from tblcihaz inner join tblentegrasyon ON tblcihaz.chz_id=tblentegrasyon.ent_cihazid inner join tblenttip ON tblentegrasyon.ent_islemtipi=tblenttip.chz_entipid inner join tblpersonel ON tblentegrasyon.ent_personelid=tblpersonel.per_id", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


            SqlCommand komut7 = new SqlCommand("Select count (*) From tblcihaz where chz_tip='Laptop'", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lbllaptop.Text = "  Laptop  " + dr7[0] .ToString();

            }
            baglanti.Close();
            baglanti.Open();

            //MONITOR İSTATİSTİK
            SqlCommand komut6 = new SqlCommand("Select count (*) From tblcihaz where chz_tip='Monitör'", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblmonitor.Text = "  Monitör  " + dr6[0].ToString();

            }

            baglanti.Close();
            baglanti.Open();

            //MASAUSTU İSTATİSTİK
            SqlCommand komut5 = new SqlCommand("Select count (*) From tblcihaz where chz_tip='Masaüstü'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblmasaustu.Text = "  Masaüstü  " + dr5[0].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            //YZICI İSTATİSTİK
            SqlCommand komut4 = new SqlCommand("Select count (*) From tblcihaz where chz_tip='Yazıcı'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblyazıcı.Text = "  Yazıcı  " + dr4[0].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            //GUC İSTATİSTİK
            SqlCommand komut8 = new SqlCommand("Select count (*) From tblcihaz where chz_tip='Güç Kaynağı'", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblguc.Text = "  Güç Kaynağı  " + dr8[0].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            //YZICI İSTATİSTİK
            SqlCommand komut9 = new SqlCommand("Select count (*) From tblcihaz where chz_tip='Veri Terminali'", baglanti);
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lblveri.Text = "Sistemdeki:  Veri Terminali   3" + dr9[0].ToString();

            }

        }

        private void cihazTeknikÖzellikToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormTeknikGörüntüle fc = new FormTeknikGörüntüle();






            fc.yazı = label1.Text;

            fc.Show();

            //FormCihazTeknik fct = new FormCihazTeknik();
            //fct.Show();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
     

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            label1.Text = gridView1.GetFocusedRowCellValue("chz_demirbasno").ToString();
          
            

            ////DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            ////if (dr != null)
            ////{
            ////    chz_demirbasno = dr[8].ToString();

            ////}
            ////if (chz_demirbasno == label1.Text)
            ////{
            ////    cihazTeknikÖzellikToolStripMenuItem.Visible = true;
            ////    cihazTeknikÖzellikToolStripMenuItem.Visible = true;
            ////}
            ////else
            ////{
            ////    FormCihazTeknik fct = new FormCihazTeknik();
            ////    fct.Show();

                //    cihazTeknikÖzellikToolStripMenuItem.Visible = true;
                //    cihazTeknikÖzellikToolStripMenuItem.Visible = true;

                //}
                //DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                //if (dr != null)
                //{
                //    chz_demirbasno = dr[8].ToString();

                //}
                //if (chz_demirbasno == "@p1")
                //{
                //    cihazTeknikÖzellikToolStripMenuItem.Visible = false;
                //    cihazTeknikÖzellikToolStripMenuItem.Visible = true;
                //}
                //else
                //{
                //    cihazTeknikÖzellikToolStripMenuItem.Visible = true;
                //    cihazTeknikÖzellikToolStripMenuItem.Visible = true;

                //}


            }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormCihazTeknikPencresi fc = new FormCihazTeknikPencresi();






            //fc.yazı = label1.Text;

            //fc.Show();
        }
    }
}
