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
    public partial class Form3 : Form
    {
        private string selectedData;
        public Form3(string data)
        {
            InitializeComponent();
            selectedData = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet1.Nilai);

        }
    }
}
