using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1204021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (rbJadwal1.Checked)
            {
                jadwal = "Senin dan Rabu, 14.00 - 16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = "Selasa dan Kamis, 14.00 - 16.00";
            }
            else if (rbJadwal3.Checked)
            {
                jadwal = "Sbtu dan Minggu, 09.00 - 11.00";
            }
            else if (rbJadwal4.Checked)
            {
                jadwal = "Selasa dan Kamis, 13.00 - 17.00";
            }

            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola,";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar";
            }
            if (cbKomposer.Checked)
            {
                kelas = kelas + "Komposer";
            }
            if (cbKonduktor.Checked)
            {
                kelas = kelas + "Konduktor";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano";
            }
            if (cbSexophone.Checked)
            {
                kelas = kelas + "Sexophone";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dar pilihan kelas", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show
                ("Nama :" + txtNama.Text +
                "\nJenis Kelamin : " + cbJK.Text +
                "\nTanggal Lahir : " + dtTglLahir +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwa : " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void rbJadwal1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
