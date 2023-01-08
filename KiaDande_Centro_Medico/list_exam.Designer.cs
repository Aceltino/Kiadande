namespace KiaDande_Centro_Medico
{
    partial class list_exam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_pos = new System.Windows.Forms.RadioButton();
            this.rbt_neg = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_exam
            // 
            this.lbl_exam.AutoSize = true;
            this.lbl_exam.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.lbl_exam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.lbl_exam.Location = new System.Drawing.Point(15, 5);
            this.lbl_exam.Name = "lbl_exam";
            this.lbl_exam.Size = new System.Drawing.Size(51, 23);
            this.lbl_exam.TabIndex = 4;
            this.lbl_exam.Text = "Exame";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 3);
            this.panel1.TabIndex = 6;
            // 
            // rbt_pos
            // 
            this.rbt_pos.AutoSize = true;
            this.rbt_pos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.rbt_pos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.rbt_pos.Location = new System.Drawing.Point(153, 3);
            this.rbt_pos.Name = "rbt_pos";
            this.rbt_pos.Size = new System.Drawing.Size(76, 27);
            this.rbt_pos.TabIndex = 7;
            this.rbt_pos.Text = "Positivo";
            this.rbt_pos.UseVisualStyleBackColor = true;
            // 
            // rbt_neg
            // 
            this.rbt_neg.AutoSize = true;
            this.rbt_neg.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.rbt_neg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.rbt_neg.Location = new System.Drawing.Point(237, 3);
            this.rbt_neg.Name = "rbt_neg";
            this.rbt_neg.Size = new System.Drawing.Size(82, 27);
            this.rbt_neg.TabIndex = 8;
            this.rbt_neg.Text = "Negativo";
            this.rbt_neg.UseVisualStyleBackColor = true;
            // 
            // list_exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbt_neg);
            this.Controls.Add(this.rbt_pos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_exam);
            this.Name = "list_exam";
            this.Size = new System.Drawing.Size(336, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_exam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_pos;
        private System.Windows.Forms.RadioButton rbt_neg;
    }
}
