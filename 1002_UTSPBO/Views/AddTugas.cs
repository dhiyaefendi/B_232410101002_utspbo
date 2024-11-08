using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1002_UTSPBO.App.Core;
using _1002_UTSPBO.App.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1002_UTSPBO.Views
{
    public partial class AddTugas : Form
    {
        public AddTugas()
        {
            InitializeComponent();
        }

        private void lblDeskripsi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            M_Tugas tugas = new M_Tugas
            {
                judul_tugas = txbNamaTugas.Text,
                deskripsi_tugas = txbDeskripsi.Text,
                deadline = txbDeadline.Text,
            };
        }

        private void AddTugas_Load(object sender, EventArgs e)
        {

        }
    }
}
