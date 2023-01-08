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
    public partial class frm_gerent : Form
    {
        public frm_gerent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_pac_Click(object sender, EventArgs e)
        {
            pnl_pac.BorderStyle = BorderStyle.Fixed3D;
            pnl_rech.BorderStyle = BorderStyle.None;
            pnl_recf.BorderStyle = BorderStyle.None;

            pnl_Recursosh.Hide();
            pnl_Recursosf.Hide();
            pnl_paciente.BringToFront();
            bt1.ShowSync(pnl_paciente);
        }

        private void pnl_recf_Click(object sender, EventArgs e)
        {
            pnl_pac.BorderStyle = BorderStyle.None;
            pnl_rech.BorderStyle = BorderStyle.None;
            pnl_recf.BorderStyle = BorderStyle.Fixed3D;

            pnl_Recursosh.Hide();
            pnl_paciente.Hide();
            pnl_Recursosf.BringToFront();
            bt1.ShowSync(pnl_Recursosf);
        }

        private void pnl_rech_Click(object sender, EventArgs e)
        {
            pnl_pac.BorderStyle = BorderStyle.None;
            pnl_rech.BorderStyle = BorderStyle.Fixed3D;
            pnl_recf.BorderStyle = BorderStyle.None;

            pnl_Recursosf.Hide();
            pnl_paciente.Hide();
            pnl_Recursosh.BringToFront();
            bt1.ShowSync(pnl_Recursosh);
        }

        private void pnl_pac_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
