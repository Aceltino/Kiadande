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
    public partial class list_proced : UserControl
    {
        public list_proced()
        {
            InitializeComponent();
        }

        private string preco;
        private string consulta;

        [Category("Custom Props")]
        public string Consulta
        {
            get { return consulta; }
            set { consulta = value; lbl_consulta.Text = value; }
        }

        [Category("Custom Props")]
        public string Preço
        {
            get { return preco; }
            set { preco = value; lbl_preco.Text = value; }
        }



    }
}
