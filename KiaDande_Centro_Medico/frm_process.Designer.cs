namespace KiaDande_Centro_Medico
{
    partial class frm_process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_process));
            this.lblEurico_Dande = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progress = new System.Windows.Forms.ProgressBar();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnl_botton = new System.Windows.Forms.Panel();
            this.lblAceltino_Quianvo = new System.Windows.Forms.Label();
            this.lbl_starting = new System.Windows.Forms.Label();
            this.bt1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnl_botton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEurico_Dande
            // 
            this.lblEurico_Dande.AutoSize = true;
            this.bt1.SetDecoration(this.lblEurico_Dande, BunifuAnimatorNS.DecorationType.None);
            this.lblEurico_Dande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEurico_Dande.ForeColor = System.Drawing.Color.White;
            this.lblEurico_Dande.Location = new System.Drawing.Point(26, 124);
            this.lblEurico_Dande.Name = "lblEurico_Dande";
            this.lblEurico_Dande.Size = new System.Drawing.Size(127, 20);
            this.lblEurico_Dande.TabIndex = 3;
            this.lblEurico_Dande.Text = "@Eurico_Dande";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.White;
            this.bt1.SetDecoration(this.progress, BunifuAnimatorNS.DecorationType.None);
            this.progress.Location = new System.Drawing.Point(121, 51);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(350, 17);
            this.progress.TabIndex = 0;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.White;
            this.pnl_top.Controls.Add(this.picLogo);
            this.bt1.SetDecoration(this.pnl_top, BunifuAnimatorNS.DecorationType.None);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(604, 254);
            this.pnl_top.TabIndex = 3;
            // 
            // picLogo
            // 
            this.bt1.SetDecoration(this.picLogo, BunifuAnimatorNS.DecorationType.None);
            this.picLogo.Image = global::KiaDande_Centro_Medico.Properties.Resources.logo_transparent;
            this.picLogo.Location = new System.Drawing.Point(121, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(350, 254);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnl_botton
            // 
            this.pnl_botton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.pnl_botton.Controls.Add(this.lblEurico_Dande);
            this.pnl_botton.Controls.Add(this.lblAceltino_Quianvo);
            this.pnl_botton.Controls.Add(this.lbl_starting);
            this.pnl_botton.Controls.Add(this.progress);
            this.bt1.SetDecoration(this.pnl_botton, BunifuAnimatorNS.DecorationType.None);
            this.pnl_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_botton.Location = new System.Drawing.Point(0, 254);
            this.pnl_botton.Name = "pnl_botton";
            this.pnl_botton.Size = new System.Drawing.Size(604, 149);
            this.pnl_botton.TabIndex = 4;
            // 
            // lblAceltino_Quianvo
            // 
            this.lblAceltino_Quianvo.AutoSize = true;
            this.bt1.SetDecoration(this.lblAceltino_Quianvo, BunifuAnimatorNS.DecorationType.None);
            this.lblAceltino_Quianvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceltino_Quianvo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAceltino_Quianvo.Location = new System.Drawing.Point(467, 124);
            this.lblAceltino_Quianvo.Name = "lblAceltino_Quianvo";
            this.lblAceltino_Quianvo.Size = new System.Drawing.Size(149, 20);
            this.lblAceltino_Quianvo.TabIndex = 2;
            this.lblAceltino_Quianvo.Text = "@Aceltino_Quianvo";
            // 
            // lbl_starting
            // 
            this.lbl_starting.AutoSize = true;
            this.bt1.SetDecoration(this.lbl_starting, BunifuAnimatorNS.DecorationType.None);
            this.lbl_starting.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_starting.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_starting.Location = new System.Drawing.Point(118, 31);
            this.lbl_starting.Name = "lbl_starting";
            this.lbl_starting.Size = new System.Drawing.Size(57, 18);
            this.lbl_starting.TabIndex = 1;
            this.lbl_starting.Text = "Starting...";
            // 
            // bt1
            // 
            this.bt1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.bt1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bt1.DefaultAnimation = animation1;
            // 
            // frm_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 403);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_botton);
            this.bt1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnl_botton.ResumeLayout(false);
            this.pnl_botton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEurico_Dande;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_botton;
        private System.Windows.Forms.Label lblAceltino_Quianvo;
        private System.Windows.Forms.Label lbl_starting;
        private System.Windows.Forms.PictureBox picLogo;
        private BunifuAnimatorNS.BunifuTransition bt1;
    }
}

