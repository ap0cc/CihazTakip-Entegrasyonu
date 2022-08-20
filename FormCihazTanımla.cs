using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Cihaz_Enteg_Programı
{
    public partial class FormCihazTanımla : Form
    {
        public FormCihazTanımla()
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
        void metot2()
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
        }

        private void FormCihazTanımla_Load(object sender, EventArgs e)
        {
            metot();
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select chz_id as 'Cihaz ID', chz_anagrup as 'Cihaz Ana Grup', chz_altgrup as 'Cihaz Alt Grup', chz_tip as 'Cihaz Tipi', chz_anadepartman as 'Cihaz Ana Departman',chz_demirbasno as 'Cihaz Demirbas No', chz_kayittarih as 'Cihaz Kayıt Tarihi'  from tblcihaz", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

      



            SqlDataAdapter da44 = new SqlDataAdapter("select chz_tipad from tblcihaztip", baglanti);
            DataTable dt44 = new DataTable();
            da44.Fill(dt44);
            gridControl3.DataSource = dt44;





            //SqlDataAdapter da3 = new SqlDataAdapter("Select chz_tipad,chz_tipid from tblcihaztip", baglanti);
            //DataTable dt3 = new DataTable();
            //da3.Fill(dt3);
            //lookUpEdit1.Properties.ValueMember = "chz_tipid";
            //lookUpEdit1.Properties.DisplayMember = "chz_tipad";
            //lookUpEdit1.Properties.DataSource = dt3;



            SqlDataAdapter da4 = new SqlDataAdapter("Select dep_id,dep_ad from tbldepartman", baglanti);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            lookUpEdit2.Properties.ValueMember = "dep_id";
            lookUpEdit2.Properties.DisplayMember = "dep_ad";
            lookUpEdit2.Properties.DataSource = dt4;


            SqlDataAdapter da6 = new SqlDataAdapter("select * from chz_anagrup", baglanti);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            lookUpEdit3.Properties.ValueMember = "chz_anagrupid";
            lookUpEdit3.Properties.DisplayMember = "chz_anagrupad";
            lookUpEdit3.Properties.DataSource = dt6;

            //SqlDataAdapter da5 = new SqlDataAdapter("select chz_altgrupad,chz_baglıanagrup from chz_altgrup", baglanti);
            //DataTable dt5 = new DataTable();
            //da5.Fill(dt5);
            //lookUpEdit4.Properties.ValueMember = "chz_altgrupad";
            //lookUpEdit4.Properties.DisplayMember = "chz_altgrupad";
            //lookUpEdit4.Properties.DataSource = dt5;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(baglantiadresi);
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("insert into tblcihaz(chz_tip,chz_kayittarih,chz_anadepartman,chz_demirbasno, chz_anagrup, chz_altgrup) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut2.Parameters.AddWithValue("@p1", lookUpEdit1.Text);
                komut2.Parameters.AddWithValue("@p2", DateTime.Parse(dateTimePicker1.Text));
                if (textBox1.Text == textBox2.Text)
                {
                    MessageBox.Show("Bu Demirbas Numaralı Cihaz Zaten Sistemde Kayıtlı");
                }
                else
                {
                    komut2.Parameters.AddWithValue("@p4", textBox1.Text);
                }
                komut2.Parameters.AddWithValue("@p3", lookUpEdit2.Text);

                komut2.Parameters.AddWithValue("@p5", lookUpEdit3.Text);
                komut2.Parameters.AddWithValue("@p6", lookUpEdit4.Text);
                komut2.ExecuteNonQuery();

            }
            catch (Exception)
            {
                MessageBox.Show("Demirbas Numarasını 1 Arttırın Veya Değiştirin.");
                textBox1.Text = "INVALID REGISTRATION";

            }


            SqlConnection baglanti2 = new SqlConnection(baglantiadresi);
            baglanti2.Open();
            SqlCommand komut3 = new SqlCommand("select chz_id from tblcihaz where chz_demirbasno = @p1", baglanti2);
            komut3.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblcihazid.Text = dr3[0].ToString();
            }
            baglanti2.Close();



            FormCihazTeknik fc = new FormCihazTeknik();






            fc.yazı = lblcihazid.Text;

            fc.Show();











        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            if(lookUpEdit3.Properties.EditValueChangedDelay != 1)
            {
                DataTable dtz = new DataTable();
                SqlDataAdapter daz = new SqlDataAdapter("select chz_altgrupid,chz_altgrupad from chz_altgrup where chz_bagliana= " + lookUpEdit3.EditValue, baglanti);
                daz.Fill(dtz);
                lookUpEdit4.Properties.ValueMember = "chz_altgrupid";
                lookUpEdit4.Properties.DisplayMember = "chz_altgrupad";
                lookUpEdit4.Properties.NullText = "Alt Grup Seçiniz";
                lookUpEdit4.Properties.DataSource = dtz;

                //SqlDataAdapter da5 = new SqlDataAdapter("select * from chz_altgrup where chz_bagliana ", baglanti);
                //DataTable dt5 = new DataTable();
                //da5.Fill(dt5);
                //lookUpEdit4.Properties.ValueMember = "chz_altgrupad";
                //lookUpEdit4.Properties.DisplayMember = "chz_altgrupad";
                //lookUpEdit4.Properties.DataSource = dt5;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tblcihaztip (chz_tipad) values (@p1)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txttip.Text);

            komut2.ExecuteNonQuery();



            SqlDataAdapter da44 = new SqlDataAdapter("select * from tblcihaztip", baglanti);
            DataTable dt44 = new DataTable();
            da44.Fill(dt44);
            gridControl3.DataSource = dt44;

            //SqlDataAdapter da3 = new SqlDataAdapter("Select chz_tipad,chz_tipid from tblcihaztip", baglanti);
            //DataTable dt3 = new DataTable();
            //da3.Fill(dt3);
            //lookUpEdit1.Properties.ValueMember = "chz_tipid";
            //lookUpEdit1.Properties.DisplayMember = "chz_tipad";
            //lookUpEdit1.Properties.DataSource = dt3;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void teknikÖzellikBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeknikGörüntüle fc = new FormTeknikGörüntüle();






            fc.yazı = lbldemirbas.Text;

            fc.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lbldemirbas.Text = gridView1.GetFocusedRowCellValue("Cihaz Demirbas No").ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi1 += 1;
            textBox2.Text = sayi1.ToString();
        }

        private void lookUpEdit4_EditValueChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();
            if (lookUpEdit4.Properties.EditValueChangedDelay != 1)
            {
                DataTable dtz = new DataTable();
                SqlDataAdapter daz = new SqlDataAdapter("Select chz_tipid,chz_tipad from tblcihaztip where chz_grupid= " + lookUpEdit4.EditValue, baglanti);
                daz.Fill(dtz);
                lookUpEdit1.Properties.ValueMember = "chz_tipid";
                lookUpEdit1.Properties.DisplayMember = "chz_tipad";
                lookUpEdit1.Properties.NullText = "Cihaz Tipi Seçiniz";
                lookUpEdit1.Properties.DataSource = dtz;
            }


 
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiadresi);
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT chz_demirbasno FROM tblcihaz WHERE chz_demirbasno = (SELECT MAX(chz_demirbasno) FROM tblcihaz where chz_tip = @p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", lookUpEdit1.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
               textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[0].ToString();
               MessageBox.Show("Görüntülenen değer bu cihaz tipine tanımlanan bir önceki demirbas numarasıdır: [  " + dr[0] + "  ] " );
                //txtmustel.Text = dr[1].ToString();
                //txtdepartman.Text = dr[2].ToString();
                //txtdemirbas.Text = dr[3].ToString();

                //MessageBox.Show = ("Repo " + dr[0]);
          

            }

            baglanti.Close();


            
        }
        }
    }

