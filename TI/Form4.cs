using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet1.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Hide();
        }
    }
}
