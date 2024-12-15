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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = 0;

            if (int.TryParse(textBox1.Text, out a1) == false)
            {
                MessageBox.Show("กรอกข้อมูลเป็นตัวเลข", "Error");
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("กรอกอักษระ", "Error");
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }
            label1.Text = ABC1(Convert.ToInt32(textBox1.Text), textBox2.Text, comboBox1.Text);
        }
        
        string ABC1(int size, string charc, string selectedItem)
        {

            string result = "";
            //selectedItem = comboBox1.Text;


            if (selectedItem == "A")
            {
                int width = size * 2; // ความกว้าง
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < width; j++)
                    {

                        if (i == 0 || i == size - 1 || j == 0 || j == width - 1)
                        {
                            result += charc;
                        }
                        else
                        {
                            result += "   ";
                        }
                    }
                    result += "\n";
                }
            }
            else if (selectedItem == "B")
            {
                for (int i = 0; i < size + 2; i++)
                {
                    for (int j = 0; j < size + 2; j++)
                    {
                        if (i == 0 || i == size + 1 || j == 0 || j == size + 1)
                            result += charc;
                        else
                            result += i;
                    }
                    result += "\n";
                }
            }
            else if (selectedItem == "C")
            {
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        result += charc;
                    }
                    result += "\n";
                }
            }
            else
            {
                MessageBox.Show("กรอกเลือกรูปแบบที่กำหนดไว้", "Error");


            }


            return result;
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            string[] ABC = { "A", "B", "C" };
            comboBox1.Items.AddRange(ABC);
        }
    }
}
