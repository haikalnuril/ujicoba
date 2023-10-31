using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_GUI
{
    public partial class FormTambahData : Form
    {
        public FormTambahData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        public MHS GetMHS()
        {
            MHS mhs1 = new MHS();
            mhs1.nama = tbNama.Text;
            mhs1.NIM = long.Parse(tbNIM.Text);
            mhs1.IPK = double.Parse(tbIPK.Text);
            mhs1.tempatLahir = tbTL.Text;
            mhs1.tanggalLahir = DateOnly.Parse(dateTime.Value.ToShortDateString());
            mhs1.Prodi = cbProdi.Text;
            mhs1.noTelp = tbNo.Text;
            return mhs1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
