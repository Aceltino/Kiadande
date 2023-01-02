namespace KiaDande_Centro_Medico
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pass_admin = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.user_admin = new System.Windows.Forms.TextBox();
            this.check_ver_pass = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pass_cadastrar2 = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Label();
            this.cbb_cargo = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.email_cadastrar = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.Pass_cadastrar = new System.Windows.Forms.TextBox();
            this.user_cadastrar = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Label();
            this.check_showpass = new System.Windows.Forms.CheckBox();
            this.link_createaccount = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.lbl_authen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_register = new System.Windows.Forms.Panel();
            this.bt1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_login.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bt1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dados do Administrador";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel11, BunifuAnimatorNS.DecorationType.None);
            this.panel11.Location = new System.Drawing.Point(12, 375);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(270, 2);
            this.panel11.TabIndex = 22;
            // 
            // pass_admin
            // 
            this.pass_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.pass_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.pass_admin, BunifuAnimatorNS.DecorationType.None);
            this.pass_admin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_admin.ForeColor = System.Drawing.Color.Silver;
            this.pass_admin.Location = new System.Drawing.Point(12, 348);
            this.pass_admin.Multiline = true;
            this.pass_admin.Name = "pass_admin";
            this.pass_admin.Size = new System.Drawing.Size(268, 51);
            this.pass_admin.TabIndex = 21;
            this.pass_admin.Text = "Palavra-Passe";
            this.pass_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel10, BunifuAnimatorNS.DecorationType.None);
            this.panel10.Location = new System.Drawing.Point(12, 331);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(270, 2);
            this.panel10.TabIndex = 20;
            // 
            // user_admin
            // 
            this.user_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.user_admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.user_admin, BunifuAnimatorNS.DecorationType.None);
            this.user_admin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_admin.ForeColor = System.Drawing.Color.Silver;
            this.user_admin.Location = new System.Drawing.Point(12, 304);
            this.user_admin.Multiline = true;
            this.user_admin.Name = "user_admin";
            this.user_admin.Size = new System.Drawing.Size(268, 51);
            this.user_admin.TabIndex = 19;
            this.user_admin.Text = "ID Usuário ou Email";
            this.user_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check_ver_pass
            // 
            this.check_ver_pass.AutoSize = true;
            this.bt1.SetDecoration(this.check_ver_pass, BunifuAnimatorNS.DecorationType.None);
            this.check_ver_pass.FlatAppearance.BorderSize = 0;
            this.check_ver_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_ver_pass.ForeColor = System.Drawing.Color.Silver;
            this.check_ver_pass.Location = new System.Drawing.Point(12, 212);
            this.check_ver_pass.Name = "check_ver_pass";
            this.check_ver_pass.Size = new System.Drawing.Size(126, 17);
            this.check_ver_pass.TabIndex = 12;
            this.check_ver_pass.Text = "Mostar Palavra-Passe";
            this.check_ver_pass.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.panel9.Location = new System.Drawing.Point(12, 205);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 2);
            this.panel9.TabIndex = 18;
            // 
            // pass_cadastrar2
            // 
            this.pass_cadastrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.pass_cadastrar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.pass_cadastrar2, BunifuAnimatorNS.DecorationType.None);
            this.pass_cadastrar2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_cadastrar2.ForeColor = System.Drawing.Color.Silver;
            this.pass_cadastrar2.Location = new System.Drawing.Point(12, 178);
            this.pass_cadastrar2.Multiline = true;
            this.pass_cadastrar2.Name = "pass_cadastrar2";
            this.pass_cadastrar2.Size = new System.Drawing.Size(268, 51);
            this.pass_cadastrar2.TabIndex = 17;
            this.pass_cadastrar2.Text = "Reescreva a Palavra-Passe";
            this.pass_cadastrar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_change
            // 
            this.btn_change.AutoSize = true;
            this.bt1.SetDecoration(this.btn_change, BunifuAnimatorNS.DecorationType.None);
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.Color.Black;
            this.btn_change.Location = new System.Drawing.Point(274, 4);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(24, 24);
            this.btn_change.TabIndex = 16;
            this.btn_change.Text = "X";
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // cbb_cargo
            // 
            this.cbb_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.bt1.SetDecoration(this.cbb_cargo, BunifuAnimatorNS.DecorationType.None);
            this.cbb_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_cargo.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.cbb_cargo.ForeColor = System.Drawing.Color.Silver;
            this.cbb_cargo.FormattingEnabled = true;
            this.cbb_cargo.Items.AddRange(new object[] {
            "Enfermeiro",
            "Analista",
            "Médico",
            "Admin"});
            this.cbb_cargo.Location = new System.Drawing.Point(12, 235);
            this.cbb_cargo.Name = "cbb_cargo";
            this.cbb_cargo.Size = new System.Drawing.Size(268, 26);
            this.cbb_cargo.TabIndex = 15;
            this.cbb_cargo.Text = "Cargo";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.panel8.Location = new System.Drawing.Point(12, 106);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 2);
            this.panel8.TabIndex = 14;
            // 
            // email_cadastrar
            // 
            this.email_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.email_cadastrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.email_cadastrar, BunifuAnimatorNS.DecorationType.None);
            this.email_cadastrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_cadastrar.ForeColor = System.Drawing.Color.Silver;
            this.email_cadastrar.Location = new System.Drawing.Point(12, 79);
            this.email_cadastrar.Multiline = true;
            this.email_cadastrar.Name = "email_cadastrar";
            this.email_cadastrar.Size = new System.Drawing.Size(268, 51);
            this.email_cadastrar.TabIndex = 13;
            this.email_cadastrar.Text = "Email";
            this.email_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(12, 160);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 2);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Location = new System.Drawing.Point(12, 62);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 2);
            this.panel7.TabIndex = 9;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.bt1.SetDecoration(this.btn_register, BunifuAnimatorNS.DecorationType.None);
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(12, 400);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(268, 38);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Cadastrar";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // Pass_cadastrar
            // 
            this.Pass_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.Pass_cadastrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.Pass_cadastrar, BunifuAnimatorNS.DecorationType.None);
            this.Pass_cadastrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_cadastrar.ForeColor = System.Drawing.Color.Silver;
            this.Pass_cadastrar.Location = new System.Drawing.Point(12, 133);
            this.Pass_cadastrar.Multiline = true;
            this.Pass_cadastrar.Name = "Pass_cadastrar";
            this.Pass_cadastrar.Size = new System.Drawing.Size(268, 51);
            this.Pass_cadastrar.TabIndex = 7;
            this.Pass_cadastrar.Text = "Palavra-Passe";
            this.Pass_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_cadastrar
            // 
            this.user_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.user_cadastrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.user_cadastrar, BunifuAnimatorNS.DecorationType.None);
            this.user_cadastrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_cadastrar.ForeColor = System.Drawing.Color.Silver;
            this.user_cadastrar.Location = new System.Drawing.Point(12, 35);
            this.user_cadastrar.Multiline = true;
            this.user_cadastrar.Name = "user_cadastrar";
            this.user_cadastrar.Size = new System.Drawing.Size(268, 51);
            this.user_cadastrar.TabIndex = 6;
            this.user_cadastrar.Text = "ID Usuário";
            this.user_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.bt1.SetDecoration(this.btn_close, BunifuAnimatorNS.DecorationType.None);
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(273, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // check_showpass
            // 
            this.check_showpass.AutoSize = true;
            this.bt1.SetDecoration(this.check_showpass, BunifuAnimatorNS.DecorationType.None);
            this.check_showpass.FlatAppearance.BorderSize = 0;
            this.check_showpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_showpass.ForeColor = System.Drawing.Color.Silver;
            this.check_showpass.Location = new System.Drawing.Point(19, 195);
            this.check_showpass.Name = "check_showpass";
            this.check_showpass.Size = new System.Drawing.Size(126, 17);
            this.check_showpass.TabIndex = 12;
            this.check_showpass.Text = "Mostar Palavra-Passe";
            this.check_showpass.UseVisualStyleBackColor = true;
            // 
            // link_createaccount
            // 
            this.link_createaccount.AutoSize = true;
            this.bt1.SetDecoration(this.link_createaccount, BunifuAnimatorNS.DecorationType.None);
            this.link_createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_createaccount.LinkColor = System.Drawing.Color.Silver;
            this.link_createaccount.Location = new System.Drawing.Point(83, 382);
            this.link_createaccount.Name = "link_createaccount";
            this.link_createaccount.Size = new System.Drawing.Size(148, 17);
            this.link_createaccount.TabIndex = 11;
            this.link_createaccount.TabStop = true;
            this.link_createaccount.Text = "Cadastrar Funcionário";
            this.link_createaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_createaccount_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(19, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.bt1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(19, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 9;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.bt1.SetDecoration(this.btn_login, BunifuAnimatorNS.DecorationType.None);
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(19, 267);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(268, 38);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.txt_pass, BunifuAnimatorNS.DecorationType.None);
            this.txt_pass.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass.Location = new System.Drawing.Point(19, 155);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(268, 51);
            this.txt_pass.TabIndex = 7;
            this.txt_pass.Text = "Palavra-Passe";
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bt1.SetDecoration(this.txt_user, BunifuAnimatorNS.DecorationType.None);
            this.txt_user.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Silver;
            this.txt_user.Location = new System.Drawing.Point(19, 86);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(268, 51);
            this.txt_user.TabIndex = 6;
            this.txt_user.Text = "ID Usuário ou Email";
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.pnl_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_login.Controls.Add(this.btn_close);
            this.pnl_login.Controls.Add(this.check_showpass);
            this.pnl_login.Controls.Add(this.link_createaccount);
            this.pnl_login.Controls.Add(this.panel4);
            this.pnl_login.Controls.Add(this.panel3);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.txt_pass);
            this.pnl_login.Controls.Add(this.txt_user);
            this.bt1.SetDecoration(this.pnl_login, BunifuAnimatorNS.DecorationType.None);
            this.pnl_login.ForeColor = System.Drawing.Color.White;
            this.pnl_login.Location = new System.Drawing.Point(273, 1);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(302, 455);
            this.pnl_login.TabIndex = 4;
            this.pnl_login.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_login_Paint);
            // 
            // lbl_authen
            // 
            this.lbl_authen.AutoSize = true;
            this.bt1.SetDecoration(this.lbl_authen, BunifuAnimatorNS.DecorationType.None);
            this.lbl_authen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_authen.ForeColor = System.Drawing.Color.Gray;
            this.lbl_authen.Location = new System.Drawing.Point(124, 217);
            this.lbl_authen.Name = "lbl_authen";
            this.lbl_authen.Size = new System.Drawing.Size(93, 18);
            this.lbl_authen.TabIndex = 1;
            this.lbl_authen.Text = "Autenticação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bt1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(123, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "KIADANDE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bt1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(38, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "KD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lbl_authen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.bt1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 455);
            this.panel1.TabIndex = 3;
            // 
            // pnl_register
            // 
            this.pnl_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.pnl_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_register.Controls.Add(this.label6);
            this.pnl_register.Controls.Add(this.panel11);
            this.pnl_register.Controls.Add(this.pass_admin);
            this.pnl_register.Controls.Add(this.panel10);
            this.pnl_register.Controls.Add(this.user_admin);
            this.pnl_register.Controls.Add(this.check_ver_pass);
            this.pnl_register.Controls.Add(this.panel9);
            this.pnl_register.Controls.Add(this.pass_cadastrar2);
            this.pnl_register.Controls.Add(this.btn_change);
            this.pnl_register.Controls.Add(this.cbb_cargo);
            this.pnl_register.Controls.Add(this.panel8);
            this.pnl_register.Controls.Add(this.email_cadastrar);
            this.pnl_register.Controls.Add(this.panel6);
            this.pnl_register.Controls.Add(this.panel7);
            this.pnl_register.Controls.Add(this.btn_register);
            this.pnl_register.Controls.Add(this.Pass_cadastrar);
            this.pnl_register.Controls.Add(this.user_cadastrar);
            this.bt1.SetDecoration(this.pnl_register, BunifuAnimatorNS.DecorationType.None);
            this.pnl_register.ForeColor = System.Drawing.Color.White;
            this.pnl_register.Location = new System.Drawing.Point(273, 1);
            this.pnl_register.Name = "pnl_register";
            this.pnl_register.Size = new System.Drawing.Size(302, 455);
            this.pnl_register.TabIndex = 5;
            // 
            // bt1
            // 
            this.bt1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bt1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bt1.DefaultAnimation = animation1;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(577, 458);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_register);
            this.bt1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_register.ResumeLayout(false);
            this.pnl_register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private BunifuAnimatorNS.BunifuTransition bt1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox pass_admin;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox user_admin;
        private System.Windows.Forms.CheckBox check_ver_pass;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox pass_cadastrar2;
        private System.Windows.Forms.Label btn_change;
        private System.Windows.Forms.ComboBox cbb_cargo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox email_cadastrar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox Pass_cadastrar;
        private System.Windows.Forms.TextBox user_cadastrar;
        private System.Windows.Forms.Label btn_close;
        private System.Windows.Forms.CheckBox check_showpass;
        private System.Windows.Forms.LinkLabel link_createaccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_authen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_register;
    }
}