using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsString
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTrapezoidArea(); // เรียกใช้ Void Method
        }
        // ฟังก์ชันคำนวณพื้นที่สี่เหลี่ยมด้านไม่เท่าแบบ Void
        private void ShowTrapezoidArea()
        {
            // ตรวจสอบค่าที่กรอกใน TextBox
            if (!double.TryParse(textBox1.Text, out double base1))
            {
                MessageBox.Show("กรุณากรอกค่าฐานบนให้ถูกต้อง", "ข้อผิดพลาด");
                textBox1.Focus();
                return;
            }

            if (!double.TryParse(textBox2.Text, out double base2))
            {
                MessageBox.Show("กรุณากรอกค่าฐานล่างให้ถูกต้อง", "ข้อผิดพลาด");
                textBox2.Focus();
                return;
            }

            if (!double.TryParse(textBox3.Text, out double height))
            {
                MessageBox.Show("กรุณากรอกค่าความสูงให้ถูกต้อง", "ข้อผิดพลาด");
                textBox3.Focus();
                return;
            }

            // คำนวณพื้นที่สี่เหลี่ยมด้านไม่เท่า
            double area = 0.5 * (base1 + base2) * height;

            // แสดงผลใน Label
            label1.Text = area.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowCircularSectorArea(); // เรียกใช้ Void Method
        }
        // ฟังก์ชันคำนวณพื้นที่วงกลมเสี้ยวแบบ Void
        private void ShowCircularSectorArea()
        {
            if (!double.TryParse(textBox4.Text, out double radius))
            {
                MessageBox.Show("กรุณากรอกค่ารัศมีให้ถูกต้อง", "ข้อผิดพลาด");
                textBox1.Focus();
                return;
            }

            if (!double.TryParse(textBox5.Text, out double angle))
            {
                MessageBox.Show("กรุณากรอกค่ามุมให้ถูกต้อง", "ข้อผิดพลาด");
                textBox2.Focus();
                return;
            }

            double area = (angle / 360) * Math.PI * Math.Pow(radius, 2);

            // แสดงผลใน Label
            label1.Text = area.ToString("0.00");
        }
    }
}
