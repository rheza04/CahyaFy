using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;

namespace CahyaFy
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNota;
        private System.Windows.Forms.TabPage tabPageMember;
        private System.Windows.Forms.TabPage tabPagePending;
        private System.Windows.Forms.TabPage tabPageFoto;
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
            this.tabPageMember = new System.Windows.Forms.TabPage();
            this.tabPagePending = new System.Windows.Forms.TabPage();
            this.tabPageFoto = new System.Windows.Forms.TabPage();
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tabControl.SuspendLayout();
            this.tabPageNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPageNota);
            this.tabControl.Controls.Add(this.tabPageMember);
            this.tabControl.Controls.Add(this.tabPagePending);
            this.tabControl.Controls.Add(this.tabPageFoto);
            this.tabControl.Location = new System.Drawing.Point(12, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(250, 250);
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
            this.tabPageNota.Location = new System.Drawing.Point(4, 4);
            this.tabPageNota.Name = "tabPageNota";
            this.tabPageNota.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNota.Size = new System.Drawing.Size(242, 224);
            this.tabPageNota.TabIndex = 0;
            this.tabPageNota.Text = "Nota";
            this.tabPageNota.UseVisualStyleBackColor = true;
            // 
            // txtKasirNo
            // 
            this.txtKasirNo.Location = new System.Drawing.Point(130, 20);
            this.txtKasirNo.Name = "txtKasirNo";
            this.txtKasirNo.Size = new System.Drawing.Size(100, 20);
            this.txtKasirNo.TabIndex = 0;
            // 
            // txtKasir
            // 
            this.txtKasir.Location = new System.Drawing.Point(130, 50);
            this.txtKasir.Name = "txtKasir";
            this.txtKasir.Size = new System.Drawing.Size(100, 20);
            this.txtKasir.TabIndex = 1;
            // 
            // txtNotaNo
            // 
            this.txtNotaNo.Location = new System.Drawing.Point(130, 80);
            this.txtNotaNo.Name = "txtNotaNo";
            this.txtNotaNo.Size = new System.Drawing.Size(100, 20);
            this.txtNotaNo.TabIndex = 2;
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(130, 110);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(100, 20);
            this.txtTanggal.TabIndex = 3;
            // 
            // txtNilaiTerhemat
            // 
            this.txtNilaiTerhemat.Location = new System.Drawing.Point(130, 140);
            this.txtNilaiTerhemat.Name = "txtNilaiTerhemat";
            this.txtNilaiTerhemat.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiTerhemat.TabIndex = 4;
            // 
            // txtStokTerakhir
            // 
            this.txtStokTerakhir.Location = new System.Drawing.Point(130, 170);
            this.txtStokTerakhir.Name = "txtStokTerakhir";
            this.txtStokTerakhir.Size = new System.Drawing.Size(100, 20);
            this.txtStokTerakhir.TabIndex = 5;
            // 
            // lblKasirNo
            // 
            this.lblKasirNo.AutoSize = true;
            this.lblKasirNo.Location = new System.Drawing.Point(10, 23);
            this.lblKasirNo.Name = "lblKasirNo";
            this.lblKasirNo.Size = new System.Drawing.Size(50, 13);
            this.lblKasirNo.TabIndex = 6;
            this.lblKasirNo.Text = "Kasir No.";
            // 
            // lblKasir
            // 
            this.lblKasir.AutoSize = true;
            this.lblKasir.Location = new System.Drawing.Point(10, 53);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.Size = new System.Drawing.Size(30, 13);
            this.lblKasir.TabIndex = 7;
            this.lblKasir.Text = "Kasir";
            // 
            // lblNotaNo
            // 
            this.lblNotaNo.AutoSize = true;
            this.lblNotaNo.Location = new System.Drawing.Point(10, 83);
            this.lblNotaNo.Name = "lblNotaNo";
            this.lblNotaNo.Size = new System.Drawing.Size(50, 13);
            this.lblNotaNo.TabIndex = 8;
            this.lblNotaNo.Text = "No. Nota";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(10, 113);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(46, 13);
            this.lblTanggal.TabIndex = 9;
            this.lblTanggal.Text = "Tanggal";
            // 
            // lblNilaiTerhemat
            // 
            this.lblNilaiTerhemat.AutoSize = true;
            this.lblNilaiTerhemat.Location = new System.Drawing.Point(10, 143);
            this.lblNilaiTerhemat.Name = "lblNilaiTerhemat";
            this.lblNilaiTerhemat.Size = new System.Drawing.Size(75, 13);
            this.lblNilaiTerhemat.TabIndex = 10;
            this.lblNilaiTerhemat.Text = "Nilai Terhemat";
            // 
            // lblStokTerakhir
            // 
            this.lblStokTerakhir.AutoSize = true;
            this.lblStokTerakhir.Location = new System.Drawing.Point(10, 173);
            this.lblStokTerakhir.Name = "lblStokTerakhir";
            this.lblStokTerakhir.Size = new System.Drawing.Size(71, 13);
            this.lblStokTerakhir.TabIndex = 11;
            this.lblStokTerakhir.Text = "Stok Terakhir";
            // 
            // tabPageMember
            // 
            this.tabPageMember.Location = new System.Drawing.Point(4, 4);
            this.tabPageMember.Name = "tabPageMember";
            this.tabPageMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMember.Size = new System.Drawing.Size(242, 224);
            this.tabPageMember.TabIndex = 1;
            this.tabPageMember.Text = "Member";
            this.tabPageMember.UseVisualStyleBackColor = true;
            // 
            // tabPagePending
            // 
            this.tabPagePending.Location = new System.Drawing.Point(4, 4);
            this.tabPagePending.Name = "tabPagePending";
            this.tabPagePending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePending.Size = new System.Drawing.Size(242, 224);
            this.tabPagePending.TabIndex = 2;
            this.tabPagePending.Text = "Pending";
            this.tabPagePending.UseVisualStyleBackColor = true;
            // 
            // tabPageFoto
            // 
            this.tabPageFoto.Location = new System.Drawing.Point(4, 4);
            this.tabPageFoto.Name = "tabPageFoto";
            this.tabPageFoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFoto.Size = new System.Drawing.Size(242, 224);
            this.tabPageFoto.TabIndex = 3;
            this.tabPageFoto.Text = "Foto";
            this.tabPageFoto.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(280, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(500, 150);
            this.dataGridView.TabIndex = 12;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(350, 180);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(100, 20);
            this.txtKode.TabIndex = 13;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(350, 210);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 14;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(350, 240);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 15;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(245, 324);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 16;
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(280, 183);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(32, 13);
            this.lblKode.TabIndex = 17;
            this.lblKode.Text = "Kode";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(280, 213);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 18;
            this.lblItem.Text = "Item";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(280, 243);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 19;
            this.lblQty.Text = "Qty";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(280, 273);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 20;
            this.lblHarga.Text = "Harga";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(179, 331);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "JITSHOMART";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(589, 331);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(906, 384);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
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

        private Label label1;
        private MaskedTextBox maskedTextBox1;
    }
}
