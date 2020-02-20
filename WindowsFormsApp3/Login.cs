using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //視窗初始化

        }
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strAccount = tbAccount.Text;
            string strPassword = tbPassword.Text;
            string strMessage = "";

            string strUser1 = "dexter";
            string strPassword1 = "1234";

            strMessage = "Login Account :" + strAccount + "\n";

            
            if ((strAccount == "")||(strPassword==""))
            {
                strMessage = "Enter the details first";
            }
            else
            {
                if ((strAccount == strUser1) && (strPassword == strPassword1))
                {
                    
                    strMessage = "log in successfully.";
                       
                }
                else
                {
                    
                    if (strAccount != strUser1)
                    {
                        strMessage = "Wrong Account";
                    }
                    else
                    {
                        strMessage = "Wrong Password";
                    }
                }
            }

            lblMessage.Text = strMessage;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            tbAccount.Text = "";
            tbPassword.Text = "";
            lblMessage.Text = "Please Log in";
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Signup Sigup = new Signup();

            Sigup.Show();
            this.Hide();
;
        }
    }
}
