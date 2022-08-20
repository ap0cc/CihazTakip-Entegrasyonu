using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormSistemOdası : Form
    {
        public FormSistemOdası()
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
        private void FormSistemOdası_Load(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select it_chztip,it_chzdemirbas,it_chzaciklama from tbl_itlistesi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


            SqlDataAdapter da2 = new SqlDataAdapter("select chz_id as 'Cihaz ID', chz_anagrup as 'Cihaz Ana Grup', chz_altgrup as 'Cihaz Alt Grup', chz_tip as 'Cihaz Tipi', chz_anadepartman as 'Cihaz Ana Departman',chz_demirbasno as 'Cihaz Demirbas No', chz_kayittarih as 'Cihaz Kayıt Tarihi'  from tblcihaz", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txttip.Text = gridView2.GetFocusedRowCellValue("Cihaz Tipi").ToString();

            txtdemirbas.Text = gridView2.GetFocusedRowCellValue("Cihaz Demirbas No").ToString();
        }

        private void btntipekle_Click(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_itlistesi(it_chztip,it_chzdemirbas,it_chzaciklama) values (@p1,@p2,@p3)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txttip.Text);
            komut2.Parameters.AddWithValue("@p2", txtdemirbas.Text);
            komut2.Parameters.AddWithValue("@p3", richTextBox1.Text);

            komut2.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("select it_chztip 'Cihaz Tipi',it_chzdemirbas 'Demirbaas Numarası',it_chzaciklama 'Durum Açıklaması' from tbl_itlistesi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from tbl_itlistesi where it_chzdemirbas=@s1", baglanti);
            komut3.Parameters.AddWithValue("@s1", txtdemir.Text);
            komut3.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter("select it_chztip as 'Cihaz Tip',it_chzdemirbas as 'Demirbas Numarası',it_chzaciklama as 'Cihaz Durum Açıklaması' from tbl_itlistesi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtdemir.Text = gridView1.GetFocusedRowCellValue("it_chzdemirbas").ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün Silindi");
            }
        }

        private void cihazTeknikBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormTeknikGörüntüle fc = new FormTeknikGörüntüle();






            fc.yazı = txtdemir.Text;

            fc.Show();
        }
    }
}
