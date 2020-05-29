using Helpers;
using POS.App.Helpers;
using POS.Logic;
using POS.Logic.Models;
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
    public partial class frmChatPanel : Form
    {
        public event EventHandler OnCheckUnReadMessage;
        private bool isLogin;
        private int _userID;
        public frmChatPanel()
        {
            InitializeComponent();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        void CheckUnreadMessage()
        {
            var handler = this.OnCheckUnReadMessage;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        void LoadList()
        {
            
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var list = Factories.CreateUser().GetUserChatList(CurrentUser.Name);
                    int count = 0;
                    gridChat.Rows.Clear();
                    foreach (UserChatListModel item in list)
                    {
                        count++;
                        gridChat.Rows.Add(new string[] { 
                            item.UserID.ToString(),
                            count.ToString(),
                            item.UserName,
                            item.IsOnline ? "Online" : "Offline",
                            item.UnReadMessageCount.ToString()});
                    }
                    // Get Offline and Online Counts and set to labels

                    var onlineCount = list.Where(x => x.IsOnline).Count();
                    var offlineCount = list.Where(x => !x.IsOnline).Count();
                    lblOffline.Text = offlineCount.ToString();
                    lblOnline.Text = onlineCount.ToString();
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmChatPanel_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gridChat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            try
            {
                var grid = gridChat;

                if (grid.SelectedRows.Count > 0)
                {
                    _userID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (_userID != 0)
                    {
                        var user = Factories.CreateUser().GetUser(_userID);
                        if (user.UserName == CurrentUser.Name)
                        {
                            LocalUtils.ShowErrorMessage(this, "You cannot message your self!");
                        }
                        else
                        {
                            CheckUnreadMessage();
                            var frmChatMessage = new frmChatMessage(user.UserName);
                            frmChatMessage.Show();
                        }

                    }


                }
                else
                {
                    LocalUtils.ShowNoRecordSelectedMessage(this);
                }

            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewCombo_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
