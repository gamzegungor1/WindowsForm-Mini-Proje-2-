using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_secim_Click(object sender, EventArgs e)
        {
            string secilenGun = comboBox2.SelectedItem.ToString();
            MessageBox.Show("Seçtiğiniz Gün :" + secilenGun);
        }
    }
}
