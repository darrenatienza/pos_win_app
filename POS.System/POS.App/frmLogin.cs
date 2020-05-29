
using POS.App.Helpers;
using POS.Logic;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.App
{
    public partial class frmLogin : Form
    {
        public event EventHandler OnLoginSuccess;
        private bool isLogin;
        public frmLogin()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoginSuccess()
        {
            var handler = this.OnLoginSuccess;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // occurs when close button click
            if (!isLogin)
            {
                Application.Exit();
            }
        }

        private  void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }
        async void Login()
        {
            try
            {
                if (txtUserName.Text == string.Empty && txtPassword.Text == string.Empty)
                {
                    LocalUtils.ShowErrorMessage(this,"User Name or Password is empty");
                }
                else
                {
                    lblLoggingIn.Visible = true;
                    await Task.Run(() => Factories.CreateUser().LoginUser(txtUserName.Text, txtPassword.Text));
                    //if login success set isLogin to true
                    isLogin = true;
                    LoginSuccess();
                }
                
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }

            lblLoggingIn.Visible = false;
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
       
    }
}
