using System;

namespace CahyaFy
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNota;
        private System.Windows.Forms.TabPage tabPageMember;  // Tambahkan ini
        private System.Windows.Forms.TabPage tabPagePending; // Tambahkan ini
        private System.Windows.Forms.TabPage tabPageFoto;    // Tambahkan ini

        // Deklarasi komponen lainnya
        private System.Windows.Forms.TextBox txtKasirNo;
        private System.Windows.Forms.TextBox txtKasir;
        private System.Windows.Forms.TextBox txtNotaNo;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.TextBox txtNilaiTerhemat;
        private System.Windows.Forms.TextBox txtStokTerakhir;
        private System.Windows.Forms.Label lblKasirNo;
        private System.Windows.Forms.Label lblKasir;
        private System.Windows.Forms.Label lblNotaNo;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblNilaiTerhemat;
        private System.Windows.Forms.Label lblStokTerakhir;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblTotal;

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
            this.tabPageMember = new System.Windows.Forms.TabPage();  // Tambahkan ini
            this.tabPagePending = new System.Windows.Forms.TabPage(); // Tambahkan ini
            this.tabPageFoto = new System.Windows.Forms.TabPage();    // Tambahkan ini
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNota = new System.Windows.Forms.TabPage();
            this.txtKasirNo = new System.Windows.Forms.TextBox();
            this.txtKasir = new System.Windows.Forms.TextBox();
            this.txtNotaNo = new System.Windows.Forms.TextBox();
            this.txtTanggal = new System.Windows.Forms.TextBox();
            this.txtNilaiTerhemat = new System.Windows.Forms.TextBox();
            this.txtStokTerakhir = new System.Windows.Forms.TextBox();
            this.lblKasirNo = new System.Windows.Forms.Label();
            this.lblKasir = new System.Windows.Forms.Label();
            this.lblNotaNo = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblNilaiTerhemat = new System.Windows.Forms.Label();
            this.lblStokTerakhir = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblKode = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();

            this.tabControl.SuspendLayout();
            this.tabPageNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageNota);
            this.tabControl.Controls.Add(this.tabPageMember);  // Tambahkan ini
            this.tabControl.Controls.Add(this.tabPagePending); // Tambahkan ini
            this.tabControl.Controls.Add(this.tabPageFoto);    // Tambahkan ini
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(200, 150);
            this.tabControl.TabIndex = 0;

            // 
            // tabPageNota
            // 
            this.tabPageNota.Controls.Add(this.txtKasirNo);
            this.tabPageNota.Controls.Add(this.txtKasir);
            this.tabPageNota.Controls.Add(this.txtNotaNo);
            this.tabPageNota.Controls.Add(this.txtTanggal);
            this.tabPageNota.Controls.Add(this.txtNilaiTerhemat);
            this.tabPageNota.Controls.Add(this.txtStokTerakhir);
            this.tabPageNota.Controls.Add(this.lblKasirNo);
            this.tabPageNota.Controls.Add(this.lblKasir);
            this.tabPageNota.Controls.Add(this.lblNotaNo);
            this.tabPageNota.Controls.Add(this.lblTanggal);
            this.tabPageNota.Controls.Add(this.lblNilaiTerhemat);
            this.tabPageNota.Controls.Add(this.lblStokTerakhir);
            this.tabPageNota.Location = new System.Drawing.Point(4, 22);
            this.tabPageNota.Name = "tabPageNota";
            this.tabPageNota.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNota.Size = new System.Drawing.Size(192, 124);
            this.tabPageNota.TabIndex = 0;
            this.tabPageNota.Text = "Nota";
            this.tabPageNota.UseVisualStyleBackColor = true;

            // 
            // txtKasirNo
            // 
            this.txtKasirNo.Location = new System.Drawing.Point(80, 10);
            this.txtKasirNo.Name = "txtKasirNo";
            this.txtKasirNo.Size = new System.Drawing.Size(100, 20);
            this.txtKasirNo.TabIndex = 0;

            // 
            // txtKasir
            // 
            this.txtKasir.Location = new System.Drawing.Point(80, 30);
            this.txtKasir.Name = "txtKasir";
            this.txtKasir.Size = new System.Drawing.Size(100, 20);
            this.txtKasir.TabIndex = 1;

            // 
            // txtNotaNo
            // 
            this.txtNotaNo.Location = new System.Drawing.Point(80, 50);
            this.txtNotaNo.Name = "txtNotaNo";
            this.txtNotaNo.Size = new System.Drawing.Size(100, 20);
            this.txtNotaNo.TabIndex = 2;

            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(80, 70);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(100, 20);
            this.txtTanggal.TabIndex = 3;

            // 
            // txtNilaiTerhemat
            // 
            this.txtNilaiTerhemat.Location = new System.Drawing.Point(80, 90);
            this.txtNilaiTerhemat.Name = "txtNilaiTerhemat";
            this.txtNilaiTerhemat.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiTerhemat.TabIndex = 4;

            // 
            // txtStokTerakhir
            // 
            this.txtStokTerakhir.Location = new System.Drawing.Point(80, 110);
            this.txtStokTerakhir.Name = "txtStokTerakhir";
            this.txtStokTerakhir.Size = new System.Drawing.Size(100, 20);
            this.txtStokTerakhir.TabIndex = 5;

            // 
            // lblKasirNo
            // 
            this.lblKasirNo.AutoSize = true;
            this.lblKasirNo.Location = new System.Drawing.Point(10, 13);
            this.lblKasirNo.Name = "lblKasirNo";
            this.lblKasirNo.Size = new System.Drawing.Size(50, 13);
            this.lblKasirNo.TabIndex = 6;
            this.lblKasirNo.Text = "Kasir No.";

            // 
            // lblKasir
            // 
            this.lblKasir.AutoSize = true;
            this.lblKasir.Location = new System.Drawing.Point(10, 33);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.Size = new System.Drawing.Size(31, 13);
            this.lblKasir.TabIndex = 7;
            this.lblKasir.Text = "Kasir";

            // 
            // lblNotaNo
            // 
            this.lblNotaNo.AutoSize = true;
            this.lblNotaNo.Location = new System.Drawing.Point(10, 53);
            this.lblNotaNo.Name = "lblNotaNo";
            this.lblNotaNo.Size = new System.Drawing.Size(49, 13);
            this.lblNotaNo.TabIndex = 8;
            this.lblNotaNo.Text = "No. Nota";

            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(10, 73);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(46, 13);
            this.lblTanggal.TabIndex = 9;
            this.lblTanggal.Text = "Tanggal";

            // 
            // lblNilaiTerhemat
            // 
            this.lblNilaiTerhemat.AutoSize = true;
            this.lblNilaiTerhemat.Location = new System.Drawing.Point(10, 93);
            this.lblNilaiTerhemat.Name = "lblNilaiTerhemat";
            this.lblNilaiTerhemat.Size = new System.Drawing.Size(73, 13);
            this.lblNilaiTerhemat.TabIndex = 10;
            this.lblNilaiTerhemat.Text = "Nilai Terhemat";

            // 
            // lblStokTerakhir
            // 
            this.lblStokTerakhir.AutoSize = true;
            this.lblStokTerakhir.Location = new System.Drawing.Point(10, 113);
            this.lblStokTerakhir.Name = "lblStokTerakhir";
            this.lblStokTerakhir.Size = new System.Drawing.Size(70, 13);
            this.lblStokTerakhir.TabIndex = 11;
            this.lblStokTerakhir.Text = "Stok Terakhir";

            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(220, 10);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(560, 300);
            this.dataGridView.TabIndex = 12;

            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(550, 320);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(100, 20);
            this.txtKode.TabIndex = 13;

            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(550, 350);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 14;

            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(550, 380);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 15;

            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(550, 410);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 16;

            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(480, 323);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(32, 13);
            this.lblKode.TabIndex = 17;
            this.lblKode.Text = "Kode";

            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(480, 353);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 18;
            this.lblItem.Text = "Item";

            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(480, 383);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 19;
            this.lblQty.Text = "Qty";

            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(480, 413);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 20;
            this.lblHarga.Text = "Harga";

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(700, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 24);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "6.000";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form1";
            this.Text = "CahyaFy";

            this.tabControl.ResumeLayout(false);
            this.tabPageNota.ResumeLayout(false);
            this.tabPageNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
