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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void link_createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bt1.HideSync(pnl_login);
            pnl_login.Visible = false;
            pnl_login.SendToBack();

            lbl_authen.Text = "Cadastrar";
            pnl_register.Visible = true;
            pnl_register.BringToFront();
            bt1.ShowSync(pnl_register);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_login_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_register);
            pnl_login.Visible = true;
            pnl_login.BringToFront();
            lbl_authen.Text = "Autenticação";

            pnl_register.Visible = false;
            pnl_register.SendToBack();
            bt1.ShowSync(pnl_login);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_main main = new frm_main();
            main.Show();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
