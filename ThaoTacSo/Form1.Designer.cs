namespace ThaoTacSo
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
            this.components = new System.ComponentModel.Container();
            this.lb_songuyen = new System.Windows.Forms.Label();
            this.bt_tpt = new System.Windows.Forms.Button();
            this.tb_songuyen = new System.Windows.Forms.TextBox();
            this.bt_capnhap = new System.Windows.Forms.Button();
            this.lst_ketqua = new System.Windows.Forms.ListBox();
            this.bt_xptdc = new System.Windows.Forms.Button();
            this.bt_xptd = new System.Windows.Forms.Button();
            this.bt_kt = new System.Windows.Forms.Button();
            this.bt_xptc = new System.Windows.Forms.Button();
            this.bt_cslc = new System.Windows.Forms.Button();
            this.bt_csdc = new System.Windows.Forms.Button();
            this.erp_songuyen = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erp_songuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_songuyen
            // 
            this.lb_songuyen.AutoSize = true;
            this.lb_songuyen.Location = new System.Drawing.Point(35, 36);
            this.lb_songuyen.Name = "lb_songuyen";
            this.lb_songuyen.Size = new System.Drawing.Size(128, 20);
            this.lb_songuyen.TabIndex = 0;
            this.lb_songuyen.Text = "Nhập số nguyên:";
            // 
            // bt_tpt
            // 
            this.bt_tpt.Location = new System.Drawing.Point(450, 118);
            this.bt_tpt.Name = "bt_tpt";
            this.bt_tpt.Size = new System.Drawing.Size(223, 44);
            this.bt_tpt.TabIndex = 2;
            this.bt_tpt.Text = "Tăng mỗi phần tử lên 2";
            this.bt_tpt.UseVisualStyleBackColor = true;
            this.bt_tpt.Click += new System.EventHandler(this.bt_tpt_Click);
            // 
            // tb_songuyen
            // 
            this.tb_songuyen.Location = new System.Drawing.Point(192, 36);
            this.tb_songuyen.Name = "tb_songuyen";
            this.tb_songuyen.Size = new System.Drawing.Size(218, 26);
            this.tb_songuyen.TabIndex = 3;
            // 
            // bt_capnhap
            // 
            this.bt_capnhap.Location = new System.Drawing.Point(505, 36);
            this.bt_capnhap.Name = "bt_capnhap";
            this.bt_capnhap.Size = new System.Drawing.Size(107, 44);
            this.bt_capnhap.TabIndex = 4;
            this.bt_capnhap.Text = "Cập nhập";
            this.bt_capnhap.UseVisualStyleBackColor = true;
            this.bt_capnhap.Click += new System.EventHandler(this.bt_capnhap_Click);
            // 
            // lst_ketqua
            // 
            this.lst_ketqua.FormattingEnabled = true;
            this.lst_ketqua.ItemHeight = 20;
            this.lst_ketqua.Location = new System.Drawing.Point(39, 87);
            this.lst_ketqua.Name = "lst_ketqua";
            this.lst_ketqua.Size = new System.Drawing.Size(186, 264);
            this.lst_ketqua.TabIndex = 5;
            // 
            // bt_xptdc
            // 
            this.bt_xptdc.Location = new System.Drawing.Point(450, 338);
            this.bt_xptdc.Name = "bt_xptdc";
            this.bt_xptdc.Size = new System.Drawing.Size(223, 44);
            this.bt_xptdc.TabIndex = 6;
            this.bt_xptdc.Text = "Xóa phần tử đang chọn";
            this.bt_xptdc.UseVisualStyleBackColor = true;
            this.bt_xptdc.Click += new System.EventHandler(this.bt_xptdc_Click);
            // 
            // bt_xptd
            // 
            this.bt_xptd.Location = new System.Drawing.Point(450, 405);
            this.bt_xptd.Name = "bt_xptd";
            this.bt_xptd.Size = new System.Drawing.Size(223, 44);
            this.bt_xptd.TabIndex = 7;
            this.bt_xptd.Text = "Xóa phần tử đầu";
            this.bt_xptd.UseVisualStyleBackColor = true;
            this.bt_xptd.Click += new System.EventHandler(this.bt_xptd_Click);
            // 
            // bt_kt
            // 
            this.bt_kt.Location = new System.Drawing.Point(206, 576);
            this.bt_kt.Name = "bt_kt";
            this.bt_kt.Size = new System.Drawing.Size(344, 44);
            this.bt_kt.TabIndex = 8;
            this.bt_kt.Text = "Kết thúc";
            this.bt_kt.UseVisualStyleBackColor = true;
            this.bt_kt.Click += new System.EventHandler(this.bt_kt_Click);
            // 
            // bt_xptc
            // 
            this.bt_xptc.Location = new System.Drawing.Point(450, 483);
            this.bt_xptc.Name = "bt_xptc";
            this.bt_xptc.Size = new System.Drawing.Size(223, 44);
            this.bt_xptc.TabIndex = 9;
            this.bt_xptc.Text = "Xóa phần tử cuối";
            this.bt_xptc.UseVisualStyleBackColor = true;
            this.bt_xptc.Click += new System.EventHandler(this.bt_xptc_Click);
            // 
            // bt_cslc
            // 
            this.bt_cslc.Location = new System.Drawing.Point(450, 267);
            this.bt_cslc.Name = "bt_cslc";
            this.bt_cslc.Size = new System.Drawing.Size(223, 44);
            this.bt_cslc.TabIndex = 10;
            this.bt_cslc.Text = "Chọn số lẻ cuối";
            this.bt_cslc.UseVisualStyleBackColor = true;
            this.bt_cslc.Click += new System.EventHandler(this.bt_cslc_Click);
            // 
            // bt_csdc
            // 
            this.bt_csdc.Location = new System.Drawing.Point(450, 188);
            this.bt_csdc.Name = "bt_csdc";
            this.bt_csdc.Size = new System.Drawing.Size(223, 44);
            this.bt_csdc.TabIndex = 11;
            this.bt_csdc.Text = "Chọn số chẳn đầu";
            this.bt_csdc.UseVisualStyleBackColor = true;
            this.bt_csdc.Click += new System.EventHandler(this.bt_csdc_Click);
            // 
            // erp_songuyen
            // 
            this.erp_songuyen.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.bt_csdc);
            this.Controls.Add(this.bt_cslc);
            this.Controls.Add(this.bt_xptc);
            this.Controls.Add(this.bt_kt);
            this.Controls.Add(this.bt_xptd);
            this.Controls.Add(this.bt_xptdc);
            this.Controls.Add(this.lst_ketqua);
            this.Controls.Add(this.bt_capnhap);
            this.Controls.Add(this.tb_songuyen);
            this.Controls.Add(this.bt_tpt);
            this.Controls.Add(this.lb_songuyen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp_songuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_songuyen;
        private System.Windows.Forms.Button bt_tpt;
        private System.Windows.Forms.TextBox tb_songuyen;
        private System.Windows.Forms.Button bt_capnhap;
        private System.Windows.Forms.ListBox lst_ketqua;
        private System.Windows.Forms.Button bt_xptdc;
        private System.Windows.Forms.Button bt_xptd;
        private System.Windows.Forms.Button bt_kt;
        private System.Windows.Forms.Button bt_xptc;
        private System.Windows.Forms.Button bt_cslc;
        private System.Windows.Forms.Button bt_csdc;
        private System.Windows.Forms.ErrorProvider erp_songuyen;
    }
}

