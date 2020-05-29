using MetroFramework;
using Microsoft.Reporting.WinForms;
using POS.App.Reports;
using POS.App.UserControls.MyControls;
using POS.Logic;
using POS.Queries.Core.Domain;
using POS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using POS.App.Helpers;
namespace POS.App.Forms
{
    public partial class frmPos : Form, IDisposable
    {


        PosTransaction postTransaction;
        private Timer _typingTimer;

        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;
        private int _postTransactionID;
        private int selectedIndex;
        private int posTransactionProductID;
        private int memberID;
        private string memberName;
 
        public frmPos()
        {
            InitializeComponent();
            AddHandlers();

            this.postTransaction = new PosTransaction();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SetTransactionProductID()
        {
            try
            {

               
                    if (grid.SelectedRows.Count > 0)
                    {
                        posTransactionProductID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                        
                    }
               
                
               

            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }
        private int getIndex(int id)
        {
            int pos = 0;
            foreach (DataGridViewRow item in grid.Rows)
            {
                if (item.Cells[0].Value.ToString() == id.ToString())
                {
                    return pos;
                }
                else
                {
                    pos++;
                }
            }
            return 0;
        }
        private void AddHandlers()
        {
            var controls = LocalUtils.GetAll(this, typeof(MyTextBox));
            
            foreach (MyTextBox control in controls)
            {
                control.KeyDown +=control_KeyDown;
                control.Enter +=control_Enter;

                if (control.Tag != null)
                {


                    if (control.Tag.ToString().Contains("int"))
                    {
                        control.TextChange += item_IntCheckTextChange;
                    }
                    else if (control.Tag.ToString().Contains("double"))
                    {
                        control.TextChange += item_DoubleCheckTextChange;
                    }


                }

            }
        }
        private void item_IntCheckTextChange(object sender, EventArgs e)
        {
            var control = (PlaceholderTextBox)sender;

            int value = 0;
            if (!int.TryParse(control.Text, out value))
            {
                control.Text = "";
            }

        }
        void item_DoubleCheckTextChange(object sender, EventArgs e)
        {
            var control = (PlaceholderTextBox)sender;

            double value = 0;
            if (!double.TryParse(control.Text, out value))
            {
                control.Text = "";
            }

        }

        void control_Enter(object sender, EventArgs e)
        {
            MyTextBox textbox = (MyTextBox)sender;
            textbox.SelectAllText();
        }

       

        void control_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeyDown(e.KeyCode);
        }


        
        void AddPosProduct()
        {
            Factories.CreatePosTransaction().AddTransactionProduct(txtProductName.Text, _postTransactionID, Utils.ConvertToInteger(txtQuantity.Text));
            LoadGridList();
            GetTotal();
            ClearProductCode();
        }

        private async void ClearProductCode()
        {
            await Task.Delay(3000);
            txtProductName.Text = "";
            txtQuantity.Text = "";
        }
        private void SetDefaultFieldValue()
        {
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtTotal.Text = "0.0";
            txtAmountTendered.Text = "";
            txtChange.Text = "";
            memberID = 0;
            txtMember.Text = "";
            grid.Rows.Clear();
        }
        private void GetTotal()
        {

            try
            {
                
                txtTotal.Text = Factories.CreatePosTransaction().GetTotal(_postTransactionID).ToString();
                
            }
            catch (Exception)
            {
                
                throw;
            }
            
            
        }
        /// <summary>
        /// Show Purchase items
        /// </summary>
        private void LoadGridList()
        {
            try
            {
                
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var posTransactionProducts = uow.PosTransactionProducts.GetAllBy(_postTransactionID);
                    var total = posTransactionProducts.Sum(x => x.Quantity * x.Product.Price);
                    int count = 0;
                    grid.Rows.Clear();
                    foreach (var item in posTransactionProducts)
                    {
                        count++;
                        grid.Rows.Add(new string[] { 
                            item.PosTransactionProductID.ToString(),
                            count.ToString(),
                            item.Product.Description,
                            item.Product.Price.ToString(),
                            item.Quantity.ToString(),
                            (item.Quantity * item.Product.Price).ToString()});
                    }
                    grid.Rows.Add(new string[] { 
                           "0",
                            "",
                            "",
                            "",
                           "Total",
                            total.Value.ToString()});

                    //var index = getIndex(posTransactionProductID);
                    //// set selected item
                    //grid.ClearSelection();
                    //grid.Rows[selectedIndex].Selected = true;

                }
                
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private  void frmPos_Load(object sender, EventArgs e)
        {
            // load previous transaction to avoid incomplete transactions
            var previousPosTransaction = Factories.CreatePosTransaction().GetPreviousPosTransaction();
            if (previousPosTransaction == null)
            {
                NewTransaction();
            }
            else
            {
                MetroMessageBox.Show(this, "Previous Transaction will be loaded!", "Previous Transaction found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // if found load previous transactions and totals
                _postTransactionID = previousPosTransaction.PosTransactionID;
                lblTransactionCode.Text = "Transaction Code: " + previousPosTransaction.TransactionCode;
                SetDefaultFieldValue();
                LoadGridList();
                GetTotal();
            }
            SetCurrentUser();
            LoadMembersAutoComplete();
        }
        void SetCurrentUser()
        {
            lblCurrentUser.Text = "Cashier: " + CurrentUser.Name;
        }
        private async void NewTransaction()
        {
             DialogResult d = MetroMessageBox.Show(this, "Do you want to create new transaction?",
                "New Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (d == DialogResult.Yes)
             {
                 txtProductName.ReadOnly = true;
                 var loading = new frmLoading();
                 loading.TopMost = true;
                 loading.Show();
                 var newPosTransaction = await Task.Run(() => Factories.CreatePosTransaction().GenerateNewTransaction());
                 _postTransactionID = newPosTransaction.PosTransactionID;
                 lblTransactionCode.Text = "Transaction Code: " + newPosTransaction.TransactionCode;
                 loading.Close();
                 txtProductName.ReadOnly = false;
                 this.SetDefaultFieldValue();
             }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utils.ConvertToDouble(txtAmountTendered.Text) <= 0)
                {
                    LocalUtils.ShowErrorMessage(this,"Amount tendered is not valid!");
                    return;
                }
                var member = Factories.CreateMember().Get(txtMember.Text);
                if (member == null)
                {
                    LocalUtils.ShowErrorMessage(this, "Member not found!");
                    return;
                }
                //Complete then transactions
                Factories.CreatePosTransaction().CompletePosTransaction(_postTransactionID,member.ID, txtAmountTendered.DoubleValue, txtTotal.DoubleValue);

                //Print Reciept
                DialogResult d = MetroMessageBox.Show(this, "Do you want to print reciept?", "Print Reciept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    //Proceed to print reciept
                    PrintReciept();
                    //Create new transaction after print
                        this.SetDefaultFieldValue();
                        NewTransaction();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        void updateTransaction()
        {

        }
        void LoadMembersAutoComplete()
        {
            try
            {
                var memberNames = Factories.CreateMember().GetAllFullNamesOnly();
                var autoCStr = new AutoCompleteStringCollection();
                autoCStr.AddRange(memberNames.ToArray());
                txtMember.AutoCompleteCustomSource = autoCStr;
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }
        private void PrintReciept()
        {
            try
            {
                if (_postTransactionID > 0)
                {


                    using (var uow = new UnitOfWork(new DataContext()))
                    {
                        var posProductTransactions = uow.PosTransactionProducts.GetAllBy(_postTransactionID);
                        var posTransaction = uow.PosTransaction.GetPosTransaction(_postTransactionID);
                        dsReports ds = new dsReports();
                        DataTable t = ds.Tables["dsReciept"];
                        DataRow r;
                        int count = 0;
                        foreach (var item in posProductTransactions)
                        {
                            count++;
                            r = t.NewRow();
                            r["ID"] = count.ToString();
                            r["Quantity"] = item.Quantity.ToString();
                            r["Item"] = item.Product.Description;
                            r["Price"] = item.Product.Price;
                            r["Total"] = item.Quantity * item.Product.Price;
                            t.Rows.Add(r);
                        }

                        LocalReport report = new LocalReport();
                        string path = Path.GetDirectoryName(Application.ExecutablePath);
                        //string fullPath = path.Remove(path.Length - 10) + @"\Reports\Reciept.rdlc";
                        string fullPath = path + @"\Reports\Reciept.rdlc";
                        report.ReportPath = fullPath;
                        report.DataSources.Add(new ReportDataSource("dsReciept", t));
                        var paramDate = new ReportParameter("date", DateTime.Now.ToShortDateString());
                        var p_time = new ReportParameter("time", DateTime.Now.ToShortTimeString());
                        var paramTotal = new ReportParameter("totalAmount", txtTotal.Text);
                        var paramCash = new ReportParameter("cash", posTransaction.AmountTender.Value.ToString());
                        var paramChange = new ReportParameter("change", txtChange.Text);
                        var p_cashier = new ReportParameter("cashier",CurrentUser.Name);
                        var p_transcCode = new ReportParameter("transCode", posTransaction.TransactionCode);
                        report.SetParameters(new ReportParameter[] { paramDate,p_time, paramTotal,paramCash,paramChange, p_cashier, p_transcCode });
                        PrintToPrinter(report);



                    //    rptViewer.LocalReport.DataSources.Clear();
                    //    ReportDataSource rds = new ReportDataSource("PrevPrenatalRecord", t);
                    //    ReportDataSource rds2 = new ReportDataSource("PresPrenatalRecord", t2);


                    //    ReportParameter p_age = new ReportParameter("Age", txtAge.Text);
                    //    ReportParameter p_weight = new ReportParameter("Weight", txtWeight.Text);
                    //    ReportParameter p_height = new ReportParameter("Height", txtHeight.Text);
                    //    ReportParameter p_bmi = new ReportParameter("BMI", txtBMI.Text);
                    //    ReportParameter p_lastMensDate = new ReportParameter("LastMensDate", txtLastMens.Text);
                    //    ReportParameter p_expDeliveryDate = new ReportParameter("ExpDeliveryDate", txtExpectedDelivery.Text);

                    //    ReportParameter p_prenatalMonthCount = new ReportParameter("PrenatalMonthCount", txtMonthCount.Text);
                    //    ReportParameter p_prenatalCount = new ReportParameter("PrenatalCount", txtPregnancyCount.Text);

                    //    this.rptViewer.LocalReport.SetParameters(new ReportParameter[] 
                    //{ p_age,
                    //p_weight,
                    //p_height,
                    //p_bmi,
                    //p_lastMensDate,
                    //p_expDeliveryDate,
                    //p_prenatalMonthCount,
                    //p_prenatalCount
                    //});
                    //    var currentRec = uow.PrenatalRecords.Get(prenatalRecID);
                    //    rptViewer.LocalReport.DataSources.Add(rds);
                    //    rptViewer.LocalReport.DataSources.Add(rds2);
                    //    rptViewer.SetDisplayMode(DisplayMode.PrintLayout);
                    //    rptViewer.ZoomMode = ZoomMode.PageWidth;
                    //    rptViewer.LocalReport.DisplayName = currentRec.FullName;
                    //    this.rptViewer.RefreshReport();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "No Transaction Reciept to print!", "Print Reciept", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }
        
        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);

        }

        public static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
             @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>3in</PageWidth>
                <PageHeight>8.3in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0.1in</MarginLeft>
                <MarginRight>0.1in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }


        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
        private void frmPos_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

       

        
        void CheckKeyDown(Keys e)
        {
            switch (e)
            {
                case Keys.F2:
                   
                    NewTransaction();
                    break;
                case Keys.F3:
                    txtProductName.Focus();
                    break;
                case Keys.F4:
                    txtQuantity.Focus();
                    break;
                
               
            }
            if ((Control.ModifierKeys & Keys.Alt) != 0 && e == Keys.U)
            {
                var frmQuantityUpdate = new frmQuantityUpdate(posTransactionProductID);
                frmQuantityUpdate.OnProductSelected += frmQuantityUpdate_OnProductSelected;
                frmQuantityUpdate.ShowDialog();
            }
        }

       

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

       

        #region Delayed product search on text change Routine
        private void txtProductCode_TextChange(object sender, EventArgs e)
        {
            // if product name contains text, just return to avoid more textchange event
            
            if (txtQuantity.Text == "" || txtQuantity.Text == "0")
            {
                LocalUtils.ShowErrorMessage(this, "Quantity must be provided!");
                txtProductName.Clear();
                return;
            }
            if (_typingTimer == null)
            {
                /* WinForms: */
                _typingTimer = new Timer();
                _typingTimer.Interval = 1000;

                _typingTimer.Tick += new EventHandler(this.handleTypingTimerTimeout);
            }
            _typingTimer.Stop(); // Resets the timer
            _typingTimer.Tag = (sender as TextBox).Text; // This should be done with EventArgs
            _typingTimer.Start();
        }

        private void handleTypingTimerTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer; // WinForms
            try
            {
                // var timer = sender as DispatcherTimer; // WPF
                if (timer == null)
                {
                    return;
                }

                // Testing - updates window title
                var text = timer.Tag.ToString();
                if (text != string.Empty)
                {
                    AddPosProduct();
                }

                // The timer must be stopped! We want to act only once per keystroke.
                timer.Stop();
            }
            catch (Exception ex)
            {
                timer.Stop();
                txtProductName.Text = "";
                MessageBox.Show(ex.Message);
               
            }
            




        }
        #endregion
        

        void IDisposable.Dispose()
        {
            DisposePrint();
        }

        private void txtAmountTendered_TextChanged(object sender, EventArgs e)
        {
            txtAmountTendered.Text = Utils.ConvertToInteger(txtAmountTendered.Text) == 0 ? "" : Utils.ConvertToInteger(txtAmountTendered.Text).ToString();
            txtChange.Text = (txtAmountTendered.DoubleValue - txtTotal.DoubleValue).ToString();
        }

        private void txtProductCode_OnIconRightClick(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "" || txtMember.Text == "")
            {
                LocalUtils.ShowErrorMessage(this, "Please provide member and quanity of item first!");
                return;
            }
            var productLookupForm = new frmTransactionProducts();
            productLookupForm.OnProductSelected += productLookupForm_OnProductSelected;
            productLookupForm.ShowDialog();
        }

        void productLookupForm_OnProductSelected(object sender, EventArgs e)
        {
            var productLookupForm = (frmTransactionProducts)sender;
            txtProductName.Text = productLookupForm.ProductCode;
        }

        private void gridList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
            else if ((Control.ModifierKeys & Keys.Alt) != 0 && e.KeyCode == Keys.U)
            {
                var frmQuantityUpdate = new frmQuantityUpdate(posTransactionProductID);
                frmQuantityUpdate.OnProductSelected += frmQuantityUpdate_OnProductSelected;
                frmQuantityUpdate.ShowDialog();
            }
            
        }

        void frmQuantityUpdate_OnProductSelected(object sender, EventArgs e)
        {
            LoadGridList();
            GetTotal();
        }

        private void Delete()
        {
            try
            {


                if (grid.SelectedRows.Count > 0)
                {
                    var posTransactionProductID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (posTransactionProductID != 0)
                    {
                        DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Factories.CreatePosTransaction().DeleteTransactionProduct(posTransactionProductID);
                            
                            LoadGridList();
                            GetTotal();
                        }
                    }
                    else
                    {
                        //LocalUtils.ShowNoRecordFoundMessage(this);
                    }

                }
                else
                {

                    //LocalUtils.ShowNoRecordSelectedMessage(this);
                }

            }
            catch (Exception ex)
            {

                //LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_OnIconLeftClick(object sender, EventArgs e)
        {
            UpdateQuantity("decrease", Utils.ConvertToInteger(txtQuantity.Text));
        }
        void UpdateQuantity(string operation, int currentValue)
        {

            try
            {

                if (grid.SelectedRows.Count > 0)
                {
                    var posTransactionProductID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (posTransactionProductID != 0)
                    {

                        switch (operation)
                        {
                            case "increase":
                                currentValue++;
                               
                                break;
                            default:
                                if (currentValue > 0)
                                {
                                    currentValue--;
                                   
                                }
                                else
                                {
                                    LocalUtils.ShowErrorMessage(this, "Quantity value must not equal to zero");
                                }
                                break;
                        }
                        txtQuantity.Text = currentValue.ToString();
                        LoadGridList();
                        GetTotal();
                        
                       
                    }
                    else
                    {
                        //LocalUtils.ShowNoRecordFoundMessage(this);
                    }

                }
                else
                {

                    //LocalUtils.ShowNoRecordSelectedMessage(this);
                }

            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
            
        }

        private void txtQuantity_OnIconRightClick(object sender, EventArgs e)
        {
            UpdateQuantity("increase", Utils.ConvertToInteger(txtQuantity.Text));
            
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            SetTransactionProductID();
        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChange(object sender, EventArgs e)
        {
            txtQuantity.Text = Utils.ConvertToInteger(txtQuantity.Text) == 0 ? ""  : Utils.ConvertToInteger(txtQuantity.Text).ToString();
        }
    }
}
