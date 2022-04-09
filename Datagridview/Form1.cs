using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa_Coba' table. You can move, or remove it, as needed.
            this.mahasiswa_CobaTableAdapter.Fill(this.prodiTIDataSet1.Mahasiswa_Coba);

        }
    }
}
