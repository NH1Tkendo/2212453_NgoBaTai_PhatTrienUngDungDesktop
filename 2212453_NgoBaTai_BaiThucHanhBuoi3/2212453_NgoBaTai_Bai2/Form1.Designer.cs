namespace _2212453_NgoBaTai_Bai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.btnToMau = new System.Windows.Forms.Button();
            this.txtToMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Location = new System.Drawing.Point(188, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(19, 33);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(19, 56);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 0;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnToMau);
            this.groupBox2.Controls.Add(this.rbXanh);
            this.groupBox2.Controls.Add(this.rbDo);
            this.groupBox2.Location = new System.Drawing.Point(188, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn màu";
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Location = new System.Drawing.Point(19, 67);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(72, 17);
            this.rbXanh.TabIndex = 0;
            this.rbXanh.TabStop = true;
            this.rbXanh.Text = "Màu xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(19, 33);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(62, 17);
            this.rbDo.TabIndex = 0;
            this.rbDo.TabStop = true;
            this.rbDo.Text = "Màu đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(107, 45);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(75, 23);
            this.btnToMau.TabIndex = 1;
            this.btnToMau.Text = "Tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // txtToMau
            // 
            this.txtToMau.Location = new System.Drawing.Point(460, 204);
            this.txtToMau.Multiline = true;
            this.txtToMau.Name = "txtToMau";
            this.txtToMau.ReadOnly = true;
            this.txtToMau.Size = new System.Drawing.Size(208, 100);
            this.txtToMau.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtToMau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnToMau;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.TextBox txtToMau;
    }
}

