using System;
using System.Windows.Forms;

namespace CahyaFy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            // Implementasi untuk tombol Nota
            MessageBox.Show("Tombol Nota diklik");
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            // Implementasi untuk tombol Member
            MessageBox.Show("Tombol Member diklik");
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            // Implementasi untuk tombol Pending
            MessageBox.Show("Tombol Pending diklik");
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            // Implementasi untuk tombol Foto
            MessageBox.Show("Tombol Foto diklik");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set tanggal dan waktu saat ini
            txtTanggal.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
        }

        private void btnTambahItem_Click(object sender, EventArgs e)
        {
            // Contoh data item
            string kode = txtKode.Text;
            string item = txtItem.Text;
            int qty = int.Parse(txtQty.Text);
            decimal harga = decimal.Parse(txtHarga.Text);
            decimal subtotal = qty * harga;

            // Tambahkan item ke DataGridView
            dataGridView1.Rows.Add(kode, item, qty, harga, subtotal);

            // Hitung total
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }

            lblTotal.Text = "Total: " + total.ToString("N0");
        }

        private void groupBoxInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
