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
            // Add event handlers if necessary
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load initial data or settings if needed
        }
    }
}
