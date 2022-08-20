
namespace Cihaz_Enteg_Programı
{
    partial class FormAnaEntegrasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaEntegrasyon));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cihazTeknikÖzellikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbllaptop = new System.Windows.Forms.Label();
            this.lblmonitor = new System.Windows.Forms.Label();
            this.lblmasaustu = new System.Windows.Forms.Label();
            this.lblyazıcı = new System.Windows.Forms.Label();
            this.lblguc = new System.Windows.Forms.Label();
            this.lblveri = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(4, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1264, 417);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cihazTeknikÖzellikToolStripMenuItem,
            this.personelGörüntüleToolStripMenuItem,
            this.raporlaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // cihazTeknikÖzellikToolStripMenuItem
            // 
            this.cihazTeknikÖzellikToolStripMenuItem.Name = "cihazTeknikÖzellikToolStripMenuItem";
            this.cihazTeknikÖzellikToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cihazTeknikÖzellikToolStripMenuItem.Text = "Cihaz Teknik Bilgi";
            this.cihazTeknikÖzellikToolStripMenuItem.Click += new System.EventHandler(this.cihazTeknikÖzellikToolStripMenuItem_Click);
            // 
            // personelGörüntüleToolStripMenuItem
            // 
            this.personelGörüntüleToolStripMenuItem.Name = "personelGörüntüleToolStripMenuItem";
            this.personelGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.personelGörüntüleToolStripMenuItem.Text = "Personel Bilgileri";
            // 
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.raporlaToolStripMenuItem.Text = "Raporla";
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // lbllaptop
            // 
            this.lbllaptop.AutoSize = true;
            this.lbllaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllaptop.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbllaptop.Location = new System.Drawing.Point(1141, 7);
            this.lbllaptop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllaptop.Name = "lbllaptop";
            this.lbllaptop.Size = new System.Drawing.Size(41, 13);
            this.lbllaptop.TabIndex = 1;
            this.lbllaptop.Text = "label1";
            // 
            // lblmonitor
            // 
            this.lblmonitor.AutoSize = true;
            this.lblmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmonitor.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblmonitor.Location = new System.Drawing.Point(642, 7);
            this.lblmonitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmonitor.Name = "lblmonitor";
            this.lblmonitor.Size = new System.Drawing.Size(41, 13);
            this.lblmonitor.TabIndex = 2;
            this.lblmonitor.Text = "label1";
            // 
            // lblmasaustu
            // 
            this.lblmasaustu.AutoSize = true;
            this.lblmasaustu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmasaustu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblmasaustu.Location = new System.Drawing.Point(974, 7);
            this.lblmasaustu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmasaustu.Name = "lblmasaustu";
            this.lblmasaustu.Size = new System.Drawing.Size(41, 13);
            this.lblmasaustu.TabIndex = 3;
            this.lblmasaustu.Text = "label2";
            // 
            // lblyazıcı
            // 
            this.lblyazıcı.AutoSize = true;
            this.lblyazıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyazıcı.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblyazıcı.Location = new System.Drawing.Point(506, 7);
            this.lblyazıcı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblyazıcı.Name = "lblyazıcı";
            this.lblyazıcı.Size = new System.Drawing.Size(41, 13);
            this.lblyazıcı.TabIndex = 4;
            this.lblyazıcı.Text = "label3";
            // 
            // lblguc
            // 
            this.lblguc.AutoSize = true;
            this.lblguc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguc.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblguc.Location = new System.Drawing.Point(800, 7);
            this.lblguc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblguc.Name = "lblguc";
            this.lblguc.Size = new System.Drawing.Size(41, 13);
            this.lblguc.TabIndex = 5;
            this.lblguc.Text = "label4";
            // 
            // lblveri
            // 
            this.lblveri.AutoSize = true;
            this.lblveri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblveri.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblveri.Location = new System.Drawing.Point(274, 7);
            this.lblveri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblveri.Name = "lblveri";
            this.lblveri.Size = new System.Drawing.Size(41, 13);
            this.lblveri.TabIndex = 6;
            this.lblveri.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // FormAnaEntegrasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 587);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblveri);
            this.Controls.Add(this.lblguc);
            this.Controls.Add(this.lblyazıcı);
            this.Controls.Add(this.lblmasaustu);
            this.Controls.Add(this.lblmonitor);
            this.Controls.Add(this.lbllaptop);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAnaEntegrasyon";
            this.Text = "FormAnaEntegrasyon";
            this.Load += new System.EventHandler(this.FormAnaEntegrasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lbllaptop;
        private System.Windows.Forms.Label lblmonitor;
        private System.Windows.Forms.Label lblmasaustu;
        private System.Windows.Forms.Label lblyazıcı;
        private System.Windows.Forms.Label lblguc;
        private System.Windows.Forms.Label lblveri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cihazTeknikÖzellikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}