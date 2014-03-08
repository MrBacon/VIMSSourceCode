using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VIMS.Class;

namespace VIMS
{
    public partial class frmLogin : Form
    {
        dbProcess MainDB = new dbProcess();
        dbUser LogUser=new dbUser ();

        bool LoginOk = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void UserLogin()
        {


            TxtUserName.Text = "image";
            TxtPassword.Text = "123456";

            if (TxtUserName.Text == "")
            {
                return;
            }

            if (TxtPassword.Text == "")
            {
                return;
            }

            LogUser.UserName = TxtUserName.Text .Trim();
            LogUser.Password = TxtPassword.Text.Trim();
            LoginOk=LogUser.ValidRegLogUser();
            
 
            if (LoginOk)
            {
                Program.UserName = LogUser.UserName;
                Program.LoginID = LogUser.LoginID;
                Program.LogType = LogUser.LogType;
                FrmMain MainForm = new FrmMain();
                this.Hide();
                MainForm.Show();
            }
            else
            {
                MessageBox.Show("Please check username and password","Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnOK_MouseMove(object sender, MouseEventArgs e)
        {
            BtnOK.BorderStyle = BorderStyle.FixedSingle;
        }

        private void BtnOK_MouseLeave(object sender, EventArgs e)
        {
            BtnOK.BorderStyle = BorderStyle.None;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            UserLogin();
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.BorderStyle = BorderStyle.None;
        }

        private void BtnExit_MouseMove(object sender, MouseEventArgs e)
        {
            BtnExit.BorderStyle = BorderStyle.FixedSingle;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin();
            }
        }

    }
}
