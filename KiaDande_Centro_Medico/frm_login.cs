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
        //Armazenamento de cores em algumas variáveis
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

        //Ao entrar na textbox "ID do usuário ou email" na tela de login
        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == txt_user.Tag.ToString())
            {
                txt_user.Text = "";
                txt_user.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "ID do usuário ou email" na tela de login
        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            { 
                txt_user.Text = txt_user.Tag.ToString();
                txt_user.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Palavra-passe" na tela de login
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == txt_pass.Tag.ToString())
            {
                txt_pass.Text = "";
                txt_pass.PasswordChar = '*';
                txt_pass.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Palavra-passe" na tela de login
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

        //Ao mudar o estado da checkbox "Mostrar palavra-passe" na tela de login
        private void check_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showpass.Checked && txt_pass.Text != txt_pass.Tag.ToString())
                txt_pass.PasswordChar = '\0';
            else if(check_showpass.Checked == false && txt_pass.Text != txt_pass.Tag.ToString())
                txt_pass.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bt1.HideSync(pnl_login);
            pnl_recuperação.Visible = true;
            pnl_recuperação.BringToFront();
            lbl_authen.Text = "Recuperação";

            pnl_login.Visible = false;
            pnl_login.SendToBack();
            bt1.ShowSync(pnl_recuperação);
        }

        private void lbl_clo_Click(object sender, EventArgs e)
        {
            bt1.HideSync(pnl_recuperação);
            pnl_login.Visible = true;
            pnl_login.BringToFront();
            lbl_authen.Text = "Autenticação";

            pnl_recuperação.Visible = false;
            pnl_recuperação.SendToBack();
            bt1.ShowSync(pnl_login);
        }

        //Parte do cadastro

        //Ao entrar na textbox "ID do usuário" no cadastro de usuário
        private void txtIDUsuarioCadastro_Enter(object sender, EventArgs e)
        {
            if(txtIDUsuarioCadastro.Text == txtIDUsuarioCadastro.Tag.ToString())
            {
                txtIDUsuarioCadastro.Text = "";
                txtIDUsuarioCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "ID do usuário" no cadastro de usuário
        private void txtIDUsuarioCadastro_Leave(object sender, EventArgs e)
        {
            if(txtIDUsuarioCadastro.Text == "")
            {
                txtIDUsuarioCadastro.Text = txtIDUsuarioCadastro.Tag.ToString();
                txtIDUsuarioCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Telefone" no cadastro de usuário
        private void txtTelefoneCadastro_Enter(object sender, EventArgs e)
        {
            if(txtTelefoneCadastro.Text == txtTelefoneCadastro.Tag.ToString()) {
                txtTelefoneCadastro.Text = "";
                txtTelefoneCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Telefone" no cadastro de usuário
        private void txtTelefoneCadastro_Leave(object sender, EventArgs e)
        {
            if(txtTelefoneCadastro.Text == "")
            {
                txtTelefoneCadastro.Text = txtTelefoneCadastro.Tag.ToString();
                txtTelefoneCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Nome de usuário" no cadastro de usuário
        private void txtNomeDeUsuarioCadastro_Enter(object sender, EventArgs e)
        {
            if(txtNomeDeUsuarioCadastro.Text == txtNomeDeUsuarioCadastro.Tag.ToString()) {
                txtNomeDeUsuarioCadastro.Text = "";
                txtNomeDeUsuarioCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Nome de usuário" no cadastro de usuário
        private void txtNomeDeUsuarioCadastro_Leave(object sender, EventArgs e)
        {
            if (txtNomeDeUsuarioCadastro.Text == "")
            {
                txtNomeDeUsuarioCadastro.Text = txtNomeDeUsuarioCadastro.Tag.ToString();
                txtNomeDeUsuarioCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Palavra-passe" no cadastro de usuário
        private void txtPalavraPasseCadastro_Enter(object sender, EventArgs e)
        {
            if(txtPalavraPasseCadastro.Text == txtPalavraPasseCadastro.Tag.ToString())
            {
                txtPalavraPasseCadastro.Text = "";
                txtPalavraPasseCadastro.PasswordChar = '*';
                txtPalavraPasseCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Palavra-passe" no cadastro de usuário
        private void txtPalavraPasseCadastro_Leave(object sender, EventArgs e)
        {
            if(txtPalavraPasseCadastro.Text == "")
            {
                txtPalavraPasseCadastro.Text = txtPalavraPasseCadastro.Tag.ToString();
                txtPalavraPasseCadastro.PasswordChar = '\0';
                txtPalavraPasseCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao mudar o estado da checkbox "Mostrar palavra-passe" no cadastro de usuário
        private void check_ver_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ver_pass.Checked && txtPalavraPasseCadastro.Text != txtPalavraPasseCadastro.Tag.ToString())
                txtPalavraPasseCadastro.PasswordChar = '\0';
            else if(check_ver_pass.Checked == false && txtPalavraPasseCadastro.Text != txtPalavraPasseCadastro.Tag.ToString())
                txtPalavraPasseCadastro.PasswordChar = '*';
        }

        //Ao entrar na textbox "Código de recuperação" no cadastro de usuário
        private void txtCodigoDeRecuperacaoCadastro_Enter(object sender, EventArgs e)
        {
            if(txtCodigoDeRecuperacaoCadastro.Text == txtCodigoDeRecuperacaoCadastro.Tag.ToString())
            {
                txtCodigoDeRecuperacaoCadastro.Text = "";
                txtCodigoDeRecuperacaoCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Código de recuperação" no cadastro de usuário
        private void txtCodigoDeRecuperacaoCadastro_Leave(object sender, EventArgs e)
        {
            if (txtCodigoDeRecuperacaoCadastro.Text == "")
            {
                txtCodigoDeRecuperacaoCadastro.Text = txtCodigoDeRecuperacaoCadastro.Tag.ToString();
                txtCodigoDeRecuperacaoCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Nome de alguém especial" no cadastro de usuário
        private void txtNomeDeAlguemEspecialCadastro_Enter(object sender, EventArgs e)
        {
            if (txtNomeDeAlguemEspecialCadastro.Text == txtNomeDeAlguemEspecialCadastro.Tag.ToString())
            {
                txtNomeDeAlguemEspecialCadastro.Text = "";
                txtNomeDeAlguemEspecialCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Nome de alguém especial" no cadastro de usuário
        private void txtNomeDeAlguemEspecialCadastro_Leave(object sender, EventArgs e)
        {
            if (txtNomeDeAlguemEspecialCadastro.Text == "")
            {
                txtNomeDeAlguemEspecialCadastro.Text = txtNomeDeAlguemEspecialCadastro.Tag.ToString();
                txtNomeDeAlguemEspecialCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "ID do usuário ou email do Administrador" no cadastro de usuário
        private void txtIDUsuarioOuEmailAdminCadastro_Enter(object sender, EventArgs e)
        {
            if (txtIDUsuarioOuEmailAdminCadastro.Text == txtIDUsuarioOuEmailAdminCadastro.Tag.ToString())
            {
                txtIDUsuarioOuEmailAdminCadastro.Text = "";
                txtIDUsuarioOuEmailAdminCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "ID do usuário ou email do Administrador" no cadastro de usuário
        private void txtIDUsuarioOuEmailAdminCadastro_Leave(object sender, EventArgs e)
        {
            if (txtIDUsuarioOuEmailAdminCadastro.Text == "")
            {
                txtIDUsuarioOuEmailAdminCadastro.Text = txtIDUsuarioOuEmailAdminCadastro.Tag.ToString();
                txtIDUsuarioOuEmailAdminCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Palavra-passe do Administrador" no cadastro de usuário
        private void txtPalavraPasseAdminCadastro_Enter(object sender, EventArgs e)
        {
            if (txtPalavraPasseAdminCadastro.Text == txtPalavraPasseAdminCadastro.Tag.ToString())
            {
                txtPalavraPasseAdminCadastro.Text = "";
                txtPalavraPasseAdminCadastro.PasswordChar = '*';
                txtPalavraPasseAdminCadastro.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Palavra-passe do Administrador" no cadastro de usuário
        private void txtPalavraPasseAdminCadastro_Leave(object sender, EventArgs e)
        {
            if (txtPalavraPasseAdminCadastro.Text == "")
            {
                txtPalavraPasseAdminCadastro.Text = txtPalavraPasseAdminCadastro.Tag.ToString();
                txtPalavraPasseAdminCadastro.PasswordChar = '\0';
                txtPalavraPasseAdminCadastro.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Recuperar conta

        //Ao entrar na textbox "Código de recuperação" na recuperação de conta
        private void txtCodigoDeRecuperacao_Enter(object sender, EventArgs e)
        {
            if (txtCodigoDeRecuperacao.Text == txtCodigoDeRecuperacao.Tag.ToString())
            {
                txtCodigoDeRecuperacao.Text = "";
                txtCodigoDeRecuperacao.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Código de recuperação" na recuperação de conta
        private void txtCodigoDeRecuperacao_Leave(object sender, EventArgs e)
        {
            if (txtCodigoDeRecuperacao.Text == "")
            {
                txtCodigoDeRecuperacao.Text = txtCodigoDeRecuperacao.Tag.ToString();
                txtCodigoDeRecuperacao.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Primeiro nome de alguém especial" na recuperação de conta
        private void txtPrimeiroNomeDeAlguemEspecial_Enter(object sender, EventArgs e)
        {
            if (txtPrimeiroNomeDeAlguemEspecial.Text == txtPrimeiroNomeDeAlguemEspecial.Tag.ToString())
            {
                txtPrimeiroNomeDeAlguemEspecial.Text = "";
                txtPrimeiroNomeDeAlguemEspecial.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Primeiro nome de alguém especial" na recuperação de conta
        private void txtPrimeiroNomeDeAlguemEspecial_Leave(object sender, EventArgs e)
        {
            if (txtPrimeiroNomeDeAlguemEspecial.Text == "")
            {
                txtPrimeiroNomeDeAlguemEspecial.Text = txtPrimeiroNomeDeAlguemEspecial.Tag.ToString();
                txtPrimeiroNomeDeAlguemEspecial.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao entrar na textbox "Actualizar palavra-passe" na recuperação de conta
        private void txtPalavraPasseActualizada_Enter(object sender, EventArgs e)
        {
            if (txtPalavraPasseActualizada.Text == txtPalavraPasseActualizada.Tag.ToString())
            {
                txtPalavraPasseActualizada.Text = "";
                txtPalavraPasseActualizada.PasswordChar = '*';
                txtPalavraPasseActualizada.ForeColor = corVerdeEscura;
            }
        }

        //Ao sair da textbox "Actualizar palavra-passe" na recuperação de conta
        private void txtPalavraPasseActualizada_Leave(object sender, EventArgs e)
        {
            if (txtPalavraPasseActualizada.Text == txtPalavraPasseActualizada.Tag.ToString())
            {
                txtPalavraPasseActualizada.Text = txtPalavraPasseActualizada.Tag.ToString();
                txtPalavraPasseActualizada.PasswordChar = '\0';
                txtPalavraPasseActualizada.ForeColor = corUsadaComoPlaceholder;
            }
        }

        //Ao mudar o estado da checkbox "Mostrar palavra-passe" na recuperação de conta
        private void chkMostrarPalavraPasseActualizada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPalavraPasseActualizada.Checked && txtPalavraPasseActualizada.Text != txtPalavraPasseActualizada.Tag.ToString())
                txtPalavraPasseActualizada.PasswordChar = '\0';
            else if(chkMostrarPalavraPasseActualizada.Checked == false && txtPalavraPasseActualizada.Text != txtPalavraPasseActualizada.Tag.ToString())
                txtPalavraPasseActualizada.PasswordChar = '*';
        }
    }
}
