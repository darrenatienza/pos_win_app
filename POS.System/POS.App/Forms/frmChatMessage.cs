using Helpers;
using POS.Queries.Core.Domain;
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
    public partial class frmChatMessage : Form
    {
        // current login user is admin
        string _currentUser;
        string _speakingWith;
        public frmChatMessage()
        {
            InitializeComponent();
        }

        public frmChatMessage(string _speakingWith)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this._speakingWith = _speakingWith;
            this._currentUser = CurrentUser.Name;
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             
        }

       

        private void frmChatPanel_Load(object sender, EventArgs e)
        {
            LoadConversation();
            
        }
        // Todo: create send logic
        private void LoadConversation()
        {
           
            using (var uow = new UnitOfWork(new DataContext()))
            {
                // get converstion
                var messageList = uow.ChatMessages.GetAllConversation(_currentUser,_speakingWith);
                var convo = "";
                foreach (var message in messageList)
                {
                    var messageIdentity = "";
                    if (message.UserNameSender == _currentUser)
                    {
                        messageIdentity = "You:";
                    }else{
                        messageIdentity = "From:" + message.UserNameSender;
                    }
                    convo += messageIdentity
                        + Environment.NewLine
                        + message.Message 
                        + Environment.NewLine
                        + message.CreateDateTime
                        + Environment.NewLine
                        + Environment.NewLine;
                    txtConverstation.Text = convo;
                }
            }
        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var msg = new ChatMessage();
                    msg.CreateDateTime = DateTime.Now;
                    msg.IsRead = false;
                    msg.Message = txtMessageInput.Text;
                    msg.UserNameReciever = _speakingWith;
                    msg.UserNameSender = _currentUser;
                    uow.ChatMessages.Add(msg);
                    uow.Complete();
                    LoadConversation();
                    txtMessageInput.Text = "";
                    SetCursorToEnd();
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
        // Scrolls to the bottom
        void SetCursorToEnd()
        {
            txtConverstation.SelectionStart = txtConverstation.Text.Length;
            txtConverstation.SelectionLength = 0;
            txtConverstation.ScrollToCaret();
        }

        private void frmChatMessage_Shown(object sender, EventArgs e)
        {
            SetCursorToEnd();
        }

        private async void txtMessageInput_Enter(object sender, EventArgs e)
        {
           // Set isRead to true of reciever (current user) from current sender
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {

                    await Task.Run(() => uow.ChatMessages.SetIsReadOfCurrentUser(_currentUser, _speakingWith));
                    await Task.Run(() => uow.Complete());
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private async void tmrTimeRefresh_Tick(object sender, EventArgs e)
        {
            bool x = await Task.Run(() => CurrentUserHasNewMessage());
            if (x)
            {
                LoadConversation();
                SetCursorToEnd();
            }
            
        }

        private bool CurrentUserHasNewMessage()
        {
            try
            {
                bool hasNewMessage = false;
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    hasNewMessage = uow.ChatMessages.CurrentUserHasNewMessage(_currentUser, _speakingWith);
                    
                }
                return hasNewMessage;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
