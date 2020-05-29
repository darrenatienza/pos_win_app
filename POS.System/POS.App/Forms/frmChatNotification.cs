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

namespace POS.App.Forms
{
    public partial class frmChatNotification : Form
    {
        private int interval;
        private string _currentUser;
        public frmChatNotification()
        {
            InitializeComponent();
        }

        private void tmrTimeOut_Tick(object sender, EventArgs e)
        {
            tmrClose.Start();
        }

        private void tmrClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else { this.Close(); }
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                tmrShow.Stop();
            }
        }

        private void frmChatNotification_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            tmrShow.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tmrClose.Start();
        }

        private async void tmrMessageChecker_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
