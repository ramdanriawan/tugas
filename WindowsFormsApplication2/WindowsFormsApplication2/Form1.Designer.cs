namespace WindowsFormsApplication2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.TextBox();
            this.harga_satuan = new System.Windows.Forms.TextBox();
            this.jumlah = new System.Windows.Forms.TextBox();
            this.diskon = new System.Windows.Forms.TextBox();
            this.total_bayar = new System.Windows.Forms.TextBox();
            this.pembayaran = new System.Windows.Forms.TextBox();
            this.kembalian = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama barang:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga satuan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diskon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Bayar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pembayaran:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kembalian:";
            // 
            // nama_barang
            // 
            this.nama_barang.Location = new System.Drawing.Point(117, 87);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(155, 20);
            this.nama_barang.TabIndex = 7;
            // 
            // harga_satuan
            // 
            this.harga_satuan.Location = new System.Drawing.Point(117, 126);
            this.harga_satuan.Name = "harga_satuan";
            this.harga_satuan.Size = new System.Drawing.Size(155, 20);
            this.harga_satuan.TabIndex = 8;
            // 
            // jumlah
            // 
            this.jumlah.Location = new System.Drawing.Point(116, 165);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(155, 20);
            this.jumlah.TabIndex = 9;
            // 
            // diskon
            // 
            this.diskon.Location = new System.Drawing.Point(116, 201);
            this.diskon.Name = "diskon";
            this.diskon.Size = new System.Drawing.Size(155, 20);
            this.diskon.TabIndex = 9;
            // 
            // total_bayar
            // 
            this.total_bayar.Location = new System.Drawing.Point(116, 240);
            this.total_bayar.Name = "total_bayar";
            this.total_bayar.Size = new System.Drawing.Size(155, 20);
            this.total_bayar.TabIndex = 9;
            // 
            // pembayaran
            // 
            this.pembayaran.Location = new System.Drawing.Point(116, 278);
            this.pembayaran.Name = "pembayaran";
            this.pembayaran.Size = new System.Drawing.Size(155, 20);
            this.pembayaran.TabIndex = 9;
            // 
            // kembalian
            // 
            this.kembalian.Location = new System.Drawing.Point(116, 318);
            this.kembalian.Name = "kembalian";
            this.kembalian.Size = new System.Drawing.Size(155, 20);
            this.kembalian.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hitung ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nama: ramdan riawan";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nim: 8020160186";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kembalian);
            this.Controls.Add(this.pembayaran);
            this.Controls.Add(this.total_bayar);
            this.Controls.Add(this.diskon);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.harga_satuan);
            this.Controls.Add(this.nama_barang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nama_barang;
        private System.Windows.Forms.TextBox harga_satuan;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.TextBox diskon;
        private System.Windows.Forms.TextBox total_bayar;
        private System.Windows.Forms.TextBox pembayaran;
        private System.Windows.Forms.TextBox kembalian;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

