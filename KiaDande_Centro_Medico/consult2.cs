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
    public partial class consult2 : Form
    {
        public consult2()
        {
            InitializeComponent();
        }

        private void consult2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_exame);
            pnl_anamnese.BringToFront();
            bt1.ShowSync(pnl_anamnese);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_anamnese);
            pnl_exame.BringToFront();
            bt1.ShowSync(pnl_exame);
        }
    }
}
