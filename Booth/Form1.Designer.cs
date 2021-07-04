namespace Booth
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBinary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.txtNhiPhanB = new System.Windows.Forms.TextBox();
            this.txtNhiPhanA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rTxtStep = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 625);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbBinary
            // 
            this.lbBinary.AutoSize = true;
            this.lbBinary.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBinary.Location = new System.Drawing.Point(183, 347);
            this.lbBinary.Name = "lbBinary";
            this.lbBinary.Size = new System.Drawing.Size(198, 19);
            this.lbBinary.TabIndex = 13;
            this.lbBinary.Text = "_____________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(22, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kết quả nhị phân:";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(183, 296);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(198, 19);
            this.lbKetQua.TabIndex = 11;
            this.lbKetQua.Text = "_____________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(15, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kết quả thập phân:";
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.Location = new System.Drawing.Point(187, 222);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(94, 50);
            this.btnGiai.TabIndex = 9;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // txtNhiPhanB
            // 
            this.txtNhiPhanB.Enabled = false;
            this.txtNhiPhanB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhiPhanB.Location = new System.Drawing.Point(187, 179);
            this.txtNhiPhanB.Name = "txtNhiPhanB";
            this.txtNhiPhanB.Size = new System.Drawing.Size(196, 27);
            this.txtNhiPhanB.TabIndex = 8;
            // 
            // txtNhiPhanA
            // 
            this.txtNhiPhanA.Enabled = false;
            this.txtNhiPhanA.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhiPhanA.Location = new System.Drawing.Point(187, 133);
            this.txtNhiPhanA.Name = "txtNhiPhanA";
            this.txtNhiPhanA.Size = new System.Drawing.Size(196, 27);
            this.txtNhiPhanA.TabIndex = 7;
            // 
            // txtSoB
            // 
            this.txtSoB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoB.Location = new System.Drawing.Point(187, 65);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(196, 27);
            this.txtSoB.TabIndex = 6;
            this.txtSoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoB_KeyPress);
            // 
            // txtSoA
            // 
            this.txtSoA.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoA.Location = new System.Drawing.Point(187, 19);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(196, 27);
            this.txtSoA.TabIndex = 5;
            this.txtSoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhị phân B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhị phân A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = " Nhập B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 68);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(961, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI THUẬT BOOTH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rTxtStep, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 557);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 557);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtNhiPhanA);
            this.panel4.Controls.Add(this.txtNhiPhanB);
            this.panel4.Controls.Add(this.txtSoA);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lbKetQua);
            this.panel4.Controls.Add(this.txtSoB);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbBinary);
            this.panel4.Controls.Add(this.btnGiai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 557);
            this.panel4.TabIndex = 15;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(442, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(519, 557);
            this.panel5.TabIndex = 16;
            // 
            // rTxtStep
            // 
            this.rTxtStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtStep.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtStep.Location = new System.Drawing.Point(3, 3);
            this.rTxtStep.Name = "rTxtStep";
            this.rTxtStep.Size = new System.Drawing.Size(513, 551);
            this.rTxtStep.TabIndex = 0;
            this.rTxtStep.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 625);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải thuật booth";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.TextBox txtNhiPhanB;
        private System.Windows.Forms.TextBox txtNhiPhanA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbBinary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox rTxtStep;
        private System.Windows.Forms.Panel panel4;

    }
}

