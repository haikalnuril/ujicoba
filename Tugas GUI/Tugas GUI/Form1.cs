namespace Tugas_GUI
{
    public partial class Form1 : Form
    {
        List<MHS> listMHS = new List<MHS>();
        public Form1()
        {
            InitializeComponent();

            MHS mhs1 = new MHS();
            mhs1.nama = "Jetro";
            mhs1.NIM = 222410101064;
            mhs1.IPK = 3.75;
            mhs1.tanggalLahir = new DateOnly(2004, 05, 17);
            mhs1.tempatLahir = "Metro";
            mhs1.Prodi = "Agrikultur";
            mhs1.noTelp = "081221389123";


            listMHS.Add(mhs1);

            dataGridView1.DataSource = listMHS;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (FormTambahData frmDataBaru = new FormTambahData())
            {
                if (frmDataBaru.ShowDialog() == DialogResult.OK)
                {
                    MHS mhs1 = frmDataBaru.GetMHS();
                    listMHS.Add(mhs1);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listMHS;

                    frmDataBaru.Close();
                }
            }
        }
    }
    public class MHS
    {
        public string nama { get; set; }
        public long NIM { get; set; }
        public double IPK { get; set; }
        public DateOnly tanggalLahir { get; set; }
        public string tempatLahir { get; set; }
        public string Prodi { get; set; }
        public string noTelp { get; set; }
    }
}