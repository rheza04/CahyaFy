﻿namespace CahyaFy
{
    partial class Form1
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnNota = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblKasirNo = new System.Windows.Forms.Label();
            this.txtKasirNo = new System.Windows.Forms.TextBox();
            this.lblKasir = new System.Windows.Forms.Label();
            this.txtKasir = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.txtTanggal = new System.Windows.Forms.TextBox();
            this.lblNilaiTerhemat = new System.Windows.Forms.Label();
            this.txtNilaiTerhemat = new System.Windows.Forms.TextBox();
            this.lblStokTerakhir = new System.Windows.Forms.Label();
            this.txtStokTerakhir = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnNota);
            this.panelButtons.Controls.Add(this.btnMember);
            this.panelButtons.Controls.Add(this.btnPending);
            this.panelButtons.Location = new System.Drawing.Point(12, 320);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(400, 40);
            this.panelButtons.TabIndex = 0;
            // 
            // btnNota
            // 
            this.btnNota.Location = new System.Drawing.Point(9, 3);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(75, 23);
            this.btnNota.TabIndex = 0;
            this.btnNota.Text = "Nota";
            this.btnNota.UseVisualStyleBackColor = true;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(90, 3);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(75, 23);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(171, 3);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(75, 23);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(243, 0);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 3;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblKasirNo);
            this.groupBoxInfo.Controls.Add(this.txtKasirNo);
            this.groupBoxInfo.Controls.Add(this.lblKasir);
            this.groupBoxInfo.Controls.Add(this.txtKasir);
            this.groupBoxInfo.Controls.Add(this.lblNota);
            this.groupBoxInfo.Controls.Add(this.txtNota);
            this.groupBoxInfo.Controls.Add(this.lblTanggal);
            this.groupBoxInfo.Controls.Add(this.txtTanggal);
            this.groupBoxInfo.Controls.Add(this.lblNilaiTerhemat);
            this.groupBoxInfo.Controls.Add(this.txtNilaiTerhemat);
            this.groupBoxInfo.Controls.Add(this.lblStokTerakhir);
            this.groupBoxInfo.Controls.Add(this.txtStokTerakhir);
            this.groupBoxInfo.Controls.Add(this.btnFoto);
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(200, 320);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Enter += new System.EventHandler(this.groupBoxInfo_Enter);
            // 
            // lblKasirNo
            // 
            this.lblKasirNo.AutoSize = true;
            this.lblKasirNo.Location = new System.Drawing.Point(6, 20);
            this.lblKasirNo.Name = "lblKasirNo";
            this.lblKasirNo.Size = new System.Drawing.Size(50, 13);
            this.lblKasirNo.TabIndex = 1;
            this.lblKasirNo.Text = "Kasir No.";
            // 
            // txtKasirNo
            // 
            this.txtKasirNo.Location = new System.Drawing.Point(80, 17);
            this.txtKasirNo.Name = "txtKasirNo";
            this.txtKasirNo.Size = new System.Drawing.Size(100, 20);
            this.txtKasirNo.TabIndex = 2;
            // 
            // lblKasir
            // 
            this.lblKasir.AutoSize = true;
            this.lblKasir.Location = new System.Drawing.Point(6, 50);
            this.lblKasir.Name = "lblKasir";
            this.lblKasir.Size = new System.Drawing.Size(30, 13);
            this.lblKasir.TabIndex = 3;
            this.lblKasir.Text = "Kasir";
            // 
            // txtKasir
            // 
            this.txtKasir.Location = new System.Drawing.Point(80, 47);
            this.txtKasir.Name = "txtKasir";
            this.txtKasir.Size = new System.Drawing.Size(100, 20);
            this.txtKasir.TabIndex = 4;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(6, 80);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(50, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "No. Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(80, 77);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 6;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(6, 110);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(46, 13);
            this.lblTanggal.TabIndex = 7;
            this.lblTanggal.Text = "Tanggal";
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(80, 107);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(100, 20);
            this.txtTanggal.TabIndex = 8;
            // 
            // lblNilaiTerhemat
            // 
            this.lblNilaiTerhemat.AutoSize = true;
            this.lblNilaiTerhemat.Location = new System.Drawing.Point(6, 140);
            this.lblNilaiTerhemat.Name = "lblNilaiTerhemat";
            this.lblNilaiTerhemat.Size = new System.Drawing.Size(75, 13);
            this.lblNilaiTerhemat.TabIndex = 9;
            this.lblNilaiTerhemat.Text = "Nilai Terhemat";
            // 
            // txtNilaiTerhemat
            // 
            this.txtNilaiTerhemat.Location = new System.Drawing.Point(80, 137);
            this.txtNilaiTerhemat.Name = "txtNilaiTerhemat";
            this.txtNilaiTerhemat.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiTerhemat.TabIndex = 10;
            // 
            // lblStokTerakhir
            // 
            this.lblStokTerakhir.AutoSize = true;
            this.lblStokTerakhir.Location = new System.Drawing.Point(6, 170);
            this.lblStokTerakhir.Name = "lblStokTerakhir";
            this.lblStokTerakhir.Size = new System.Drawing.Size(71, 13);
            this.lblStokTerakhir.TabIndex = 11;
            this.lblStokTerakhir.Text = "Stok Terakhir";
            // 
            // txtStokTerakhir
            // 
            this.txtStokTerakhir.Location = new System.Drawing.Point(80, 167);
            this.txtStokTerakhir.Name = "txtStokTerakhir";
            this.txtStokTerakhir.Size = new System.Drawing.Size(100, 20);
            this.txtStokTerakhir.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode,
            this.Item,
            this.Qty,
            this.Harga,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(230, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Kode
            // 
            this.Kode.Name = "Kode";
            // 
            // Item
            // 
            this.Item.Name = "Item";
            // 
            // Qty
            // 
            this.Qty.Name = "Qty";
            // 
            // Harga
            // 
            this.Harga.Name = "Harga";
            // 
            // SubTotal
            // 
            this.SubTotal.Name = "SubTotal";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(230, 170);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(32, 13);
            this.lblKode.TabIndex = 9;
            this.lblKode.Text = "Kode";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(280, 167);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(100, 20);
            this.txtKode.TabIndex = 10;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(230, 200);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 11;
            this.lblItem.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(280, 197);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 12;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(230, 230);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 13;
            this.lblQty.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(280, 227);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 14;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(230, 260);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 15;
            this.lblHarga.Text = "Harga";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(280, 257);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(230, 290);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "Form1";
            this.Text = "CahyaFy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelButtons.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnNota;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblKasirNo;
        private System.Windows.Forms.TextBox txtKasirNo;
        private System.Windows.Forms.Label lblKasir;
        private System.Windows.Forms.TextBox txtKasir;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.TextBox txtTanggal;
        private System.Windows.Forms.Label lblNilaiTerhemat;
        private System.Windows.Forms.TextBox txtNilaiTerhemat;
        private System.Windows.Forms.Label lblStokTerakhir;
        private System.Windows.Forms.TextBox txtStokTerakhir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        #endregion
    }
}
