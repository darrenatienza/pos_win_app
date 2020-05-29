
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using Helpers;
using MetroFramework;
using Microsoft.Reporting.WinForms;
using POS.App.Helpers;
using POS.App.Properties;
using POS.App.Reports;
using POS.App.UserControls;
using POS.App.UserControls.MyControls;
using POS.Logic;
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
    public partial class frmProductManager : Form
    {

        private int _productID;
        private int initialWidth;
        private int initialHeight;
        public FormAction FormAction { get; set; }

        
        public frmProductManager()
        {
            InitializeComponent();
        }
        
        private void pnlContents_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Validates Form Fields data
        /// </summary>
        /// <returns>If Validation succed, returns True. If not, returns false.</returns>
        private bool ValidatedFields()
        {

            var ctrlTextBoxes2 = LocalUtils.GetAll(pageProductDetail, typeof(BunifuTextBox))
                       .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (BunifuTextBox item in ctrlTextBoxes2)
            {

                if (item.Text == string.Empty)
                {
                    LocalUtils.ShowValidationFailedMessage(this);
                    return false;
                }
    
            }
            var ctrlDropdown = LocalUtils.GetAll(pageProductDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown))
                        .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in ctrlDropdown)
            {
                if (item.SelectedIndex < 0)
                {
                    item.Focus();
                    LocalUtils.ShowValidationFailedMessage(this);
                    return false;
                }
            }

            return true;
        }

        private void LoadSupplier()
        {
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var suppliers = uow.Suppliers.GetAll();
                    foreach (var item in suppliers)
                    {
                        cboSupplier.Items.Add(new ItemX(item.Description, item.SupplierID.ToString()));
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
       
        private void Save()
        {
            try
            {
                if (!ValidatedFields())
                {
                    return;
                }

                using (var uow = new UnitOfWork(new DataContext()))
                {

                    if (_productID == 0)
                    {
                       
                        var product = new Product();

                        product.CreateTimeStamp = DateTime.Now;
                        product.Description = txtDescription.Text;
                        product.Remarks = txtRemarks.Text;
                        product.Limit = Utils.ConvertToInteger(txtLimit.Text);
                        product.Quantity = Utils.ConvertToInteger(txtQuantity.Text);
                        product.Price = Utils.ConvertToInteger(txtPrice.Text);
                        product.SupplierID = int.Parse(((ItemX)cboSupplier.SelectedItem).Value);
                        uow.Products.Add(product);
                        uow.Complete();
                        _productID = product.ProductID;

                    }
                    else
                    {
                        var product = uow.Products.Get(_productID);
  
                        product.CreateTimeStamp = DateTime.Now;
                        product.Description = txtDescription.Text;
                        product.Remarks = txtRemarks.Text;
                        product.Limit = Utils.ConvertToInteger(txtLimit.Text);
                        product.Quantity = Utils.ConvertToInteger(txtQuantity.Text);
                        product.Price = Utils.ConvertToInteger(txtPrice.Text);
                        product.SupplierID = int.Parse(((ItemX)cboSupplier.SelectedItem).Value);
                        uow.Products.Edit(product);
                        uow.Complete();
                    }
                    //page.SetPage(pageProductList);
                    LocalUtils.ShowSaveMessage(this);
                    LoadProducts();

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void SetData()
        {
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var product = uow.Products.GetProduct(_productID);
                    if (product != null)
                    {
                        txtDescription.Text = product.Description;
                        txtRemarks.Text = product.Remarks;
                        txtLimit.Text = product.Limit.ToString();
                        txtQuantity.Text = product.Quantity.ToString();
                        txtPrice.Text = product.Price.HasValue ? product.Price.Value.ToString() : "0.0";
                        cboSupplier.SelectedItem = LocalUtils.GetSelectedItemX(cboSupplier.Items, product.SupplierID.ToString());

                       
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditsSupplier_Load(object sender, EventArgs e)
        {
            initialWidth = this.Width;
            initialHeight = this.Height;
            LoadProducts();
            LoadSupplier();


            this.rptReport.RefreshReport();
        }

        async void LoadProducts()
        {
            try
            {
                await Task.Delay(1000);
                var products = await Task.Run(() =>Factories.CreateProducts().GetProductList(txtSearch.Text));
                int count = 0;

                gridProducts.Rows.Clear();
                foreach (var item in products)
                {
                    count++;
                    gridProducts.Rows.Add(new string[] {
                            item.ProductID.ToString(),
                            count.ToString(),
                            item.Description,
                            item.Quantity.ToString()});
                }
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            page.SetPage(pageProductDetail);
            _productID = 0;
            ResetInputs();

        }

        private void gridProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            page.SetPage(pageProductList);
           
            
        }
        private void ResetInputs()
        {
            var textboxes = LocalUtils.GetAll(pageProductDetail, typeof(BunifuTextBox));
            foreach (BunifuTextBox item in textboxes)
            {
                item.Text = string.Empty;
            }
            var comboboxes = LocalUtils.GetAll(pageProductDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown));
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in comboboxes)
            {
                item.SelectedIndex = -1;
                item.Enabled = true;
            }
            var dates = LocalUtils.GetAll(pageProductDetail, typeof(BunifuDatepicker));
            foreach (BunifuDatepicker item in dates)
            {
                item.Value = DateTime.UtcNow;
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtQuantity.Text = Utils.ConvertToInteger(txtQuantity.Text).ToString();
        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {
            txtLimit.Text = Utils.ConvertToInteger(txtLimit.Text).ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.Text = Utils.ConvertToDouble(txtPrice.Text).ToString();
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                var grid = gridProducts;

                if (grid.SelectedRows.Count > 0)
                {
                    var posTransactionProductID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (posTransactionProductID != 0)
                    {
                        DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Factories.CreateProducts().Delete(posTransactionProductID);
                            LoadProducts();
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

                //LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            if (_productID == 0)
            {
                LocalUtils.ShowErrorMessage(this, "Please save new product before adding new quantity!");
                return;
            }
            var frm = new frmUpdateProductQuantity(_productID, "Stock In");
            frm.OnProductUpdated += frm_OnProductUpdated;
            frm.ShowDialog();
        }

        void frm_OnProductUpdated(object sender, EventArgs e)
        {
            SetData();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (_productID == 0)
            {
                LocalUtils.ShowErrorMessage(this, "Please save new product before removing quantity!");
                return;
            }
            var frm = new frmUpdateProductQuantity(_productID, "Stock Out");
            frm.OnProductUpdated += frm_OnProductUpdated;
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            page.SetPage(pageProductList);
            LoadProducts();
            SetDefaultData();
        }

        private void SetDefaultData()
        {
            
        }

        private void btnProductLog_Click(object sender, EventArgs e)
        {
            var frm = new frmProductLog(_productID);
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            try
            {
                var grid = gridProducts;

                if (grid.SelectedRows.Count > 0)
                {
                    _productID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (_productID != 0)
                    {
                        page.SetPage(pageProductDetail);
                        SetData();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            this.Width = int.Parse(Properties.Resources.WindowPrintWidth);
            this.Height = int.Parse(Properties.Resources.WindowPrintHeight);
            
            page.SetPage(pagePrint);
            this.CenterToScreen();
            PrintPreview();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Height = initialHeight;
            this.Width = initialWidth;
            page.SetPage(pageProductList);
            this.CenterToScreen();

        }
        private void PrintPreview()
        {
            try
            {
                using (var uow = new UnitOfWork(new DataContext()))
                {
                    var products = Factories.CreateProducts().GetProductList("");
                    var ds = new dsReports();
                    var productTable = ds.Tables["Product"];
                    DataRow productRow;
                    int p_count = 0;
                    foreach (var item in products)
                    {
                        p_count++;
                        productRow = productTable.NewRow();
                        productRow["i"] = p_count.ToString();
                        productRow["Name"] = item.Description;
                        productRow["SupplierName"] = item.SupplierName;
                        productRow["Price"] = item.Price;
                        productRow["Quantity"] = item.Quantity;
                        productRow["Limit"] = item.Limit;
                        productTable.Rows.Add(productRow);
                    }

                    var p_dateNow = new ReportParameter("DateNow", DateTime.Now.ToLongDateString());
                    
 
                    this.rptReport.LocalReport.SetParameters(new ReportParameter[] {
                        p_dateNow
                    });
                    var productRDS = new ReportDataSource("Product", productTable);
                    rptReport.LocalReport.DataSources.Clear();
                    rptReport.LocalReport.DataSources.Add(productRDS);


                    rptReport.SetDisplayMode(DisplayMode.PrintLayout);
                    rptReport.ZoomMode = ZoomMode.PageWidth;
                    this.rptReport.RefreshReport();



                }
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.ToString());
            }
        }
    }
}
