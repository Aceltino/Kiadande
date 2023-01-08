using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiaDande_Centro_Medico
{
    public partial class recep1 : Form
    {
        public recep1()
        {
            InitializeComponent();
        }

        private void recep1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            pnl_idpaciente.Hide();
            pnl_idpac_edit.BringToFront();
            bt1.ShowSync(pnl_idpac_edit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_idpac_edit.Hide();
            pnl_idpaciente.BringToFront();
            bt1.ShowSync(pnl_idpaciente);
        }
    }
}
