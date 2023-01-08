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
    public partial class list_result : UserControl
    {
        public list_result()
        {
            InitializeComponent();
        }

        private string exame;
        private string resultado;

        [Category("Custom Props")]
        public string Exame
        {
            get { return exame; }
            set { exame = value; lbl_exam.Text = value; }
        }

        [Category("Custom Props")]
        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; lbl_res.Text = value; }
        }
    }
}
