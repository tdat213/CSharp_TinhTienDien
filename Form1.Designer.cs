namespace CSharp_TinhTienDien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSokWh = new TextBox();
            btnTinh = new Button();
            label3 = new Label();
            lblKQ = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 66);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhap so luong kWh :";
            // 
            // txtSokWh
            // 
            txtSokWh.Location = new Point(235, 63);
            txtSokWh.Name = "txtSokWh";
            txtSokWh.Size = new Size(200, 23);
            txtSokWh.TabIndex = 1;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(102, 106);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(87, 31);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 118);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Ket qua:";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(307, 118);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(38, 15);
            lblKQ.TabIndex = 6;
            lblKQ.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKQ);
            Controls.Add(label3);
            Controls.Add(btnTinh);
            Controls.Add(txtSokWh);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSokWh;
        private Button btnTinh;
        private Label label3;
        private Label lblKQ;
    }
}
