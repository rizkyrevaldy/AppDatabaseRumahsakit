namespace AppDatabaseRumahsakit
{
    partial class TransaksiForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbBiaya = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbPenyakit = new System.Windows.Forms.ComboBox();
            this.cbPasien = new System.Windows.Forms.ComboBox();
            this.cbDokter = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 156);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIP Dokter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kode Penyakit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 22, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Biaya";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cbPasien);
            this.flowLayoutPanel2.Controls.Add(this.cbDokter);
            this.flowLayoutPanel2.Controls.Add(this.cbPenyakit);
            this.flowLayoutPanel2.Controls.Add(this.tbBiaya);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(123, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(142, 156);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // tbBiaya
            // 
            this.tbBiaya.Location = new System.Drawing.Point(3, 120);
            this.tbBiaya.Name = "tbBiaya";
            this.tbBiaya.Size = new System.Drawing.Size(122, 20);
            this.tbBiaya.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPenyakit
            // 
            this.cbPenyakit.FormattingEnabled = true;
            this.cbPenyakit.Location = new System.Drawing.Point(3, 81);
            this.cbPenyakit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.cbPenyakit.MaxDropDownItems = 100;
            this.cbPenyakit.Name = "cbPenyakit";
            this.cbPenyakit.Size = new System.Drawing.Size(121, 21);
            this.cbPenyakit.TabIndex = 5;
            // 
            // cbPasien
            // 
            this.cbPasien.FormattingEnabled = true;
            this.cbPasien.Location = new System.Drawing.Point(3, 3);
            this.cbPasien.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.cbPasien.MaxDropDownItems = 100;
            this.cbPasien.Name = "cbPasien";
            this.cbPasien.Size = new System.Drawing.Size(121, 21);
            this.cbPasien.TabIndex = 6;
            // 
            // cbDokter
            // 
            this.cbDokter.FormattingEnabled = true;
            this.cbDokter.Location = new System.Drawing.Point(3, 42);
            this.cbDokter.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.cbDokter.MaxDropDownItems = 100;
            this.cbDokter.Name = "cbDokter";
            this.cbDokter.Size = new System.Drawing.Size(121, 21);
            this.cbDokter.TabIndex = 7;
            // 
            // TransaksiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TransaksiForm";
            this.Text = "TransaksiForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBiaya;
        private System.Windows.Forms.ComboBox cbPenyakit;
        private System.Windows.Forms.ComboBox cbPasien;
        private System.Windows.Forms.ComboBox cbDokter;
    }
}