namespace _2212453_NgoBaTai_Bai1
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDaNhap = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(254, 75);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(226, 20);
            this.txtTen.TabIndex = 0;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(116, 78);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(119, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Hãy nhập tên của bạn: ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(265, 123);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Xử lý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDaNhap
            // 
            this.lblDaNhap.AutoSize = true;
            this.lblDaNhap.Location = new System.Drawing.Point(116, 163);
            this.lblDaNhap.Name = "lblDaNhap";
            this.lblDaNhap.Size = new System.Drawing.Size(75, 13);
            this.lblDaNhap.TabIndex = 3;
            this.lblDaNhap.Text = "Bạn đã nhập: ";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(254, 163);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.Size = new System.Drawing.Size(226, 20);
            this.txtSaoChep.TabIndex = 4;
            this.txtSaoChep.TextChanged += new System.EventHandler(this.txtSaoChep_TextChanged);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Location = new System.Drawing.Point(383, 123);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(75, 23);
            this.btnSaoChep.TabIndex = 5;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.lblDaNhap);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDaNhap;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

