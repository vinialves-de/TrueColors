using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueColors
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hsbred_Scroll(object sender, ScrollEventArgs e)
        {
            cbxred.Text = hsbred.Value.ToString();
            TrocaCor();
        }

        private void cbxver_TextChanged(object sender, EventArgs e)
        {

        }

        private void hsbver_Scroll(object sender, ScrollEventArgs e)
        {
            cbxver.Text = hsbver.Value.ToString();
            TrocaCor();

        }

        private void hsbblu_Scroll(object sender, ScrollEventArgs e)
        {
            cbxblu.Text = hsbblu.Value.ToString();
            TrocaCor();
        }

        private void TrocaCor()
       {
            lblni.BackColor = Color.FromArgb(
                hsbred.Value,
                hsbver.Value,
                hsbblu.Value


                );

       }
    }
}
