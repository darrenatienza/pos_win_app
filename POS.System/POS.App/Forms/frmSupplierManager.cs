using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using MetroFramework;
using POS.App.Helpers;
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
    public partial class frmSupplierManager : Form
    {

        public int SupplierID;
        private int _supplierID;
        public FormAction FormAction { get; set; }
        public frmSupplierManager()
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

            var ctrlTextBoxes2 = LocalUtils.GetAll(tabSupplierDetail, typeof(BunifuTextBox))
                       .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (BunifuTextBox item in ctrlTextBoxes2)
            {
                if (item.Text == string.Empty)
                {
                        item.Focus();
                        LocalUtils.ShowValidationFailedMessage(this);
                        return false;
                }
            }

            var ctrlDropdown = LocalUtils.GetAll(tabSupplierDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown))
                        .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in ctrlDropdown)
            {
                if (item.SelectedIndex < 0)
                {
                    item.Focus();
                    MetroMessageBox.Show(this, string.Format("Empty field {0 }", item.Tag), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            return true;
        }

        void AddToolTipToFields()
        {
            var ctrlTextBoxes2 = LocalUtils.GetAll(pnlContents, typeof(MyTextBox))
                        .OrderBy(c => c.TabIndex);
            foreach (MyTextBox item in ctrlTextBoxes2)
            {
                bunifuToolTip1.SetToolTip(item, item.ToolTipText);
            }



            var ctrlDropdown = LocalUtils.GetAll(pnlContents, typeof(Bunifu.UI.WinForms.BunifuDropdown))
                        .OrderBy(c => c.TabIndex);
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in ctrlDropdown)
            {
                bunifuToolTip1.SetToolTip(item, item.Tag.ToString());
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

                    if (_supplierID == 0)
                    {
                       
                        var supplier = new Supplier();
                        supplier.Address = txtAddress.Text;
                        supplier.CreateTimeStamp = DateTime.Now;
                        supplier.Description = txtDescription.Text;
                        supplier.Remarks = txtRemarks.Text;
                        
                        uow.Suppliers.Add(supplier);
                        uow.Complete();
                        
                    }
                    else
                    {
                        var supplier = uow.Suppliers.Get(_supplierID);
                        supplier.Address = txtAddress.Text;
                        supplier.CreateTimeStamp = DateTime.Now;
                        supplier.Description = txtDescription.Text;
                        supplier.Remarks = txtRemarks.Text;
                        uow.Suppliers.Edit(supplier);
                        uow.Complete();
                        
                    }
                    page.SetPage(tabSupplierList);
                    LoadSupplierList();

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
                    var supplier = uow.Suppliers.Get(_supplierID);
                    if (supplier != null)
                    {
                        txtAddress.Text = supplier.Address;
                        txtDescription.Text = supplier.Description;
                        txtRemarks.Text = supplier.Remarks;
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
            LoadSupplierList();
           
        }
        async void LoadSupplierList()
        {
            try
            {
                await Task.Delay(1000);
                var suppliers = await Task.Run(() => Factories.CreateSupplier().GetSupplierList(txtSearch.Text));
                int count = 0;
                gridSuppliers.Rows.Clear();
                foreach (var item in suppliers)
                {
                    count++;
                    gridSuppliers.Rows.Add(new string[] {
                            item.SupplierID.ToString(),
                            count.ToString(),
                            item.Description,
                            item.Address});
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSupplierList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            page.SetPage(tabSupplierDetail);
            _supplierID = 0;
            ResetInputs();
        }
        private void ResetInputs()
        {
            var textboxes = LocalUtils.GetAll(tabSupplierDetail, typeof(BunifuTextBox));
            foreach (BunifuTextBox item in textboxes)
            {
                item.Text = string.Empty;
            }
            var comboboxes = LocalUtils.GetAll(tabSupplierDetail, typeof(Bunifu.UI.WinForms.BunifuDropdown));
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in comboboxes)
            {
                item.SelectedIndex = -1;
                item.Enabled = true;
            }
            var dates = LocalUtils.GetAll(tabSupplierDetail, typeof(BunifuDatepicker));
            foreach (BunifuDatepicker item in dates)
            {
                item.Value = DateTime.UtcNow;
            }
        }

        private void gridSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            try
            {
                var grid = gridSuppliers;

                if (grid.SelectedRows.Count > 0)
                {
                    _supplierID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (_supplierID != 0)
                    {
                        page.SetPage(tabSupplierDetail);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            page.SetPage(tabSupplierList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void Delete()
        {
            try
            {
                var grid = gridSuppliers;

                if (grid.SelectedRows.Count > 0)
                {
                    var supplierID = int.Parse(grid.SelectedRows[0].Cells[0].Value.ToString());
                    if (supplierID != 0)
                    {
                        DialogResult result = MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Factories.CreateSupplier().Delete(supplierID);
                            LoadSupplierList();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
    }
}
