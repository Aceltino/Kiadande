using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiaDande_Centro_Medico
{
    public partial class list_exam : UserControl
    {
        public list_exam()
        {
            InitializeComponent();
        }

        private string exame;
        [Category("Custom Props")]
        public string Exame
        {
            get { return exame; }
            set { exame = value; lbl_exam.Text = value; }
        }

      
        private string rbt;
        [Category("Custom Props")]
        public string Check
        {
            get { return rbt; }
            set { rbt = value;
                if (rbt_neg.Checked == true)
                {   
                rbt_neg.Text = value;
                    value = "Negativo";
                } else
                {
                    rbt_pos.Text = value;
                    value = "Positivo";
                }

                 }
        }


    }
}
