namespace KiaDande_Centro_Medico
{
    partial class frm_triagem
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbb_cargo = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(416, 397);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(268, 28);
            this.btn_login.TabIndex = 106;
            this.btn_login.Text = "Encaminhar ao Médico";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enfermeiro",
            "Analista",
            "Médico",
            "Admin"});
            this.comboBox1.Location = new System.Drawing.Point(422, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 27);
            this.comboBox1.TabIndex = 103;
            this.comboBox1.Text = "Estado";
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
            this.cbb_cargo.Location = new System.Drawing.Point(60, 93);
            this.cbb_cargo.Name = "cbb_cargo";
            this.cbb_cargo.Size = new System.Drawing.Size(275, 27);
            this.cbb_cargo.TabIndex = 102;
            this.cbb_cargo.Text = "Documento de Identificação";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel9.Location = new System.Drawing.Point(780, 165);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 2);
            this.panel9.TabIndex = 101;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Silver;
            this.textBox8.Location = new System.Drawing.Point(780, 138);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(268, 51);
            this.textBox8.TabIndex = 100;
            this.textBox8.Tag = "ID Usuário ou Email";
            this.textBox8.Text = "Frequência Cardíaca";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel10.Location = new System.Drawing.Point(784, 232);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(270, 2);
            this.panel10.TabIndex = 99;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Silver;
            this.textBox9.Location = new System.Drawing.Point(784, 205);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(268, 51);
            this.textBox9.TabIndex = 98;
            this.textBox9.Tag = "ID Usuário ou Email";
            this.textBox9.Text = "Tipo Sanguíneo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(422, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 95;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Silver;
            this.textBox4.Location = new System.Drawing.Point(422, 203);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(268, 51);
            this.textBox4.TabIndex = 94;
            this.textBox4.Tag = "ID Usuário ou Email";
            this.textBox4.Text = "Temperatura";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel8.Location = new System.Drawing.Point(422, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 2);
            this.panel8.TabIndex = 93;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Silver;
            this.textBox7.Location = new System.Drawing.Point(422, 138);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(268, 51);
            this.textBox7.TabIndex = 92;
            this.textBox7.Tag = "ID Usuário ou Email";
            this.textBox7.Text = "Peso";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel4.Location = new System.Drawing.Point(62, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 89;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(62, 138);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 51);
            this.textBox3.TabIndex = 88;
            this.textBox3.Tag = "ID Usuário ou Email";
            this.textBox3.Text = "Número de Identificação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.label3.Location = new System.Drawing.Point(428, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 31);
            this.label3.TabIndex = 87;
            this.label3.Text = "RECOLHA DE SINAIS VITAIS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel3.Location = new System.Drawing.Point(62, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 86;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Silver;
            this.txt_user.Location = new System.Drawing.Point(62, 203);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(268, 51);
            this.txt_user.TabIndex = 85;
            this.txt_user.Tag = "ID Usuário ou Email";
            this.txt_user.Text = "Nome Completo";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Enfermeiro",
            "Analista",
            "Médico",
            "Admin"});
            this.comboBox3.Location = new System.Drawing.Point(780, 93);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(270, 27);
            this.comboBox3.TabIndex = 108;
            this.comboBox3.Text = "Escala de Dor";
            // 
            // frm_triagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 428);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbb_cargo);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_user);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_triagem";
            this.Text = "frm_triagem";
            this.Load += new System.EventHandler(this.frm_triagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbb_cargo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}