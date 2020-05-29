using Helpers;
using POS.App.Forms;
using POS.App.Helpers;
using POS.App.Helpers.Themes;
using POS.App.Properties;
using POS.Logic;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.App
{
    public partial class frmDashboard : Form
    {
        string _currentUser;
        private DateTime expDate;

        public frmDashboard()
        {
            
            InitializeComponent();
            _currentUser = CurrentUser.Name;
            expDate = DateTime.Parse("2020-04-20");

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ResizeSideBar();

        }
        private void ResizeSideBar()
        {
            const int maxSize = (int)SideBar.maxSize;
            const int minSize = (int)SideBar.minSize;
            switch (pnlSideBar.Width)
            {
                case maxSize:
                    //reduce the size of side bar
                    pnlSideBar.Width = minSize; 
                    //hide the avatar
                    pictureBox1.Visible = false;
                    btnArrow.Image = Resources.arrow_31_256_white;
                    break;
                default:
                    //show the avatar
                    pictureBox1.Visible = true;
                    //increase the size of side bar
                    pnlSideBar.Width = maxSize;
                    btnArrow.Image = Resources.arrow_96_256_white;
                    break;
            }
            // Center controls horizontally
            this.CenterPanels();
        }
        
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    // restore the default windows state
                    this.WindowState = FormWindowState.Normal;
                    // change image to maximized
                    btnMaximize.Image = Resources.maximize_window_48;
                    break;
                default:
                    // restore the maximized windows state
                    this.WindowState = FormWindowState.Maximized;
                    // change image to restore
                    btnMaximize.Image = Resources.restore_window_48;
                    break;
            }
            //Center controls horizontally
            this.CenterPanels();
             
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Factories.CreateUser().SetOnlineStatus(CurrentUser.Name, false);
            Application.Exit();
            
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShowMoreMenus_Click(object sender, EventArgs e)
        {
            ResizeSideBar();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
           
        }

       

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            this.tp.SetPage(tabDashboard);
            SetPageTitle("Dashboard Statistic Overview");
            this.CenterPanels();
            SetDashboardSummary();
        }
        void SetPageTitle(string title)
        {
            lblPageTitle.Text = title;
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //CheckTrialVersion();
            ShowLogin();

            CenterPanels();
            SetDashboardSummary();
            ResizeSideBar();
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            tp.SetPage(tabSetting);
            CenterPanels();
            SetPageTitle("Settings");
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.tp.SetPage(tabSales);
            SetPageTitle("Sales");
            this.CenterPanels();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            tp.SetPage(tabInventory);
            SetPageTitle("Inventories");
            this.CenterPanels();
            
        }

        

        private void btnProductManager_Click(object sender, EventArgs e)
        {
            if (!AdminCheck())
            {
                return;
            }
            new frmProductManager().ShowDialog();
        }

        private void btnSupplierManager_Click(object sender, EventArgs e)
        {
            if (!AdminCheck())
            {
                return;
            }
            var form = new frmSupplierManager();
            form.ShowDialog();

        }
        void CenterPanels()
        {
            //LocalUtils.CenterControlXY(tabSales, pnlSalesContents);
            //LocalUtils.CenterControlXY(tabDashboard, pnlDashboardContents);
            //LocalUtils.CenterControlXY(tabInventory, pnlInventoryContents);
            //LocalUtils.CenterControlXY(tabSetting, pnlSettingContents);
            //LocalUtils.CenterControlXY(tabAbout, pnlAbout);
            //LocalUtils.CenterControlXY(tabAbout, pagesAbout);
        }

        private void tp_Resize(object sender, EventArgs e)
        {
            this.CenterPanels();
        }
        private void SetOpacityToImage(PictureBox pic, int opacity)
        {
            Image original = null;
            if (original == null) original = (Bitmap)pic.Image.Clone();
            pic.BackColor = Color.Transparent;
            pic.Image = SetAlpha((Bitmap)original, opacity);
        }
        private Image SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = { 
        new float[] {1, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, a, 0}, 
        new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }
        private void setting1_Load(object sender, EventArgs e)
        {


        }

        private void tp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void supplierManager1_Load(object sender, EventArgs e)
        {

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmPos frm = new frmPos();
            frm.ShowDialog();
        }

        private void btnPreviousTransaction_Click(object sender, EventArgs e)
        {
            if (!AdminCheck())
            {
                return;
            }
            var form = new frmSaleTransaction();
            form.ShowDialog();
           
        }
        bool AdminCheck()
        {
            if (!CurrentUser.HasRoles("Administrator"))
            {
                LocalUtils.ShowErrorMessage(this, "Your not allowed for this action!");
                return false;
            }
            return true;
        }
        private async void tmrChatNotification_Tick(object sender, EventArgs e)
        {
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    _currentUser = CurrentUser.Name;
                    var unNotifiedMessages = await Task.Run(() => uow.ChatMessages.GetAll(false, _currentUser));
                    if (unNotifiedMessages.Count() > 0)
                    {
                        foreach (var msg in unNotifiedMessages)
                        {
                            msg.IsNotified = true;
                            uow.ChatMessages.Edit(msg);
                            uow.Complete();
                        }
                        var chatNotificationForm = new frmChatNotification();
                        chatNotificationForm.TopMost = true;
                        chatNotificationForm.Show();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        void CheckUnReadMessages()
        {
            var hasUnreadMessages = Factories.CreateChat().HasUnreadMessages(CurrentUser.Name);
            if (hasUnreadMessages)
            {
                btnChatPanel.Image = Resources.mail_2_256_green;
            }
            else
            {
                btnChatPanel.Image = Resources.mail_2_256_gray;
            }
        }

        private void frmDashboard_Shown(object sender, EventArgs e)
        {
            
            SetBgOpacity();
        }
        private void CheckTrialVersion()
        {
            if (expDate.Date <= DateTime.Now.Date)
            {
                LocalUtils.ShowErrorMessage(this, "Your trial version has been ended! Please contact developer.");
                Application.Exit();
            }
            else
            {
                LocalUtils.ShowInfo(this, "This application is a trial version and will be expired on " + expDate.ToString("MMMM dd, yyyy"));
            }
        }
        private void SetBgOpacity()
        {
            SetOpacityToImage(picBg1, 215);
            SetOpacityToImage(picBg2, 215);
            SetOpacityToImage(picBg3, 215);
            SetOpacityToImage(picBg4, 215);
            SetOpacityToImage(picBg5, 215);
            SetOpacityToImage(picBg6, 215);
            SetOpacityToImage(picBg7, 215);
            SetOpacityToImage(picBg8, 215);
            SetOpacityToImage(picBg9, 215);
            SetOpacityToImage(picBg10, 215);
            SetOpacityToImage(picBg11, 215);
        }

        private void frmLogin_OnLoginSuccess(object sender, EventArgs e)
        {
            ((frmLogin)sender).Close();
            tmrChatNotification.Enabled = true;
            this.Visible = true;
            CheckUnReadMessages();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!AdminCheck())
            {
                return;
            }
            var frm = new frmUserManager();
            frm.ShowDialog();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Factories.CreateUser().SetOnlineStatus(CurrentUser.Name, false);
            this.Visible = false;
            ShowLogin();
        }

        private void ShowLogin()
        {
            var frmLogin = new frmLogin();
            frmLogin.OnLoginSuccess += frmLogin_OnLoginSuccess;
            frmLogin.ShowDialog();
        }

        private void btnChatPanel_Click(object sender, EventArgs e)
        {
            var frmChat = new frmChatPanel();
            frmChat.OnCheckUnReadMessage += frmChat_OnCheckUnReadMessage;
            frmChat.ShowDialog();
        }

        void frmChat_OnCheckUnReadMessage(object sender, EventArgs e)
        {
            CheckUnReadMessages();
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX13_Click(object sender, EventArgs e)
        {

        }
        async void SetDashboardSummary()
        {
            await Task.Delay(500);
            var productCount = await Task.Run(() => Factories.CreateProducts().GetProductList("").Count);
            var userCount = await Task.Run(() => Factories.CreateUser().GetUserList("").Count);
            var posTransactionSummary = await Task.Run(() => Factories.CreatePosTransaction().GetPosTransactionSummary());
            lblTansactionSaleToday.Text = posTransactionSummary.SaleToday.ToString();
            lblTansactionSaleWeek.Text = posTransactionSummary.SaleWeek.ToString();
            lblTansactionSaleMonth.Text = posTransactionSummary.SaleMonth.ToString();
            lblProductCount.Text = productCount.ToString();
            lblUserCount.Text = userCount.ToString();

        }

       

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            tp.SetPage(tabAbout);
            CenterPanels();
            SetPageTitle("About");
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            CenterPanels();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            if (!AdminCheck())
            {
                return;
            }
            var form = new frmMemberManager();
            form.ShowDialog();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAboutCompany_Click(object sender, EventArgs e)
        {
            pagesAbout.SetPage(pageCompany);
        }

        private void btnAboutProponents_Click(object sender, EventArgs e)
        {
            pagesAbout.SetPage(pageProponents);
        }

        private void btnWhatAreWe_Click(object sender, EventArgs e)
        {
            pagesCompany.SetPage(pageWhoAreWe);
        }

        private void btnVision_Click(object sender, EventArgs e)
        {
            pagesCompany.SetPage(pageMission1);
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            pagesCompany.SetPage(pageVision);
        }

        private void btnWhatWeOffer_Click(object sender, EventArgs e)
        {
            pagesCompany.SetPage(pageWhatWeOffer);
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            pagesCompany.SetPage(pageLocation);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pagesCompany.SetPage(pageContactUs);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
