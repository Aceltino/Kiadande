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
        private Color corVerdeEscura = Color.FromArgb(44, 60, 61);
        private Color corVerdeMenosEscura = Color.FromArgb(76, 156, 148);
        private Color corVerdeClara = Color.FromArgb(52, 188, 160);
        private Color corClaraParaSubstituirOBranco = Color.WhiteSmoke;
        private Color corCinzentaAzuladaMeioEscura = Color.FromArgb(84, 116, 124);
        private Color corCinzentaAzuladaMeioClara = Color.FromArgb(111, 139, 142);
        private Color corUsadaComoPlaceholder = Color.Silver;


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

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == txt_user.Tag.ToString())
            {
                txt_user.Text = "";
                txt_user.ForeColor = corVerdeEscura;
            }

        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            { 
                txt_user.Text = txt_user.Tag.ToString();
                txt_user.ForeColor = corUsadaComoPlaceholder;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == txt_pass.Tag.ToString())
            {
                txt_pass.Text = "";
                txt_pass.PasswordChar = '*';
                txt_pass.ForeColor = corVerdeEscura;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = txt_pass.Tag.ToString();
                txt_pass.ForeColor = corUsadaComoPlaceholder;
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void check_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showpass.Checked)
                txt_pass.PasswordChar = '\0';
            else
                txt_pass.PasswordChar = '*';
        }
    }
}
