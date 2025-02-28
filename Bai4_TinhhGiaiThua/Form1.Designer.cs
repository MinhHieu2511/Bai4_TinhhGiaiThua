namespace Bai4_TinhhGiaiThua
{
    partial class Form1
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.Tính = new System.Windows.Forms.Button();
            this.trbSo = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbSo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(77, 11);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(125, 26);
            this.txtSo.TabIndex = 2;
            this.txtSo.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(77, 43);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(125, 26);
            this.txtKq.TabIndex = 2;
            // 
            // Tính
            // 
            this.Tính.Location = new System.Drawing.Point(54, 171);
            this.Tính.Name = "Tính";
            this.Tính.Size = new System.Drawing.Size(188, 85);
            this.Tính.TabIndex = 3;
            this.Tính.Text = "Tính giai thừa";
            this.Tính.UseVisualStyleBackColor = true;
            this.Tính.Click += new System.EventHandler(this.Tính_Click);
            // 
            // trbSo
            // 
            this.trbSo.Location = new System.Drawing.Point(208, 11);
            this.trbSo.Maximum = 100;
            this.trbSo.Name = "trbSo";
            this.trbSo.Size = new System.Drawing.Size(178, 45);
            this.trbSo.TabIndex = 4;
            this.trbSo.Scroll += new System.EventHandler(this.trbSo_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.trbSo);
            this.Controls.Add(this.Tính);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button Tính;
        private System.Windows.Forms.TrackBar trbSo;
    }
}

