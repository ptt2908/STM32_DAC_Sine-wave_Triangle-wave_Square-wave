using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BTL_Nhung
{
    public partial class Form1 : Form
    {
        float a1 = 0, a2 = 0;
        float f1 = 0, f2 = 0;
        string a1_value, a2_value;
        string f1_value, f2_value;
        int select1 = 0, select2 = 0;
        int lenght = 0;
        string lenght_value;
        string header_value = "AB";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] myport = SerialPort.GetPortNames();
            selectCOM.Items.AddRange(myport);
            serialPort1.BaudRate = 115200;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            CheckBox_Sine_DAC1.CheckedChanged += CheckBox_Sine_DAC1_CheckedChanged;
            CheckBox_Square_DAC1.CheckedChanged += CheckBox_Square_DAC1_CheckedChanged;
            CheckBox_Triangle_DAC1.CheckedChanged += CheckBox_Triangle_DAC1_CheckedChanged;

            CheckBox_Sine_DAC2.CheckedChanged += CheckBox_Sine_DAC2_CheckedChanged;
            CheckBox_Square_DAC2.CheckedChanged += CheckBox_Square_DAC2_CheckedChanged;
            CheckBox_Triangle_DAC2.CheckedChanged += CheckBox_Triangle_DAC2_CheckedChanged;

        }

        private void txt_a2_TextChanged(object sender, EventArgs e)
        {
            label_load.Text = "NOT LOADED";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_f2_TextChanged(object sender, EventArgs e)
        {
            label_load.Text = "NOT LOADED";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void CheckBox_Sine_DAC1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Sine_DAC1.Checked)
            {
                CheckBox_Square_DAC1.Checked = false;
                CheckBox_Triangle_DAC1.Checked = false;
                label_load.Text = "NOT LOADED";
            }

        }

        private void CheckBox_Square_DAC1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Square_DAC1.Checked)
            {
                CheckBox_Sine_DAC1.Checked = false;
                CheckBox_Triangle_DAC1.Checked = false;
                label_load.Text = "NOT LOADED";
            }
        }

        private void CheckBox_Triangle_DAC1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Triangle_DAC1.Checked)
            {
                CheckBox_Square_DAC1.Checked = false;
                CheckBox_Sine_DAC1.Checked = false;
                label_load.Text = "NOT LOADED";
            }
        }

        private void CheckBox_Sine_DAC2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Sine_DAC2.Checked)
            {
                CheckBox_Square_DAC2.Checked = false;
                CheckBox_Triangle_DAC2.Checked = false;
                label_load.Text = "NOT LOADED";
            }
        }

        private void CheckBox_Square_DAC2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Square_DAC2.Checked)
            {
                CheckBox_Sine_DAC2.Checked = false;
                CheckBox_Triangle_DAC2.Checked = false;
                label_load.Text = "NOT LOADED";
            }
        }

        private void CheckBox_Triangle_DAC2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Triangle_DAC2.Checked)
            {
                CheckBox_Square_DAC2.Checked = false;
                CheckBox_Sine_DAC2.Checked = false;
                label_load.Text = "NOT LOADED";
            }
        }

        private void txt_f1_TextChanged(object sender, EventArgs e)
        {
            label_load.Text = "NOT LOADED";
        }

        private void txt_a1_TextChanged(object sender, EventArgs e)
        {
            label_load.Text = "NOT LOADED";
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            /*a1 = float.Parse(txt_a1.Text, CultureInfo.InvariantCulture);
            a2 = float.Parse(txt_a2.Text, CultureInfo.InvariantCulture);*/
            if (CheckBox_Sine_DAC1.Checked) select1 = 1;
            else if (CheckBox_Square_DAC1.Checked) select1 = 2;
            else if (CheckBox_Triangle_DAC1.Checked) select1 = 3;
            else select1 = 0;

            if (CheckBox_Sine_DAC2.Checked) select2 = 1;
            else if (CheckBox_Square_DAC2.Checked) select2 = 2;
            else if (CheckBox_Triangle_DAC2.Checked) select2 = 3;
            else select2 = 0;

            string a1_value = txt_a1.Text;
            string f1_value = txt_f1.Text;
            string a2_value = txt_a2.Text;
            string f2_value = txt_f2.Text;

            string sl1 = select1.ToString();
            string sl2 = select2.ToString();

            if ((txt_a1.Text.Length) * (txt_f1.Text.Length) == 0)
            {
                MessageBox.Show("Chi dung kenh DAC2");
                a1_value = "0";  f1_value = "0"; sl1 = "0";
                a1 = 0;
                a2 = float.Parse(txt_a2.Text, CultureInfo.InvariantCulture);
            }
            else if ((txt_a2.Text.Length) * (txt_f2.Text.Length) == 0)
            {
                MessageBox.Show("Chi dung kenh DAC1");
                a2_value = "0"; f2_value = "0"; sl2 = "0";
                a2 = 0;
                a1 = float.Parse(txt_a1.Text, CultureInfo.InvariantCulture);
            }
            else 
            {
                a1 = float.Parse(txt_a1.Text, CultureInfo.InvariantCulture);
                a2 = float.Parse(txt_a2.Text, CultureInfo.InvariantCulture);
            } 
            
            if (a1 > 1.5 | a2 > 1.5) MessageBox.Show("Biên độ max la 1.5. Vui lòng nhập lại!");
                
            else if (a1 < 0 | a2 < 0) MessageBox.Show("Biên độ không thể âm. Vui lòng nhập lại!");
            
            else
            {
                string sendtostm = $"a1={a1_value}|f1={f1_value}|select1={sl1}|a2={a2_value}|f2={f2_value}|select2={sl2}|\n\r";
                lenght = sendtostm.Length;
                lenght_value = lenght.ToString();
                string sendtostm2 = header_value + lenght_value + '|' + sendtostm;
                serialPort1.Write(sendtostm2);
                label_load.Text = "LOADED";
            }

        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = selectCOM.Text;
                serialPort1.Open();
                progressBar1.Value = 100;
                lb_connect.Text = "Connected";
                btnconnect.Enabled = false;
                btndisconnect.Enabled = true;
                btnload.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 0;
                serialPort1.Close();
                lb_connect.Text = "Disconnected";
                btnconnect.Enabled = true;
                btndisconnect.Enabled = false;
                btnload.Enabled = false;
                
                CheckBox_Sine_DAC1.Checked = false;
                CheckBox_Square_DAC1.Checked = false;
                CheckBox_Triangle_DAC1.Checked = false;
                CheckBox_Sine_DAC2.Checked = false;
                CheckBox_Square_DAC2.Checked = false;
                CheckBox_Triangle_DAC2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
