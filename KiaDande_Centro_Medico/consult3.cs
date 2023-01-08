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
    public partial class consult3 : Form
    {
        public consult3()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_diagnost);
            pnl_recolher.BringToFront();
            bt1.ShowSync(pnl_recolher);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_recolher);
            pnl_diagnost.BringToFront();
            bt1.ShowSync(pnl_diagnost);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_diagnost);
            pnl_atualizar.BringToFront();
            bt1.ShowSync(pnl_atualizar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_recolher);
            pnl_diagnost.BringToFront();
            bt1.ShowSync(pnl_diagnost);
        }
    }
}
