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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullname="" , firstname="" , lastname="" , title="";
            int x = 0;
            fullname = txtFullname.Text.Trim();

            if (fullname.StartsWith("นางสาว"))
            {
                x = 6;
                title = fullname.Substring(0, x);
                //fullname = fullname.Substring(6).Trim();
            }
            else if (fullname.StartsWith("นาง") || fullname.StartsWith("นาย"))
            {
                x = 3;
                title = fullname.Substring(0, x);
                //  fullname = fullname.Substring(3).Trim();
            }
            else if (fullname.StartsWith("เด็กชาย"))
            {
                x = 7;
                title = fullname.Substring(0, x);
                //  fullname = fullname.Substring(3).Trim();
            }
            else if (fullname.StartsWith("เด็กหญิง"))
            {
                x = 8;
                title = fullname.Substring(0, x);
                //  fullname = fullname.Substring(3).Trim();
            }
            else 
            {
                x = fullname.IndexOf(" ");
                x = fullname.LastIndexOf('.') + 1;
                title = fullname.Substring(0, x);
           
            }
            
            fullname = fullname.Substring(x).Trim();
            //MessageBox.Show(title + "\n" + fullname);

            x= fullname.IndexOf(" ");

            
            firstname = fullname.Substring(0,x).Trim();

            lastname = fullname.Substring(x).Trim();

            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }

        
    }
}
