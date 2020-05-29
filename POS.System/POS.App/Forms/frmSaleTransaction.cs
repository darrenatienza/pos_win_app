using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using MetroFramework;
using Microsoft.Reporting.WinForms;
using POS.App.Helpers;
using POS.App.Reports;
using POS.App.UserControls;
using POS.App.UserControls.MyControls;
using POS.Logic;
using POS.Logic.Models;
using POS.Queries.Core.Domain;
using POS.Queries.Persistence;
using Helpers;
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
    public partial class frmSaleTransaction : Form
    {

        private int posTransactionID;

        public frmSaleTransaction()
        {
            InitializeComponent();
        }

        private void pnlContents_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AddHandlers()
        {
            // fires checked events when 
            var radios = LocalUtils.GetAll(this, typeof(BunifuRadioButton))
                     .OrderBy(c => c.TabIndex);
            foreach (BunifuRadioButton item in radios)
            {

                item.CheckedChanged += radio_CheckedChanged;
            }
            // fires checked events when 
            var dates = LocalUtils.GetAll(this, typeof(BunifuDatePicker))
                     .OrderBy(c => c.TabIndex);
            foreach (BunifuDatePicker item in dates)
            {

                item.ValueChanged += dates_ValueChanged;
            }
            //var textboxes = LocalUtils.GetAll(this, typeof(BunifuTextBox))
            //         .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            //foreach (BunifuTextBox item in textboxes)
            //{
            //    if (item.Tag != null)
            //    {


            //        if (item.Tag.ToString().Contains("integer") || item.Tag.ToString().Contains("double"))
            //        {
            //            item.KeyPress += textBox_keyPress;
            //        }


            //    }
            //}
            ////We get all textboxes with tag compute to compute textbox value
            //// after text change event fires
            //var computeTextBoxes = LocalUtils.GetAll(this, typeof(BunifuTextBox))
            //        .Where(c => c.Tag.ToString().Contains("compute")).OrderBy(c => c.TabIndex);
            //foreach (BunifuTextBox item in computeTextBoxes)
            //{
            //    item.TextChange += item_TextChange;
            //}
        }

        private void dates_ValueChanged(object sender, EventArgs e)
        {
            LoadPreviousTransactions();
        }
         void radio_CheckedChanged(object sender, EventArgs e)
        {
             //if  selected radio is range filter, 
             //change visibility of date range selection panel
            pnlRange.Visible = radioRange.Checked ? true : false;
            
             LoadPreviousTransactions();
        }
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Validates Form Fields data
        /// </summary>
        /// <returns>If Validation succed, returns True. If not, returns false.</returns>
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditsSupplier_Load(object sender, EventArgs e)
        {
            AddHandlers();
            LoadPreviousTransactions();
           
        }
      
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPreviousTransactions();
        }

        
        

        private void gridSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }


        private void Delete()
        {
            try
            {
                var grid = gridList;

                if (grid.SelectedRows.Count > 0)
                {
                    var supplierID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (supplierID != 0)
                    {
                        DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Factories.CreateSupplier().Delete(supplierID);
                            LoadPreviousTransactions();
                        }
                    }
                    else
                    {
                        LocalUtils.ShowNoRecordFoundMessage(this);
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




        async void LoadPreviousTransactionReport()
        {
            try
            {
                var criteria = txtSearch.Text;
                var dateFrom = DateTime.Now;
                var dateTo = DateTime.Now;
                
                await Task.Delay(1000);
                List<PreviousTransactionListModel> prevTransactions = new List<PreviousTransactionListModel>();
                if (radioDailySales.Checked)
                {
                   
                    // range filter selected
                    prevTransactions = await Task.Run(() => Factories.CreatePosTransaction().GetDailyTransactions(criteria));
                }
                else if (radioWeeklySales.Checked)
                {
                    dateFrom = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                    dateTo = dateFrom.AddDays(6);
                    prevTransactions = await Task.Run(() => Factories.CreatePosTransaction().GetWeeklyTransactions(criteria));
                }
                else if (radioMonthlySales.Checked)
                {
                    dateFrom = DateTime.Now.FirstDayOfMonth();
                    dateTo = DateTime.Now.LastDayOfMonth();
                    prevTransactions = await Task.Run(() => Factories.CreatePosTransaction().GetMonthlyTransactions(criteria));
                }
                else
                {
                    dateFrom = dtDateFrom.Value;
                    dateTo = dtDateTo.Value;
                    // range filter selected
                    prevTransactions = await Task.Run(() => Factories.CreatePosTransaction().GetTransactions(criteria, dateFrom, dateTo));
                }
                int count = 0;

                var ds = new dsReports();
                DataTable t = ds.Tables["dtPosTransaction"];
                DataRow r;
                foreach (var item in prevTransactions)
                {
                    count++;
                    r = t.NewRow();
                    r["i"] = count.ToString();
                    r["Date"] = item.Date;
                    r["TransactionCode"] = item.TransactionCode;
                    r["Quantity"] = item.Quantity;
                    r["AmountTendered"] = item.AmountTendered;
                    r["Total"] = item.Total;

                    t.Rows.Add(r);
                }
                rptViewer.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("dsPosTransaction", t);

                var p_datefrom = new ReportParameter("DateFrom", dateFrom.ToShortDateString());
                var p_dateTo = new ReportParameter("DateTo",dateTo.ToShortDateString());

                rptViewer.LocalReport.SetParameters(new ReportParameter[] { p_datefrom, p_dateTo });

                rptViewer.LocalReport.DataSources.Add(rds);
                rptViewer.SetDisplayMode(DisplayMode.PrintLayout);
                rptViewer.ZoomMode = ZoomMode.PageWidth;
                this.rptViewer.RefreshReport();
            }
            catch (Exception)
            {

                throw;
            }
        }
        async void LoadPreviousTransactions()
        {
            try
            {
                var criteria = txtSearch.Text;
                var dateFrom = dtDateFrom.Value;
                var dateTo = dtDateTo.Value;
                await Task.Delay(1000);
                List<PreviousTransactionListModel> prevTransactions = new List<PreviousTransactionListModel>();
                if (radioDailySales.Checked)
                {
                    // range filter selected
                    prevTransactions = await Task.Run(() => Factories.CreatePosTransaction().GetDailyTransactions(criteria));
                }
                else if (radioWeeklySales.Checked)
                {
                    prevTransactions = await Task.Run(() => Factories.CreatePosTransaction().GetWeeklyTransactions(criteria));
                }
                else if (radioMonthlySales.Checked)
                {
                    prevTransactions = await Task.Run(() => Factories.CreatePosTransaction().GetMonthlyTransactions(criteria));
                }
                else
                {
                    // range filter selected
                   prevTransactions =  await Task.Run(() => Factories.CreatePosTransaction().GetTransactions(criteria,dateFrom,dateTo));
                }
               
                int count = 0;
                gridList.Rows.Clear();
                foreach (var item in prevTransactions)
                {
                    count++;
                    gridList.Rows.Add(new string[] {
                            item.ID.ToString(),
                            count.ToString(),
                            item.Date.ToString(),
                            item.TransactionCode,
                            item.Quantity.ToString(),
                            item.AmountTendered.ToString(),
                            item.Total.ToString()});
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        private void txtSearch_OnIconRightClick(object sender, EventArgs e)
        {
            LoadPreviousTransactions();
        }

        

        private void gridSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }
        void SetData()
        {
            try
            {
                var model = Factories.CreatePosTransaction().GetPosTransactionDetail(posTransactionID);
                lblAmountTendered.Text = model.AmountTendered;
                lblCashier.Text = model.Cashier;
                lblChange.Text = model.Change;
                lblDateTime.Text = model.DateTimePurchase;
                lblMemberName.Text = model.MemberName;
                lblQuantity.Text = model.Quantity;
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }
        async void LoadPosTransactionProducts()
        {

            try
            {
                var criteria = txtSearch.Text;
                var dateFrom = dtDateFrom.Value;
                var dateTo = dtDateTo.Value;
                await Task.Delay(1000);
                var posTransactionProducts = await Task.Run(() => Factories.CreatePosTransaction().GetPosTransactionProducts(posTransactionID));
                int count = 0;
                gridProducts.Rows.Clear();
                foreach (var item in posTransactionProducts)
                {
                    count++;
                    gridProducts.Rows.Add(new string[] {
                            item.ID.ToString(),
                            count.ToString(),
                            item.ProductName,
                            item.UnitPrice.ToString(),
                            item.Quantity.ToString(),
                            item.SubTotal.ToString(),
                            });
                }
                var total = posTransactionProducts.Sum(x => x.SubTotal);
                gridProducts.Rows.Add(new string[] {
                            "0",
                            "",
                            "",
                           "",
                            "Total",
                            total.ToString()
                            });
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void gridSuppliers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
           
        }

        private void gridList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewDetail();
        }

        private void ViewDetail()
        {
            try
            {
                var grid = gridList;

                if (grid.SelectedRows.Count > 0)
                {
                    posTransactionID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (posTransactionID != 0)
                    {
                        page.SetPage(pageTransactionDetails);
                        SetData();
                        LoadPosTransactionProducts();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            page.SetPage(pagePerTransactions);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LoadPreviousTransactionReport();
            page.SetPage(pagePrintPreview);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            page.SetPage(pagePerTransactions);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ViewDetail();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }
        
    }
}
