namespace KiaDande_Centro_Medico
{
    partial class frm_lab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.cbb_cargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.list_exam1 = new KiaDande_Centro_Medico.list_exam();
            this.list_exam2 = new KiaDande_Centro_Medico.list_exam();
            this.list_exam3 = new KiaDande_Centro_Medico.list_exam();
            this.list_exam4 = new KiaDande_Centro_Medico.list_exam();
            this.list_exam5 = new KiaDande_Centro_Medico.list_exam();
            this.list_exam6 = new KiaDande_Centro_Medico.list_exam();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(426, 388);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(268, 28);
            this.btn_login.TabIndex = 124;
            this.btn_login.Text = "Encaminhar ao Médico";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // cbb_cargo
            // 
            this.cbb_cargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_cargo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_cargo.ForeColor = System.Drawing.Color.Silver;
            this.cbb_cargo.FormattingEnabled = true;
            this.cbb_cargo.Items.AddRange(new object[] {
            "Enfermeiro",
            "Analista",
            "Médico",
            "Admin"});
            this.cbb_cargo.Location = new System.Drawing.Point(60, 78);
            this.cbb_cargo.Name = "cbb_cargo";
            this.cbb_cargo.Size = new System.Drawing.Size(275, 27);
            this.cbb_cargo.TabIndex = 122;
            this.cbb_cargo.Text = "Documento de Identificação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(472, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 111;
            this.label3.Text = "RESULTADOS EXAMES";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.list_exam1);
            this.flowLayoutPanel1.Controls.Add(this.list_exam2);
            this.flowLayoutPanel1.Controls.Add(this.list_exam3);
            this.flowLayoutPanel1.Controls.Add(this.list_exam4);
            this.flowLayoutPanel1.Controls.Add(this.list_exam5);
            this.flowLayoutPanel1.Controls.Add(this.list_exam6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(375, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(359, 230);
            this.flowLayoutPanel1.TabIndex = 126;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(417, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 128;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(417, 78);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 29);
            this.textBox3.TabIndex = 127;
            this.textBox3.Tag = "ID Usuário ou Email";
            this.textBox3.Text = "Número de Identificação";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(783, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 130;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(783, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 29);
            this.textBox1.TabIndex = 129;
            this.textBox1.Tag = "ID Usuário ou Email";
            this.textBox1.Text = "Nome do Paciente";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.checkBox1.Location = new System.Drawing.Point(60, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 27);
            this.checkBox1.TabIndex = 131;
            this.checkBox1.Text = "Análise de Controle";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // list_exam1
            // 
            this.list_exam1.Exame = null;
            this.list_exam1.Location = new System.Drawing.Point(3, 3);
            this.list_exam1.Name = "list_exam1";
            this.list_exam1.Size = new System.Drawing.Size(336, 37);
            this.list_exam1.TabIndex = 0;
            // 
            // list_exam2
            // 
            this.list_exam2.Exame = null;
            this.list_exam2.Location = new System.Drawing.Point(3, 46);
            this.list_exam2.Name = "list_exam2";
            this.list_exam2.Size = new System.Drawing.Size(336, 37);
            this.list_exam2.TabIndex = 1;
            // 
            // list_exam3
            // 
            this.list_exam3.Exame = null;
            this.list_exam3.Location = new System.Drawing.Point(3, 89);
            this.list_exam3.Name = "list_exam3";
            this.list_exam3.Size = new System.Drawing.Size(336, 37);
            this.list_exam3.TabIndex = 2;
            // 
            // list_exam4
            // 
            this.list_exam4.Exame = null;
            this.list_exam4.Location = new System.Drawing.Point(3, 132);
            this.list_exam4.Name = "list_exam4";
            this.list_exam4.Size = new System.Drawing.Size(336, 37);
            this.list_exam4.TabIndex = 3;
            // 
            // list_exam5
            // 
            this.list_exam5.Exame = null;
            this.list_exam5.Location = new System.Drawing.Point(3, 175);
            this.list_exam5.Name = "list_exam5";
            this.list_exam5.Size = new System.Drawing.Size(336, 37);
            this.list_exam5.TabIndex = 4;
            // 
            // list_exam6
            // 
            this.list_exam6.Exame = null;
            this.list_exam6.Location = new System.Drawing.Point(3, 218);
            this.list_exam6.Name = "list_exam6";
            this.list_exam6.Size = new System.Drawing.Size(336, 37);
            this.list_exam6.TabIndex = 5;
            // 
            // frm_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 428);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.cbb_cargo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_lab";
            this.Text = "frm_lab";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox cbb_cargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private list_exam list_exam1;
        private list_exam list_exam2;
        private list_exam list_exam3;
        private list_exam list_exam4;
        private list_exam list_exam5;
        private list_exam list_exam6;
    }
}