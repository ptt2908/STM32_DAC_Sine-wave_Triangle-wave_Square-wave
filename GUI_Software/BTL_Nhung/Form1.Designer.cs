namespace BTL_Nhung
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
            this.btnload = new System.Windows.Forms.Button();
            this.txt_a1 = new System.Windows.Forms.TextBox();
            this.txt_f1 = new System.Windows.Forms.TextBox();
            this.txt_f2 = new System.Windows.Forms.TextBox();
            this.txt_a2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btndisconnect = new System.Windows.Forms.Button();
            this.lb_connect = new System.Windows.Forms.Label();
            this.selectCOM = new System.Windows.Forms.ComboBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label_load = new System.Windows.Forms.Label();
            this.CheckBox_Sine_DAC1 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Square_DAC1 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Triangle_DAC1 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Triangle_DAC2 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Square_DAC2 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Sine_DAC2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnload.Enabled = false;
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(440, 322);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(129, 75);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // txt_a1
            // 
            this.txt_a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a1.Location = new System.Drawing.Point(434, 58);
            this.txt_a1.Multiline = true;
            this.txt_a1.Name = "txt_a1";
            this.txt_a1.Size = new System.Drawing.Size(95, 53);
            this.txt_a1.TabIndex = 1;
            this.txt_a1.TextChanged += new System.EventHandler(this.txt_a1_TextChanged);
            // 
            // txt_f1
            // 
            this.txt_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f1.Location = new System.Drawing.Point(583, 58);
            this.txt_f1.Multiline = true;
            this.txt_f1.Name = "txt_f1";
            this.txt_f1.Size = new System.Drawing.Size(95, 53);
            this.txt_f1.TabIndex = 2;
            this.txt_f1.TextChanged += new System.EventHandler(this.txt_f1_TextChanged);
            // 
            // txt_f2
            // 
            this.txt_f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f2.Location = new System.Drawing.Point(583, 172);
            this.txt_f2.Multiline = true;
            this.txt_f2.Name = "txt_f2";
            this.txt_f2.Size = new System.Drawing.Size(95, 53);
            this.txt_f2.TabIndex = 4;
            this.txt_f2.TextChanged += new System.EventHandler(this.txt_f2_TextChanged);
            // 
            // txt_a2
            // 
            this.txt_a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a2.Location = new System.Drawing.Point(434, 172);
            this.txt_a2.Multiline = true;
            this.txt_a2.Name = "txt_a2";
            this.txt_a2.Size = new System.Drawing.Size(95, 53);
            this.txt_a2.TabIndex = 3;
            this.txt_a2.TextChanged += new System.EventHandler(this.txt_a2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "DAC1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "DAC2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "V";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "V";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hz";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hz";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btndisconnect);
            this.groupBox1.Controls.Add(this.lb_connect);
            this.groupBox1.Controls.Add(this.selectCOM);
            this.groupBox1.Controls.Add(this.btnconnect);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(314, 17);
            this.progressBar1.TabIndex = 5;
            // 
            // btndisconnect
            // 
            this.btndisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndisconnect.FlatAppearance.BorderSize = 2;
            this.btndisconnect.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisconnect.Location = new System.Drawing.Point(147, 105);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(173, 46);
            this.btndisconnect.TabIndex = 4;
            this.btndisconnect.Text = "DISCONNECT";
            this.btndisconnect.UseVisualStyleBackColor = false;
            this.btndisconnect.Click += new System.EventHandler(this.btndisconnect_Click);
            // 
            // lb_connect
            // 
            this.lb_connect.AutoSize = true;
            this.lb_connect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_connect.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_connect.Location = new System.Drawing.Point(107, 166);
            this.lb_connect.Name = "lb_connect";
            this.lb_connect.Size = new System.Drawing.Size(124, 25);
            this.lb_connect.TabIndex = 3;
            this.lb_connect.Text = "Disconnected";
            // 
            // selectCOM
            // 
            this.selectCOM.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCOM.FormattingEnabled = true;
            this.selectCOM.Location = new System.Drawing.Point(110, 29);
            this.selectCOM.Name = "selectCOM";
            this.selectCOM.Size = new System.Drawing.Size(121, 30);
            this.selectCOM.TabIndex = 2;
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.LimeGreen;
            this.btnconnect.FlatAppearance.BorderSize = 2;
            this.btnconnect.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect.Location = new System.Drawing.Point(6, 105);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(135, 46);
            this.btnconnect.TabIndex = 2;
            this.btnconnect.Text = "CONNECT";
            this.btnconnect.UseVisualStyleBackColor = false;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select";
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_load.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_load.Location = new System.Drawing.Point(608, 349);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(137, 25);
            this.label_load.TabIndex = 15;
            this.label_load.Text = "NOT LOADED";
            // 
            // CheckBox_Sine_DAC1
            // 
            this.CheckBox_Sine_DAC1.AutoSize = true;
            this.CheckBox_Sine_DAC1.Location = new System.Drawing.Point(730, 37);
            this.CheckBox_Sine_DAC1.Name = "CheckBox_Sine_DAC1";
            this.CheckBox_Sine_DAC1.Size = new System.Drawing.Size(67, 24);
            this.CheckBox_Sine_DAC1.TabIndex = 16;
            this.CheckBox_Sine_DAC1.Text = "Sine";
            this.CheckBox_Sine_DAC1.UseVisualStyleBackColor = true;
            this.CheckBox_Sine_DAC1.CheckedChanged += new System.EventHandler(this.CheckBox_Sine_DAC1_CheckedChanged);
            // 
            // CheckBox_Square_DAC1
            // 
            this.CheckBox_Square_DAC1.AutoSize = true;
            this.CheckBox_Square_DAC1.Location = new System.Drawing.Point(730, 67);
            this.CheckBox_Square_DAC1.Name = "CheckBox_Square_DAC1";
            this.CheckBox_Square_DAC1.Size = new System.Drawing.Size(87, 24);
            this.CheckBox_Square_DAC1.TabIndex = 17;
            this.CheckBox_Square_DAC1.Text = "Square";
            this.CheckBox_Square_DAC1.UseVisualStyleBackColor = true;
            this.CheckBox_Square_DAC1.CheckedChanged += new System.EventHandler(this.CheckBox_Square_DAC1_CheckedChanged);
            // 
            // CheckBox_Triangle_DAC1
            // 
            this.CheckBox_Triangle_DAC1.AutoSize = true;
            this.CheckBox_Triangle_DAC1.Location = new System.Drawing.Point(730, 97);
            this.CheckBox_Triangle_DAC1.Name = "CheckBox_Triangle_DAC1";
            this.CheckBox_Triangle_DAC1.Size = new System.Drawing.Size(91, 24);
            this.CheckBox_Triangle_DAC1.TabIndex = 18;
            this.CheckBox_Triangle_DAC1.Text = "Triangle";
            this.CheckBox_Triangle_DAC1.UseVisualStyleBackColor = true;
            this.CheckBox_Triangle_DAC1.CheckedChanged += new System.EventHandler(this.CheckBox_Triangle_DAC1_CheckedChanged);
            // 
            // CheckBox_Triangle_DAC2
            // 
            this.CheckBox_Triangle_DAC2.AutoSize = true;
            this.CheckBox_Triangle_DAC2.Location = new System.Drawing.Point(730, 208);
            this.CheckBox_Triangle_DAC2.Name = "CheckBox_Triangle_DAC2";
            this.CheckBox_Triangle_DAC2.Size = new System.Drawing.Size(91, 24);
            this.CheckBox_Triangle_DAC2.TabIndex = 21;
            this.CheckBox_Triangle_DAC2.Text = "Triangle";
            this.CheckBox_Triangle_DAC2.UseVisualStyleBackColor = true;
            this.CheckBox_Triangle_DAC2.CheckedChanged += new System.EventHandler(this.CheckBox_Triangle_DAC2_CheckedChanged);
            // 
            // CheckBox_Square_DAC2
            // 
            this.CheckBox_Square_DAC2.AutoSize = true;
            this.CheckBox_Square_DAC2.Location = new System.Drawing.Point(730, 178);
            this.CheckBox_Square_DAC2.Name = "CheckBox_Square_DAC2";
            this.CheckBox_Square_DAC2.Size = new System.Drawing.Size(87, 24);
            this.CheckBox_Square_DAC2.TabIndex = 20;
            this.CheckBox_Square_DAC2.Text = "Square";
            this.CheckBox_Square_DAC2.UseVisualStyleBackColor = true;
            this.CheckBox_Square_DAC2.CheckedChanged += new System.EventHandler(this.CheckBox_Square_DAC2_CheckedChanged);
            // 
            // CheckBox_Sine_DAC2
            // 
            this.CheckBox_Sine_DAC2.AutoSize = true;
            this.CheckBox_Sine_DAC2.Location = new System.Drawing.Point(730, 148);
            this.CheckBox_Sine_DAC2.Name = "CheckBox_Sine_DAC2";
            this.CheckBox_Sine_DAC2.Size = new System.Drawing.Size(67, 24);
            this.CheckBox_Sine_DAC2.TabIndex = 19;
            this.CheckBox_Sine_DAC2.Text = "Sine";
            this.CheckBox_Sine_DAC2.UseVisualStyleBackColor = true;
            this.CheckBox_Sine_DAC2.CheckedChanged += new System.EventHandler(this.CheckBox_Sine_DAC2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 511);
            this.Controls.Add(this.CheckBox_Triangle_DAC2);
            this.Controls.Add(this.CheckBox_Square_DAC2);
            this.Controls.Add(this.CheckBox_Sine_DAC2);
            this.Controls.Add(this.CheckBox_Triangle_DAC1);
            this.Controls.Add(this.CheckBox_Square_DAC1);
            this.Controls.Add(this.CheckBox_Sine_DAC1);
            this.Controls.Add(this.label_load);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_f2);
            this.Controls.Add(this.txt_a2);
            this.Controls.Add(this.txt_f1);
            this.Controls.Add(this.txt_a1);
            this.Controls.Add(this.btnload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.TextBox txt_a1;
        private System.Windows.Forms.TextBox txt_f1;
        private System.Windows.Forms.TextBox txt_f2;
        private System.Windows.Forms.TextBox txt_a2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btndisconnect;
        private System.Windows.Forms.Label lb_connect;
        private System.Windows.Forms.ComboBox selectCOM;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label_load;
        private System.Windows.Forms.CheckBox CheckBox_Sine_DAC1;
        private System.Windows.Forms.CheckBox CheckBox_Square_DAC1;
        private System.Windows.Forms.CheckBox CheckBox_Triangle_DAC1;
        private System.Windows.Forms.CheckBox CheckBox_Triangle_DAC2;
        private System.Windows.Forms.CheckBox CheckBox_Square_DAC2;
        private System.Windows.Forms.CheckBox CheckBox_Sine_DAC2;
    }
}

