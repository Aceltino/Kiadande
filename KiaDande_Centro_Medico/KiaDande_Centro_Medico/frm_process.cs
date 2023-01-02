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
    public partial class frm_process : Form
    {
        public frm_process()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress.ForeColor = Color.Lavender;

            if (progress.Value < 100)
            {
                progress.Value += 50;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frm_login login = new frm_login();
                login.Show();
            }
        }
    }
}
