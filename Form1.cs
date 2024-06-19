using System;
using System.Windows.Forms;

namespace CahyaFy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Add event handlers for any necessary events
            this.Load += new EventHandler(Form1_Load);
            this.txtKasirNo.TextChanged += new EventHandler(txtKasirNo_TextChanged);
            this.txtKasir.TextChanged += new EventHandler(txtKasir_TextChanged);
            this.txtNotaNo.TextChanged += new EventHandler(txtNotaNo_TextChanged);
            this.txtTanggal.TextChanged += new EventHandler(txtTanggal_TextChanged);
            this.txtNilaiTerhemat.TextChanged += new EventHandler(txtNilaiTerhemat_TextChanged);
            this.txtStokTerakhir.TextChanged += new EventHandler(txtStokTerakhir_TextChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load initial data or settings
        }

        private void txtKasirNo_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event for txtKasirNo
        }

        private void txtKasir_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event for txtKasir
        }

        private void txtNotaNo_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event for txtNotaNo
        }

        private void txtTanggal_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event for txtTanggal
        }

        private void txtNilaiTerhemat_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event for txtNilaiTerhemat
        }

        private void txtStokTerakhir_TextChanged(object sender, EventArgs e)
        {
            // Handle text change event for txtStokTerakhir
        }
    }
}
