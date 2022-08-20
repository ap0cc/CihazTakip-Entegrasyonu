using System;


namespace Cihaz_Enteg_Programı
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormAnaEntegrasyon fa = new FormAnaEntegrasyon();
            fa.MdiParent = this;
            fa.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormAnaEntegrasyon fa = new FormAnaEntegrasyon();
            fa.MdiParent = this;
            fa.Show();

          
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCihazGrupTanımları fc = new FormCihazGrupTanımları();
            fc.MdiParent = this;
            fc.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCihazTeknik fct = new FormCihazTeknik();
            fct.MdiParent = this;
            fct.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCihazTanımla fci = new FormCihazTanımla();
            fci.MdiParent = this;
            fci.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormEntegTanımla fe = new FormEntegTanımla();
            fe.MdiParent = this;
            fe.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPersonelTanımlama fo = new FormPersonelTanımlama();
            fo.MdiParent = this;
            fo.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSistemOdası fs = new FormSistemOdası();
            fs.MdiParent = this;
            fs.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTeknikGörüntüle ft = new FormTeknikGörüntüle();
            ft.MdiParent = this;
            ft.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
