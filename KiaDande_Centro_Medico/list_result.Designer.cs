namespace KiaDande_Centro_Medico
{
    partial class list_result
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_exam = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_exam
            // 
            this.lbl_exam.AutoSize = true;
            this.lbl_exam.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.lbl_exam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.lbl_exam.Location = new System.Drawing.Point(16, 6);
            this.lbl_exam.Name = "lbl_exam";
            this.lbl_exam.Size = new System.Drawing.Size(51, 23);
            this.lbl_exam.TabIndex = 3;
            this.lbl_exam.Text = "Exame";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.lbl_res.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.lbl_res.Location = new System.Drawing.Point(179, 6);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(73, 23);
            this.lbl_res.TabIndex = 4;
            this.lbl_res.Text = "Resultado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 3);
            this.panel1.TabIndex = 5;
            // 
            // list_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_exam);
            this.Name = "list_result";
            this.Size = new System.Drawing.Size(272, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_exam;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Panel panel1;
    }
}
