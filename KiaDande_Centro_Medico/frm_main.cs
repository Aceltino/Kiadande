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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();

            btn_recepcao.Font = new Font(btn_recepcao.Font.Name, btn_recepcao.Font.Size, FontStyle.Bold);
            btn_triagem.Font = new Font(btn_triagem.Font.Name, btn_triagem.Font.Size, FontStyle.Regular);
            btn_consult.Font = new Font(btn_consult.Font.Name, btn_consult.Font.Size, FontStyle.Regular);
            btn_lab.Font = new Font(btn_lab.Font.Name, btn_lab.Font.Size, FontStyle.Regular);
            btn_geren.Font = new Font(btn_geren.Font.Name, btn_geren.Font.Size, FontStyle.Regular);

            btn_recep1.BringToFront();
            btn_recep1.Visible = true;
            btn_recep1.Font = new Font(btn_recep1.Font.Name, btn_recep1.Font.Size, FontStyle.Bold);
            btn_recep1.BringToFront();
            btn_recep1.Visible = true;
            btn_recep1.BringToFront();
            btn_recep1.Visible = true;

            btn_consult1.Visible = false;
            btn_consult2.Visible = false;
            btn_consult3.Visible = false;

            open_form(new recep1());
        }

        // Menu
        private void btn_recepcao_Click(object sender, EventArgs e)
        {
            if (!btn_recepcao.Font.Bold) { 
            btn_recepcao.Font = new Font(btn_recepcao.Font.Name, btn_recepcao.Font.Size, FontStyle.Bold);
            btn_triagem.Font = new Font(btn_triagem.Font.Name, btn_triagem.Font.Size, FontStyle.Regular);
            btn_consult.Font = new Font(btn_consult.Font.Name, btn_consult.Font.Size, FontStyle.Regular);
            btn_lab.Font = new Font(btn_lab.Font.Name, btn_lab.Font.Size, FontStyle.Regular);
            btn_geren.Font = new Font(btn_geren.Font.Name, btn_geren.Font.Size, FontStyle.Regular);

                pnl_submenu.Visible = true;

                btn_recep1.BringToFront();
                btn_recep1.Visible = true;
                btn_recep1.Font = new Font(btn_recep1.Font.Name, btn_recep1.Font.Size, FontStyle.Bold);
                btn_recep2.BringToFront();
                btn_recep2.Visible = true;
                btn_recep3.BringToFront();
                btn_recep3.Visible = true;

                btn_consult1.Visible = false;
                btn_consult2.Visible = false;
                btn_consult3.Visible = false;


                if (pnl_form.Controls.Count > 0)
                {
                    pnl_form.Controls.RemoveAt(0);
                    open_form(new recep1());
                }
                else
                {
                    open_form(new recep1());
                }
                

            }
            
        }

        private void btn_triagem_Click(object sender, EventArgs e)
        {
            if (!btn_triagem.Font.Bold)
            {
                btn_recepcao.Font = new Font(btn_recepcao.Font.Name, btn_recepcao.Font.Size, FontStyle.Regular);
                btn_triagem.Font = new Font(btn_triagem.Font.Name, btn_triagem.Font.Size, FontStyle.Bold);
                btn_consult.Font = new Font(btn_consult.Font.Name, btn_consult.Font.Size, FontStyle.Regular);
                btn_lab.Font = new Font(btn_lab.Font.Name, btn_lab.Font.Size, FontStyle.Regular);
                btn_geren.Font = new Font(btn_geren.Font.Name, btn_geren.Font.Size, FontStyle.Regular);

                pnl_submenu.Visible = false;

                btn_recep1.Visible = false;
                btn_recep2.Visible = false;
                btn_recep3.Visible = false;

                btn_consult1.Visible = false;
                btn_consult2.Visible = false;
                btn_consult3.Visible = false;

                if (pnl_form.Controls.Count > 0)
                {
                    pnl_form.Controls.RemoveAt(0);
                    open_form(new frm_triagem());
                }
                else
                {
                    open_form(new frm_triagem());
                }


            }
        }

        private void btn_consult_Click(object sender, EventArgs e)
        {
            if (!btn_consult.Font.Bold)
            {
                btn_recepcao.Font = new Font(btn_recepcao.Font.Name, btn_recepcao.Font.Size, FontStyle.Regular);
                btn_triagem.Font = new Font(btn_triagem.Font.Name, btn_triagem.Font.Size, FontStyle.Regular);
                btn_consult.Font = new Font(btn_consult.Font.Name, btn_consult.Font.Size, FontStyle.Bold);
                btn_lab.Font = new Font(btn_lab.Font.Name, btn_lab.Font.Size, FontStyle.Regular);
                btn_geren.Font = new Font(btn_geren.Font.Name, btn_geren.Font.Size, FontStyle.Regular);

                pnl_submenu.Visible = true;

                btn_consult1.BringToFront();
                btn_consult1.Visible = true;
                btn_consult1.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Bold);
                btn_consult2.BringToFront();
                btn_consult2.Visible = true;
                btn_consult3.BringToFront();
                btn_consult3.Visible = true;

                btn_recep1.Visible = false;
                btn_recep2.Visible = false;
                btn_recep3.Visible = false;


                if (pnl_form.Controls.Count > 0)
                {
                    pnl_form.Controls.RemoveAt(0);
                    open_form(new consult1());
                }
                else
                {
                    open_form(new consult1());
                }
            }
        }

        private void btn_lab_Click(object sender, EventArgs e)
        {
            if (!btn_lab.Font.Bold)
            {
                btn_recepcao.Font = new Font(btn_recepcao.Font.Name, btn_recepcao.Font.Size, FontStyle.Regular);
                btn_triagem.Font = new Font(btn_triagem.Font.Name, btn_triagem.Font.Size, FontStyle.Regular);
                btn_consult.Font = new Font(btn_consult.Font.Name, btn_consult.Font.Size, FontStyle.Regular);
                btn_lab.Font = new Font(btn_lab.Font.Name, btn_lab.Font.Size, FontStyle.Bold);
                btn_geren.Font = new Font(btn_geren.Font.Name, btn_geren.Font.Size, FontStyle.Regular);

                pnl_submenu.Visible = false;

                btn_recep1.Visible = false;
                btn_recep2.Visible = false;
                btn_recep3.Visible = false;

                btn_consult1.Visible = false;
                btn_consult2.Visible = false;
                btn_consult3.Visible = false;

                if (pnl_form.Controls.Count > 0)
                {
                    pnl_form.Controls.RemoveAt(0);
                    open_form(new frm_lab());
                }
                else
                {
                    open_form(new frm_lab());
                }
            }
        }

        private void btn_geren_Click(object sender, EventArgs e)
        {
            if (!btn_geren.Font.Bold)
            {
                btn_recepcao.Font = new Font(btn_recepcao.Font.Name, btn_recepcao.Font.Size, FontStyle.Regular);
                btn_triagem.Font = new Font(btn_triagem.Font.Name, btn_triagem.Font.Size, FontStyle.Regular);
                btn_consult.Font = new Font(btn_consult.Font.Name, btn_consult.Font.Size, FontStyle.Regular);
                btn_lab.Font = new Font(btn_lab.Font.Name, btn_lab.Font.Size, FontStyle.Regular);
                btn_geren.Font = new Font(btn_geren.Font.Name, btn_geren.Font.Size, FontStyle.Bold);

                pnl_submenu.Visible = false;

                btn_recep1.Visible = false;
                btn_recep2.Visible = false;
                btn_recep3.Visible = false;

                btn_consult1.Visible = false;
                btn_consult2.Visible = false;
                btn_consult3.Visible = false;


                if (pnl_form.Controls.Count > 0)
                {
                    pnl_form.Controls.RemoveAt(0);
                    open_form(new frm_gerent());
                }
                else
                {
                    open_form(new frm_gerent());
                }
            }
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            if (!btn_lab.Font.Bold)
            {
                btn_recepcao.Font = new Font(btn_recepcao.Font.Name, btn_recepcao.Font.Size, FontStyle.Regular);
                btn_triagem.Font = new Font(btn_triagem.Font.Name, btn_triagem.Font.Size, FontStyle.Regular);
                btn_consult.Font = new Font(btn_consult.Font.Name, btn_consult.Font.Size, FontStyle.Regular);
                btn_lab.Font = new Font(btn_lab.Font.Name, btn_lab.Font.Size, FontStyle.Regular);
                btn_geren.Font = new Font(btn_geren.Font.Name, btn_geren.Font.Size, FontStyle.Regular);

                pnl_submenu.Visible = false;

                btn_recep1.Visible = false;
                btn_recep2.Visible = false;
                btn_recep3.Visible = false;

                btn_consult1.Visible = false;
                btn_consult2.Visible = false;
                btn_consult3.Visible = false;

            }
        }
        //End_Menu

        // Sub-Menu Consultório
        private void btn_consult1_Click(object sender, EventArgs e)
        {
            btn_consult1.BringToFront();
            btn_consult1.Visible = true;
            btn_consult1.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Bold);
            btn_consult2.BringToFront();
            btn_consult2.Visible = true;
            btn_consult2.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Regular);
            btn_consult3.BringToFront();
            btn_consult3.Visible = true;
            btn_consult3.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Regular);


            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
                opens_forms(new consult1());
            }
            else
            {
                opens_forms(new consult1());
            }
        }

        private void btn_consult2_Click(object sender, EventArgs e)
        {
            btn_consult1.BringToFront();
            btn_consult1.Visible = true;
            btn_consult1.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Regular);
            btn_consult2.BringToFront();
            btn_consult2.Visible = true;
            btn_consult2.Font = new Font(btn_consult2.Font.Name, btn_consult2.Font.Size, FontStyle.Bold);
            btn_consult3.BringToFront();
            btn_consult3.Visible = true;
            btn_consult3.Font = new Font(btn_consult3.Font.Name, btn_consult3.Font.Size, FontStyle.Regular);

            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
                opens_forms(new consult2());
            }
            else
            {
                opens_forms(new consult2());
            }
        }

        private void btn_consult3_Click(object sender, EventArgs e)
        {
            btn_consult1.BringToFront();
            btn_consult1.Visible = true;
            btn_consult1.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Regular);
            btn_consult2.BringToFront();
            btn_consult2.Visible = true;
            btn_consult2.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Regular);
            btn_consult3.BringToFront();
            btn_consult3.Visible = true;
            btn_consult3.Font = new Font(btn_consult1.Font.Name, btn_consult1.Font.Size, FontStyle.Bold);

            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
                opens_forms(new consult3());
            }
            else
            {
                opens_forms(new consult3());
            }
        }
        // End_Sub-Menu Consultório

        // Sub-Menu Recepção
        private void btn_recep1_Click(object sender, EventArgs e)
        {
            btn_recep1.BringToFront();
            btn_recep1.Visible = true;
            btn_recep1.Font = new Font(btn_recep1.Font.Name, btn_recep1.Font.Size, FontStyle.Bold);
            btn_recep2.BringToFront();
            btn_recep2.Visible = true;
            btn_recep2.Font = new Font(btn_recep2.Font.Name, btn_recep2.Font.Size, FontStyle.Regular);
            btn_recep3.BringToFront();
            btn_recep3.Visible = true;
            btn_recep3.Font = new Font(btn_recep3.Font.Name, btn_recep3.Font.Size, FontStyle.Regular);

            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
                opens_forms(new recep1());
            }
            else
            {
                opens_forms(new recep1());
            }

        }

        private void btn_recep2_Click(object sender, EventArgs e)
        {
            btn_recep1.BringToFront();
            btn_recep1.Visible = true;
            btn_recep1.Font = new Font(btn_recep1.Font.Name, btn_recep1.Font.Size, FontStyle.Regular);
            btn_recep2.BringToFront();
            btn_recep2.Visible = true;
            btn_recep2.Font = new Font(btn_recep2.Font.Name, btn_recep2.Font.Size, FontStyle.Bold);
            btn_recep3.BringToFront();
            btn_recep3.Visible = true;
            btn_recep3.Font = new Font(btn_recep3.Font.Name, btn_recep3.Font.Size, FontStyle.Regular);

            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
                opens_forms(new recep2());
            }
            else
            {
                opens_forms(new recep2());
            }
        }

        private void btn_recep3_Click(object sender, EventArgs e)
        {
            btn_recep1.BringToFront();
            btn_recep1.Visible = true;
            btn_recep1.Font = new Font(btn_recep1.Font.Name, btn_recep1.Font.Size, FontStyle.Regular);
            btn_recep2.BringToFront();
            btn_recep2.Visible = true;
            btn_recep2.Font = new Font(btn_recep2.Font.Name, btn_recep2.Font.Size, FontStyle.Regular);
            btn_recep3.BringToFront();
            btn_recep3.Visible = true;
            btn_recep3.Font = new Font(btn_recep3.Font.Name, btn_recep3.Font.Size, FontStyle.Bold);

            if (pnl_form.Controls.Count > 0)
            {
                pnl_form.Controls.RemoveAt(0);
                opens_forms(new recep3());
            }
            else
            {
                opens_forms(new recep3());
            }
        }
        // End_Sub-Menu Recepção

        //Bring form in panel _MENU
 
        private void open_form(Form bring_frm)
        {
            bring_frm.TopLevel = false;
            bring_frm.TopMost = true;
            bring_frm.FormBorderStyle = FormBorderStyle.None;
            bring_frm.Dock = DockStyle.Fill;
            pnl_form.Controls.Add(bring_frm);
            bt1.ShowSync(bring_frm);
            bring_frm.Show();
        }
        //End_Bring form in panel _MENU
        //Bring form in panel _S_MENU

        private void opens_forms(Form bring_frm)
        {
            bring_frm.TopLevel = false;
            bring_frm.TopMost = true;
            bring_frm.FormBorderStyle = FormBorderStyle.None;
            bring_frm.Dock = DockStyle.Fill;
            pnl_form.Controls.Add(bring_frm);
            bring_frm.Show();
        }
        //End_Bring form in panel _S_MENU

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
