using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Assignement01
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frm_StorageDetails();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frm_ImageDetails();
            frm.ShowDialog();
        }
    }
}
