
namespace Cihaz_Enteg_Programı
{
    partial class FormSistemOdası
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cihazTeknikBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txttip = new System.Windows.Forms.TextBox();
            this.txtdemirbas = new System.Windows.Forms.TextBox();
            this.btntipekle = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.txtdemir = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl2.Location = new System.Drawing.Point(4, 269);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1070, 154);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1268, 262);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cihazTeknikBilgiToolStripMenuItem,
            this.personelBilgileriToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // cihazTeknikBilgiToolStripMenuItem
            // 
            this.cihazTeknikBilgiToolStripMenuItem.Name = "cihazTeknikBilgiToolStripMenuItem";
            this.cihazTeknikBilgiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cihazTeknikBilgiToolStripMenuItem.Text = "Cihaz Teknik Bilgi";
            this.cihazTeknikBilgiToolStripMenuItem.Click += new System.EventHandler(this.cihazTeknikBilgiToolStripMenuItem_Click);
            // 
            // personelBilgileriToolStripMenuItem
            // 
            this.personelBilgileriToolStripMenuItem.Name = "personelBilgileriToolStripMenuItem";
            this.personelBilgileriToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.personelBilgileriToolStripMenuItem.Text = "Personel Bilgileri";
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(9, 278);
            this.txttip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(126, 20);
            this.txttip.TabIndex = 4;
            // 
            // txtdemirbas
            // 
            this.txtdemirbas.Location = new System.Drawing.Point(142, 278);
            this.txtdemirbas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdemirbas.Name = "txtdemirbas";
            this.txtdemirbas.Size = new System.Drawing.Size(126, 20);
            this.txtdemirbas.TabIndex = 5;
            // 
            // btntipekle
            // 
            this.btntipekle.ImageOptions.SvgImage = global::Cihaz_Enteg_Programı.Properties.Resources.opportunities;
            this.btntipekle.Location = new System.Drawing.Point(280, 278);
            this.btntipekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntipekle.Name = "btntipekle";
            this.btntipekle.Size = new System.Drawing.Size(150, 21);
            this.btntipekle.TabIndex = 6;
            this.btntipekle.Text = "Aktar";
            this.btntipekle.Click += new System.EventHandler(this.btntipekle_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 31);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(183, 123);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.SvgImage = global::Cihaz_Enteg_Programı.Properties.Resources.unlike;
            this.btnsil.Location = new System.Drawing.Point(441, 278);
            this.btnsil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 21);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "Kaldır";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtdemir
            // 
            this.txtdemir.Location = new System.Drawing.Point(604, 278);
            this.txtdemir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdemir.Name = "txtdemir";
            this.txtdemir.Size = new System.Drawing.Size(126, 20);
            this.txtdemir.TabIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.DimGray;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Location = new System.Drawing.Point(1079, 269);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(190, 154);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "IT Cihaz Açıklaması;";
            // 
            // FormSistemOdası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 425);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtdemir);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btntipekle);
            this.Controls.Add(this.txtdemirbas);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSistemOdası";
            this.Text = "FormSistemOdası";
            this.Load += new System.EventHandler(this.FormSistemOdası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.TextBox txtdemirbas;
        private DevExpress.XtraEditors.SimpleButton btntipekle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private System.Windows.Forms.TextBox txtdemir;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cihazTeknikBilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
    }
}