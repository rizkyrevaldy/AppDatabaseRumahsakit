namespace AppDatabaseRumahsakit
{
    partial class PasienForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.tbUmur = new System.Windows.Forms.TextBox();
            this.tbBB = new System.Windows.Forms.TextBox();
            this.tbTB = new System.Windows.Forms.TextBox();
            this.cbGD = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 273);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Gol. Darah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tinggi Badan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Berat Badan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Umur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "No Telp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(92, 312);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tbNama);
            this.flowLayoutPanel2.Controls.Add(this.cbJK);
            this.flowLayoutPanel2.Controls.Add(this.tbAlamat);
            this.flowLayoutPanel2.Controls.Add(this.tbTelp);
            this.flowLayoutPanel2.Controls.Add(this.tbUmur);
            this.flowLayoutPanel2.Controls.Add(this.tbBB);
            this.flowLayoutPanel2.Controls.Add(this.tbTB);
            this.flowLayoutPanel2.Controls.Add(this.cbGD);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(145, 22);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 312);
            this.flowLayoutPanel2.TabIndex = 39;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(3, 3);
            this.tbNama.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(185, 20);
            this.tbNama.TabIndex = 2;
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cbJK.Location = new System.Drawing.Point(3, 41);
            this.cbJK.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(185, 21);
            this.cbJK.TabIndex = 41;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(3, 80);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(185, 20);
            this.tbAlamat.TabIndex = 42;
            // 
            // tbTelp
            // 
            this.tbTelp.Location = new System.Drawing.Point(3, 118);
            this.tbTelp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(185, 20);
            this.tbTelp.TabIndex = 43;
            // 
            // tbUmur
            // 
            this.tbUmur.Location = new System.Drawing.Point(3, 156);
            this.tbUmur.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tbUmur.Name = "tbUmur";
            this.tbUmur.Size = new System.Drawing.Size(185, 20);
            this.tbUmur.TabIndex = 44;
            // 
            // tbBB
            // 
            this.tbBB.Location = new System.Drawing.Point(3, 194);
            this.tbBB.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tbBB.Name = "tbBB";
            this.tbBB.Size = new System.Drawing.Size(185, 20);
            this.tbBB.TabIndex = 45;
            // 
            // tbTB
            // 
            this.tbTB.Location = new System.Drawing.Point(3, 232);
            this.tbTB.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tbTB.Name = "tbTB";
            this.tbTB.Size = new System.Drawing.Size(185, 20);
            this.tbTB.TabIndex = 46;
            // 
            // cbGD
            // 
            this.cbGD.FormattingEnabled = true;
            this.cbGD.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cbGD.Location = new System.Drawing.Point(3, 270);
            this.cbGD.Name = "cbGD";
            this.cbGD.Size = new System.Drawing.Size(185, 21);
            this.cbGD.TabIndex = 40;
            // 
            // PasienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 402);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "PasienForm";
            this.Text = "PasienForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox cbGD;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.TextBox tbUmur;
        private System.Windows.Forms.TextBox tbBB;
        private System.Windows.Forms.TextBox tbTB;
    }
}