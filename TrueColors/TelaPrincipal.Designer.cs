
namespace TrueColors
{
    partial class TelaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblred = new System.Windows.Forms.Label();
            this.lblver = new System.Windows.Forms.Label();
            this.lblblu = new System.Windows.Forms.Label();
            this.lblni = new System.Windows.Forms.Label();
            this.cbxred = new System.Windows.Forms.TextBox();
            this.cbxblu = new System.Windows.Forms.TextBox();
            this.cbxver = new System.Windows.Forms.TextBox();
            this.hsbred = new System.Windows.Forms.HScrollBar();
            this.hsbver = new System.Windows.Forms.HScrollBar();
            this.hsbblu = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(228, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paleta De Cores";
            // 
            // lblred
            // 
            this.lblred.BackColor = System.Drawing.Color.Red;
            this.lblred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblred.Location = new System.Drawing.Point(112, 142);
            this.lblred.Name = "lblred";
            this.lblred.Size = new System.Drawing.Size(38, 23);
            this.lblred.TabIndex = 1;
            // 
            // lblver
            // 
            this.lblver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblver.Location = new System.Drawing.Point(112, 172);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(38, 23);
            this.lblver.TabIndex = 2;
            this.lblver.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblblu
            // 
            this.lblblu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblblu.Location = new System.Drawing.Point(112, 206);
            this.lblblu.Name = "lblblu";
            this.lblblu.Size = new System.Drawing.Size(38, 23);
            this.lblblu.TabIndex = 3;
            // 
            // lblni
            // 
            this.lblni.BackColor = System.Drawing.Color.Aqua;
            this.lblni.Location = new System.Drawing.Point(124, 252);
            this.lblni.Name = "lblni";
            this.lblni.Size = new System.Drawing.Size(589, 171);
            this.lblni.TabIndex = 4;
            // 
            // cbxred
            // 
            this.cbxred.Location = new System.Drawing.Point(171, 142);
            this.cbxred.Name = "cbxred";
            this.cbxred.Size = new System.Drawing.Size(67, 23);
            this.cbxred.TabIndex = 5;
            // 
            // cbxblu
            // 
            this.cbxblu.Location = new System.Drawing.Point(171, 206);
            this.cbxblu.Name = "cbxblu";
            this.cbxblu.Size = new System.Drawing.Size(67, 23);
            this.cbxblu.TabIndex = 6;
            // 
            // cbxver
            // 
            this.cbxver.Location = new System.Drawing.Point(171, 172);
            this.cbxver.Name = "cbxver";
            this.cbxver.Size = new System.Drawing.Size(67, 23);
            this.cbxver.TabIndex = 7;
            this.cbxver.TextChanged += new System.EventHandler(this.cbxver_TextChanged);
            // 
            // hsbred
            // 
            this.hsbred.LargeChange = 1;
            this.hsbred.Location = new System.Drawing.Point(307, 142);
            this.hsbred.Maximum = 255;
            this.hsbred.Name = "hsbred";
            this.hsbred.Size = new System.Drawing.Size(406, 22);
            this.hsbred.TabIndex = 8;
            this.hsbred.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbred_Scroll);
            // 
            // hsbver
            // 
            this.hsbver.LargeChange = 1;
            this.hsbver.Location = new System.Drawing.Point(307, 173);
            this.hsbver.Maximum = 255;
            this.hsbver.Name = "hsbver";
            this.hsbver.Size = new System.Drawing.Size(406, 22);
            this.hsbver.TabIndex = 9;
            this.hsbver.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbver_Scroll);
            // 
            // hsbblu
            // 
            this.hsbblu.LargeChange = 1;
            this.hsbblu.Location = new System.Drawing.Point(307, 206);
            this.hsbblu.Maximum = 255;
            this.hsbblu.Name = "hsbblu";
            this.hsbblu.Size = new System.Drawing.Size(406, 22);
            this.hsbblu.TabIndex = 10;
            this.hsbblu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbblu_Scroll);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hsbblu);
            this.Controls.Add(this.hsbver);
            this.Controls.Add(this.hsbred);
            this.Controls.Add(this.cbxver);
            this.Controls.Add(this.cbxblu);
            this.Controls.Add(this.cbxred);
            this.Controls.Add(this.lblni);
            this.Controls.Add(this.lblblu);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.lblred);
            this.Controls.Add(this.label1);
            this.Name = "TelaPrincipal";
            this.Text = "Cores 24 Bits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblred;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.Label lblblu;
        private System.Windows.Forms.Label lblni;
        private System.Windows.Forms.TextBox cbxred;
        private System.Windows.Forms.TextBox cbxblu;
        private System.Windows.Forms.TextBox cbxver;
        private System.Windows.Forms.HScrollBar hsbred;
        private System.Windows.Forms.HScrollBar hsbver;
        private System.Windows.Forms.HScrollBar hsbblu;
    }
}