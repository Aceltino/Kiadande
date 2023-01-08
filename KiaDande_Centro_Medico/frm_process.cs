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
            progress.ForeColor = Color.FromArgb(76, 156, 148);

            if (progress.Value < 100)
            {
                if (progress.Value == 10 || progress.Value == 30 || progress.Value == 50 || progress.Value == 70 || progress.Value == 90)
                    lbl_starting.Visible = false;
                else
                    lbl_starting.Visible = true;

                    progress.Value += 10;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frm_login login = new frm_login();
                bt1.ShowSync(login);
                login.Show();
            }
        }
    }
}
